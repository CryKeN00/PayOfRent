using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayOfRent
{
    public partial class EditRecordForm: Form
    {
        private MySqlConnection connection;
        private int? recordId;
        public EditRecordForm(int? recordId = null)
        {
            InitializeComponent();
            this.recordId = recordId;
            InitializeDatabaseConnection();
            if (recordId.HasValue)
            {
                LoadRecord(recordId.Value);
            }
        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "server=localhost;user id=root;database=payrent";
            connection = new MySqlConnection(connectionString);
        }
        private void LoadRecord(int UserID)
        {
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM Users WHERE UserID=@UserID", connection);
                command.Parameters.AddWithValue("@UserID", UserID);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBox1.Text = reader["Name"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["Date"]);
                        textBox3.Text = reader["Login"].ToString();
                        textBox4.Text = reader["Password"].ToString();
                    }
                }
            }
            finally
            {
                connection.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (recordId.HasValue)
                {
                    MySqlCommand command = new MySqlCommand("UPDATE Users SET Name=@Name, Date=@Date, Login=@Login, Password=@Password WHERE UserID = @UserID", connection);
                    command.Parameters.AddWithValue("Name", textBox1.Text);
                    command.Parameters.AddWithValue("Date", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("Login", textBox3.Text);
                    command.Parameters.AddWithValue("Password", textBox4.Text);
                    command.Parameters.AddWithValue("@UserID", recordId.Value);
                    command.ExecuteNonQuery();

                }
                else
                {
                    MySqlCommand command = new MySqlCommand("INSERT INTO Users (Name,Date,Login,Password) VALUES (@Name,@Date,@Login,@Password)", connection);
                    command.Parameters.AddWithValue("Name", textBox1.Text);
                    command.Parameters.AddWithValue("Date", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("Login", textBox3.Text);
                    command.Parameters.AddWithValue("Password", textBox4.Text);
                    command.ExecuteNonQuery();
                }
            }
            finally
            {
                connection.Close();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditRecordForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
