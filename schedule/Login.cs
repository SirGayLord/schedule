using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace schedule
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void войти_Click(object sender, EventArgs e)
        {
            
        }

        private void войти_Click_1(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5433;Database=schedule;User ID=postgres;Password=0000";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);

            string логин = логинBox.Text;
            string пароль = парольBox.Text;

            string query = "SELECT * FROM Пользователи WHERE Логин = @Логин AND Пароль = @Пароль";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Логин", логин);
                cmd.Parameters.AddWithValue("@Пароль", пароль);

                try
                {
                    connection.Open();
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        // Получаем значение из столбца "Роль" (или другого столбца, содержащего информацию о роли пользователя)
                        string role = reader.GetString(reader.GetOrdinal("Логин"));

                        // Скрыть текущую форму
                        this.Hide();

                        if (role == "adm1")
                        {
                            // Пользователь с ролью "admin", перенаправляем на первую форму
                            AdmForm form1 = new AdmForm();
                            form1.Show();
                        }
                        else if (role == "pr1")
                        {
                            // Пользователь с ролью "pr", перенаправляем на третью форму
                            PrepodForm form3 = new PrepodForm();
                            form3.Show();
                        }
                        else if (role == "std1")
                        {
                            // Пользователь с ролью "std", перенаправляем на третью форму
                            StudForm form4 = new StudForm();
                            form4.Show();
                        }
                        else
                        {
                            // Неизвестная роль, обработка по умолчанию (можно вывести сообщение об ошибке или перенаправить на другую форму)
                            MessageBox.Show("Неизвестная роль пользователя");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неправильный логин или пароль");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
