using Domain.DTO;
using Domain.DTO.Requestes.Security;
using Domain.DTO.Requestes.Users;
using Domain.DTO.Responses.Rubrics;
using Domain.DTO.Responses.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppActivite3.DomainWF.BOWF;
using WinFormsAppActivite3.DomainWF.DTOWF.ResponseWF;

namespace WinFormsAppActivite3
{
    public class DALWF
    {
        HttpClient _client = new HttpClient();

        #region Token and Roles

        //static DALWF _dal = null;

        string _token;

        // userName et roles extraits du JwtToken

        private static List<string> roles = new();

        string userName = null;

        //private DALWF() { }
        //public static DALWF getDAL()
        //{
        //    if (_dal == null)
        //        _dal = new DALWF();

        //    return _dal;
        //}
        //  public string UserName { get => userName; }

        //public List<string> Roles { get => roles; }

        public List<string> getRoles()
        {
            return roles;
        }


        public async Task<string> Login(string name, string password)
        {
            //Login_name
            AuthentificationRequestDTO authentificationRequestDTO = new() { Login_name = name, Password = password };

            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(authentificationRequestDTO), Encoding.UTF8, "application/json");

            var res = await _client.PostAsync($"{Settings1.Default.ConnectionString}/account/login", jsonBodyParameter);

            string content = await res.Content.ReadAsStringAsync();

            if (res.IsSuccessStatusCode)
            {                
                _token = content;
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                var handler = new JwtSecurityTokenHandler();
                var tokenDecoded = handler.ReadJwtToken(_token);

                foreach (var item in tokenDecoded.Claims)
                {
                    switch (item.Type)
                    {
                        case ClaimTypes.Role:
                            roles.Add(item.Value);
                            break;
                        case ClaimTypes.NameIdentifier:
                            userName = item.Value;
                            break;
                    }
                }

                return _token;
            }
            else
            {
                var val = JsonSerializer.Deserialize<ValidationProblemDetails>(content);
                if (val != null)
                {
                    MessageBox.Show("Data validation error!");
                }
                
                _client.DefaultRequestHeaders.Authorization = null;
            }

            return null;




        }
        #endregion

        #region User

        // Method Get All User
        public async Task<List<BOUser>> GetAllUsersAsync()
        {
            var res = await _client.GetAsync($"{Settings1.Default.ConnectionString}/user");
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();

                var lstDTOUsers = JsonSerializer.Deserialize<List<GetUsersResponseDTO>>(content
                    //          , new JsonSerializerOptions  { PropertyNameCaseInsensitive = true }
                    );
                //var lstDTO = JsonSerializer.Deserialize<List<DTOUtilisateur>>(content);
                return lstDTOUsers.ConvertAll(u => new BOUser
                {
                    Id = u.Id,
                    Name = u.Name,
                    First_Name = u.FirstName,
                    Login_Name = u.LoginName,
                    Ph_No = u.PhNo,
                    // Photo = u.Photo,
                    E_Mail = u.EMail,
                    Moderator_Y_N = u.ModeratorYN,
                    Password = u.Password
                });
            }
            else
            {
                return null;
            }
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var res = await _client.DeleteAsync($"{Settings1.Default.ConnectionString}/user/{id}");
           // string content = await res.Content.ReadAsStringAsync();

           return res.IsSuccessStatusCode;         
        }

        //Method Add User
        public async Task<BOUser> AddUserAsync(string name, string firstname, string loginname, string phno, string email, string password)
        {
            CreateUserRequestDTO createUserRequestDTO = new()
            {
                Name = name,
                First_Name = firstname,
                Login_Name = loginname,
                Ph_No = phno,
                E_Mail = email,
                Password = password
            };
            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(createUserRequestDTO), Encoding.UTF8, "application/json");
            var res = await _client.PostAsync($"{Settings1.Default.ConnectionString}/user", jsonBodyParameter);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();



                var DTOUser = JsonSerializer.Deserialize<GetUsersResponseDTO>(content);

                return new BOUser()
                {
                    Id = DTOUser.Id,
                    Name = DTOUser.Name,
                    First_Name = DTOUser.FirstName,
                    Login_Name = DTOUser.LoginName,
                    Ph_No = DTOUser.PhNo,
                    E_Mail = DTOUser.EMail,
                    Moderator_Y_N = DTOUser.ModeratorYN,
                    Password = DTOUser.Password
                };
            }
            else
            {
                return null;
            }
        }

        //Method Update User
        public async Task<BOUser> UpdateUserAsync(int id, string name, string firstname, string loginname, string phno, string email, string password)
        {
            UpdateUserRequestDTO updateUserRequestDTO = new()
            {
                Name = name,
                First_Name = firstname,
                Login_Name = loginname,
                Ph_No = phno,
                E_Mail = email,
                Password = password,
                Id = id
            };

            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(updateUserRequestDTO), Encoding.UTF8, "application/json");

            var res = await _client.PutAsync($"{Settings1.Default.ConnectionString}/user/{id}", jsonBodyParameter);

            if (res.IsSuccessStatusCode)
            {

                string content = await res.Content.ReadAsStringAsync();

                var DTOUser = JsonSerializer.Deserialize<GetUsersResponseDTO>(content);

                return new BOUser()
                {
                    Id = DTOUser.Id,
                    Name = DTOUser.Name,
                    First_Name = DTOUser.FirstName,
                    Login_Name = DTOUser.LoginName,
                    Ph_No = DTOUser.PhNo,
                    E_Mail = DTOUser.EMail,
                    Moderator_Y_N = DTOUser.ModeratorYN,
                    Password = DTOUser.Password
                };
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Topic
        #endregion

        #region Reply
        #endregion

        #region Rubric

        //Get topics by rubric id
        public async Task<List<BOTopics>> GetTopicsByRubricIdAsync(int id)
        {
            var res = await _client.GetAsync($"{Settings1.Default.ConnectionString}/rubric/{id}/topics");

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();

                var lstDTOUsers = JsonSerializer.Deserialize<List<GetRubricsAndTopicsDetailResponseDTO>>(content);

                return lstDTOUsers.ConvertAll(u => new BOTopics
                {
                    TopicTitle = u.TopicTitle,
                    TopicText = u.TopicText,
                    TopicCreatorNickName = u.TopicCreatorNickName,
                    TopicPublishedDate = u.TopicPublishedDate,
                    RubricId = u.RubricId,
                    RubricName = u.RubricName,
                    TopicId = u.TopicId,
                });
            }
            else
            {
                return null;
            }


        }


        #endregion
    }

    }
