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
        DatabaseManager db = new DatabaseManager();
        public Form1()
        {
            InitializeComponent();
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
            string filePath = "..\\..\\..\\..\\..\\repos\\Projekt_9\\BazaDanych\\Dane.txt";
            string result = $"{nrAlbumu.Text},{imieNazwisko.Text},{semestr.Text},{kierunek.Text},{dataGora.Text},{przedmiot.Text},{punkty.Text},{prowadzacy.Text},{powod.Text},{podpisStudenta.Text},{komisja1.Text},{komisja2.Text},{komisja3.Text},{dataDol.Text},{podpisKomisji.Text}" + Environment.NewLine;
            File.WriteAllText(filePath, result);  
        }
        private void odczytZBazy_Click(object sender, EventArgs e)
        {
            string filePath = "..\\..\\..\\..\\..\\repos\\Projekt_9\\BazaDanych\\Dane.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                nrAlbumu.Text= fields[0];
                imieNazwisko.Text = fields[1];
                semestr.Text = fields[2];
                kierunek.Text = fields[3];
                dataGora.Text = fields[4];
                przedmiot.Text = fields[5];
                punkty.Text = fields[6];
                prowadzacy.Text = fields[7];
                powod.Text = fields[8];
                podpisStudenta.Text = fields[9];
                komisja1.Text = fields[10];
                komisja2.Text = fields[11];
                komisja3.Text = fields[12];
                dataDol.Text = fields[13];
                podpisKomisji.Text = fields[14];
            }
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
    public class DatabaseManager
    {
        private string connectionString = @"Data Source=C:\Users\mjwoj\Desktop\bazaDanych.db;Version=3;";
        public void ReadData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "SELECT * FROM Users";
                SQLiteCommand command = new SQLiteCommand(query,connection);
                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int userId = reader.GetInt32(0); // Assuming Id is the first column
                        string userName = reader.GetString(1); // Assuming Name is the second column
                        Console.WriteLine($"User Id: {userId}, Name: {userName}");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
        public void WriteData(int userId, string userName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY,Name TEXT)";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);

                try
                {
                    connection.Open();
                    createTableCommand.ExecuteNonQuery();
                    Console.WriteLine("Table 'Users' created or already exists.");
                    string insertQuery = "INSERT INTO Users (Id, Name) VALUES (@Id, @Name)";
                    SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@Id", userId);
                    insertCommand.Parameters.AddWithValue("@Name", userName);
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

