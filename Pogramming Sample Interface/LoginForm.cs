using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pogramming_Sample_Interface
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            String userName = UsernameTextBox.Text;
            String password = PasswordTextBox.Text;

            if (userName == "admin@AyuboDrive" && password == "AD3104")
            {
                MessageBox.Show("Successfully Login Welcome to Ayubo Drive", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Main_MenuForm mainMenu = new Main_MenuForm();
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Login Not Success, Check your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
