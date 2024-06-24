using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pogramming_Sample_Interface.ApplicationClass;

namespace Pogramming_Sample_Interface
{
    public partial class VehicleTypeForm : Form
    {
        VehicleTypeClass vehicleType = null;


        public VehicleTypeForm()
        {
            InitializeComponent();

            vehicleType = new VehicleTypeClass(this);
        }
        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        //When Click the Save Button in the Vehicle Type Form, this Save Button Click Function will execute
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            // This statement is implement for if minimum one column is empty save function not be execute
            if ( PerDayTextBox.Text == "" || PerWeekBox.Text == "" || PerMonthTextBox.Text == "" )
            {
                //When the statement is true that means, not every column will fill with data,
                //message box shows the data is not valid

                MessageBox.Show("Insert data not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //if the if statement is false else statement will execute and the save function will execute
            {
                vehicleType.save(); //this is the save function which is created in the Vehicle Type Class               
            }
        
        }

        //When Click the Update Button in the Vehicle Type Form, this Save Button Click Function will execute
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //this is the update function which is created in the Vehicle Type Class     

            vehicleType.update();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            vehicleType.delete();
        }

        private void VehicleTypeForm_Load(object sender, EventArgs e)
        {
            vehicleType.dataGridView = VehicleTypeGridView ;
            vehicleType.view();


        }

        private void ClearTextBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to clear the text in text boxes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                VehicleTyIDTextBox .Clear();
                PerDayTextBox.Clear();
                PerWeekBox.Clear();
                PerMonthTextBox.Clear();
                VehicleNameTextBox.Clear();

            }
            else
            {

            }
        }

        private void VehicleTyIDTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicleType.Vehicle_Type_ID = VehicleTyIDTextBox.Text;
        }

        private void PerDayTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicleType.Per_Day = PerDayTextBox.Text;
        }

        private void PerWeekBox_TextChanged(object sender, EventArgs e)
        {
            vehicleType.Per_Week = PerWeekBox.Text;
        }

        private void PerMonthTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicleType.Per_Month = PerMonthTextBox.Text;
        }

        private void VehicleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            vehicleType.Vehicle_Name = VehicleNameTextBox.Text;
        }

        private void VechicleSearchBtn_Click(object sender, EventArgs e)
        {
            vehicleType.search(TypeVehicleTypeIDTextBox.Text);
            vehicleType.view();
        }
    }
}
