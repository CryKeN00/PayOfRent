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
    public partial class HistoryOfPay : Form
    {
        private int currentUserId;
        public HistoryOfPay(int userId)
        {
            currentUserId = userId;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string apartmentNumber = textBox1.Text;

            if (string.IsNullOrEmpty(apartmentNumber))
            {
                MessageBox.Show("Пожалуйста, введите номер квартиры.");
                return;
            }

            string connectionString = "server=localhost;user id=root;database=payrent";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM reporting WHERE NumberOfFlat = @NumberOfFlat";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumberOfFlat", apartmentNumber);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;


                    dataGridView1.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HistoryOfPay_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void HistoryOfPay_Load(object sender, EventArgs e)
        {

        }
    }
}
