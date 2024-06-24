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
    public partial class HireMenuForm : Form
    {
        public HireMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void HireBtn_Click(object sender, EventArgs e)
        {
            HireForm hire = new HireForm();
            this.Hide();
            hire.Show();
        }

        private void HirePayBtn_Click(object sender, EventArgs e)
        {
            HirePaymentForm hirePay = new HirePaymentForm();
            this.Hide();
            hirePay.Show();
        }
    }
}
