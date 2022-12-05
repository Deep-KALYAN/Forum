using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public interface IForumService
    {
        /// <summary>
        /// To Create Reply 
        /// </summary>
        /// <param name="reply"></param>
        /// <returns> BO Reply or Null</returns>
        Task<Reply> CreateReplyAsync(Reply reply);

        /// <summary>
        /// To Create Rubric 
        /// </summary>
        /// <param name="rubric"></param>
        /// <returns>BO Rubric or Null</returns>
        Task<Rubric> CreateRubricAsync(Rubric rubric);

        /// <summary>
        /// To Create Topic 
        /// </summary>
        /// <param name="topic"></param>
        /// <returns>BO Topic or Null</returns>
        Task<Topic> CreateTopicAsync(Topic topic);


        /// <summary>
        /// To Delete Reply by Reply Id
        /// If Deleted, Text Change as "message have been deleted by admin"
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>boolean</returns>
        Task<bool> DeleteReplyAsync(int id);

        /// <summary>
        /// To Delete Rubric by Id
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>boolean</returns>
        /// 
        Task<bool> DeleteRubricAsync(int id);

        /// <summary>
        /// To Delete Topic  by Id,
        /// All Concerning Replies will Delete also
        /// </summary>
        /// <param name="id"></param>
        /// <returns>boolean</returns>
        Task<bool> DeleteTopicAsync(int id);

        /// <summary>
        /// To Get All Replies 
        /// </summary>
        /// <returns>BO Reply IEnumerable</returns>
        Task<IEnumerable<Reply>> GetRepliesAsync();

        /// <summary>
        /// To Get Replies of Concerning Topic by Topic Id 
        /// </summary>
        /// <param name="topicId">id</param>
        /// <returns>BO Reply IEnumerable</returns>
        Task<IEnumerable<Reply>> GetRepliesByTopicIdAsync(int topicId);



        /// <summary>
        /// To Get Reply by Id  
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>BO Reply</returns>
        Task<Reply> GetReplyByIdAsync(int id);

        /// <summary>
        /// To Get Rubric by Id
        /// </summary>
        /// <returns>BO Rubric</returns>
        Task<Rubric> GetRubricByIdAsync(int id);

        /// <summary>
        /// To Get All Rubrics  
        /// </summary>
        /// <returns>BO Rubric IEnumerable</returns>
        Task<IEnumerable<Rubric>> GetRubricsAsync();

        /// <summary>
        /// To Get Topic by Id 
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>BO Topic</returns>
        Task<Topic> GetTopicByIdAsync(int id);

        /// <summary>
        /// To Get All Topics
        /// </summary>
        /// <returns>BO Topic IEnumerable</returns>
        Task<IEnumerable<Topic>> GetTopicsAsync();

        /// <summary>
        /// To Get Topics of Concerning Rubric by Rubric Id
        /// </summary>
        /// <param name="rubricId">id</param>
        /// <returns>BO Topic IEnumerable</returns>
        Task<IEnumerable<Topic>> GetTopicsByRubricIdAsync(int rubricId);

        /// <summary>
        /// To Modify Reply
        /// </summary>      
        /// <param name="reply">BO Reply</param>
        /// <returns>BO Reply or Null</returns>
        Task<Reply> ModifyReplyAsync( Reply reply);

        /// <summary>
        /// To Modify Rubric 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="rubric">BO Rubric</param>
        /// <returns>BO Rubric or Null</returns>
        Task<Rubric> ModifyRubricAsync(int id, Rubric rubric);

        /// <summary>
        /// To Modify Topic 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="topic">BO Topic</param>
        /// <returns>BO Topic or Null</returns>
        Task<Topic> ModifyTopicAsync(int id, Topic topic);




        // //To work with view TOPIC_DETAIL 

        /// <summary>
        /// To Get All Replies with Detail (by View TOPIC_DETAIL )
        /// </summary>
        /// <returns>BO TopicDetail IEnumerable</returns>
        Task<IEnumerable<TopicDetail>> DetailTopicsAsync();

        /// <summary>
        /// To Get Replies with Detail by Topic Id (by View TOPIC_DETAIL )
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>BO TopicDetail IEnumerable</returns>
        Task<IEnumerable<TopicDetail>> DetailTopicByIdAsync(int id);


        // //To work with view RUBRICS_DETAIL 

        /// <summary>
        /// To Get All Topics with Detail (by View RUBRICS_DETAIL )
        /// </summary>
        /// <returns>BO RubricDetail IEnumerable</returns>
        Task<IEnumerable<RubricDetail>> DetailRubricsAsync();

        /// <summary>
        /// To Get Topics with Detail by Rubric Id (by View RUBRICS_DETAIL )
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>BO RubricDetail IEnumerable</returns>
        Task<IEnumerable<RubricDetail>> DetailRubricByIdAsync(int id);


    }
}