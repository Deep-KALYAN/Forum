using APIActivite3.Utils;
using BLL;
using Domain.DTO.Requestes.Topics;
using Domain.DTO.Responses.Topics;
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
    [Route("api/topic")]
    [Authorize(Roles = "USER, ADMIN")]
    public class TopicController : ControllerBase, ITopicController
    {
        private static IForumService _forumService;

        public TopicController(IForumService forumService)
        {
            _forumService = forumService;
        }


        //Not necessary for thr moment
        /*
        [HttpGet("")]
        public async Task<IActionResult> GetTopics()
        {
            var topics = await _forumService.GetTopicsAsync();
            return Ok(topics);

        }
        */


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetTopicById([FromRoute] int id)
        {
            var topic = await _forumService.GetTopicByIdAsync(id); //  GetTopicsByIdAsync();

            if (topic == null) return NotFound();

            TopicResponseDTO topicResponseDTO = new TopicResponseDTO()
            {
                TopicId           = topic.Id,
                TopicTitle          = topic.Title,
                TopicText           = topic.Text_Pub,
                TopicPublishedDate = topic.Pub_Date,
                TopicCreatorId      = topic.Id_User,
                TopicIdRubric       = topic.Id_Rubric,
                TopicCountViews      = topic.Count_Views,


            };


            return Ok(topicResponseDTO);

        }



        //// Get The Replies By Topic Id 
        //// Get The Parent reply
        //// Get The id and nick name of Creater
        ////Checked Deleted message in bll
        //[HttpGet("{id}/replies")]
        //public async Task<IActionResult> GetRepliesByTopicId([FromRoute] int id)
        //{
        //    var replies = await _forumService.GetRepliesByTopicIdAsync(id);


        //    var topicResponse = replies.Select(reply => new GetTopicRepliesResponseDTO
        //    {
        //        //_Reply = new GetTopicReplyResponseDTO
        //        //{
        //        //    Id         =    reply.replyParent.Id,
        //        //    Text       =    reply.replyParent.Text,
        //        //    Reply_Date =    reply.replyParent.Reply_Date,
        //        //},
        //        _Reply = reply.replyParent,
        //        Id = reply.Id,
        //        Text = reply.Text,
        //        Reply_Date = reply.Reply_Date
        //    });




        //    //foreach (var reply in replies)
        //    //{
        //    //    if (reply.replyParent == null)
        //    //    {
        //    //        GetTopicRepliesResponseDTO responseDTO1 = new GetTopicRepliesResponseDTO()
        //    //        {
        //    //            _Reply = null,
        //    //            Id = reply.Id,
        //    //            Text = reply.Text,
        //    //            Reply_Date = reply.Reply_Date
        //    //        };
        //    //    }
        //    //    else
        //    //    {
        //    //        GetTopicRepliesResponseDTO responseDTO2 = new GetTopicRepliesResponseDTO()
        //    //        {
        //    //            _Reply = null,
        //    //            Id = reply.replyParent.Id,
        //    //            Text = reply.replyParent.Text,
        //    //            Reply_Date = reply.replyParent.Reply_Date
        //    //        };
        //    //        GetTopicRepliesResponseDTO responseDTO1 = new GetTopicRepliesResponseDTO()
        //    //        {
        //    //            _Reply = responseDTO2,
        //    //            Id = reply.Id,
        //    //            Text = reply.Text,
        //    //            Reply_Date = reply.Reply_Date
        //    //        };
        //    //    }
        //    //    var topicResponse += responseDTO1;
        //    //}          

        //    return Ok(topicResponse);
        //}


        // Get The Replies By Topic Id 
        // Get The Parent reply
        // Get The id and nick name of Creater
        //Checked Deleted message in bll

        [HttpGet("{id}/detail")]
        [AllowAnonymous]
        //// Get The Replies By Topic Id 
        //// Get The Parent reply
        //// Get The id and nick name of Creator
        //// Deleled topics filtered in DB view
        //// Deleted messages for child reply and parent text have been changed in bll
        ////---- Each time someone open count must increase + 1
        public async Task<IActionResult> GetTopicDetailById([FromRoute] int id)
        {
            var topics = await _forumService.DetailTopicByIdAsync(id); //    GetTopicByIdAsync(id);
            if (topics == null)
            {
                return NotFound();
            }

            //need one dto 

            var topicDetailsResponse = topics.Select(topic => new GetTopicRepliesDetailResponseDTO
            {
                TopicId = topic.Id,
                TopicViews = topic.Count_Views,
                ChildReplyId = topic.Child_Reply_Id,
                ChildReplyText = topic.Child_Reply_Text,
                ChildReplyDate = topic.Child_Reply_Date,
                Child_Reply_Deleted = topic.Child_Reply_Deleted,
                CR_CreatorId = topic.Creator_Id_CR,
                CR_CreatorNickName = topic.Creator_Nick_Name_CR,
                ParentReplyId = topic.Parent_Reply_Id,
                ParentReplyText = topic.Parent_Reply_Text,
                ParentReplyDate = topic.Parent_Reply_Date,
                PR_CreatorId = topic.Creator_Id_PR,
                PR_CreatorNickName = topic.Creator_Nick_Name_PR,
            }).ToList();

            if (topicDetailsResponse == null)
            {
                ;
            }

            return Ok(topicDetailsResponse);
        }




        [HttpPost()]
        public async Task<IActionResult> CreateTopic([FromBody] CreateTopicRequestDTO newTopicDTO, [FromServices] ICurrentUserUtils currentUserUtils)
        {
            int idMemberToken = currentUserUtils.GetCurrentUserId().GetValueOrDefault();//HttpContext.User.Claims.ElementAt(2).Value;
                                                                                        // dto => TITLE,TEXT_PUB,ID_RUBRIC
                                                                                        // we add here PUB_DATE,DELETED,ID_USER
                                                                                        //Validation des données envoyer par le client

<<<<<<< HEAD
            // string idMemberToken =  HttpContext.User.Claims.ElementAt(2).Value; //"2";
            if (idMemberToken == 0) throw new UnknownException();
            int userId = idMemberToken;
=======
            string idMemberToken =  HttpContext.User.Claims.ElementAt(2).Value; //"2";
            if (idMemberToken == null) throw new UnknownException();
            int userId = int.Parse(idMemberToken);
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            Topic topic = new Topic()
            {
                //  public int Id { get; set; }
                Title = newTopicDTO.TopicTitle,
                Text_Pub = newTopicDTO.TopicText,
                //  Pub_Date = DateTime.Now,
                //  Deleted = 0,
                Id_User = userId, /***************************************must get dynamically******************************/
                Id_Rubric = newTopicDTO.TopicRubricId


            };

            //    public string TopicTitle { get; set; }
            //public string TopicText { get; set; }
            ////public DateTime TopicPulishedDate { get; set; }
            ////public byte TopicDeleted { get; set; }
            ////public int TopicCreatorId { get; set; }
            //public int TopicRubricId { get; set; }

            ////public int TopicViews { get; set; }


            //******************codesmissing**********
            //newTopic.Pub_Date = DateTime.Now;

            var topic1 = await _forumService.CreateTopicAsync(topic);
            if (topic1 != null)
            {
                //******************codesmissing**********
                // dto TopicResponseDTO

                TopicResponseDTO topicResponseDTO = new TopicResponseDTO()
                {
                    TopicId = topic1.Id,
                    TopicTitle = topic1.Title,
                    TopicText = topic1.Text_Pub,
                    TopicPublishedDate = topic1.Pub_Date,
                    TopicCreatorId = topic1.Id_User,
                    TopicIdRubric = topic1.Id_Rubric,
                    TopicCountViews = topic1.Count_Views,
                };

                return CreatedAtAction(nameof(GetTopicById), new { id = topic1.Id }, topicResponseDTO);

                // return Ok(topicResponseDTO);
            }
            return BadRequest();
        }



        [HttpPut("{id}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> UpdateTopic([FromRoute] int id, [FromBody] UpdateTopicRequestDTO updateTopicDTO, [FromServices] ICurrentUserUtils currentUserUtils)
        {
<<<<<<< HEAD
            int idMemberToken = currentUserUtils.GetCurrentUserId().GetValueOrDefault();//HttpContext.User.Claims.ElementAt(2).Value;
=======
            string idMemberToken =  HttpContext.User.Claims.ElementAt(2).Value;
>>>>>>> 699d6e11aaec17672f14b0642fa8bcf974453ab9

            if (idMemberToken != updateTopicDTO.IdUser) throw new UnknownException();


            if (id != updateTopicDTO.TopicId) return BadRequest();
            //Validation des données envoyer par le client

            // Dto => ID   TITLE   TEXT_PUB
            //  PUB_DATE = datetime.now
            //   DELETED = 0 in dal


            Topic topic = new Topic()
            {
                Id = updateTopicDTO.TopicId,
                Title = updateTopicDTO.TopicTitle,
                Text_Pub = updateTopicDTO.TopicText,
                // Pub_Date = DateTime.Now,
                //  Deleted = 0,
                //  Id_User = updateTopicDTO.IdUser, /***************************************must get dynamically******************************/
                //  Id_Rubric = updateTopicDTO.TopicRubricId


            };

            //Topic topic = new Topic()
            //{
            //    //  public int Id { get; set; }
            //    Title = newTopicDTO.TopicTitle,
            //    Text_Pub = newTopicDTO.TopicText,
            //    Pub_Date = DateTime.Now,
            //    Deleted = 0,
            //    Id_User = 1, /***************************************must get dynamically******************************/
            //    Id_Rubric = newTopicDTO.TopicRubricId


            //};



            //******************codesmissing**********
            var updatedTopic = await _forumService.ModifyTopicAsync(id, topic);
            if (updatedTopic != null)
            {
                //******************codesmissing********** dto
                TopicResponseDTO topicResponseDTO = new TopicResponseDTO()
                {
                    TopicId            = updatedTopic.Id,
                    TopicTitle         = updatedTopic.Title,
                    TopicText           = updatedTopic.Text_Pub,
                    TopicPublishedDate  = updatedTopic.Pub_Date,
                    TopicCreatorId      = updatedTopic.Id_User,
                    TopicIdRubric       = updatedTopic.Id_Rubric,
                    TopicCountViews     = updatedTopic.Count_Views,
                };

                //return CreatedAtAction(nameof(GetTopicById), new { id = updatedTopic.Id }, topicResponseDTO);



                return Ok(topicResponseDTO);
            }
            return BadRequest();
        }




        // It'll return 1 if ok

        [HttpDelete("{id}")]
        [Authorize(Roles = "ADMIN")]
        public async Task<IActionResult> DeleteTopic([FromRoute] int id)
        {
            var isDeleted = await _forumService.DeleteTopicAsync(id);

            return (isDeleted) ? NoContent() : NotFound();
        }






    }
}
