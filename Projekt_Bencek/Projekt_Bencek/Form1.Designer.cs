namespace Projekt_Bencek
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UnosTeksta = new System.Windows.Forms.TextBox();
            this.GumbUnosaTeksta = new System.Windows.Forms.Button();
            this.GumbKriptiranja = new System.Windows.Forms.Button();
            this.GumbDekriptiranja = new System.Windows.Forms.Button();
            this.UnosAesKljuca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IspisDatoteke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UnosIspravnogKljuca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GumbKriptirajAsimetricno = new System.Windows.Forms.Button();
            this.IspisDatAsimetricno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GumbDekriptirajAsim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GumbObrisi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.GumbHash = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GumbProvjeri = new System.Windows.Forms.Button();
            this.GumbKreirajPotpis = new System.Windows.Forms.Button();
            this.GumbGenerirajKljuceve = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnosTeksta
            // 
            this.UnosTeksta.Location = new System.Drawing.Point(12, 40);
            this.UnosTeksta.Multiline = true;
            this.UnosTeksta.Name = "UnosTeksta";
            this.UnosTeksta.Size = new System.Drawing.Size(335, 119);
            this.UnosTeksta.TabIndex = 0;
            this.UnosTeksta.TextChanged += new System.EventHandler(this.UnosTeksta_TextChanged);
            // 
            // GumbUnosaTeksta
            // 
            this.GumbUnosaTeksta.Location = new System.Drawing.Point(237, 165);
            this.GumbUnosaTeksta.Name = "GumbUnosaTeksta";
            this.GumbUnosaTeksta.Size = new System.Drawing.Size(110, 23);
            this.GumbUnosaTeksta.TabIndex = 1;
            this.GumbUnosaTeksta.Text = "Kreiraj datoteku";
            this.GumbUnosaTeksta.UseVisualStyleBackColor = true;
            this.GumbUnosaTeksta.Click += new System.EventHandler(this.GumbUnosaTeksta_Click);
            // 
            // GumbKriptiranja
            // 
            this.GumbKriptiranja.Location = new System.Drawing.Point(234, 258);
            this.GumbKriptiranja.Name = "GumbKriptiranja";
            this.GumbKriptiranja.Size = new System.Drawing.Size(113, 23);
            this.GumbKriptiranja.TabIndex = 2;
            this.GumbKriptiranja.Text = "Kriptiraj simetrično";
            this.GumbKriptiranja.UseVisualStyleBackColor = true;
            this.GumbKriptiranja.Click += new System.EventHandler(this.GumbKriptiranja_Click);
            // 
            // GumbDekriptiranja
            // 
            this.GumbDekriptiranja.Location = new System.Drawing.Point(681, 193);
            this.GumbDekriptiranja.Name = "GumbDekriptiranja";
            this.GumbDekriptiranja.Size = new System.Drawing.Size(75, 23);
            this.GumbDekriptiranja.TabIndex = 3;
            this.GumbDekriptiranja.Text = "Dekriptiraj";
            this.GumbDekriptiranja.UseVisualStyleBackColor = true;
            this.GumbDekriptiranja.Click += new System.EventHandler(this.GumbDekriptiranja_Click);
            // 
            // UnosAesKljuca
            // 
            this.UnosAesKljuca.Location = new System.Drawing.Point(93, 219);
            this.UnosAesKljuca.Name = "UnosAesKljuca";
            this.UnosAesKljuca.Size = new System.Drawing.Size(254, 20);
            this.UnosAesKljuca.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aes kljuc:";
            // 
            // IspisDatoteke
            // 
            this.IspisDatoteke.Location = new System.Drawing.Point(421, 40);
            this.IspisDatoteke.Multiline = true;
            this.IspisDatoteke.Name = "IspisDatoteke";
            this.IspisDatoteke.Size = new System.Drawing.Size(335, 119);
            this.IspisDatoteke.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(149, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duljina: 16, 32 (npr: 0123456789abcdef)";
            // 
            // UnosIspravnogKljuca
            // 
            this.UnosIspravnogKljuca.Location = new System.Drawing.Point(502, 165);
            this.UnosIspravnogKljuca.Name = "UnosIspravnogKljuca";
            this.UnosIspravnogKljuca.Size = new System.Drawing.Size(254, 20);
            this.UnosIspravnogKljuca.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Aes kljuc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proizvoljni tekst:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Simetrično kriptirana datoteka:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // GumbKriptirajAsimetricno
            // 
            this.GumbKriptirajAsimetricno.Location = new System.Drawing.Point(226, 22);
            this.GumbKriptirajAsimetricno.Name = "GumbKriptirajAsimetricno";
            this.GumbKriptirajAsimetricno.Size = new System.Drawing.Size(113, 23);
            this.GumbKriptirajAsimetricno.TabIndex = 12;
            this.GumbKriptirajAsimetricno.Text = "Kriptiraj asimetrično";
            this.GumbKriptirajAsimetricno.UseVisualStyleBackColor = true;
            this.GumbKriptirajAsimetricno.Click += new System.EventHandler(this.GumbKriptirajAsimetricno_Click);
            // 
            // IspisDatAsimetricno
            // 
            this.IspisDatAsimetricno.Location = new System.Drawing.Point(421, 242);
            this.IspisDatAsimetricno.Multiline = true;
            this.IspisDatAsimetricno.Name = "IspisDatAsimetricno";
            this.IspisDatAsimetricno.Size = new System.Drawing.Size(335, 119);
            this.IspisDatAsimetricno.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Asimetrično kriptirana datoteka:";
            // 
            // GumbDekriptirajAsim
            // 
            this.GumbDekriptirajAsim.Location = new System.Drawing.Point(681, 367);
            this.GumbDekriptirajAsim.Name = "GumbDekriptirajAsim";
            this.GumbDekriptirajAsim.Size = new System.Drawing.Size(75, 23);
            this.GumbDekriptirajAsim.TabIndex = 15;
            this.GumbDekriptirajAsim.Text = "Dekriptiraj";
            this.GumbDekriptirajAsim.UseVisualStyleBackColor = true;
            this.GumbDekriptirajAsim.Click += new System.EventHandler(this.GumbDekriptirajAsim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 117);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simetrično kriptiranje";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GumbGenerirajKljuceve);
            this.groupBox2.Controls.Add(this.GumbKriptirajAsimetricno);
            this.groupBox2.Location = new System.Drawing.Point(15, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 57);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asimetrično kriptiranje";
            // 
            // GumbObrisi
            // 
            this.GumbObrisi.Location = new System.Drawing.Point(12, 160);
            this.GumbObrisi.Name = "GumbObrisi";
            this.GumbObrisi.Size = new System.Drawing.Size(69, 23);
            this.GumbObrisi.TabIndex = 18;
            this.GumbObrisi.Text = "Obrisi tekst";
            this.GumbObrisi.UseVisualStyleBackColor = true;
            this.GumbObrisi.Click += new System.EventHandler(this.GumbObrisi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtHash);
            this.groupBox3.Controls.Add(this.GumbHash);
            this.groupBox3.Location = new System.Drawing.Point(15, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 94);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sažetak poruke";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "(Sha1)";
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(6, 19);
            this.txtHash.Multiline = true;
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(333, 40);
            this.txtHash.TabIndex = 19;
            // 
            // GumbHash
            // 
            this.GumbHash.Location = new System.Drawing.Point(226, 65);
            this.GumbHash.Name = "GumbHash";
            this.GumbHash.Size = new System.Drawing.Size(113, 23);
            this.GumbHash.TabIndex = 12;
            this.GumbHash.Text = "Prikazi hash";
            this.GumbHash.UseVisualStyleBackColor = true;
            this.GumbHash.Click += new System.EventHandler(this.GumbHash_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GumbProvjeri);
            this.groupBox4.Controls.Add(this.GumbKreirajPotpis);
            this.groupBox4.Location = new System.Drawing.Point(15, 487);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 94);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Digitalni potpis";
            // 
            // GumbProvjeri
            // 
            this.GumbProvjeri.Location = new System.Drawing.Point(219, 37);
            this.GumbProvjeri.Name = "GumbProvjeri";
            this.GumbProvjeri.Size = new System.Drawing.Size(113, 23);
            this.GumbProvjeri.TabIndex = 13;
            this.GumbProvjeri.Text = "Provjeri potpis";
            this.GumbProvjeri.UseVisualStyleBackColor = true;
            this.GumbProvjeri.Click += new System.EventHandler(this.GumbProvjeri_Click);
            // 
            // GumbKreirajPotpis
            // 
            this.GumbKreirajPotpis.Location = new System.Drawing.Point(6, 37);
            this.GumbKreirajPotpis.Name = "GumbKreirajPotpis";
            this.GumbKreirajPotpis.Size = new System.Drawing.Size(113, 23);
            this.GumbKreirajPotpis.TabIndex = 12;
            this.GumbKreirajPotpis.Text = "Napravi potpis";
            this.GumbKreirajPotpis.UseVisualStyleBackColor = true;
            this.GumbKreirajPotpis.Click += new System.EventHandler(this.GumbKreirajPotpis_Click);
            // 
            // GumbGenerirajKljuceve
            // 
            this.GumbGenerirajKljuceve.Location = new System.Drawing.Point(94, 22);
            this.GumbGenerirajKljuceve.Name = "GumbGenerirajKljuceve";
            this.GumbGenerirajKljuceve.Size = new System.Drawing.Size(113, 23);
            this.GumbGenerirajKljuceve.TabIndex = 13;
            this.GumbGenerirajKljuceve.Text = "Generiraj ključeve";
            this.GumbGenerirajKljuceve.UseVisualStyleBackColor = true;
            this.GumbGenerirajKljuceve.Click += new System.EventHandler(this.GumbGenerirajKljuceve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GumbObrisi);
            this.Controls.Add(this.GumbDekriptirajAsim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IspisDatAsimetricno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UnosIspravnogKljuca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IspisDatoteke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UnosAesKljuca);
            this.Controls.Add(this.GumbDekriptiranja);
            this.Controls.Add(this.GumbKriptiranja);
            this.Controls.Add(this.GumbUnosaTeksta);
            this.Controls.Add(this.UnosTeksta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Digitalni potpis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UnosTeksta;
        private System.Windows.Forms.Button GumbUnosaTeksta;
        private System.Windows.Forms.Button GumbKriptiranja;
        private System.Windows.Forms.Button GumbDekriptiranja;
        private System.Windows.Forms.TextBox UnosAesKljuca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IspisDatoteke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UnosIspravnogKljuca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GumbKriptirajAsimetricno;
        private System.Windows.Forms.TextBox IspisDatAsimetricno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GumbDekriptirajAsim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GumbObrisi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Button GumbHash;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button GumbProvjeri;
        private System.Windows.Forms.Button GumbKreirajPotpis;
        private System.Windows.Forms.Button GumbGenerirajKljuceve;
    }
}

