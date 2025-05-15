using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayOfRent
{

    public partial class Account : Form
    {
        private string connectionString = "server=localhost;database=payrent;user id=root;";
        private int currentUserId;
        public Account(int userId)
        {
            InitializeComponent();
            currentUserId = userId;
            LoadUserData();
            LoadTariffs();
        }
        private void LoadUserData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                // Объединяем таблицы users и flats по UserID
                string query = "SELECT users.Name, flats.NumberOfFlat FROM users INNER JOIN flats ON users.UserID = flats.Users_UserID WHERE users.UserID = @UserID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", currentUserId);

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["Name"].ToString();
                    textBox6.Text = reader["NumberOfFlat"].ToString();
                }
            }
        }

        private void LoadTariffs()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT GorVoda, HolVoda, Gas, Elecrich FROM Tarif";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    textBox7.Text = reader["GorVoda"].ToString();
                    textBox8.Text = reader["HolVoda"].ToString();
                    textBox9.Text = reader["Gas"].ToString();
                    textBox10.Text = reader["Elecrich"].ToString();
                }
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
{
    decimal gorVoda = decimal.Parse(textBox2.Text) * decimal.Parse(textBox7.Text);
    decimal holVoda = decimal.Parse(textBox3.Text) * decimal.Parse(textBox8.Text);
    decimal gas = decimal.Parse(textBox4.Text) * decimal.Parse(textBox9.Text);
    decimal elecrich = decimal.Parse(textBox5.Text) * decimal.Parse(textBox10.Text);

    // Получаем значения CapRepair и Trash
    var mandatoryTotals = GetMandatoryTotals();
    decimal totalPayment = gorVoda + holVoda + gas + elecrich + mandatoryTotals.capRepair + mandatoryTotals.trash;

    label17.Text = totalPayment.ToString();

    // Сохранение данных в базу
    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        connection.Open();
        string query = "INSERT INTO reporting (HotWater, ColdWater, Gas, Electicity, AllRent, DateOfPay, NumberOfFlat) VALUES (@HotWater, @ColdWater, @Gas, @Electicity, @AllRent, @DateOfPay, @NumberOfFlat)";

        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@HotWater", decimal.Parse(textBox2.Text));
        command.Parameters.AddWithValue("@ColdWater", decimal.Parse(textBox3.Text));
        command.Parameters.AddWithValue("@Gas", decimal.Parse(textBox4.Text));
        command.Parameters.AddWithValue("@Electicity", decimal.Parse(textBox5.Text));
        command.Parameters.AddWithValue("@AllRent", totalPayment);
        command.Parameters.AddWithValue("@DateOfPay", DateTime.Now);
        command.Parameters.AddWithValue("@NumberOfFlat", textBox6.Text);

        command.ExecuteNonQuery();
    }

    using (MySqlConnection connection = new MySqlConnection(connectionString))
    {
        connection.Open();
        string query = "INSERT INTO rent (HotWater, ColdWater, Gas, Electicity, AllRent, DateOfPay, flats_NumberOfFlat) VALUES (@HotWater, @ColdWater, @Gas, @Electicity, @AllRent, @DateOfPay, @NumberOfFlat)";

        MySqlCommand command = new MySqlCommand(query, connection);
        command.Parameters.AddWithValue("@HotWater", decimal.Parse(textBox2.Text));
        command.Parameters.AddWithValue("@ColdWater", decimal.Parse(textBox3.Text));
        command.Parameters.AddWithValue("@Gas", decimal.Parse(textBox4.Text));
        command.Parameters.AddWithValue("@Electicity", decimal.Parse(textBox5.Text));
        command.Parameters.AddWithValue("@AllRent", totalPayment);
        command.Parameters.AddWithValue("@DateOfPay", DateTime.Now);
        command.Parameters.AddWithValue("@NumberOfFlat", textBox6.Text);

        command.ExecuteNonQuery();
    }

    MessageBox.Show("Данные успешно сохранены!");
}



        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();
            Auth authForm = new Auth();
            authForm.Show();
        }
        private void Account_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
        private void linkLabelHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            HistoryOfPay historyForm = new HistoryOfPay(currentUserId);
            
            historyForm.Show();
        }
        private (decimal capRepair, decimal trash) GetMandatoryTotals()
        {
            decimal capRepair = 0;
            decimal trash = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SUM(CapRepair) AS total_CapRepair, SUM(Trash) AS total_Trash FROM mandatory";

                MySqlCommand command = new MySqlCommand(query, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        capRepair = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        trash = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    }
                }
            }

            return (capRepair, trash);
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public decimal CalculateRent(decimal gorVoda, decimal holVoda, decimal gas, decimal elecrich)
        {
            decimal gorVodaCost = gorVoda * decimal.Parse(textBox7.Text);
            decimal holVodaCost = holVoda * decimal.Parse(textBox8.Text);
            decimal gasCost = gas * decimal.Parse(textBox9.Text);
            decimal elecrichCost = elecrich * decimal.Parse(textBox10.Text);

            var mandatoryTotals = GetMandatoryTotals();
            return gorVodaCost + holVodaCost + gasCost + elecrichCost + mandatoryTotals.capRepair + mandatoryTotals.trash;
        }
    }
}
