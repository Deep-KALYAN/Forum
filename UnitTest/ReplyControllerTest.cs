using APIActivite3.Controllers;
using BLL;
using Domain.DTO.Requestes.Replies;
using Domain.DTO.Responses.Replies;
using Domain.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Xunit;

namespace UnitTest
{
    public class ReplyControllerTest
    {


        [Fact]
        /*****  [HttpGet("{id}")]   GetReplyById([FromRoute] int id)*****  ShouldBeOk   *****/
        public async void GetReplyByIdShouldBeOk()
        {
            var date = DateTime.Now;

            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();
            Mock.Get(forumService)
                .Setup(fs => fs
                .GetReplyByIdAsync(5))
                .ReturnsAsync(new Reply()
                {
                    Id = 5,
                    Text = "",
                    Reply_Date = date,
                    Id_Parent_Reply = 1,
                    Id_User = 1,
                    Id_Topic = 1
                });

            ReplyController replyController = new ReplyController(forumService);

            //Act = Action
            IActionResult oKResult = await replyController.GetReplyById(5);

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            OkObjectResult result = oKResult as OkObjectResult; //null ou OKObjectResult
            Assert.NotNull(result);
            Assert.Equal(result.Value as ReplyResponseDTO, new ReplyResponseDTO()
            {
                ReplyId = 5,
                ReplyText = "",
                ReplyDate = date,
                ParentReplyId = 1,
                CreatorId = 1,
                TopicId = 1
            });

        }
        
        // I have commented because not found is handeled in bll

        //[Fact]
        //public async void GetReplyByIdShouldBeNotFound()
        //{
        //    var date = DateTime.Now;
        //    //Arrange = Organiser les données
        //    IForumService forumService = Mock.Of<IForumService>();
        //    Mock.Get(forumService)
        //        .Setup(fs => fs.GetReplyByIdAsync(It.IsAny<int>()))
        //        .ReturnsAsync(null as Reply);//(new Reply() { Id = 5, Text = "", Reply_Date = date, Id_Parent_Reply = 1, Id_User = 1, Id_Topic = 1 });

        //    ReplyController replyController = new ReplyController(forumService);

        //    //Act = Action
        //    IActionResult oKResult = await replyController.GetReplyById(5);
        //    //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
        //    NotFoundResult notFoundResult = oKResult as NotFoundResult;
        //    Assert.NotNull(notFoundResult);


        //}





        [Fact]
        /*****  [HttpPost()]   CreateReply([FromBody] CreateReplyRequestDTO newReply)*****  ShouldBeOk   *****/
        public async void CreateReplyShouldBeOk()
        {
      
            var date = DateTime.Now;
   

        //    var httpContext = Mock.Of<HttpContext>();  //ControllerBase
        //// string idMemberToken = 
        //        Mock.Get(httpContext.User.Claims)
        //       .Setup(_ => _.ElementAt(2).Value)
        //       .Returns("1");
        //    int userId = int.Parse("1");

            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();

            CreateReplyRequestDTO newReply = new CreateReplyRequestDTO()
            {
                UserId = 1,
                ReplyText = "Hello Text",
                ReplyParentId = 1,
                ReplyTopicId = 1
            };

            Reply createReply = new Reply()
            {
                Id_Parent_Reply = newReply.ReplyParentId,
                Id_Topic = newReply.ReplyTopicId,
                Text = newReply.ReplyText,
                Id_User = newReply.UserId, /*must get from token **/
              //  Deleted = false,
              //  Reply_Date = date
            };

            Reply createReplyReturn = new Reply()
            {
                Id = 2,
                Id_Parent_Reply = newReply.ReplyParentId,
                Id_Topic = newReply.ReplyTopicId,
                Text = newReply.ReplyText,
                Id_User = newReply.UserId, /*must get from token **/
                Reply_Date = date
            };


            Mock.Get(forumService)
                .Setup(fService => fService.CreateReplyAsync(createReply))
                .ReturnsAsync(createReplyReturn);

            ReplyController replyController = new ReplyController(forumService);
      

            //Act = Action
            IActionResult result = await replyController.CreateReply(newReply);

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            OkObjectResult oKresult = result as OkObjectResult; //null ou OKObjectResult
            Assert.NotNull(oKresult);
            Assert.Equal(oKresult.Value as ReplyResponseDTO, new ReplyResponseDTO()
            {
                ReplyId = 2,
                ReplyText = "Hello Text",
                ReplyDate = date,
                ParentReplyId = 1,
                CreatorId = 1,
                TopicId = 1
            });
        }



        [Fact]
        /*****  [HttpPost()]   CreateReply([FromBody] CreateReplyRequestDTO newReply)*****  ShouldBeBadRequest   *****/
        public async void CreateReplyShouldBeBadRequest()
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

            CreateReplyRequestDTO newReply = new CreateReplyRequestDTO()
            {
                ReplyText = "Hello Text",
                ReplyParentId = 1,
                ReplyTopicId = 0
            };

            Reply createReply = new Reply()
            {
                Id_Parent_Reply = newReply.ReplyParentId,
                Id_Topic = newReply.ReplyTopicId,
                Text = newReply.ReplyText,
                Id_User = 1, /*must get from token **/
                Deleted = false,
                Reply_Date = date
            };


            Mock.Get(forumService)
                .Setup(fService => fService.CreateReplyAsync(createReply))
                .ReturnsAsync(null as Reply);

            ReplyController replyController = new ReplyController(forumService);


            //Act = Action
            IActionResult result = await replyController.CreateReply(newReply);

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)           
            Assert.NotNull(result as BadRequestResult);
           

        }




        [Fact]
        /*****  [HttpPut()]   UpdateReply([FromRoute] int id, [FromBody] UpdateReplyRequestDTO updateReply)*****  ShouldBeOk   *****/
        public async void UpdateReplyShouldBeOk()
        {
            //var httpContext = Mock.Of<HttpContext>();  //ControllerBase

            //var user = Mock.Of<httpContext.User>();


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

            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();

            UpdateReplyRequestDTO updateReply = new UpdateReplyRequestDTO()
            {
                ReplyText = "Hello Text",               
                ReplyId = 1,
                IdUser = 1
            };

            Reply updateReplyRequest = new Reply()
            {
                Id = updateReply.ReplyId,
                Text = updateReply.ReplyText
            };

            Reply updateReplyRequestReturn = new Reply()
            {
                Id = updateReply.ReplyId,
                Text = updateReply.ReplyText,
                Reply_Date = date,
                Id_Parent_Reply = 1,
                Id_User = 1,
                Id_Topic = 1
            };


            Mock.Get(forumService)
                .Setup(fService => fService.ModifyReplyAsync(updateReplyRequest))
                .ReturnsAsync(updateReplyRequestReturn);

            ReplyController replyController = new ReplyController(forumService);


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

            replyController.ControllerContext.HttpContext = contextMock.Object;

            //replyController.ControllerContext.HttpContext.User.Claims.Append(new Claim("NameIdentifier", "1"));
            //replyController.ControllerContext.HttpContext.User.Claims.Append(new Claim("NameIdentifier", "1"));
            //replyController.ControllerContext.HttpContext.User.Claims.Append(new Claim("NameIdentifier", "1"));
           

            //Act = Action
            IActionResult result = await replyController.UpdateReply(1, updateReply);

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
            OkObjectResult oKresult = result as OkObjectResult;
            Assert.NotNull(oKresult);

            Assert.Equal(oKresult.Value as ReplyUpdateResponseDTO, new ReplyUpdateResponseDTO()
            {
                ReplyId = updateReplyRequestReturn.Id,
                ReplyText = updateReplyRequestReturn.Text,
                ReplyDate = updateReplyRequestReturn.Reply_Date,
                ParentReplyId = updateReplyRequestReturn.Id_Parent_Reply,
                CreatorId = updateReplyRequestReturn.Id_User,
                TopicId = updateReplyRequestReturn.Id_Topic
            });
        }


        [Fact]
        /*****  [HttpPut()]   UpdateReply([FromRoute] int id, [FromBody] UpdateReplyRequestDTO updateReply)*****  ShouldBeNotFound   *****/
        public async void UpdateReplyShouldBeNotFound()
        {
           
            var date = DateTime.Now;

            //Arrange = Organiser les données
            IForumService forumService = Mock.Of<IForumService>();

            UpdateReplyRequestDTO updateReply = new UpdateReplyRequestDTO()
            {
                ReplyText = "",
                ReplyId = 1,
                IdUser = 1
            };

            Mock.Get(forumService)
                .Setup(fService => fService.ModifyReplyAsync(It.IsAny<Reply>()))
                .ReturnsAsync(null as Reply);

            ReplyController replyController = new ReplyController(forumService);




            //Act = Action
            IActionResult result = await replyController.UpdateReply(1, updateReply);

            //Assert =  Comparer les valeurs (attendues et réelles) (Expected, Actual)
           
            Assert.NotNull(result as NotFoundResult);
          
        }





    }
}
