using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Projekt_Bencek
{
    public class DigitalniPotpis
    {
        
        public void KreirajPotpis(byte[] sazetak)
        {
            DSACryptoServiceProvider dsa = new DSACryptoServiceProvider();
            
            byte[] hash = sazetak;
            DSASignatureFormatter dsaFommater = new DSASignatureFormatter(dsa);
            dsaFommater.SetHashAlgorithm("SHA1");
            byte[] signedHash = dsaFommater.CreateSignature(hash);


            Datoteka datoteka = new Datoteka();
            string potpisstring = Convert.ToBase64String(signedHash);
            datoteka.KreirajDatoteku("digitalni_potpis.txt", potpisstring);

            var pubKey= dsa.ExportParameters(false);
            string pubKeyString;
            {
                var sw = new StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(DSAParameters));
                xs.Serialize(sw, pubKey);
                pubKeyString = sw.ToString();
            }
            datoteka.KreirajDatoteku("javni_kljuc_potpisa.txt", pubKeyString);

            var privKey = dsa.ExportParameters(true);
            string privKeyString;
            {
                var sw = new StringWriter();
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(DSAParameters));
                xs.Serialize(sw, privKey);
                privKeyString = sw.ToString();
            }
            datoteka.KreirajDatoteku("privatni_kljuc_potpisa.txt", privKeyString);

        }

        public string ProvjeriPotpis(byte[] hash, string signedHash, string kljuc)
        {
            var sr = new System.IO.StringReader(kljuc);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(DSAParameters));
            var pubKey = (DSAParameters)xs.Deserialize(sr);

            var dsa = new DSACryptoServiceProvider();
            dsa.ImportParameters(pubKey);


            byte[] signedHashValue = Convert.FromBase64String(signedHash);
            DSASignatureDeformatter dsaDeformatter = new DSASignatureDeformatter(dsa);



            if (dsaDeformatter.VerifySignature(hash, signedHashValue))
            {
                return "Potpis je validan!";
            }
            else
            {
                return "Potpis nije validan!";
            }
        }
    }
}
