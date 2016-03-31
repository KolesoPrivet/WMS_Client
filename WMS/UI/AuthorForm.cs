using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMS
{
    public partial class AuthorForm : Form
    {
        private string Login = "admin";
        private string Pass = "root";

        public AuthorForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string _login = txtbxForLogin.Text;
            string _pass = txtbxForPass.Text;

            if (Login == _login)
            {
                if (Pass == _pass)
                {
                    MessageBox.Show("Авторизация прошла успешно!");
                    (this.Owner as MainForm).btnRefreshDB.Enabled = true;
                   // (this.Owner as MainForm).AuthorMenu.Enabled = false;
                    this.Close();
                }
                else MessageBox.Show("Неверный логин и/или пароль!");
            }
            else MessageBox.Show("Неверный логин и/или пароль!");
        }
        private void checkBoxHidePass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHidePass.Checked)
                txtbxForPass.UseSystemPasswordChar = false;
            else
                txtbxForPass.UseSystemPasswordChar = true;
        }
    }
}
