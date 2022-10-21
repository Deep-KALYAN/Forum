using Dapper;
using Domain.Entites;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UOW.Repositories
{
    class TopicRepository : ITopicRepository
    {
        private readonly IDBSession _db;
        public TopicRepository(IDBSession db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Topic>> GetAllAsync()
        {
            string query = @"Select * from TOPIC WHERE DELETED = 0";
            IEnumerable<Topic> topics = await _db.Connection.QueryAsync<Topic>(query, transaction: _db.Transaction);
            return topics;
        }

        /** special **/
        public async Task<IEnumerable<Topic>> GetAllByRubricIdAsync(int rubricId)
        {
            string query = "SELECT * FROM TOPIC WHERE ID_RUBRIC = @Id_Rubric AND DELETED = 0";
            IEnumerable<Topic> topics = await _db.Connection.QueryAsync<Topic>(query, new { Id_Rubric = rubricId }, transaction: _db.Transaction);
            return topics;
        }

        public async Task<Topic> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM TOPIC WHERE ID = @Id AND DELETED = 0";
            Topic topic = await _db.Connection.QueryFirstOrDefaultAsync<Topic>(query, new { Id = id }, transaction: _db.Transaction);
            return topic;
        }

        public async Task<Topic> CreateAsync(Topic topic)
        {
            string query = @"INSERT INTO TOPIC (TITLE,TEXT_PUB,PUB_DATE,DELETED,ID_USER,ID_RUBRIC)
                            OUTPUT INSERTED.ID
                            VALUES (@TITLE,@TEXT_PUB,GETDATE(),0,@ID_USER,@ID_RUBRIC)";



            int? idInserted = await _db.Connection.ExecuteScalarAsync<int?>(query, new
                {
                    TITLE = topic.Title,
                    TEXT_PUB = topic.Text_Pub,
                  //  PUB_DATE = topic.Pub_Date,
                  //  DELETED = topic.Deleted,
                    ID_USER = topic.Id_User,
                    ID_RUBRIC = topic.Id_Rubric

                }, transaction: _db.Transaction);

            if (!idInserted.HasValue) throw new InsertSQLFailureException(topic);
            topic.Id = idInserted.GetValueOrDefault();
            return topic;
        }




        public async Task<Topic> UpdateAsync(Topic topic)
        {
            string query = @"UPDATE TOPIC SET 
                TITLE      = @TITLE    ,
                TEXT_PUB   = @TEXT_PUB ,
                UPDATE_DATE   = GETDATE() 
              
                             
                WHERE ID   = (@ID)";

            int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new
                {
                    ID = topic.Id,
                    TITLE = topic.Title,
                    TEXT_PUB = topic.Text_Pub,
                   // UPDATE_DATE = topic.Pub_Update_Date,
                   // DELETED = 0,
                    //ID_USER = topic.Id_User,
                    //ID_RUBRIC = topic.Id_Rubric,

                }, transaction: _db.Transaction);

          

            if (nbLigneAffected != 1) throw new UpdateSQLFailureException(topic);

            return await GetByIdAsync(topic.Id);
        }

        public async Task<bool> DeleteAsync(int id)
        {

            string query = @"UPDATE TOPIC SET                
                DELETED  = 1,
                UPDATE_DATE = GETDATE() 
                WHERE ID = @Id";

            int nbLigneTF = await _db.Connection.ExecuteAsync(query, new
                {
                 //   DELETED = 1,
                    Id = id,

                }, transaction: _db.Transaction);

 

            //string query = "DELETE FROM TOPIC WHERE ID = @Id";
            //int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new { Id = id }, transaction: _db.Transaction);

            return nbLigneTF == 1;
        }



        // To work with view TOPIC_DETAIL        //normally* We don't need this
        public async Task<IEnumerable<TopicDetail>> DetailAsync()
        {
            string query = @"Select * from TOPIC_DETAIL";
            IEnumerable<TopicDetail> topicsDetail = await _db.Connection.QueryAsync<TopicDetail>(query, transaction: _db.Transaction);
            return topicsDetail;
        }

        // To work with view RUBRICS_DETAIL
        public async Task<IEnumerable<TopicDetail>> DetailByIdAsync(int id)
        {
            string query = "SELECT * FROM TOPIC_DETAIL WHERE ID = @Id";

            string queryCount = @"UPDATE TOPIC SET      COUNT_VIEWS   = @Count_Views          WHERE ID = @Id";

           

           

                
                // Here we can handel the counting of views

                // Search the topic
                Topic topicViews = await GetByIdAsync(id);
                if (topicViews == null) throw new NotFoundException("The Topic doest not exist (or deleted)");
                // Handel the null values
                int? views = topicViews.Count_Views;
                int viewsPlusOne;
                
                // Increment + 1
                if (views == null)
                {
                    viewsPlusOne = 1;
                }
                else
                {
                    viewsPlusOne = (int)views + 1;
                }
                
                // Update in DB
                int nbLigneTF = await _db.Connection.ExecuteAsync(queryCount, new
                {
                    Count_Views = viewsPlusOne,
                    Id = id,

                }, transaction: _db.Transaction);

            IEnumerable<TopicDetail> topicDetail = await _db.Connection.QueryAsync<TopicDetail>(query, new { Id = id }, transaction: _db.Transaction);
           

            return topicDetail;
        }
    }
}
