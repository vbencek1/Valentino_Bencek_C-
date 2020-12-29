using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Projekt_Bencek
{
    public class AesAlgoritam
    {
        public string Encryptxx(string text, string kljuc)
        {

            byte[] src = Encoding.UTF8.GetBytes(text);
            byte[] key = Encoding.ASCII.GetBytes(kljuc);
            RijndaelManaged aes = new RijndaelManaged();
            aes.Mode = CipherMode.ECB;
            aes.Padding = PaddingMode.PKCS7;
            aes.KeySize = 128;

            using (ICryptoTransform encrypt = aes.CreateEncryptor(key, null))
            {
                byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                encrypt.Dispose();
                return Convert.ToBase64String(dest);
            }
        }

        public string Decryptxx(string text, string kljuc)
        {

            byte[] src = Convert.FromBase64String(text);
            RijndaelManaged aes = new RijndaelManaged();
            byte[] key = Encoding.ASCII.GetBytes(kljuc);
            aes.KeySize = 128;
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.ECB;
            using (ICryptoTransform decrypt = aes.CreateDecryptor(key, null))
            {
                byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                decrypt.Dispose();
                return Encoding.UTF8.GetString(dest);
            }
        }
    }
}
