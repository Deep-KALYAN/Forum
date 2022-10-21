using Dapper;
using Domain.Entites;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UOW.Repositories
{
    class RubricRepository : IRubricRepository
    {
        private readonly IDBSession _db;
        public RubricRepository(IDBSession db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Rubric>> GetAllAsync()
        {
            string query = @"Select * from RUBRIC";
            IEnumerable<Rubric> rubrics = await _db.Connection.QueryAsync<Rubric>(query, transaction: _db.Transaction);
            return rubrics;
        }

        public async Task<Rubric> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM RUBRIC WHERE ID = @Id";
            Rubric rubric = await _db.Connection.QueryFirstOrDefaultAsync<Rubric>(query, new { Id = id }, transaction: _db.Transaction);
            // If rubric not found QueryFirstOrDefaultAsync will send null
            return rubric;
        }

        public async Task<Rubric> CreateAsync(Rubric rubric)
        {
            string query = @"INSERT INTO RUBRIC (NAME)
                            OUTPUT INSERTED.ID
                            VALUES (@NAME)";
            int? idInserted = await _db.Connection.ExecuteScalarAsync<int?>(query, new
            {
                NAME = rubric.Name,
            }, transaction: _db.Transaction);

            if (!idInserted.HasValue) throw new InsertSQLFailureException(rubric);
            rubric.Id = idInserted.GetValueOrDefault();
            return rubric;
        }

        public async Task<Rubric> UpdateAsync(Rubric rubric)
        {
            string query = @"UPDATE RUBRIC SET 
                NAME = @Name,                
                WHERE ID = @Id";

            int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new
            {
                NAME = rubric.Name,
                ID = rubric.Id

            }, transaction: _db.Transaction);

            if (nbLigneAffected != 1) throw new UpdateSQLFailureException(rubric);

            return await GetByIdAsync(rubric.Id);
        }


        //
        public async Task<bool> DeleteAsync(int id)
        {
            string query = "DELETE FROM RUBRIC WHERE ID = @Id";
            int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new { Id = id }, transaction: _db.Transaction);

            return nbLigneAffected == 1;
        }


        // To work with view RUBRICS_DETAIL
        // Dapper

        public async Task<IEnumerable<RubricDetail>> DetailAsync()
        {
            string query = @"Select * from RUBRICS_DETAIL";
            IEnumerable<RubricDetail> rubricsDetail = await _db.Connection.QueryAsync<RubricDetail>(query, transaction: _db.Transaction);
            return rubricsDetail;
        }

        #region      without dapper
        //public async Task<IEnumerable<RubricDetail>> DetailAsync()
        //{
        //    string query = @"Select * from RUBRICS_DETAIL";
        //    SqlCommand command = new SqlCommand(query, (SqlConnection)_db.Connection);
        //    List<RubricDetail> rubricDetails = new List<RubricDetail>();



        //        using (SqlDataReader reader = await command.ExecuteReaderAsync())                
        //        {                
        //        while (reader.Read())
        //        {
        //            try
        //            {


        //                //read column
        //                RubricDetail rubDetail = new RubricDetail()
        //            {
        //                Id = reader.GetInt32(0),
        //                //NomAuteur = reader.GetString(1),
        //                //DateDeCreation = reader.GetDateTime(2),
        //                Rubric_Name            = reader.GetString(1),
        //                Topic_Id               = reader.GetInt32(2),
        //                Topic_Delete           = reader.GetBoolean(3),
        //                Topic_Tex_Pub          = reader.GetString(4),
        //                Topic_Pub_Date         = reader.GetDateTime(5),
        //                Topic_Title            = reader.GetString(6),
        //                T_Creator_Id           = reader.GetInt32(7),
        //                T_Creator_Nick_Name    = reader.GetString(8),
        //            };
        //            rubricDetails.Add(rubDetail);


        //            }
        //            catch (Exception ex)
        //            {

        //                throw ex;
        //            }
        //        }


        //        return rubricDetails;
        //    }





        //}
        #endregion
        // To work with view RUBRICS_DETAIL
        public async Task<IEnumerable<RubricDetail>> DetailByIdAsync(int id)
        {
             
            string query = "SELECT * FROM RUBRICS_DETAIL WHERE ID = @Id";

            IEnumerable<RubricDetail> rubricDetail = await _db.Connection.QueryAsync<RubricDetail>(query, new { Id = id }, transaction: _db.Transaction);
           
           return rubricDetail;
        }

        

    }
}
