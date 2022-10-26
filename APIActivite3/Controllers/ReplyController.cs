using BLL;
using Domain.DTO.Requestes.Replies;
using Domain.DTO.Responses.Replies;
using Domain.Entites;
using Domain.Exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    [ApiController]
    [Route("api/reply")]
    [Authorize(Roles = "USER, ADMIN")]
    public class ReplyController : ControllerBase
    {

        private static IForumService _forumService;

        public ReplyController(IForumService forumService)
        {
            _forumService = forumService;
        }


        //not necessary

        //[HttpGet("")]
        //public async Task<IActionResult> GetReplies()
        //{
        //    var replies = await _forumService.GetRepliesAsync();
        //    return Ok(replies);

        //}



       
        [HttpGet("{id}")]
        [AllowAnonymous]
        //To get reply by Id
        //If deleted is true in reply the text will change in BLL
        //Not found is handeled in bll
        public async Task<IActionResult> GetReplyById([FromRoute] int id)
        {         

            var replies = await _forumService.GetReplyByIdAsync(id);
            //if (replies == null) return NotFound(); //checked in bll

            //In dto doestn't have deleted field, text modified in bll if deleted
            ReplyResponseDTO replyResponseDTO = new ReplyResponseDTO()
            {
                ReplyId       =  replies.Id,
                ReplyText = replies.Text,
                ReplyDate = replies.Reply_Date,
                ParentReplyId = replies.Id_Parent_Reply,
                CreatorId = replies.Id_User,
                TopicId = replies.Id_Topic,                
            };
            return Ok(replyResponseDTO);
        }


       // [Authorize(Roles ="User,Admin")]
        [HttpPost()]
        public async Task<IActionResult> CreateReply([FromBody] CreateReplyRequestDTO newReply)
        {

            //string idMemberToken = HttpContext.User.Claims.ElementAt(2).Value;

            //if (idMemberToken == null) throw new UnknownException();

            //int userId = int.Parse(idMemberToken);


            Reply createReply = new Reply()
            {
                Id_Parent_Reply = newReply.ReplyParentId,
                Id_Topic = newReply.ReplyTopicId,
                Text = newReply.ReplyText,
                Id_User = newReply.UserId, /***************************************must get from token ******************************/
              //  Deleted = false,   //just to understand here we use false actually Delete is 0(false) in dal
             //   Reply_Date = DateTime.Now
            };

            var reply = await _forumService.CreateReplyAsync(createReply);

            if (reply != null)
            {
                ReplyResponseDTO replyResponseDTO = new ReplyResponseDTO()
                {
                    ReplyId       = reply.Id,
                    ReplyText     = reply.Text,
                    ReplyDate     = reply.Reply_Date,
                    ParentReplyId = reply.Id_Parent_Reply,
                    CreatorId     = reply.Id_User,
                    TopicId       = reply.Id_Topic,
                };
                // Dto de retour reply
                //return Ok(replyResponseDTO);
                return CreatedAtAction(nameof(GetReplyById), new { Id = reply.Id }, replyResponseDTO);
            }
            return BadRequest();
        }



        //No one will have right to use this Update
        [HttpPut("{id}")]
        [Authorize(Roles = "NOBODY")]
        public async Task<IActionResult> UpdateReply([FromRoute] int id, [FromBody] UpdateReplyRequestDTO updateReply)
        {


            //string idMemberToken = HttpContext.User.Claims.ElementAt(2).Value;

            //if (idMemberToken is null || int.Parse(idMemberToken) != updateReply.IdUser) throw new UnknownException();

            if (id != updateReply.ReplyId) return BadRequest();

            //Request -> BO
            Reply updateReplyRequest = new Reply()
            {
                Id = updateReply.ReplyId,
                Text = updateReply.ReplyText,
                Id_User = updateReply.IdUser
                
            };

            //Logique métier
            var updatedReply = await _forumService.ModifyReplyAsync(updateReplyRequest);

            //Response avec DTO
            if (updatedReply != null)
            {
                ReplyUpdateResponseDTO replyResponseDTO = new ReplyUpdateResponseDTO()
                {

                    TopicId = updatedReply.Id_Topic,
                    ReplyId = updatedReply.Id,
                    ReplyText = updatedReply.Text,
                    ReplyDate = updatedReply.Reply_Date,
                    ParentReplyId = updatedReply.Id_Parent_Reply,
                    CreatorId = updatedReply.Id_User,

                };
                //******************codesmissing**********
                return Ok(replyResponseDTO);
            }
            return NotFound();
        }

       
        


        //actually it is update (not delete) 
        [HttpDelete("{id}")]
        [Authorize(Roles = "ADMIN")] 
        // User Only who have posted
        public async Task<IActionResult> DeleteReply([FromRoute] int id)
        {
            //var reply = await _forumService.GetReplyByIdAsync(id);
            //   /*  //if (replies == null) return NotFound(); //checked in bll  */

            //string idMemberToken = HttpContext.User.Claims.ElementAt(2).Value;
          

            //if (int.Parse(idMemberToken) == reply.Id_User || User.IsInRole("ADMIN") == true)
            //{


            var isDeleted = await _forumService.DeleteReplyAsync(id);
                return (isDeleted) ? NoContent() : NotFound();



            //}
            //else
            //{
            //    throw new ForbiddenAccessException();
            //}

            
        }
    }
}
