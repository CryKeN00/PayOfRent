

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
                        // Изменяем запрос, чтобы получить UserID
                        string query = "SELECT UserID FROM Users WHERE Login=@Login AND Password=@Password";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Login", textBox1.Text);
                        command.Parameters.AddWithValue("@Password", textBox2.Text);

                        object result = command.ExecuteScalar(); // Получаем UserID
                        if (result != null) // Проверяем, что результат не null
                        {
                            int userId = Convert.ToInt32(result); // Получаем userId
                            MessageBox.Show("Успешный вход!");
                            Account accountForm = new Account(userId); // Передаем userId в конструктор
                            accountForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверное имя пользователя или пароль");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Ошибка подключения: {ex.Message}");
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
            // Обработка клика по label3, если необходимо
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            // Код, который выполняется при загрузке формы
        }
        public bool TestCredentials(string login, string password)
        {
            return login == "admin" && password == "admin";
        }
    }
}
