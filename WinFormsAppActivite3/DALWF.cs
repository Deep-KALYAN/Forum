using Domain.DTO;
using Domain.DTO.Requestes.Replies;
using Domain.DTO.Requestes.Security;
using Domain.DTO.Requestes.Topics;
using Domain.DTO.Requestes.Users;
using Domain.DTO.Responses.Replies;
using Domain.DTO.Responses.Rubrics;
using Domain.DTO.Responses.Topics;
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

        string _token;

        // userName et roles extraits du JwtToken

        private List<string> roles = new();

        string userId = null;



        public List<string> GetRoles()
        {
            return roles;
        }

        public void SetRoles()
        {
            roles.Clear();
        }


        public string GetUserId()
        {
            return this.userId;
        }

        public void SetUserId()
        {
            userId = null;
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

                userId = null;
                roles.Clear();
                foreach (var item in tokenDecoded.Claims)
                {
                    switch (item.Type)
                    {
                        case ClaimTypes.Role:
                            roles.Add(item.Value);
                            break;
                        case ClaimTypes.NameIdentifier:
                            userId = item.Value;
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

        //Get replies by topic id
        public async Task<List<BOReply>> GetRepliesDetailByTopicIdAsync(int id)
        {
            var res = await _client.GetAsync($"{Settings1.Default.ConnectionString}/topic/{id}/detail");

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();

                var lstDTOReplies = JsonSerializer.Deserialize<List<GetTopicRepliesDetailResponseDTO>>(content);

                return lstDTOReplies.ConvertAll(u => new BOReply
                {
                    TopicId = u.TopicId,
                    TopicViews = u.TopicViews,
                    ChildReplyId = u.ChildReplyId,
                    ChildReplyText = u.ChildReplyText,
                    ChildReplyDate = u.ChildReplyDate,
                    Child_Reply_Deleted = u.Child_Reply_Deleted,
                    CR_CreatorId = u.CR_CreatorId,
                    CR_CreatorNickName = u.CR_CreatorNickName,
                    ParentReplyId = u.ParentReplyId,
                    ParentReplyText = u.ParentReplyText,
                    ParentReplyDate = u.ParentReplyDate,
                    PR_CreatorId = u.PR_CreatorId,
                    PR_CreatorNickName = u.PR_CreatorNickName,
                });
            }
            else
            {
                return null;
            }


        }

        //Add Topic
        //AddTopicAsync(rubricId, ftextBox1TopicTitle.Text, frichTextBox1TopicText.Text, GetCreatorId());

        public async Task<BOTopic> AddTopicAsync(int rubricId, string topicTitle, string topicText, int creatorId)
        {
            CreateTopicRequestDTO createTopicRequestDTO = new()
            {
              TopicCreatorId = creatorId,
              TopicRubricId = rubricId,
              TopicText = topicText,
              TopicTitle = topicTitle,
            };
            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(createTopicRequestDTO), Encoding.UTF8, "application/json");
            var res = await _client.PostAsync($"{Settings1.Default.ConnectionString}/topic", jsonBodyParameter);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();



                var DTOtopic = JsonSerializer.Deserialize<TopicResponseDTO>(content);

                return new BOTopic()
                {
                    TopicTitle = DTOtopic.TopicTitle,
                    TopicText = DTOtopic.TopicText,
                    // TopicCreatorNickName = DTOtopic.,
                    TopicPublishedDate = DTOtopic.TopicPublishedDate,
                    TopicId = DTOtopic.TopicId,
                    RubricId = DTOtopic.TopicIdRubric,
                    // RubricName = DTOtopic
                };
            }
            else
            {
                return null;
            }
        }





        //Update Topic
        //UpdateTopicAsync(  ftextBox4TopicUpdateTitle.Text,frichTextBox2UpdateTopicText.Text,currentTopic.TopicId,   currentTopic.RubricId, GetCreatorId());

        public async Task<BOTopic> UpdateTopicAsync(string topicTitle, string topicText, int topicId, int rubricId, int creatorId)
        {
            UpdateTopicRequestDTO updateTopicRequestDTO = new()
            {
                IdUser = creatorId,
                TopicId = topicId,
                TopicTitle = topicTitle,
                TopicText = topicText,
                TopicRubricId = rubricId,
            };

            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(updateTopicRequestDTO), Encoding.UTF8, "application/json");

            var res = await _client.PutAsync($"{Settings1.Default.ConnectionString}/topic/{topicId}", jsonBodyParameter);

            if (res.IsSuccessStatusCode)
            {

                string content = await res.Content.ReadAsStringAsync();

                var DTOtopic = JsonSerializer.Deserialize<TopicResponseDTO>(content);

                return new BOTopic()
                {
                   TopicTitle = DTOtopic.TopicTitle,
                   TopicText = DTOtopic.TopicText,
                  // TopicCreatorNickName = DTOtopic.,
                   TopicPublishedDate = DTOtopic.TopicPublishedDate,
                   TopicId = DTOtopic.TopicId,
                   RubricId = DTOtopic.TopicIdRubric,
                  // RubricName = DTOtopic


                };
            }
            else
            {
                return null;
            }
        }






        // DeleteTopicAsync(currentTopic.TopicId)
        public async Task<bool> DeleteTopicAsync(int id)
        {
            var res = await _client.DeleteAsync($"{Settings1.Default.ConnectionString}/topic/{id}");
            return res.IsSuccessStatusCode;
        }
        #endregion

        #region Reply

        //Method Add Reply
        //AddReplyAsync(frichTextBox1ReplyAddText.Text, parentId, topicId, GetCreatorId());
        public async Task<BOReplyCU> AddReplyAsync(string replyText, int? replyParentId, int replyTopicId, int creatorId)
        {
            CreateReplyRequestDTO createReplyRequestDTO = new()
            {
                UserId = creatorId,
                ReplyText = replyText,
                ReplyParentId = replyParentId,
                ReplyTopicId = replyTopicId
            };
            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(createReplyRequestDTO), Encoding.UTF8, "application/json");
            var res = await _client.PostAsync($"{Settings1.Default.ConnectionString}/reply", jsonBodyParameter);
            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();



                var DTOReplyC = JsonSerializer.Deserialize<ReplyResponseDTO>(content);

                return new BOReplyCU()
                {
                    ChildReplyId = DTOReplyC.ReplyId,
                    ChildReplyText = DTOReplyC.ReplyText,
                    ChildReplyDate = DTOReplyC.ReplyDate,
                    ParentReplyId = DTOReplyC.ParentReplyId,
                    CR_CreatorId = DTOReplyC.CreatorId,
                    TopicId = DTOReplyC.TopicId
                };
            }
            else
            {
                return null;
            }
        }









        //Method Update Reply
        public async Task<BOReplyCU> UpdateReplyAsync(string replyText, int replyId, int creatorId)
        {
            UpdateReplyRequestDTO updateReplyRequestDTO = new()
            {
                ReplyText = replyText,
                ReplyId = replyId, //replyId,
                IdUser = creatorId
            };

            var jsonBodyParameter = new StringContent(JsonSerializer.Serialize(updateReplyRequestDTO), Encoding.UTF8, "application/json");

            var res = await _client.PutAsync($"{Settings1.Default.ConnectionString}/reply/{replyId}", jsonBodyParameter);
         
            if (res.IsSuccessStatusCode)
            {

                string content = await res.Content.ReadAsStringAsync();

                var DTOReplyU = JsonSerializer.Deserialize<ReplyUpdateResponseDTO>(content);

                return new BOReplyCU()
                {
                     ChildReplyId      = DTOReplyU.ReplyId   ,
                     ChildReplyText    = DTOReplyU.ReplyText   ,
                     ChildReplyDate    = DTOReplyU.ReplyDate   ,
                     ParentReplyId     = DTOReplyU.ParentReplyId   ,
                     CR_CreatorId      = DTOReplyU.CreatorId   ,
                     TopicId           = DTOReplyU.TopicId   

                };
            }
            else
            {
                return null;
            }
        }








        // DeleteReplyAsync(currentReply.ChildReplyId)
        public async Task<bool> DeleteReplyAsync(int id)
        {
            var res = await _client.DeleteAsync($"{Settings1.Default.ConnectionString}/reply/{id}");
            return res.IsSuccessStatusCode;
        }

        #endregion

        #region Rubric

        //Get topics by rubric id
        public async Task<List<BOTopic>> GetTopicsByRubricIdAsync(int id)
        {
            var res = await _client.GetAsync($"{Settings1.Default.ConnectionString}/rubric/{id}/topics");

            if (res.IsSuccessStatusCode)
            {
                string content = await res.Content.ReadAsStringAsync();

                var lstDTOUsers = JsonSerializer.Deserialize<List<GetRubricsAndTopicsDetailResponseDTO>>(content);

                return lstDTOUsers.ConvertAll(u => new BOTopic
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
