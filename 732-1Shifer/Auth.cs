using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _732_1Shifer
{
    public partial class Auth : Form
    {
        private bool _isAuthenticated = false;

        public Auth()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void GoReg_Click(object sender, EventArgs e)
        {
            Reg reg_form = new Reg();
            reg_form.ShowDialog();
        }

        private void AuthPwd_TextChanged(object sender, EventArgs e)
        {
        }

        private void MakeAuth_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("C:\\BASE\\732SHIFER.db");
            if (dBManager.AuthUser(Login.Text, AuthPwd.Text))
            {
                _isAuthenticated = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("Ошибка в логине или пароле!");
            }
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
        }

        private void Auth_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false)
                Application.Exit();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
        }
    }
}
