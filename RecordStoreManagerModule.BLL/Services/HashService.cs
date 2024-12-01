using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RecordStoreManagerModule.BLL.Services
{
    public class HashService : IHashService
    {
        public string GetHashCode(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }

        }
    }
}
