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
    
    public partial class RentMenu : Form
    {
       
        public RentMenu()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            
        }

        private void RentBtn_Click(object sender, EventArgs e)
        {
            RentForm rent = new RentForm();
            this.Hide();
            rent.Show();
        }

        private void RentPayBtn_Click(object sender, EventArgs e)
        {
            RentPaymentForm rentPayment = new RentPaymentForm();
            this.Hide();
            rentPayment.Show();
        }
    }
}
