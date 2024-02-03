using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _732_1Shifer
{
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void MakeReg_Click(object sender, EventArgs e)
        {
            string login = RegLogin.Text;
            string password = RegPwd.Text;
            string confirmPassword = RedgPwdRepit.Text;

            // Проверка, что пароль введен и соответствует длине
            if (string.IsNullOrWhiteSpace(password) || password.Length < 4 || password.Length > 16)
            {
                MessageBox.Show("Пожалуйста, введите пароль от 4 до 16 символов.");
                return;
            }

            // Проверка, что логин введен и соответствует длине
            if (string.IsNullOrWhiteSpace(login) || login.Length < 4 || login.Length > 16)
            {
                MessageBox.Show("Пожалуйста, введите логин от 4 до 16 символов.");
                return;
            }

            // Проверка, что в логине и пароле можно использовать только цифры, буквы и специальные символы
            if (!IsValidInput(login) || !IsValidInput(password))
            {
                MessageBox.Show("Логин и пароль могут содержать только цифры, буквы и специальные символы.");
                return;
            }

            // Проверка, что пароль и его повторение совпадают
            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return;
            }

            // Продолжаем только если ввод соответствует требованиям
            DBManager dBManager = new DBManager("C:\\BASE\\732SHIFER.db");
            if (dBManager.AddNewUser(login, password))
            {
                MessageBox.Show("Успешно!");
            }
            else
            {
                MessageBox.Show("Не успешно(");
            }
        }

        private bool IsValidInput(string input)
        {
            // Запрещенные символы
            string forbiddenChars = @"[\.,\?!\[\]\\\/]+";

            // Проверка на наличие запрещенных символов
            if (Regex.IsMatch(input, forbiddenChars))
            {
                MessageBox.Show("Логин и пароль не могут содержать запрещенные символы.");
                return false;
            }

            // Разрешаем все остальные символы
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RedgPwdRepit_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegPwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
