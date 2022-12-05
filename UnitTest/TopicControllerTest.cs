using APIActivite3.Controllers;
<<<<<<< HEAD
using APIActivite3.Utils;
=======
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
using BLL;
using Domain.DTO.Requestes.Topics;
using Domain.DTO.Responses.Topics;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTest
{
    public class TopicControllerTest : ControllerBase
    {


        [Fact]
        /*****  [HttpGet("{id}")]   GetTopicById([FromRoute] int id)*****  ShouldBeOk   *****/
        public async void GetTopicByIdShouldBeOk()
        {
            //var date = DateTime.Now;

            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();
            Mock.Get(forumService)
                .Setup(fs => fs
                .GetTopicByIdAsync(1))
                .ReturnsAsync(new Topic()
                {
                    Id = 1,
                    Title = "Continuing Education",
                    Text_Pub = "Enrollment in formal degree programs, courses, or workshops\r\nPursuing certificates, accreditations or other credentials through educational programs",
                    Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                    Id_User = 1,
                    Id_Rubric = 1,
                    Count_Views = 0
                });

            TopicController topicController = new TopicController(forumService);

            //Act = Action
            IActionResult oKResult = await topicController.GetTopicById(1);

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            OkObjectResult result = oKResult as OkObjectResult; //null ou OKObjectResult
            Assert.NotNull(result);
            Assert.Equal(result.Value as TopicResponseDTO, new TopicResponseDTO()
            {
                TopicId = 1,
                TopicTitle = "Continuing Education",
                TopicText = "Enrollment in formal degree programs, courses, or workshops\r\nPursuing certificates, accreditations or other credentials through educational programs",
                TopicPublishedDate = DateTime.Parse("2022-09-27T11:42:42"),
                TopicCreatorId = 1,
                TopicIdRubric = 1,
                TopicCountViews = 0
            });

        }

        // I have commented because not found is handeled in bll

        //[Fact]
        //public async void GetTopicByIdShouldBeNotFound()
        //{
        //    var date = DateTime.Now;
        //    //Arrange = Organiser les données
        //    IForumService forumService = Mock.Of<IForumService>();
        //    Mock.Get(forumService)
        //        .Setup(fs => fs.GetTopicByIdAsync(It.IsAny<int>()))
        //        .ReturnsAsync(null as Topic);//(new Topic() { Id = 5, Text = "", Topic_Date = date, Id_Parent_Topic = 1, Id_User = 1, Id_Topic = 1 });

        //    TopicController topicController = new TopicController(forumService);

        //    //Act = Action
        //    IActionResult oKResult = await topicController.GetTopicById(5);
        //    //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
        //    NotFoundResult notFoundResult = oKResult as NotFoundResult;
        //    Assert.NotNull(notFoundResult);


        //}




       

        [Fact]
        /*****  [HttpPost()]   CreateTopic([FromBody] CreateTopicRequestDTO newTopic)*****  ShouldBeOk   *****/
        public async void CreateTopicShouldBeOk()
        {

            //Arrange = Organiser les données
<<<<<<< HEAD
          //  ISecurityService securityService = Mock.Of<ISecurityService>();

        IForumService forumService = Mock.Of<IForumService>();
            ICurrentUserUtils currentUserUtils = Mock.Of<ICurrentUserUtils>();
            /*        string[] roles = { "USER", "ADMIN" };

                    Mock.Get(securityService)
                      .Setup(sService => sService
                      .SigningAsync("Leo2", "password"))
                      .ReturnsAsync("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJMZW8yIiwianRpIjoiZWNkMDNmOWUtMzY3Ny00NmY1LTkxMDYtMjM4ODI5NDg3NTE0IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiIyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjpbIkFETUlOIiwiVVNFUiJdLCJleHAiOjE2NjkxNTk5MjIsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NTAwMCJ9.X9ThiWl5kcXQeNVo6r2jaDF2m25uuyapHBvfKZMntw4");

                    var fakeHttpContext = new Mock<ControllerBase>();
                    var fakeIdentity = new GenericIdentity("Leo2");
                    var principal = new GenericPrincipal(fakeIdentity, roles);
                   */
            // string idMemberToken =
            //Setup(t => t.User).Returns(principal); //   User.Claims.ElementAt(2).Value; 
            // int userId = int.Parse(idMemberToken);  
=======
            ISecurityService securityService = Mock.Of<ISecurityService>();
        IForumService forumService = Mock.Of<IForumService>();
    /*        string[] roles = { "USER", "ADMIN" };

            Mock.Get(securityService)
              .Setup(sService => sService
              .SigningAsync("Leo2", "password"))
              .ReturnsAsync("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJMZW8yIiwianRpIjoiZWNkMDNmOWUtMzY3Ny00NmY1LTkxMDYtMjM4ODI5NDg3NTE0IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvbmFtZWlkZW50aWZpZXIiOiIyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjpbIkFETUlOIiwiVVNFUiJdLCJleHAiOjE2NjkxNTk5MjIsImlzcyI6Imh0dHA6Ly9sb2NhbGhvc3Q6NTAwMCJ9.X9ThiWl5kcXQeNVo6r2jaDF2m25uuyapHBvfKZMntw4");

            var fakeHttpContext = new Mock<ControllerBase>();
            var fakeIdentity = new GenericIdentity("Leo2");
            var principal = new GenericPrincipal(fakeIdentity, roles);
           */
            // string idMemberToken =
            //Setup(t => t.User).Returns(principal); //   User.Claims.ElementAt(2).Value; 
                                        // int userId = int.Parse(idMemberToken);  
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9


            CreateTopicRequestDTO newTopic = new CreateTopicRequestDTO()
            {
                TopicTitle = "Topic Title test",
                TopicText = "Topic Text test",
                TopicRubricId = 1,
                TopicCreatorId = 2,

            };

            Topic createTopic = new Topic()
            {
                //  Id = 1,
                Title = newTopic.TopicTitle,
                Text_Pub = newTopic.TopicText,
                //  Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                Id_User = newTopic.TopicCreatorId,
                Id_Rubric = newTopic.TopicRubricId,
                //  Count_Views = 0
            };

            Topic createTopicReturn = new Topic()
            {
                //Id = 2,
                Title = newTopic.TopicTitle,
                Text_Pub = newTopic.TopicText,
                Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                Id_User = newTopic.TopicCreatorId,
                Id_Rubric = newTopic.TopicRubricId,
                Count_Views = 0
            };

          /*  Mock.Get(securityService)
               .Setup(sService => sService.SigningAsync("Leo2", "password")) 
               .ReturnsAsync(GenerateJwtToken("Leo2", new List<string>() { "ADMIN", "USER" }, 2));
            //GenerateJwtToken(login_name, new List<string>() { "ADMIN", "USER" }, id)*/

            Mock.Get(forumService)
                .Setup(fService => fService.CreateTopicAsync(createTopic))
                .ReturnsAsync(createTopicReturn);

<<<<<<< HEAD
            Mock.Get(currentUserUtils)
               .Setup(cUserUtils => cUserUtils.GetCurrentUserId())
               .Returns(2);

=======
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
            TopicController topicController = new TopicController(forumService);


            //Act = Action
<<<<<<< HEAD
            IActionResult result = await topicController.CreateTopic(newTopic, currentUserUtils);
=======
            IActionResult result = await topicController.CreateTopic(newTopic);
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            //OkObjectResult oKresult = result as OkObjectResult; //null ou OKObjectResult
           // Assert.NotNull(oKresult);
            Assert.True(result is CreatedAtActionResult);
      /*      CreatedAtActionResult result1 = result as CreatedAtActionResult;
            Assert.Equal(oKresult.Value as TopicResponseDTO, new TopicResponseDTO()
            {
                //  TopicId = 
                TopicTitle = newTopic.TopicTitle,
                TopicText = newTopic.TopicText,
                TopicPublishedDate = DateTime.Parse("2022-09-27T11:42:42"),
                TopicCreatorId = newTopic.TopicCreatorId,
                TopicIdRubric = newTopic.TopicRubricId,
                TopicCountViews = 0,
            });*/
        }



        [Fact]
        /*****  [HttpPost()]   CreateTopic([FromBody] CreateTopicRequestDTO newTopic)*****  ShouldBeBadRequest   *****/
        public async void CreateTopicShouldBeBadRequest()
        {

            var date = DateTime.Now;


            // var httpContext = Mock.Of<HttpContext>();  //ControllerBase


            // string idMemberToken = 
            // Mock.Get(httpContext.User.Claims)
            //.Setup(_ => _.ElementAt(2).Value)
            //.Returns("1");


            // int userId = int.Parse("1");
            /*********************************************************************************/
            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();
<<<<<<< HEAD
            ICurrentUserUtils currentUserUtils = Mock.Of<ICurrentUserUtils>();
=======
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            CreateTopicRequestDTO newTopic = new CreateTopicRequestDTO()
            {
                TopicTitle = "Topic Title test",
                TopicText = "Topic Text test",
                TopicRubricId = 0,
                TopicCreatorId = 2,
            };

            Topic createTopic = new Topic()
            {
                //  Id = 1,
                Title = newTopic.TopicTitle,
                Text_Pub = newTopic.TopicText,
                //  Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                Id_User = newTopic.TopicCreatorId,
                Id_Rubric = newTopic.TopicRubricId,
                //  Count_Views = 0
            };


            Mock.Get(forumService)
                .Setup(fService => fService.CreateTopicAsync(createTopic))
                .ReturnsAsync(null as Topic);
<<<<<<< HEAD
            Mock.Get(currentUserUtils)
              .Setup(cUserUtils => cUserUtils.GetCurrentUserId())
              .Returns(2);
=======

>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
            TopicController topicController = new TopicController(forumService);


            //Act = Action
<<<<<<< HEAD
            IActionResult result = await topicController.CreateTopic(newTopic, currentUserUtils);
=======
            IActionResult result = await topicController.CreateTopic(newTopic);
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)           
            Assert.NotNull(result as BadRequestResult);


        }




        [Fact]
        /*****  [HttpPut()]   UpdateTopic([FromRoute] int id, [FromBody] UpdateTopicRequestDTO updateTopic)*****  ShouldBeOk   *****/
        public async void UpdateTopicShouldBeOk()
        {
            //var httpContext = Mock.Of<HttpContext>();  //ControllerBase

            //var user = Mock.Of<httpContext.User>();


            //string idMemberToken = httpContext.User.Claims.ElementAt(2).Value;
     /*
      * var claims = new List<ClaimsIdentity>(){
               new ClaimsIdentity ("sub", "1","user"),
               new ClaimsIdentity("jti", "1","user"),
             //  new Claim("NewClaim", "toto"),

               new ClaimsIdentity("NameIdentifier", "1","user")
           };



            var contextMock = new Mock<HttpContext>();
            contextMock.Setup(x => x.User).Returns(new ClaimsPrincipal(new ClaimsIdentity()));
     */


          //  var date = DateTime.Now;

            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();
<<<<<<< HEAD
            ICurrentUserUtils currentUserUtils = Mock.Of<ICurrentUserUtils>();
=======

>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
            UpdateTopicRequestDTO updateTopic = new UpdateTopicRequestDTO()
            {
                IdUser =2,
                   TopicId = 9,
                   TopicTitle = "Topic Title test",
                   TopicText = "Topic Text test",
                   TopicRubricId = 3

            };

            Topic updateTopicRequest = new Topic()
            {
                 Id = updateTopic.TopicId,
                Title = updateTopic.TopicTitle,
                Text_Pub = updateTopic.TopicText,
              //  Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
               // Id_User = updateTopic.IdUser,
              //  Id_Rubric = updateTopic.TopicRubricId,
              //  Count_Views = 0
            };

            Topic updateTopicRequestReturn = new Topic()
            {
                Id = updateTopic.TopicId,
                Title = updateTopic.TopicTitle,
                Text_Pub = updateTopic.TopicText,
                Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                Id_User = updateTopic.IdUser,
                Id_Rubric = updateTopic.TopicRubricId,
                Count_Views = 0
            };


            Mock.Get(forumService)
                .Setup(fService => fService.ModifyTopicAsync(9,updateTopicRequest))
                .ReturnsAsync(updateTopicRequestReturn);
<<<<<<< HEAD
            Mock.Get(currentUserUtils)
               .Setup(cUserUtils => cUserUtils.GetCurrentUserId())
               .Returns(2);
=======

>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
            TopicController topicController = new TopicController(forumService);


            //var identity = new Mock<IIdentity>();
            //identity.SetupGet(i => i.IsAuthenticated).Returns(true);
            //identity.SetupGet(i => i.Name).Returns("FakeUserName");

            //var mockPrincipal = new Mock<ClaimsPrincipal>();
            //mockPrincipal.Setup(x => x.Identity).Returns(identity.Object);
            // var claims = new List<ClaimsIdentity>(){
            //    new ClaimsIdentity ("sub", "1","user"),
            //    new ClaimsIdentity("jti", "1","user"),
            //  //  new Claim("NewClaim", "toto"),

            //    new ClaimsIdentity("NameIdentifier", "1","user")
            //};



            // var contextMock = new Mock<HttpContext>();
            // contextMock.Setup(x => x.User).Returns(new ClaimsPrincipal( claims));

           // topicController.ControllerContext.HttpContext = contextMock.Object;

            //topicController.ControllerContext.HttpContext.User.Claims.Append(new Claim("NameIdentifier", "1"));
            //topicController.ControllerContext.HttpContext.User.Claims.Append(new Claim("NameIdentifier", "1"));
            //topicController.ControllerContext.HttpContext.User.Claims.Append(new Claim("NameIdentifier", "1"));


            //Act = Action
<<<<<<< HEAD
            IActionResult result = await topicController.UpdateTopic(9, updateTopic, currentUserUtils);
=======
            IActionResult result = await topicController.UpdateTopic(9, updateTopic);
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            OkObjectResult oKresult = result as OkObjectResult;
            Assert.NotNull(oKresult);

          /*  Assert.Equal(oKresult.Value as TopicResponseDTO, new TopicResponseDTO()
            {
                TopicId = updateTopicRequestReturn.Id,
                TopicTitle = updateTopicRequestReturn.Title,
                TopicText = updateTopicRequestReturn.Text_Pub,
                TopicPublishedDate = updateTopicRequestReturn.Pub_Date,
                TopicIdRubric = updateTopicRequestReturn.Id_Rubric,
                TopicCreatorId = updateTopicRequestReturn.Id_User,
                TopicCountViews = updateTopicRequestReturn.Count_Views
            });*/
        }


        [Fact]
        /*****  [HttpPut()]   UpdateTopic([FromRoute] int id, [FromBody] UpdateTopicRequestDTO updateTopic)*****  ShouldBeNotFound   *****/
        public async void UpdateTopicShouldBeNotFound()
        {

            
/*
            //string idMemberToken = httpContext.User.Claims.ElementAt(2).Value;
            var claims = new List<ClaimsIdentity>(){
               new ClaimsIdentity ("sub", "1","user"),
               new ClaimsIdentity("jti", "1","user"),
             //  new Claim("NewClaim", "toto"),

               new ClaimsIdentity("NameIdentifier", "1","user")
           };



            var contextMock = new Mock<HttpContext>();
            contextMock.Setup(x => x.User).Returns(new ClaimsPrincipal(new ClaimsIdentity()));



            var date = DateTime.Now;
*/
            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();
<<<<<<< HEAD
            ICurrentUserUtils currentUserUtils = Mock.Of<ICurrentUserUtils>();
=======

>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
            UpdateTopicRequestDTO updateTopic = new UpdateTopicRequestDTO()
            {
                IdUser = 2,
                TopicId = 9,
                TopicTitle = "Topic Title test",
                TopicText = "Topic Text test",
                TopicRubricId = 0

            };

            Topic updateTopicRequest = new Topic()
            {
                Id = updateTopic.TopicId,
                Title = updateTopic.TopicTitle,
                Text_Pub = updateTopic.TopicText,
                Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                Id_User = updateTopic.IdUser,
                Id_Rubric = updateTopic.TopicRubricId,
                Count_Views = 0
            };

            Topic updateTopicRequestReturn = null;/*new Topic()
            {
                Id = updateTopic.TopicId,
                Title = updateTopic.TopicTitle,
                Text_Pub = updateTopic.TopicText,
                Pub_Date = DateTime.Parse("2022-09-27T11:42:42"),
                Id_User = updateTopic.IdUser,
                Id_Rubric = updateTopic.TopicRubricId,
                Count_Views = 0
            };*/


            Mock.Get(forumService)
                .Setup(fService => fService
                .ModifyTopicAsync(9, updateTopicRequest))
                .ReturnsAsync(updateTopicRequestReturn);
<<<<<<< HEAD
            Mock.Get(currentUserUtils)
               .Setup(cUserUtils => cUserUtils.GetCurrentUserId())
               .Returns(2);
=======

>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9
            TopicController topicController = new TopicController(forumService);



        //    topicController.ControllerContext.HttpContext = contextMock.Object;

          

            //Act = Action
<<<<<<< HEAD
            IActionResult result = await topicController.UpdateTopic(0, updateTopic, currentUserUtils);
=======
            IActionResult result = await topicController.UpdateTopic(9, updateTopic);
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            if (result is null)
            {
              //  result = 
            }

            Assert.NotNull(result as BadRequestResult);

        }

        
    }
}
