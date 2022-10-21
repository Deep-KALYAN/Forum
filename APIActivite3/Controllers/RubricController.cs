using BLL;
using Domain.DTO.Responses.Rubrics;
using Domain.Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIActivite3.Controllers
{
    [ApiController]
    [Route("api/rubric")]
    public class RubricController : ControllerBase
    {
        private static IForumService _forumService;

        public RubricController(IForumService forumService)
        {
            _forumService = forumService;
        }


        // To get dictionary of Rubrics(Keys) and List<Topics>(values) for home page
        //[HttpGet("")]
        //public async Task<IActionResult> GetRubrics()
        //{
        //    Dictionary<Entity, List<Topic>> rubricsWithTopics = new Dictionary<Entity, List<Topic>>();

        //    var rubrics = await _forumService.GetRubricsAsync();


        //    foreach (Rubric rubric in rubrics)
        //    {
        //        List<Topic> topicsList = new List<Topic>();

        //      //  Rubric rubric = rubric1;

        //        var Topics = await _forumService.GetTopicsByRubricIdAsync(rubric.Id);

        //        foreach (Topic topic in Topics)
        //        {
        //            topicsList.Add(topic);
        //        }

        //        rubricsWithTopics.Add(rubric, topicsList);
        //    }

        //    GetRubricsAndTopicsResponseDTO responseDTO = new GetRubricsAndTopicsResponseDTO()
        //    {

        //        RubricsAndTopics = rubricsWithTopics
        //    };

        //    return (responseDTO != null) ? Ok(responseDTO) : BadRequest();

        //}




        [HttpGet("")]
        public async Task<IActionResult> GetRubrics()
        {
            var rubrics = await _forumService.GetRubricsAsync();
            if (rubrics == null) return NotFound();

            var rubricsResponse = rubrics.Select(rubric => new GetRubricsResponseDTO
            {                
               RubricId = rubric.Id,
               RubricName = rubric.Name,
               
            });

            return Ok(rubricsResponse);
        }


        
       //All rubrics details and relative topics details       

        [HttpGet("details")]
        public async Task<IActionResult> GetAllRubricsTopics()
        {
            var rubricsDetails = await _forumService.DetailRubricsAsync();
            if (rubricsDetails == null) return NotFound();

            var rubricsDetailsResponse = rubricsDetails.Select(rubricDetail => new GetRubricsAndTopicsDetailResponseDTO
            {
        RubricId                = rubricDetail.Id,
        RubricName              = rubricDetail.Rubric_Name,
        TopicId                 = rubricDetail.Topic_Id,
        TopicText               = rubricDetail.Topic_Tex_Pub,
        TopicPublishedDate      = rubricDetail.Topic_Pub_Date,
        TopicTitle              = rubricDetail.Topic_Title,
        TopicCreatorNickName    = rubricDetail.T_Creator_Nick_Name

            });
            


            return Ok(rubricsDetailsResponse);
        }




        //rubric detail and relative topics details

        //// Get The Topics By Reply Id         
        //// Get The id and nick name of Creator of Topic
        //// Checked Deleted topic in bll,  change text and title as "Topic is deleted by admin"

        [HttpGet("{id}/topics")]
        public async Task<IActionResult> GetTopicsByRubricId([FromRoute] int id)
        {
            var rubricTopics = await _forumService.DetailRubricByIdAsync(id); // DetailTopicByIdAsync(id);  
            if (rubricTopics == null) return NotFound();

            var rubricDetailsResponse = rubricTopics.Select(rubricTopic => new GetRubricsAndTopicsDetailResponseDTO
            {
                RubricId = rubricTopic.Id,
                RubricName = rubricTopic.Rubric_Name,
                TopicId = rubricTopic.Topic_Id,
                TopicText = rubricTopic.Topic_Tex_Pub,
                TopicPublishedDate = rubricTopic.Topic_Pub_Date,
                TopicTitle = rubricTopic.Topic_Title,
                TopicCreatorNickName = rubricTopic.T_Creator_Nick_Name
            });

            return Ok(rubricDetailsResponse);
        }






        //Not necessary for thr moment
        /*
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRubricById([FromRoute] int id)
        {
            var rubric = await _forumService.GetRubricByIdAsync(id);

            return Ok(rubric);
        }
        */


        //Not necessary for thr moment
        /*
        [HttpPost()]
        public async Task<IActionResult> CreateRubric([FromBody] Rubric newRubric)
        {
            //Validation des données envoyer par le client
            //******************codesmissing**********
            var rubric = await _forumService.CreateRubricAsync(newRubric);
            if (rubric != null)
            {
                //******************codesmissing**********
                return Ok(rubric);
            }
            return BadRequest();
        }
        */

        //Not necessary for thr moment
        /*
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRubric([FromRoute] int id, [FromBody] Rubric updateRubric)
        {
            //Validation des données envoyer par le client
            //******************codesmissing**********
            var updatedRubric = await _forumService.ModifyRubricAsync(id, updateRubric);
            if (updatedRubric != null)
            {
                //******************codesmissing**********
                return Ok(updateRubric);
            }
            return BadRequest();
        }
        */



        //Not necessary for thr moment
        /*
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTopic([FromRoute] int id)
        {
        var isDeleted = await _forumService.DeleteRubricAsync(id);
        return (isDeleted) ? NoContent() : NotFound();
        }
        */
    }
}
