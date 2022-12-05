using Domain.DTO.Requestes.Replies;
using Domain.DTO.Responses.Replies;
using IntegrationTest.Fixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTest
{
    public class ReplyControllerTest : AbstractIntegrationTest
    {
        public ReplyControllerTest(APIWebApplicationFactory fixture) : base(fixture) { }

        [Fact]
        public async void GetReplyByIdShouldBeOk()
        {
            //Arrange
            string uri = "/api/reply/1";
            ReplyResponseDTO replyResponseDTOExpected = new ReplyResponseDTO()
            {

                ReplyId = 1,
                ReplyText = "Communication skills, involves evaluating members of your team1",
                ReplyDate = DateTime.Parse("2022-09-27T11:42:49"),
                ParentReplyId = null,
                CreatorId = 2,
                TopicId = 1

            };

            //Act
            HttpResponseMessage response = await _client.GetAsync(uri);

            //Assert
            //Assert.True(response.IsSuccessStatusCode);
            Assert.True(response.IsSuccessStatusCode );//== HttpStatusCode.OK);
            ReplyResponseDTO replyResponseDTO = await response.Content.ReadFromJsonAsync<ReplyResponseDTO>();
            Assert.Equal(replyResponseDTOExpected, replyResponseDTO);
        }


        [Fact]
        public async void GetReplyByIdShouldBeNotFound()
        {
            //Arrange
            string uri = "/api/reply/999999";
           

            //Act
            HttpResponseMessage response = await _client.GetAsync(uri);

            //Assert           
            Assert.True(response.StatusCode == HttpStatusCode.NotFound);
          
        }

        [Fact]
        public async void CreateReplyShouldBeOkAndCreated()
        {
            var date = DateTime.Now;

            //Arrange
            CreateReplyRequestDTO createReplyRequestDTO = new CreateReplyRequestDTO()
            {
                ReplyParentId = null,
                ReplyTopicId = 1,
                ReplyText = "Reply Text Test",
                UserId = 2,
            };

            ReplyResponseDTO resultExpected = new ReplyResponseDTO()
            {
               // ReplyId =,
                ReplyText = "Reply Text Test",
                ReplyDate = date,
                ParentReplyId = null,
                CreatorId = 2,
                TopicId = 1,
            };

            string uri = "/api/reply";

            await SignIn("Leo2", "password");

            //Act
            HttpResponseMessage response = await _client.PostAsJsonAsync<CreateReplyRequestDTO>(uri, createReplyRequestDTO);


            //Assert           
            Assert.True(response.StatusCode == HttpStatusCode.Created);

            ReplyResponseDTO replyResponseDTO = await response.Content.ReadFromJsonAsync<ReplyResponseDTO>();


            Assert.True(replyResponseDTO.ReplyId > 0);
            Assert.True(replyResponseDTO.ReplyText == resultExpected.ReplyText);
        //  Assert.True(replyResponseDTO.ReplyDate == date);
            Assert.True(replyResponseDTO.TopicId == resultExpected.TopicId);
            Assert.True(replyResponseDTO.ParentReplyId == resultExpected.ParentReplyId);
            Assert.True(replyResponseDTO.CreatorId == resultExpected.CreatorId);

            SignOut();
        }

       
        [Fact]
        public async void CreateReplyShouldBadRequest()
        {
            var date = DateTime.Now;

            //Arrange
            CreateReplyRequestDTO createReplyRequestDTO = new CreateReplyRequestDTO()
            {
                ReplyParentId = null,
                ReplyTopicId = 0,
                ReplyText = "Reply Text Test",
                UserId = 2,
            };

            ReplyResponseDTO resultExpected = null;

            string uri = "/api/reply";

            await SignIn("Leo2", "password");

            //Act
            HttpResponseMessage response = await _client.PostAsJsonAsync<CreateReplyRequestDTO>(uri, createReplyRequestDTO);

            //Assert           
            Assert.True(response.StatusCode == HttpStatusCode.BadRequest);

            SignOut();
        }

        [Fact]
        public async void DeleteReplyShouldBeNoContent()
        {
            //Arrange
            string uri = "/api/reply/5";

            //sign in
            await SignIn("Leo2", "password"); // as admin

            //Act
            HttpResponseMessage response = await _client.DeleteAsync(uri);

            //Assert           
            Assert.True(response.StatusCode == HttpStatusCode.NoContent);

            //sign out
            SignOut();
        }

        [Fact]
        public async void DeleteReplyShouldBeNotFound()
        {
            //Arrange
            string uri = "/api/reply/0";

            //sign in
            await SignIn("Leo2", "password"); // as admin

            //Act
            HttpResponseMessage response = await _client.DeleteAsync(uri);

            //Assert           
            Assert.True(response.StatusCode == HttpStatusCode.NotFound);

            //sign out
            SignOut();
        }

    }
}
