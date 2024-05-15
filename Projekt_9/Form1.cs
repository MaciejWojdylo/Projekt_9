using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void zapisDoBazy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Już");
            if (nrAlbumu.Text == "Wpisz tutaj" || string.IsNullOrEmpty(nrAlbumu.Text))
            {
                return;
            }
            if(imieNazwisko.Text == "Wpisz tutaj" || string.IsNullOrEmpty(imieNazwisko.Text))
            { 
                return; 
            }
            if(semestr.Text == "Wpisz tutaj" || string.IsNullOrEmpty(semestr.Text))
            {
                return;
            }
            if(kierunek.Text == "Wpisz tutaj" || string.IsNullOrEmpty(kierunek.Text))
            {
                return;
            }
            if(dataGora.Text == "Wpisz tutaj" || string.IsNullOrEmpty(dataGora.Text))
            {
                return;
            }
            if(przedmiot.Text == "Wpisz tutaj" || string.IsNullOrEmpty(przedmiot.Text))
            {
                return;
            }
            if (punkty.Text == "Wpisz tutaj" || string.IsNullOrEmpty(punkty.Text))
            {
                return;
            }
            if (prowadzacy.Text == "Wpisz tutaj" || string.IsNullOrEmpty(prowadzacy.Text))
            {
                return;
            }
            if (powod.Text == "Wpisz tutaj" || string.IsNullOrEmpty(powod.Text))
            {
                return;
            }
            if (podpisStudenta.Text == "Wpisz tutaj" || string.IsNullOrEmpty(podpisStudenta.Text))
            {
                return;
            }
            if (komisja1.Text == "Wpisz tutaj" || string.IsNullOrEmpty(komisja1.Text))
            {
                return;
            }
            if (komisja2.Text == "Wpisz tutaj" || string.IsNullOrEmpty(komisja2.Text))
            {
                return;
            }
            if (komisja3.Text == "Wpisz tutaj" || string.IsNullOrEmpty(komisja3.Text))
            {
                return;
            }
            if (dataDol.Text == "Wpisz tutaj" || string.IsNullOrEmpty(dataDol.Text))
            {
                return;
            }
            if (podpisKomisji.Text == "Wpisz tutaj" || string.IsNullOrEmpty(podpisKomisji.Text))
            {
                return;
            }
            /*
            string result = $"{nrAlbumu.Text},{imieNazwisko.Text},{semestr.Text},{kierunek.Text},{dataGora.Text},{przedmiot.Text},{punkty.Text},{prowadzacy.Text},{powod.Text},{podpisStudenta.Text},{komisja1.Text},{komisja2.Text},{komisja3.Text},{dataDol.Text},{podpisKomisji.Text}";
            MessageBox.Show(result);
            */
        }
        private void odczytZBazy_Click(object sender, EventArgs e)
        {

        }

        private void nrAlbumu_DoubleClick(object sender, EventArgs e)
        {
            nrAlbumu.Text = "";
        }

        private void imieNazwisko_DoubleClick(object sender, EventArgs e)
        {
            imieNazwisko.Text = "";
        }

        private void semestr_DoubleClick(object sender, EventArgs e)
        {
            semestr.Text = "";
        }

        private void kierunek_DoubleClick(object sender, EventArgs e)
        {
            kierunek.Text = "";
        }

        private void dataGora_DoubleClick(object sender, EventArgs e)
        {
            dataGora.Text = "";
        }

        private void przedmiot_DoubleClick(object sender, EventArgs e)
        {
            przedmiot.Text = "";
        }

        private void punkty_DoubleClick(object sender, EventArgs e)
        {
            punkty.Text = "";
        }

        private void prowadzacy_DoubleClick(object sender, EventArgs e)
        {
            prowadzacy.Text = "";
        }

        private void powod_DoubleClick(object sender, EventArgs e)
        {
            powod.Text = "";
        }

        private void podpisStudenta_DoubleClick(object sender, EventArgs e)
        {
            podpisStudenta.Text = "";
        }

        private void komisja1_DoubleClick(object sender, EventArgs e)
        {
            komisja1.Text = "";
        }

        private void komisja2_DoubleClick(object sender, EventArgs e)
        {
            komisja2.Text = "";
        }
        private void komisja3_DoubleClick(object sender, EventArgs e)
        {
            komisja3.Text = "";
        }

        private void dataDol_DoubleClick(object sender, EventArgs e)
        {
            dataDol.Text = "";
        }

        private void podpisKomisji_DoubleClick(object sender, EventArgs e)
        {
            podpisKomisji.Text = "";
        }

    }
}
