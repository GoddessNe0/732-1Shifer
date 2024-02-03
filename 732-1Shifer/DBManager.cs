using System;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace _732_1Shifer
{
    public class DBManager
    {
        SQLiteConnection conn;

        public DBManager(string path)
        {
            // Инициализация объекта SQLiteConnection с указанием пути к базе данных и открытие соединения
            conn = new SQLiteConnection("Data Source = " + path);
            conn.Open();
        }

        public bool DisconnectDB()
        {
            // Метод для закрытия соединения с базой данных
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Dispose();
                }
            }

            return true;
        }

        // Метод для аутентификации пользователя
        public bool AuthUser(string login, string password)
        {
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand command = conn.CreateCommand();

                        // Используется параметризованный SQL-запрос для безопасной аутентификации
                        command.CommandText = "SELECT * FROM users WHERE login = @login and password = @password";

                        // Добавление параметров для предотвращения SQL-инъекций
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", getHash(password));

                        // Выполнение запроса и получение результата
                        object res = command.ExecuteScalar();

                        // Если результат не равен null, то аутентификация прошла успешно
                        if (res != null)
                            return true;
                        else
                            return false;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }

            return false;
        }

        // Метод для добавления нового пользователя
        public bool AddNewUser(string login, string password)
        {
            if (conn != null)
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    try
                    {
                        SQLiteCommand command = conn.CreateCommand();

                        // Используется параметризованный SQL-запрос для безопасной вставки нового пользователя
                        command.CommandText = "INSERT INTO users VALUES (@login, @password)";

                        // Добавление параметров для предотвращения SQL-инъекций
                        command.Parameters.AddWithValue("@login", login);
                        command.Parameters.AddWithValue("@password", getHash(password));

                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        return true;
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
            }

            return false;
        }

        // Метод для аутентификации пользователя с использованием параметров
        public bool AuthUserWithParameters(string login, string password)
        {
            // Этот метод аналогичен AuthUser, но добавлен для наглядности использования параметров в запросе
            return AuthUser(login, password);
        }

        // Метод для вычисления хеша SHA-256
        private string getHash(string text)
        {
            SHA256 sha256 = SHA256.Create();
            byte[] raw_text = Encoding.Unicode.GetBytes(text);
            byte[] raw_hash = sha256.ComputeHash(raw_text);
            string hash = Encoding.Unicode.GetString(raw_hash);

            sha256.Clear();

            return hash;
        }
    }
}
