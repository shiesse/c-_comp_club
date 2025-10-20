using katharsis_code.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace katharsis_code
{
    public partial class FormAuthorize : Form
    {
        public FormAuthorize()
        {
            InitializeComponent();
        }

        private void button_userLogin_Click(object sender, EventArgs e)
        {
            string login = textBox_login.Text;
            string password = textBox_password.Text;
           

            if(UserLogic.GetUser(login, password) != null)
            {
                this.Hide();
                FormMain form = new FormMain();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
    }
}
