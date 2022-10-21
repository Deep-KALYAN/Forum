using Domain.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public interface IForumService
    {
        /// <summary>
        /// To create reply (logged user and admin have right)
        /// </summary>
        /// <param name="reply"></param>
        /// <returns></returns>
        Task<Reply> CreateReplyAsync(Reply reply);

        /// <summary>
        /// To create rubric (no one have right)
        /// </summary>
        /// <param name="rubric"></param>
        /// <returns>ForbiddenAccessException</returns>
        Task<Rubric> CreateRubricAsync(Rubric rubric);

        /// <summary>
        /// To create topic (logged user and admin have right)
        /// </summary>
        /// <param name="topic"></param>
        /// <returns></returns>
        Task<Topic> CreateTopicAsync(Topic topic);


        /// <summary>
        /// To delete reply (only logged admin have right)
        /// If deleted, need to display "message have been deleted by admin" instead of reply
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteReplyAsync(int id);

        /// <summary>
        /// To delete rubric (no one have right)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ForbiddenAccessException</returns>
        Task<bool> DeleteRubricAsync(int id);

        /// <summary>
        /// To delete topic (only logged admin have right)
        /// Firstly need to delete all concerning replies
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteTopicAsync(int id);

        /// <summary>
        /// to get all replies ( ----- public )
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Reply>> GetRepliesAsync();

        /// <summary>
        /// to get replies of concerning topic by topic id ( ----- public )
        /// </summary>
        /// <param name="topicId"></param>
        /// <returns></returns>
        Task<IEnumerable<Reply>> GetRepliesByTopicIdAsync(int topicId);

        

        /// <summary>
        /// to get reply by id  ( ----- public )
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Reply> GetReplyByIdAsync(int id);

        /// <summary>
        /// to get rubric by id ( ----- public )
        /// </summary>
        /// <returns></returns>
        Task<Rubric> GetRubricByIdAsync(int id);

        /// <summary>
        /// to get all rubrics  ( ----- public )
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Rubric>> GetRubricsAsync();

        /// <summary>
        /// to get topic by id ( ----- public )
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Topic> GetTopicByIdAsync(int id);

        /// <summary>
        /// to get all topics( ----- public )
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Topic>> GetTopicsAsync();

        /// <summary>
        /// to get topics of concerning rubric by rubric id ( ----- public )
        /// </summary>
        /// <param name="rubricId"></param>
        /// <returns></returns>
        Task<IEnumerable<Topic>> GetTopicsByRubricIdAsync(int rubricId);

        /// <summary>
        /// to modify reply (no one have right)
        /// </summary>      
        /// <param name="reply"></param>
        /// <returns>ForbiddenAccessException</returns>
        Task<Reply> ModifyReplyAsync( Reply reply);

        /// <summary>
        /// to modify rubric (no one have right)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="rubric"></param>
        /// <returns>ForbiddenAccessException</returns>
        Task<Rubric> ModifyRubricAsync(int id, Rubric rubric);

        /// <summary>
        /// to modify topic (only logged admin have right)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="topic"></param>
        /// <returns></returns>
        Task<Topic> ModifyTopicAsync(int id, Topic topic);




        // //To work with view TOPIC_DETAIL 
        Task<IEnumerable<TopicDetail>> DetailTopicsAsync();

        Task<IEnumerable<TopicDetail>> DetailTopicByIdAsync(int id);


        // //To work with view RUBRICS_DETAIL 
        Task<IEnumerable<RubricDetail>> DetailRubricsAsync();

        Task<IEnumerable<RubricDetail>> DetailRubricByIdAsync(int id);


    }
}