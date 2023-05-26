using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FiyatBu
{
    public class Encryption
    {
        public string Encrypt(string query)
        {
            const int iterations = 3;
            query = String.Concat(query, query, query);
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(query);
            byte[] hashBytes = md5.ComputeHash(inputBytes);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                stringBuilder.Append(hashBytes[i].ToString("x2"));
            }
            string encryptedQuery = stringBuilder.ToString();
            for (int iteration = 1; iteration < iterations; iteration++)
            {
                hashBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(encryptedQuery));
                stringBuilder.Clear();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                encryptedQuery = stringBuilder.ToString();
            }

            return encryptedQuery;

        }
    }
}
