

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PayOfRent
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;database=payrent";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    if (textBox1.Text == "admin" && textBox2.Text == "admin")
                    {
                        Administrator adminForm = new Administrator();
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // �������� ������, ����� �������� UserID
                        string query = "SELECT UserID FROM Users WHERE Login=@Login AND Password=@Password";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Login", textBox1.Text);
                        command.Parameters.AddWithValue("@Password", textBox2.Text);

                        object result = command.ExecuteScalar(); // �������� UserID
                        if (result != null) // ���������, ��� ��������� �� null
                        {
                            int userId = Convert.ToInt32(result); // �������� userId
                            MessageBox.Show("�������� ����!");
                            Account accountForm = new Account(userId); // �������� userId � �����������
                            accountForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("�������� ��� ������������ ��� ������");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"������ �����������: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void Auth_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // ��������� ����� �� label3, ���� ����������
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            // ���, ������� ����������� ��� �������� �����
        }
        public bool TestCredentials(string login, string password)
        {
            return login == "admin" && password == "admin";
        }
    }
}
