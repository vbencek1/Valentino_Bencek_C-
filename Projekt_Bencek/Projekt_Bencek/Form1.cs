using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Projekt_Bencek
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GumbUnosaTeksta_Click(object sender, EventArgs e)
        {
            Datoteka datoteka = new Datoteka();
            datoteka.KreirajDatoteku("Datoteka.txt", UnosTeksta.Text.ToString());
            MessageBox.Show("Datoteka je kreirana!");
        }

        private void GumbObrisi_Click(object sender, EventArgs e)
        {
            UnosTeksta.Clear();
        }

        private void GumbKriptiranja_Click(object sender, EventArgs e)
        {
            string kljuc = UnosAesKljuca.Text.ToString();
            if(kljuc.Length ==16 || kljuc.Length == 32)
            {
                Datoteka datoteka = new Datoteka();
                AesAlgoritam aes = new AesAlgoritam();
                datoteka.KreirajDatoteku("tajni_kljuc.txt", kljuc);
                datoteka.KreirajDatoteku("KriptiranaDatotekaAES.txt", aes.Encryptxx(datoteka.ProcitajDatoteku("Datoteka.txt").ToString(), kljuc));
                IspisDatoteke.Text = datoteka.ProcitajDatoteku("KriptiranaDatotekaAES.txt").ToString();
            }
            else{
                MessageBox.Show("Kljuc nije ispravne duljine!");
            }
            UnosAesKljuca.Clear();
        }

        private void GumbDekriptiranja_Click(object sender, EventArgs e)
        {
            string kljuc = UnosIspravnogKljuca.Text.ToString();
            if (kljuc.Length == 16 || kljuc.Length == 32)
            {
                Datoteka datoteka = new Datoteka();
            AesAlgoritam aes = new AesAlgoritam();
            
            datoteka.KreirajDatoteku("DekriptiranaDatotekaAES.txt", aes.Decryptxx(datoteka.ProcitajDatoteku("KriptiranaDatotekaAES.txt").ToString(), kljuc));
            IspisDatoteke.Text = datoteka.ProcitajDatoteku("DekriptiranaDatotekaAES.txt").ToString();
            }
            else
            {
                MessageBox.Show("Kljuc nije ispravne duljine!");
            }
            UnosAesKljuca.Clear();
        }

        private void GumbGenerirajKljuceve_Click(object sender, EventArgs e)
        {
            AsimetricniAlg asimetricniAlg = new AsimetricniAlg();
            asimetricniAlg.GenerirajKljuceve();
        }

        private void GumbKriptirajAsimetricno_Click(object sender, EventArgs e)
        {
            AsimetricniAlg asimetricniAlg = new AsimetricniAlg();
            Datoteka datoteka = new Datoteka();
            
            datoteka.KreirajDatoteku("KriptiranaDatotekaRSA.txt",asimetricniAlg.Kriptiraj(datoteka.ProcitajDatoteku("javni_kljuc.txt"), datoteka.ProcitajDatoteku("Datoteka.txt")));
            IspisDatAsimetricno.Text = datoteka.ProcitajDatoteku("KriptiranaDatotekaRSA.txt");
            
        }

        private void GumbDekriptirajAsim_Click(object sender, EventArgs e)
        {
            AsimetricniAlg asimetricniAlg = new AsimetricniAlg();
            Datoteka datoteka = new Datoteka();
            datoteka.KreirajDatoteku("DekriptiranaDatotekaRSA.txt", asimetricniAlg.Dekriptiraj(datoteka.ProcitajDatoteku("privatni_kljuc.txt"), datoteka.ProcitajDatoteku("KriptiranaDatotekaRSA.txt")));
            IspisDatAsimetricno.Text = datoteka.ProcitajDatoteku("DekriptiranaDatotekaRSA.txt");
        }

        private void GumbHash_Click(object sender, EventArgs e)
        {
            Sazetak sazetak = new Sazetak();
            Datoteka datoteka = new Datoteka();
            txtHash.Text = sazetak.BytesToString(sazetak.GetHashSha(@"C:\Users\Tino\Downloads\Desktop\Valentino_Bencek_C#\Datoteka.txt"));
            datoteka.KreirajDatoteku("sazetak_poruke.txt", txtHash.Text);

        }


        private void GumbKreirajPotpis_Click(object sender, EventArgs e)
        {
            
            Datoteka datoteka = new Datoteka();
            Sazetak sazetak = new Sazetak();
            DigitalniPotpis digitalniPotpis = new DigitalniPotpis();
            digitalniPotpis.KreirajPotpis(sazetak.GetHashSha(@"C:\Users\Tino\Downloads\Desktop\Valentino_Bencek_C#\Datoteka.txt"));
            

        }

        private void GumbProvjeri_Click(object sender, EventArgs e)
        {
            Datoteka datoteka = new Datoteka();
            Sazetak sazetak = new Sazetak();
            DigitalniPotpis digitalniPotpis = new DigitalniPotpis();
            string poruka= digitalniPotpis.ProvjeriPotpis(
                sazetak.GetHashSha(@"C:\Users\Tino\Downloads\Desktop\Valentino_Bencek_C#\Datoteka.txt"),
                datoteka.ProcitajDatoteku("digitalni_potpis.txt"),
                datoteka.ProcitajDatoteku("javni_kljuc_potpisa.txt"));
            MessageBox.Show(poruka);
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UnosTeksta_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
