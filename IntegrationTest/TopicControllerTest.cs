using Domain.DTO.Requestes.Topics;
using Domain.DTO.Responses.Topics;
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
    public class TopicControllerTest : AbstractIntegrationTest
    {
        public TopicControllerTest(APIWebApplicationFactory fixture) : base(fixture) { }

        [Fact]
        public async void GetTopicByIdShouldBeOk()
        {
            //Arrange
            string uri = "/api/topic/1";
            TopicResponseDTO topicResponseDTOExpected = new TopicResponseDTO()
            {

                /*  TopicId = 1,
                  TopicTitle = "Continuing Education",
                  TopicText = "Enrollment in formal degree programs, courses, or workshops\r\nPursuing certificates, accreditations or other credentials through educational programs",
                  TopicPublishedDate = DateTime.Parse("2022-09-27 11:42:42"),
                  TopicCreatorId = 1,
                  TopicIdRubric = 1,
                  TopicCountViews = 0*/


                TopicId = 1,
                TopicTitle = "Continuing Education",
                TopicText = "Enrollment in formal degree programs, courses, or workshops\r\nPursuing certificates, accreditations or other credentials through educational programs",
                TopicPublishedDate = DateTime.Parse("2022-09-27T11:42:42"),
                TopicCreatorId = 1,
                TopicIdRubric = 1,
                TopicCountViews = 0

            };

            //Act
            HttpResponseMessage response = await _client.GetAsync(uri);

            //Assert
            //Assert.True(response.IsSuccessStatusCode);
            Assert.True(response.StatusCode == HttpStatusCode.OK);//IsSuccessStatusCode);//== HttpStatusCode.OK);
            TopicResponseDTO topicResponseDTO = await response.Content.ReadFromJsonAsync<TopicResponseDTO>();
            Assert.Equal(topicResponseDTOExpected, topicResponseDTO);
        }

        
                [Fact]
                public async void GetTopicByIdShouldBeNotFound()
                {
                    //Arrange
                    string uri = "/api/topic/999999";


                    //Act
                    HttpResponseMessage response = await _client.GetAsync(uri);

                    //Assert           
                    Assert.True(response.StatusCode == HttpStatusCode.NotFound);

                }
        
                [Fact]
                public async void CreateTopicShouldBeOkAndCreated()
                {
                    var date = DateTime.Now;

                    //Arrange
                    CreateTopicRequestDTO createTopicRequestDTO = new CreateTopicRequestDTO()
                    {
                        TopicTitle = "Topic Title Test",
                        TopicText = "Topic Text Test",
                        TopicRubricId = 4,
                        TopicCreatorId = 2,
                    };

                    TopicResponseDTO resultExpected = new TopicResponseDTO()
                    {
                      //  TopicId > 0,
                        TopicTitle = "Topic Title Test",
                        TopicText = "Topic Text Test",
                     //  TopicPublishedDate >= date,
                        TopicCreatorId = 2,
                        TopicIdRubric = 4,
                        TopicCountViews = 0,
                    };

                    string uri = "/api/topic";

                    await SignIn("Leo2", "password");

                    //Act
                    HttpResponseMessage response = await _client.PostAsJsonAsync<CreateTopicRequestDTO>(uri, createTopicRequestDTO);


                    //Assert           
                    Assert.True(response.StatusCode == HttpStatusCode.Created);

                    TopicResponseDTO topicResponseDTO = await response.Content.ReadFromJsonAsync<TopicResponseDTO>();


                    Assert.True(topicResponseDTO.TopicId > 0);
                    Assert.True(topicResponseDTO.TopicText == resultExpected.TopicText);
                   // Assert.True(topicResponseDTO.TopicPublishedDate >= date);
                    Assert.True(topicResponseDTO.TopicCreatorId == resultExpected.TopicCreatorId);
                    Assert.True(topicResponseDTO.TopicIdRubric == resultExpected.TopicIdRubric);
                    Assert.True(topicResponseDTO.TopicCountViews == resultExpected.TopicCountViews);

                    SignOut();
                }

        
                [Fact]
                public async void CreateTopicShouldBadRequest()
                {
                    var date = DateTime.Now;

                    //Arrange
                    CreateTopicRequestDTO createTopicRequestDTO = new CreateTopicRequestDTO()
                    {
                        TopicTitle = "Topic Title Test",
                        TopicText = "Topic Text Test",
                        TopicRubricId = 0,
                        TopicCreatorId = 2,
                    };

                    TopicResponseDTO resultExpected = null;

                    string uri = "/api/topic";

                    await SignIn("Leo2", "password");

                    //Act
                    HttpResponseMessage response = await _client.PostAsJsonAsync<CreateTopicRequestDTO>(uri, createTopicRequestDTO);

                    //Assert           
                    Assert.True(response.StatusCode == HttpStatusCode.BadRequest);

                    SignOut();
                }
        
                [Fact]
                public async void DeleteTopicShouldBeNoContent()
                {
                    //Arrange
                    string uri = "/api/topic/25";

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
                public async void DeleteTopicShouldBeNotFound()
                {
                    //Arrange
                    string uri = "/api/topic/0";

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
