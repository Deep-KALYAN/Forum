using DAL.UOW;
using Domain.Entites;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ForumService : IForumService
    {
        private readonly IUnitOfWork _dbContext;

        public ForumService(IUnitOfWork dbContext)
        {
            _dbContext = dbContext;
        }

        #region Rubric
        //+GetRubricsAsync() : IEnumerable<Domain.Entites.Rubric>
        public async Task<IEnumerable<Rubric>> GetRubricsAsync()
        {
            return await _dbContext.Rubrics.GetAllAsync();
        }//return rubric<Rubric> 




        //+GetRubricByIdAsync(Id : int) : Domain.Entites.Rubric
        public async Task<Rubric> GetRubricByIdAsync(int id)
        {
            try
            {
                return await _dbContext.Rubrics.GetByIdAsync(id);
            }
            catch (Exception)
            {
                return null;
            }
        }//return rubric<Rubric> or null




        //+CreateRubricAsync(rubric : Rubric) : Domain.Entites.Rubric
        public async Task<Rubric> CreateRubricAsync(Rubric newRubric)
        {
            try
            {
                Rubric rubric = await _dbContext.Rubrics.CreateAsync(newRubric);
                return rubric;
            }
            catch (Exception)
            {

                return null;

            }
        }//return rubric<Rubric> or null



        //+ModifyRubricAsync(id : int, rubric : Domain.Entites.Rubric) : Domain.Entites.Rubric
        public async Task<Rubric> ModifyRubricAsync(int id, Rubric modifiedRubric)
        {
            try
            {
                Rubric updateRubric = await _dbContext.Rubrics.UpdateAsync(modifiedRubric);
                return updateRubric;
            }
            catch (Exception)
            {
                return null;
            }
        }//return updateRubric<Rubric> or null



        //+DeleteRubricAsync(Id : int) : Domain.Entites.Rubric
        public async Task<bool> DeleteRubricAsync(int id)
        {
            bool success = await _dbContext.Rubrics.DeleteAsync(id);
            return success;
        }

        //To work with view RUBRICS_DETAIL
        public async Task<IEnumerable<RubricDetail>> DetailRubricsAsync()
        {

            IEnumerable<RubricDetail> rubricsDetails = await _dbContext.Rubrics.DetailAsync();
            foreach (RubricDetail rubricDetail in rubricsDetails)
            {
                if (rubricDetail.Topic_Deleted == true)
                {
                    rubricDetail.Topic_Tex_Pub = "Topic is deleted by admin";
                    rubricDetail.Topic_Title = "Topic is deleted by admin";
                }
            }
            return rubricsDetails;
        }


        public async Task<IEnumerable<RubricDetail>> DetailRubricByIdAsync(int id)
        {
            var rubric = await _dbContext.Rubrics.GetByIdAsync(id);
            if (rubric == null) throw new NotFoundException();


            IEnumerable<RubricDetail> rubricsDetails = await _dbContext.Rubrics.DetailByIdAsync(id);


            //no need verify because deleted topic is filtered in view of DB

            //foreach (RubricDetail rubricDetail in rubricsDetails)
            //{
            //    if (rubricDetail.Topic_Deleted == true)
            //    {
            //        rubricDetail.Topic_Tex_Pub = "Topic is deleted by admin";
            //        rubricDetail.Topic_Title = "Topic is deleted by admin";
            //    }
            //}

            return rubricsDetails;

        }//return RubricDetails<RubricDetail> 





        #endregion

        #region Topic
        //+GetTopicsAsync() : IEnumerable<Domain.Entites.Topic>
        public async Task<IEnumerable<Topic>> GetTopicsAsync()
        {
            return await _dbContext.Topics.GetAllAsync();
        }



        //+GetTopicsByRubricIdAsync(rubricId : int) : IEnumerable<Domain.Entites.Topic>
        public async Task<IEnumerable<Topic>> GetTopicsByRubricIdAsync(int rubricId)
        {
            return await _dbContext.Topics.GetAllByRubricIdAsync(rubricId);
        }




        //+GetTopicByIdAsync(Id : int) : Domain.Entites.Topic
        public async Task<Topic> GetTopicByIdAsync(int id)
        {
            return await _dbContext.Topics.GetByIdAsync(id);
        }

        //+CreateTopicAsync(topic : Domain.Entites.Topic) : Domain.Entites.Topic
        public async Task<Topic> CreateTopicAsync(Topic newTopic)
        {
            try
            {
                Topic topic = await _dbContext.Topics.CreateAsync(newTopic);
                return topic;
            }
            catch (InsertSQLFailureException ex)
            {
                return null;
            }
        }

        //+ModifyTopicAsync(Id : int, topic : Domain.Entites.Topic) : Domain.Entites.Topic
        public async Task<Topic> ModifyTopicAsync(int id, Topic updateTopic)
        {
            try
            {
                Topic updatedTopic = await _dbContext.Topics.UpdateAsync(updateTopic);
                return updatedTopic;
            }
            catch (UpdateSQLFailureException ex)
            {
                return null;
            }
        }

        //+DeleteTopicAsync() : Domain.Entites.Topic
        public async Task<bool> DeleteTopicAsync(int id)
        {


            _dbContext.BeginTransaction();  // ***********??*************** //

            var getAllRepliesByTopicId = await _dbContext.Replies.GetAllByTopicIdAsync(id);
           
            if (getAllRepliesByTopicId != null)
            {

                foreach (Reply reply in getAllRepliesByTopicId)
                {
                    var replyIsDeleted = await _dbContext.Replies.DeleteAsync(reply.Id);
                    if (!replyIsDeleted)
                    {
                        _dbContext.RollBack(); //  Rollback();
                        throw new UpdateSQLFailureException();
                    }
                }
            }

            bool success = await _dbContext.Topics.DeleteAsync(id);

            if (success)
            {
                _dbContext.Commit();
                return true;
            }
            else
            {
                _dbContext.RollBack();

                return false;
            }


        }



        //To work with view TOPIC_DETAIL
        //this method is not useful
        public async Task<IEnumerable<TopicDetail>> DetailTopicsAsync()
        {
            IEnumerable<TopicDetail> topicsDetails = await _dbContext.Topics.DetailAsync();
            return topicsDetails;
        }//return topicDetails<TopicDetail>





        ////To work with view TOPIC_DETAIL
        public async Task<IEnumerable<TopicDetail>> DetailTopicByIdAsync(int id)
        {
            IEnumerable<TopicDetail> topicDetails = await _dbContext.Topics.DetailByIdAsync(id);

            if (topicDetails == null)
            {
                throw new NotFoundException();
            }

            foreach (TopicDetail topicDetail in topicDetails)
            {
                if (topicDetail.Child_Reply_Deleted == true) //(rubricDetail.Topic_Delete == true)
                {
                    topicDetail.Child_Reply_Text = "Reply is deleted by admin";
                }

                if (topicDetail.Parent_Reply_Deleted == true) //(rubricDetail.Topic_Delete == true)
                {
                    topicDetail.Parent_Reply_Text = "Reply is deleted by admin";
                }
            }
            return topicDetails;
        }//return topicDetails<TopicDetail> 



        #endregion

        #region Reply
        //+GetRepliesAsync() : Enumerable<Domain.Entites.Reply>
        public async Task<IEnumerable<Reply>> GetRepliesAsync()
        {
            IEnumerable<Reply> replies = await _dbContext.Replies.GetAllAsync();
            // if reply not found throw exception
            if (replies == null) throw new NotFoundException();

            foreach (var reply in replies)
            {
                if (reply.Deleted == true)
                {
                    reply.Text = "Inappropriate message deleted by admin";
                }
            }
            return replies;
        }//return reply<Reply> 



        //+GetRepliesByTopicIdAsync(topicId : int) : Domain.Entites.Reply
        public async Task<IEnumerable<Reply>> GetRepliesByTopicIdAsync(int topicId)
        {
            //var topic = await _dbContext.Topics.GetByIdAsync(topicId);
            //// if topic not found throw exception
            //if (topic == null) throw new NotFoundException();

            //GetByIdAsync(int id)
            //
            IEnumerable<Reply> replies = await _dbContext.Replies.GetAllByTopicIdAsync(topicId);
            // if replies not found throw exception
            if (replies == null) throw new NotFoundException();

            foreach (var reply in replies)
            {
                if (reply.Deleted == true)
                {
                    reply.Text = "Inappropriate message deleted by admin";
                }
            }

            return replies;

        }//return reply<Reply> 






        //+GetReplyByIdAsync() : Domain.Entites.Reply
        public async Task<Reply> GetReplyByIdAsync(int id)
        {
            Reply reply = await _dbContext.Replies.GetByIdAsync(id);
            // if reply not found throw exception
            if (reply == null) throw new NotFoundException();

            if (reply.Deleted == true) reply.Text = "Reply(inappropriate) deleted by admin";

            return reply;

        }//return reply<Reply> 



        //+CreateReplyAsync(reply : Reply) : Domain.Entites.Reply
        public async Task<Reply> CreateReplyAsync(Reply newReply)
        {
            try
            {
                Reply reply = await _dbContext.Replies.CreateAsync(newReply);
                //if (reply == null) throw new InsertSQLFailureException("Create User Failure");
                return reply;
            }
            catch (InsertSQLFailureException ex)
            {
                return null;
            }
        }//return modifiedreply<Reply> or null




        //+ModifyReplyAsync(iId : int, reply : Domain.Entites.Reply) : Domain.Entites.Reply
        public async Task<Reply> ModifyReplyAsync(Reply modifyreply)
        {
            try
            {
                Reply modifiedreply = await _dbContext.Replies.UpdateAsync(modifyreply);

                return modifiedreply;

            }
            catch (InsertSQLFailureException ex)
            {
                return null;
            }
        }//return modifiedreply<Reply> or null




        //+DeleteReplyAsync() : Domain.Entites.Reply
        public async Task<bool> DeleteReplyAsync(int id)
        {
            //Before delete we check if reply exist
            Reply reply = await _dbContext.Replies.GetByIdAsync(id);
            // if reply to delete not exist throw exception
            if (reply == null) throw new NotFoundException();

            bool success = await _dbContext.Replies.DeleteAsync(id);
            return success;

        }  //return bool true or false
        #endregion
    }
}
