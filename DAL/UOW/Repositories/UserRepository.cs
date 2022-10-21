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
    class UserRepository : IUserRepository
    {
        private readonly IDBSession _db;
        public UserRepository(IDBSession db)
        {
            _db = db;
        }

        public async Task<IEnumerable<_User>> GetAllAsync()
        {
            string query = @"Select * from _USER";
            IEnumerable<_User> users;

            try
            {
                users = await _db.Connection.QueryAsync<_User>(query, transaction: _db.Transaction);
            }
            catch (Exception ex)
            {
                throw new NotFoundException();
            }

            return users;
        }

        public async Task<_User> GetByIdAsync(int id)
        {
            string query = "SELECT * FROM _USER WHERE ID = @Id";

            try
            {
                _User user = await _db.Connection.QueryFirstOrDefaultAsync<_User>(query, new { Id = id }, transaction: _db.Transaction);
                return user;

            }
            catch (Exception ex)
            {

                return null;
            }
        }




        // To check the token
        public async Task<_User> GetUserBylogin_NameAsync(string loginname)
        {
            string query = "SELECT * FROM _USER WHERE NICK_NAME = @LoginName";

            try
            {
                _User user = await _db.Connection.QueryFirstOrDefaultAsync<_User>(query, new { LoginName = loginname }, transaction: _db.Transaction);
                return user;

            }
            catch (Exception)
            {

                throw new NotFoundException();
            }
        }


        public async Task<_User> CreateAsync(_User user)
        {
            string query = @"INSERT INTO _USER (NAME,FIRST_NAME,NICK_NAME,PH_NO,PHOTO,E_MAIL,MODERATOR_Y_N,PASSWORD)
                            OUTPUT INSERTED.ID
                            VALUES (@NAME,@FIRST_NAME,@NICK_NAME,@PH_NO,NULL,@E_MAIL,0,@PASSWORD)";
            int? idInserted = await _db.Connection.ExecuteScalarAsync<int?>(query, new
            {
                NAME = user.Name,
                FIRST_NAME = user.First_Name,
                NICK_NAME = user.Nick_Name,
                PH_NO = user.Ph_No,
                // PHOTO = user.Photo,
                E_MAIL = user.E_Mail,
                //  MODERATOR_Y_N = 0,
                PASSWORD = user.Password
            }, transaction: _db.Transaction);

            if (!idInserted.HasValue) throw new InsertSQLFailureException(user);
            user.Id = idInserted.GetValueOrDefault();
            return user;
        }

        public async Task<_User> UpdateAsync(_User user)
        {
            string query = @"UPDATE _USER SET 
                NAME = @Name,
                FIRST_NAME = @First_Name,
                NICK_NAME = @Nick_Name,
                PH_NO = @Ph_No,
                PHOTO = NULL,
                E_MAIL = @E_Mail,
                PASSWORD = @PASSWORD
                WHERE ID = @Id";

            try
            {


                int nbLigneAffected = await _db.Connection.ExecuteAsync(query, new
                {
                    Name = user.Name,
                    First_Name = user.First_Name,
                    Nick_Name = user.Nick_Name,
                    Ph_No = user.Ph_No,
                    // PHOTO = user.Photo,
                    E_Mail = user.E_Mail,
                    PASSWORD = user.Password,
                    Id = user.Id
                }, transaction: _db.Transaction);

            }
            catch (Exception ex)
            {

                throw new UpdateSQLFailureException();
            }


            //  if (nbLigneAffected != 1) throw new UpdateSQLFailureException(user);

            return await GetByIdAsync(user.Id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            string query = "DELETE FROM _USER WHERE ID = @Id";

            int nbLigneAffected;
            try
            {
                nbLigneAffected = await _db.Connection.ExecuteAsync(query, new { Id = id }, transaction: _db.Transaction);

            }
            catch (Exception)
            {

                throw new UpdateSQLFailureException();
            }

            return nbLigneAffected == 1;
        }




    }
}
