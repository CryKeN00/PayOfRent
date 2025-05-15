using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayOfRent
{
    public partial class Administrator : Form
    {
        private MySqlConnection connection;
        public Administrator()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadData();
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=localhost;user id=root; database=payrent";
            connection = new MySqlConnection(connectionString);
        }
        private void LoadData()
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Users", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form =new EditRecordForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }

        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var recordId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                var form = new EditRecordForm(recordId);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите запись для изменения.");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var recordId = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                var result = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Подтверждение", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand("DELETE FROM Users WHERE UserID = @UserID", connection);
                        command.Parameters.AddWithValue("@UserID", recordId);
                        command.ExecuteNonQuery();
                    }
                    finally
                    {
                        connection.Close();
                    }
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите запись для удаления.");
                }
            }
        }
        private void btnChangeFormula_Click(object sender, EventArgs e)
        {
            var formula = Microsoft.VisualBasic.Interaction.InputBox("Введите новую формулу расчета квартплаты:", "Изменение формулы", "Текущая формула");
            if (!string.IsNullOrEmpty(formula))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand("UPDATE settings SET formula = @Formula WHERE ID = 1", connection);
                    command.Parameters.AddWithValue("@Formula", formula);
                    command.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
                MessageBox.Show("Формула успешно изменена.");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Auth authForm = new Auth();
            authForm.Show();
        }
        private void Administrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Подтверждение выхода", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Отменяем закрытие формы
            }
            else
            {
                Application.Exit();
            }
        }
        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Button GetAddButtonForTesting() => button2;
        public Button GetEditButtonForTesting() => button1;
        public Button GetDeleteButtonForTesting() => button3;
    }
}
