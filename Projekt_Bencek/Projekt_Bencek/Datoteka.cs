using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Projekt_Bencek
{
    public  class Datoteka
    {
        public void KreirajDatoteku(string nazivDatoteke, string textDatoteke)
        {
            string filePath = @"C:\Users\Tino\Downloads\Desktop\Valentino_Bencek_C#\"+nazivDatoteke;

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (FileStream fs = File.Create(filePath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(textDatoteke);
                fs.Write(info, 0, info.Length);
            }

        }
        public string ProcitajDatoteku(string nazivDatoteke)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Tino\Downloads\Desktop\Valentino_Bencek_C#\" + nazivDatoteke);
            return text;
        }
    }
}
