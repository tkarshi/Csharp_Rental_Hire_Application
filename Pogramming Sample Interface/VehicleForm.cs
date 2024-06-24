using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pogramming_Sample_Interface;
using Pogramming_Sample_Interface.ApplicationClass;

namespace Pogramming_Sample_Interface
{
    public partial class VehicleForm : Form
    {

        VehicleClass vehicle = null;
     
        public VehicleForm()
        {
            InitializeComponent();

            vehicle = new VehicleClass(this);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            vehicle.save();
            VeTyIdComboBox.SelectedValue.ToString();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            vehicle.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            vehicle.delete();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            vehicle.Loadforeignkey(VeTyIdComboBox);
            vehicle.dataGridView = VehicleGridView;
            vehicle.view();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void VehicleIDTextBox_TextChanged_1(object sender, EventArgs e)
        {
            vehicle.Vehicle_ID = VehicleIDTextBox.Text;
        }

        private void VehicleNumTextBox_TextChanged_1(object sender, EventArgs e)
        {
            vehicle.Vehicle_Number = VehicleNumTextBox.Text;
        }

        private void VehicleLicenBox_TextChanged(object sender, EventArgs e)
        {
            vehicle.Vehicle_License = VehicleLicenBox.Text;
        }

        private void VehicleRegNoTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicle.Vehicle_Registration_Number = VehicleRegNoTextBox.Text;
        }

        private void LastkmReTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicle.Last_km_Reading = LastkmReTextBox.Text;
        }

        private void startkmReadTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicle.Start_km_Reading = startkmReadTextBox.Text;
        }

        private void RenewalTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicle.Renewal_Date = RenewalTextBox.Text;
        }

        private void VeTyIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicle.Vehicle_Type_ID = VeTyIdComboBox.Text;
        }

        private void TypeVechicleIDTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicle.Vehicle_Type_ID = TypeVechicleIDTextBox.Text;
        }
    }
}
