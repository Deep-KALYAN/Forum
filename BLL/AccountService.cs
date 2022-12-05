using DAL.UOW;
using Domain.Entites;
using Domain.Exceptions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//For Cryptography
using System.IO;
using System.Text;
using System.Security.Cryptography;


namespace BLL
{
    class AccountService : IAccountService
    {
        private readonly IUnitOfWork _dbContext;

        public AccountService(IUnitOfWork dbContext)
        {
            _dbContext = dbContext;
        }

        #region User
        //+GetUsersAsync() : IEnumerable
        /* not necessary ***/
        public async Task<IEnumerable<_User>> GetUsersAsync()
        {
            IEnumerable<_User> users = await _dbContext.Users.GetAllAsync();
            if (users == null) throw new NotFoundException();
            return users;
        }

        //+GetUserByIdAsync(Id : int) : Domain.Entites._User
        public async Task<_User> GetUserByIdAsync(int id)
        {
            _User user = await _dbContext.Users.GetByIdAsync(id);
            if (user == null) throw new NotFoundException();
            return user;
        }


        public async Task<_User> GetUserByloginNameAsync(string loginname)
        {
                _User user = await _dbContext.Users.GetUserBylogin_NameAsync(loginname);

            if (user == null) throw new NotFoundException();

            return user;
           
        }




        //esult = shaM. .ComputeHash(data);
        //+CreateUserAsync() : Domain.Entites._User
        public async Task<_User> CreateUserAsync(_User newUser)
        {
            string loginname = newUser.Nick_Name;

            _User user = await _dbContext.Users.GetUserBylogin_NameAsync(loginname);

            if (user != null) throw new InsertSQLFailureException(user.Name + "Login name exist already");

            try
            {
                string newPassword = Encrypt(newUser.Password);
                newUser.Password = newPassword;                
                return await _dbContext.Users.CreateAsync(newUser);

            }
            catch (InsertSQLFailureException ex)
            {
                return null;
            }
        }


        #region Cryptography SHA512

        public static string Encrypt(string password)
        {
            string encPassword;

            var data = Encoding.UTF8.GetBytes(password);
            using (SHA512 shaM = new SHA512Managed())
            {

                byte[] encryptPassword = shaM.ComputeHash(data);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in encryptPassword)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                encPassword = hashedInputStringBuilder.ToString();

            }
            return encPassword;
        }


        #endregion        

        //+ModifyUserAsync(Id : int, user : Domain.Entites._User) : Domain.Entites._User
        public async Task<_User> ModifyUserAsync(_User modifyUser)
        {

            //string loginname = modifyUser.Nick_Name;

            //_User user = await _dbContext.Users.GetUserBylogin_NameAsync(loginname);

            //if (user == null) throw new InsertSQLFailureException(user.Name + "Login name exist already");
            



            try
            {
                string newPassword = Encrypt(modifyUser.Password);
                modifyUser.Password = newPassword;
                
                _User updatedUser = await _dbContext.Users.UpdateAsync(modifyUser);
                return updatedUser;
            }
            catch (UpdateSQLFailureException ex)
            {
                //An error occurred while processing your request Try to use different Nick name
                return null;
            }

        }

        //+DeleteUserAsync(Id : int) : Domain.Entites._User
        public async Task<bool> DeleteUserAsync(int id)
        {
           
                bool success = await _dbContext.Users.DeleteAsync(id);
                return success;

        }
        #endregion


        #region  chiffrement
        
        //Cryptography et chiffrement 
        //https://stackoverflow.com/questions/10168240/encrypting-decrypting-a-string-in-c-sharp
        //public static class EncryptionHelper
        //{
        public static string Encryp(string clearText)
        {
            string EncryptionKey = "abc123";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }


        public static string Decrypt(string cipherText)
        {
            string EncryptionKey = "abc123";
            cipherText = cipherText.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        //}
        #endregion 
    }

}
