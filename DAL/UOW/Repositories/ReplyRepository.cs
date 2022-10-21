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
    class ReplyRepository : IReplyRepository
    {
        private readonly IDBSession _db;
        public ReplyRepository(IDBSession db)
        {
            _db = db;
        }


        public async Task<IEnumerable<Reply>> GetAllAsync()
        {
            string query = @"Select * from REPLY";
            IEnumerable<Reply> replies = await _db.Connection.QueryAsync<Reply>(query, transaction: _db.Transaction);
            return replies;
        }

        /** special **/
        public async Task<IEnumerable<Reply>> GetAllByTopicIdAsync(int topicId)
        {
            //In BLL already checked if topic exist then possible to come here

            string query = "SELECT * FROM REPLY  WHERE ID_TOPIC = @Id_Topic";

            //I think need to check if there is at least 1 reply in topic

            IEnumerable<Reply> replies = await _db.Connection.QueryAsync<Reply>(query, new { Id_Topic = topicId }, transaction: _db.Transaction);
            
            return replies;
        }



        public async Task<Reply> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM REPLY WHERE ID = @Id";
            Reply   reply = await _db.Connection.QueryFirstOrDefaultAsync<Reply>(query, new { Id = id }, transaction: _db.Transaction);
            // If reply not found QueryFirstOrDefaultAsync will send null
            return reply;
        }

        public async Task<Reply> CreateAsync(Reply reply)
        {
            string query = @"INSERT INTO REPLY (TEXT, REPLY_DATE, DELETED, ID_PARENT_REPLY, ID_USER,ID_TOPIC)
                            OUTPUT INSERTED.ID
                            VALUES (@TEXT,GETDATE(),0,@ID_PARENT_REPLY,@ID_USER,@ID_TOPIC)";

           

            int? idInserted = await _db.Connection.ExecuteScalarAsync<int?>(query, new
                {
                    TEXT = reply.Text,                   
                    ID_PARENT_REPLY = reply.Id_Parent_Reply,
                    ID_USER = reply.Id_User,
                    ID_TOPIC = reply.Id_Topic

                }, transaction: _db.Transaction);

            
            if (!idInserted.HasValue) throw new InsertSQLFailureException(reply);
            reply.Id = idInserted.GetValueOrDefault();
            return reply;
        }

        public async Task<Reply> UpdateAsync(Reply reply)
        {
            string query = @"UPDATE REPLY SET 
                TEXT            = @TEXT, 
                UPDATE_DATE     = GETDATE()
                WHERE ID        = @ID";

            
              int  nbLigneAffected = await _db.Connection.ExecuteAsync(query, new
                {
                    TEXT = reply.Text,
                    ID = reply.Id

                }, transaction: _db.Transaction);

            if (nbLigneAffected != 1) throw new UpdateSQLFailureException(reply);

            return await GetByIdAsync(reply.Id); //return reply or null
        }

        public async Task<bool> DeleteAsync(int id)
        {
            //In bll already checked if reply exist
            string query = @"UPDATE REPLY SET
                DELETED = @DELETED 
                WHERE ID = @Id";
            
            int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new

                {
                    DELETED = 1,
                    ID = id
                }, transaction: _db.Transaction);

            // To DELETE REALLY FROM DB
            //string query = "DELETE FROM REPLY WHERE ID = @Id";
            //int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new { Id = id }, transaction: _db.Transaction);
           
            return nbLigneAffected == 1; //return true or false
        }

    }
}
