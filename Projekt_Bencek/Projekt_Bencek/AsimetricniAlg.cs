using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Projekt_Bencek
{
    public class AsimetricniAlg
    {
        private static RSAParameters privKey;
        private static RSAParameters pubKey;
        public void GenerirajKljuceve()
        {
            using (var csp = new RSACryptoServiceProvider(2048))
            {
                privKey = csp.ExportParameters(true);
                pubKey = csp.ExportParameters(false);
            }
        

            Datoteka datoteka = new Datoteka();
            string pubKeyString;
            {
                var sw = new StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, pubKey);
                pubKeyString = sw.ToString();
            }
            string privKeyString;
            {
                var sw = new StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                xs.Serialize(sw, privKey);
                privKeyString = sw.ToString();
            }
            datoteka.KreirajDatoteku("javni_kljuc.txt", pubKeyString);
            datoteka.KreirajDatoteku("privatni_kljuc.txt", privKeyString);
        }

        public string Kriptiraj(string javniKljuc, string tekst)
        {
           
                var sr = new System.IO.StringReader(javniKljuc);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                var pubKey = (RSAParameters)xs.Deserialize(sr);
            

            var csp = new RSACryptoServiceProvider();
            csp.ImportParameters(pubKey);

            byte[] bytesPlainTextData = Encoding.Unicode.GetBytes(tekst);

            var bytesCypherText = csp.Encrypt(bytesPlainTextData, false);

            string cypherText = Convert.ToBase64String(bytesCypherText);
            return cypherText;
        }

        public string Dekriptiraj(string privatniKljuc, string tekst)
        {
            
                var sr = new System.IO.StringReader(privatniKljuc);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                var privKey = (RSAParameters)xs.Deserialize(sr);

            var csp = new RSACryptoServiceProvider();
            csp.ImportParameters(privKey);
            byte[] bytesCypherText = Convert.FromBase64String(tekst);
            byte[] bytesPlainTextData = csp.Decrypt(bytesCypherText, false);
            string plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);
            return plainTextData;

        }
    }
}
