using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Projekt_Bencek
{
    public class Sazetak
    {
        private SHA1 Sha1 = SHA1.Create();
        public byte[] GetHashSha(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha1.ComputeHash(stream);
            }
        }
        public  string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }
    }
}
