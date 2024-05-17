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
using System.Data.SQLite;
using System.IO;


namespace Projekt_9
{
    public partial class Form1 : Form
    {
        DatabaseManager db;
        public Form1()
        {
            InitializeComponent();
            this.db = new DatabaseManager(this);
        }

        private void zapisDoBazy_Click(object sender, EventArgs e)
        {
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
            int nr_album = 0;
            try
            {
                nr_album = int.Parse(nrAlbumu.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nr albumu musi być liczbą");
                return;
            }
            db.WriteData(nr_album,imieNazwisko.Text,semestr.Text,kierunek.Text,dataGora.Text,przedmiot.Text,punkty.Text,prowadzacy.Text,powod.Text,podpisStudenta.Text,komisja1.Text,komisja2.Text,komisja3.Text,dataDol.Text,podpisKomisji.Text);
        }
        private void odczytZBazy_Click(object sender, EventArgs e)
        {
            db.ReadData();
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

        public void setLabels(int nr_albumu, string nazwisko_imie, string semestr_rok, string Kierunek, string data_gora, string Przedmiot, string Punkty, string Prowadzacy, string uzasadnienie, string podpis_studenta, string Komisja1, string Komisja2, string Komisja3, string data_dol, string podpis_komisji)
        {
            nrAlbumu.Text = nr_albumu.ToString();
            imieNazwisko.Text = nazwisko_imie;
            semestr.Text = semestr_rok;
            kierunek.Text = Kierunek;
            dataGora.Text = data_gora;
            przedmiot.Text = Przedmiot;
            punkty.Text = Punkty;
            prowadzacy.Text = Prowadzacy;
            powod.Text = uzasadnienie;
            podpisStudenta.Text = podpis_studenta;
            komisja1.Text = Komisja1;
            komisja2.Text = Komisja2;
            komisja3.Text = Komisja3;
            dataDol.Text = data_dol;
            podpisKomisji.Text = podpis_komisji;
        }

    }
    public class DatabaseManager
    {
        Form1 form1;
        public DatabaseManager(Form1 form1)
        {
            this.form1 = form1;
        }
        private string connectionString = "Data Source=C:\\Users\\mjwoj\\source\\repos\\Projekt_9\\Projekt_9\\DataBase\\Data.db;Version=3;";
        public void ReadData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Wniosek";
                SQLiteCommand command = new SQLiteCommand(query,connection);
                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int nr_albumu = reader.GetInt32(0);
                        string nazwisko = reader.GetString(1);
                        string semestr = reader.GetString(2);
                        string kierunek = reader.GetString(3);
                        string data_gora = reader.GetString(4);
                        string przedmiot = reader.GetString(5);
                        string punkty = reader.GetString(6);
                        string prowadzacy = reader.GetString(7);
                        string uzasadnienie = reader.GetString(8);
                        string podpisStudenta = reader.GetString(9);
                        string komisja1 = reader.GetString(10);
                        string komisja2 = reader.GetString(11);
                        string komisja3 = reader.GetString(12);
                        string data_dol = reader.GetString(13);
                        string podpis_komisji = reader.GetString(14);
                        form1.setLabels(nr_albumu, nazwisko, semestr, kierunek, data_gora, przedmiot, punkty, prowadzacy, uzasadnienie, podpisStudenta, komisja1 , komisja2 , komisja3, data_dol, podpis_komisji);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void WriteData(int nr_albumu, string nazwisko_imie, string semestr_rok, string kierunek, string data_gora, string przedmiot, string punkty, string prowadzacy, string uzasadnienie, string podpis_studenta, string komisja1, string komisja2, string komisja3, string data_dol, string podpis_komisji)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            { 

                try
                {
                    connection.Open();
                    string Query = "INSERT INTO Wniosek (nr_albumu,nazwisko_imie,semestr_rok,kierunek,data_gora,przedmiot,punkty,prowadzacy,uzasadnienie,podpis_studenta,komisja1,komisja2,komisja3,data_dol,podpis_komisji) VALUES (@nr_albumu,@nazwisko_imie,@semestr_rok,@kierunek,@data_gora,@przedmiot,@punkty,@prowadzacy,@uzasadnienie,@podpis_studenta,@komisja1,@komisja2,@komisja3,@data_dol,@podpis_komisji)";
                    SQLiteCommand insertCommand = new SQLiteCommand(Query, connection);
                    insertCommand.Parameters.AddWithValue("@nr_albumu", nr_albumu);
                    insertCommand.Parameters.AddWithValue("@nazwisko_imie", nazwisko_imie);
                    insertCommand.Parameters.AddWithValue("@semestr_rok", semestr_rok);
                    insertCommand.Parameters.AddWithValue("@kierunek", kierunek);
                    insertCommand.Parameters.AddWithValue("@data_gora", data_gora);
                    insertCommand.Parameters.AddWithValue("@przedmiot", przedmiot);
                    insertCommand.Parameters.AddWithValue("@punkty", punkty);
                    insertCommand.Parameters.AddWithValue("@prowadzacy", prowadzacy);
                    insertCommand.Parameters.AddWithValue("@uzasadnienie", uzasadnienie);
                    insertCommand.Parameters.AddWithValue("@podpis_studenta", podpis_studenta);
                    insertCommand.Parameters.AddWithValue("@komisja1", komisja1);
                    insertCommand.Parameters.AddWithValue("@komisja2", komisja2);
                    insertCommand.Parameters.AddWithValue("@komisja3", komisja3);
                    insertCommand.Parameters.AddWithValue("@data_dol", data_dol);
                    insertCommand.Parameters.AddWithValue("@podpis_komisji", podpis_komisji);
                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine($"{rowsAffected} row(s) inserted.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

    }
}

