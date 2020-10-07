using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Password
    {
        public static string getPassword(string dni, string pass)
        {
            HashAlgorithm hash = new SHA512Managed();
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(dni + pass);
            byte[] hashBytes = hash.ComputeHash(plainTextBytes);
            return Convert.ToBase64String(hashBytes);
        }
        
    }
}
