namespace Projekt_9
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Document = new System.Windows.Forms.PictureBox();
            this.zapisDoBazy = new System.Windows.Forms.Button();
            this.odczytZBazy = new System.Windows.Forms.Button();
            this.nrAlbumu = new System.Windows.Forms.TextBox();
            this.imieNazwisko = new System.Windows.Forms.TextBox();
            this.semestr = new System.Windows.Forms.TextBox();
            this.kierunek = new System.Windows.Forms.TextBox();
            this.dataGora = new System.Windows.Forms.TextBox();
            this.przedmiot = new System.Windows.Forms.TextBox();
            this.punkty = new System.Windows.Forms.TextBox();
            this.prowadzacy = new System.Windows.Forms.TextBox();
            this.powod = new System.Windows.Forms.TextBox();
            this.podpisStudenta = new System.Windows.Forms.TextBox();
            this.komisja1 = new System.Windows.Forms.TextBox();
            this.komisja2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.komsja3 = new System.Windows.Forms.TextBox();
            this.dataDol = new System.Windows.Forms.TextBox();
            this.podpisKomisji = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Document)).BeginInit();
            this.SuspendLayout();
            // 
            // Document
            // 
            this.Document.Image = global::Projekt_9.Properties.Resources.Wniosek_o_egzamin_komisyjny_1;
            this.Document.Location = new System.Drawing.Point(-1, -3);
            this.Document.Name = "Document";
            this.Document.Size = new System.Drawing.Size(683, 1063);
            this.Document.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Document.TabIndex = 0;
            this.Document.TabStop = false;
            // 
            // zapisDoBazy
            // 
            this.zapisDoBazy.Location = new System.Drawing.Point(103, 899);
            this.zapisDoBazy.Name = "zapisDoBazy";
            this.zapisDoBazy.Size = new System.Drawing.Size(94, 42);
            this.zapisDoBazy.TabIndex = 16;
            this.zapisDoBazy.Text = "Zapis";
            this.zapisDoBazy.UseVisualStyleBackColor = true;
            this.zapisDoBazy.Click += new System.EventHandler(this.zapisDoBazy_Click);
            // 
            // odczytZBazy
            // 
            this.odczytZBazy.Location = new System.Drawing.Point(453, 900);
            this.odczytZBazy.Name = "odczytZBazy";
            this.odczytZBazy.Size = new System.Drawing.Size(95, 41);
            this.odczytZBazy.TabIndex = 17;
            this.odczytZBazy.Text = "Odczyt";
            this.odczytZBazy.UseVisualStyleBackColor = true;
            this.odczytZBazy.Click += new System.EventHandler(this.odczytZBazy_Click);
            // 
            // nrAlbumu
            // 
            this.nrAlbumu.Location = new System.Drawing.Point(81, 146);
            this.nrAlbumu.Name = "nrAlbumu";
            this.nrAlbumu.Size = new System.Drawing.Size(262, 20);
            this.nrAlbumu.TabIndex = 18;
            this.nrAlbumu.Text = "Wpisz tutaj";
            this.nrAlbumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nrAlbumu.DoubleClick += new System.EventHandler(this.nrAlbumu_DoubleClick);
            // 
            // imieNazwisko
            // 
            this.imieNazwisko.Location = new System.Drawing.Point(81, 182);
            this.imieNazwisko.Name = "imieNazwisko";
            this.imieNazwisko.Size = new System.Drawing.Size(262, 20);
            this.imieNazwisko.TabIndex = 19;
            this.imieNazwisko.Text = "Wpisz tutaj";
            this.imieNazwisko.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.imieNazwisko.DoubleClick += new System.EventHandler(this.imieNazwisko_DoubleClick);
            // 
            // semestr
            // 
            this.semestr.Location = new System.Drawing.Point(81, 218);
            this.semestr.Name = "semestr";
            this.semestr.Size = new System.Drawing.Size(262, 20);
            this.semestr.TabIndex = 20;
            this.semestr.Text = "Wpisz tutaj";
            this.semestr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.semestr.DoubleClick += new System.EventHandler(this.semestr_DoubleClick);
            // 
            // kierunek
            // 
            this.kierunek.Location = new System.Drawing.Point(81, 253);
            this.kierunek.Name = "kierunek";
            this.kierunek.Size = new System.Drawing.Size(262, 20);
            this.kierunek.TabIndex = 21;
            this.kierunek.Text = "Wpisz tutaj";
            this.kierunek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kierunek.DoubleClick += new System.EventHandler(this.kierunek_DoubleClick);
            // 
            // dataGora
            // 
            this.dataGora.Location = new System.Drawing.Point(487, 135);
            this.dataGora.Name = "dataGora";
            this.dataGora.Size = new System.Drawing.Size(116, 20);
            this.dataGora.TabIndex = 22;
            this.dataGora.Text = "Wpisz tutaj";
            this.dataGora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataGora.DoubleClick += new System.EventHandler(this.dataGora_DoubleClick);
            // 
            // przedmiot
            // 
            this.przedmiot.Location = new System.Drawing.Point(142, 454);
            this.przedmiot.Name = "przedmiot";
            this.przedmiot.Size = new System.Drawing.Size(273, 20);
            this.przedmiot.TabIndex = 23;
            this.przedmiot.Text = "Wpisz tutaj";
            this.przedmiot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.przedmiot.DoubleClick += new System.EventHandler(this.przedmiot_DoubleClick);
            // 
            // punkty
            // 
            this.punkty.Location = new System.Drawing.Point(462, 454);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(95, 20);
            this.punkty.TabIndex = 24;
            this.punkty.Text = "Wpisz tutaj";
            this.punkty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.punkty.DoubleClick += new System.EventHandler(this.punkty_DoubleClick);
            // 
            // prowadzacy
            // 
            this.prowadzacy.Location = new System.Drawing.Point(195, 480);
            this.prowadzacy.Name = "prowadzacy";
            this.prowadzacy.Size = new System.Drawing.Size(408, 20);
            this.prowadzacy.TabIndex = 25;
            this.prowadzacy.Text = "Wpisz tutaj";
            this.prowadzacy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.prowadzacy.DoubleClick += new System.EventHandler(this.prowadzacy_DoubleClick);
            // 
            // powod
            // 
            this.powod.Location = new System.Drawing.Point(81, 534);
            this.powod.Name = "powod";
            this.powod.Size = new System.Drawing.Size(519, 20);
            this.powod.TabIndex = 26;
            this.powod.Text = "Wpisz tutaj";
            this.powod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.powod.DoubleClick += new System.EventHandler(this.powod_DoubleClick);
            // 
            // podpisStudenta
            // 
            this.podpisStudenta.Location = new System.Drawing.Point(422, 582);
            this.podpisStudenta.Name = "podpisStudenta";
            this.podpisStudenta.Size = new System.Drawing.Size(165, 20);
            this.podpisStudenta.TabIndex = 27;
            this.podpisStudenta.Text = "Wpisz tutaj";
            this.podpisStudenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.podpisStudenta.DoubleClick += new System.EventHandler(this.podpisStudenta_DoubleClick);
            // 
            // komisja1
            // 
            this.komisja1.Location = new System.Drawing.Point(101, 699);
            this.komisja1.Name = "komisja1";
            this.komisja1.Size = new System.Drawing.Size(260, 20);
            this.komisja1.TabIndex = 28;
            this.komisja1.Text = "Wpisz tutaj";
            this.komisja1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.komisja1.DoubleClick += new System.EventHandler(this.komisja1_DoubleClick);
            // 
            // komisja2
            // 
            this.komisja2.Location = new System.Drawing.Point(101, 721);
            this.komisja2.Name = "komisja2";
            this.komisja2.Size = new System.Drawing.Size(260, 20);
            this.komisja2.TabIndex = 29;
            this.komisja2.Text = "Wpisz tutaj";
            this.komisja2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.komisja2.DoubleClick += new System.EventHandler(this.komisja2_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(78, 702);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(78, 724);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Snow;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 715);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "AAAAA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(78, 750);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "3";
            // 
            // komsja3
            // 
            this.komsja3.Location = new System.Drawing.Point(99, 747);
            this.komsja3.Name = "komsja3";
            this.komsja3.Size = new System.Drawing.Size(262, 20);
            this.komsja3.TabIndex = 34;
            this.komsja3.Text = "Wpisz tutaj";
            this.komsja3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.komsja3.DoubleClick += new System.EventHandler(this.komsja3_DoubleClick);
            // 
            // dataDol
            // 
            this.dataDol.Location = new System.Drawing.Point(134, 817);
            this.dataDol.Name = "dataDol";
            this.dataDol.Size = new System.Drawing.Size(95, 20);
            this.dataDol.TabIndex = 35;
            this.dataDol.Text = "Wpisz tutaj";
            this.dataDol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dataDol.DoubleClick += new System.EventHandler(this.dataDol_DoubleClick);
            // 
            // podpisKomisji
            // 
            this.podpisKomisji.Location = new System.Drawing.Point(422, 817);
            this.podpisKomisji.Name = "podpisKomisji";
            this.podpisKomisji.Size = new System.Drawing.Size(178, 20);
            this.podpisKomisji.TabIndex = 36;
            this.podpisKomisji.Text = "Wpisz tutaj";
            this.podpisKomisji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.podpisKomisji.DoubleClick += new System.EventHandler(this.podpisKomisji_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 1061);
            this.Controls.Add(this.podpisKomisji);
            this.Controls.Add(this.dataDol);
            this.Controls.Add(this.komsja3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.komisja2);
            this.Controls.Add(this.komisja1);
            this.Controls.Add(this.podpisStudenta);
            this.Controls.Add(this.powod);
            this.Controls.Add(this.prowadzacy);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.przedmiot);
            this.Controls.Add(this.dataGora);
            this.Controls.Add(this.kierunek);
            this.Controls.Add(this.semestr);
            this.Controls.Add(this.imieNazwisko);
            this.Controls.Add(this.nrAlbumu);
            this.Controls.Add(this.odczytZBazy);
            this.Controls.Add(this.zapisDoBazy);
            this.Controls.Add(this.Document);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Document)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Document;
        private System.Windows.Forms.Button zapisDoBazy;
        private System.Windows.Forms.Button odczytZBazy;
        private System.Windows.Forms.TextBox nrAlbumu;
        private System.Windows.Forms.TextBox imieNazwisko;
        private System.Windows.Forms.TextBox semestr;
        private System.Windows.Forms.TextBox kierunek;
        private System.Windows.Forms.TextBox dataGora;
        private System.Windows.Forms.TextBox przedmiot;
        private System.Windows.Forms.TextBox punkty;
        private System.Windows.Forms.TextBox prowadzacy;
        private System.Windows.Forms.TextBox powod;
        private System.Windows.Forms.TextBox podpisStudenta;
        private System.Windows.Forms.TextBox komisja1;
        private System.Windows.Forms.TextBox komisja2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox komsja3;
        private System.Windows.Forms.TextBox dataDol;
        private System.Windows.Forms.TextBox podpisKomisji;
    }
}

