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
    public partial class DriverMenu : Form
    {
        public DriverMenu()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void DriverBtn_Click(object sender, EventArgs e)
        {
            DriverForm driver = new DriverForm();
            this.Hide();
            driver.Show();
        }

        private void MedicalBtn_Click(object sender, EventArgs e)
        {
            MedicalForm medical = new MedicalForm();
            this.Hide();
            medical.Show();
        }

        private void FineBtn_Click(object sender, EventArgs e)
        {
            FineForm fine = new FineForm();
            this.Hide();
            fine.Show(); 
        }
    }
}
