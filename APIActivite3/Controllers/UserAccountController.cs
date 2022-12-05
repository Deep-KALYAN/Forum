using BLL;
using Domain.DTO;
using Domain.DTO.Requestes.Users;
using Domain.DTO.Responses.Users;
using Domain.Entites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    [ApiController]
    [Route("api/user")]
    [Authorize(Roles = "USER, ADMIN")] //(Roles = "USER")
    public class UserAccountController : ControllerBase, IUserAccountController
    {
        private static IAccountService _accountService;

        public UserAccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }


        //// it's not necessary
        [HttpGet("")]
        // [Authorize(Roles = "ADMIN")]
        [AllowAnonymous]
        public async Task<IActionResult> GetUsers()
        {
            //  string idMemberToken = HttpContext.User.Claims.ElementAt(2).Value;

            var users = await _accountService.GetUsersAsync();


            var listUsers = users.Select(user =>

                        new GetUsersResponseDTO()
                        {
                            Id = user.Id,
                            Name = user.Name,
                            FirstName = user.First_Name,
                            LoginName = user.Nick_Name,
                            PhNo = user.Ph_No,
                            //   Photo = user.Photo,
                            Password = user.Password,
                            ModeratorYN = user.Moderator_Y_N,
                            EMail = user.E_Mail

                        });

            return Ok(listUsers);
        }



        [HttpGet("{id}")]
        //[Authorize(Roles = "USER")]

        public async Task<IActionResult> GetUserById([FromRoute] int id)
        {
            var user = await _accountService.GetUserByIdAsync(id);
            if (user == null) return NotFound();


            GetUsersResponseDTO getUserByIdResponseDTO = new GetUsersResponseDTO()
            {
                Id = user.Id,
                Name = user.Name,
                FirstName = user.First_Name,
                LoginName = user.Nick_Name,
                PhNo = user.Ph_No,
                //   Photo = user.Photo,
                Password = user.Password,
                ModeratorYN = user.Moderator_Y_N,
                EMail = user.E_Mail

            };

            return Ok(getUserByIdResponseDTO);

        }


        [HttpPost()]
        // [AllowAnonymous]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequestDTO newUser)
        {
            // Recupérer le DTO de requête => Le transformé en un ou plusieur object métiers

            _User user = new _User()
            {
                //Id         = newUser.Id,
                Name = newUser.Name,
                First_Name = newUser.First_Name,
                Nick_Name = newUser.Login_Name,
                Ph_No = newUser.Ph_No,
                // Photo = newUser.Photo,
                E_Mail = newUser.E_Mail,
                Password = newUser.Password
            };

            // Les Actions à faire sur le server

            var newUser1 = await _accountService.CreateUserAsync(user);

            // Construire le de réponse


            CreateUserResponseDTO response = new CreateUserResponseDTO()
            {
                // Id       = newUser1.Id,
                Name = newUser1.Nick_Name,
                Message = "Your Welcome to Forum!"
            };

            return (newUser1 != null) ? CreatedAtAction(nameof(GetUserById), new { Id = newUser1.Id }, response) : BadRequest();
            //(newAutheur != null) ? Ok(response) : BadRequest();
        }

        //   [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> ModifieUser([FromRoute] int id, [FromBody] UpdateUserRequestDTO newUser)
        {
            if (id != newUser.Id) return BadRequest();

            _User user = new _User()
            {
                Id = newUser.Id,
                Name = newUser.Name,
                First_Name = newUser.First_Name,
                Nick_Name = newUser.Login_Name,
                Ph_No = newUser.Ph_No,
                //  Photo = newUser.Photo,
                E_Mail = newUser.E_Mail,
                Password = newUser.Password
            };

            var updatedUser = await _accountService.ModifyUserAsync(user);

            if (updatedUser == null) return BadRequest();

            UpdateUserResponseDTO response = new UpdateUserResponseDTO()
            {

                Id = updatedUser.Id,
                Name = updatedUser.Name,
                First_Name = updatedUser.First_Name,
                Login_Name = updatedUser.Nick_Name,
                Ph_No = updatedUser.Ph_No,
                //  Photo = updatedUser.Photo,
                Password = updatedUser.Password,
                E_Mail = updatedUser.E_Mail,
                Moderator_Y_N = updatedUser.Moderator_Y_N,
                // Message = "Your have updated information!"
            };

            return Ok(response); // (updatedUser != null) ? CreatedAtAction(nameof(GetUserById), new { Id = updatedUser.Id }, response) : BadRequest();
        }




        //// it's not necessary

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var isDeleted = await _accountService.DeleteUserAsync(id);

            return (isDeleted) ? NoContent() : NotFound();
        }

    }
}
