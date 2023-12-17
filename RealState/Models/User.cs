using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RealState.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public User(string userName, string userPassword)
        {
            UserName = userName;
            PasswordHash = CalculatePasswordHash(userPassword);
        }

        private string CalculatePasswordHash(string password)
        {
            //Create a byte array from source data.
            byte[] tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
            
            //Compute hash based on source data.
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

            return Convert.ToBase64String(tmpHash);
        }
    }
}
