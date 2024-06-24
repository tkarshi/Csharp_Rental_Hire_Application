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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void VechMenuBtn_Click(object sender, EventArgs e)
        {
            VehicleMenuForm vechicleMenu = new VehicleMenuForm();
            this.Hide();
            vechicleMenu.Show();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void HireMenuBtn_Click(object sender, EventArgs e)
        {
            HireMenuForm hireMenu = new HireMenuForm();
            this.Hide();
            hireMenu.Show();
        }

        private void RentMenuBtn_Click(object sender, EventArgs e)
        {
            RentMenu rentMenu = new RentMenu();
            this.Hide();
            rentMenu.Show();
        }

        private void CusMenuBtn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void DriverMenuBtn_Click(object sender, EventArgs e)
        {
            DriverMenu driverMenu = new DriverMenu();
            this.Hide();
            driverMenu.Show();
        }
    }
}
