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
    public partial class VehicleMenuForm : Form
    {
        public VehicleMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
        }

        private void VechicleMenu_Load(object sender, EventArgs e)
        {

        }

        private void VehicleBtn_Click(object sender, EventArgs e)
        {
            VehicleForm vehicle = new VehicleForm();
            this.Hide();
            vehicle.Show();
        }

        private void VehiTypeBtn_Click(object sender, EventArgs e)
        {
            VehicleTypeForm vehicleTypeForm = new VehicleTypeForm();
            this.Hide();
            vehicleTypeForm.Show();
        }

        private void InsuranceBtn_Click(object sender, EventArgs e)
        {
            InsuranceForm insuranceForm = new InsuranceForm();
            this.Hide();
            insuranceForm.Show();
        }

        private void ProviderBtn_Click(object sender, EventArgs e)
        {
            ProviderForm providerForm = new ProviderForm();
            this.Hide();
            providerForm.Show();
                
        }
    }
}
