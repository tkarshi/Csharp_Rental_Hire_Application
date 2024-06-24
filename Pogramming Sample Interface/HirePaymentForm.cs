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
    public partial class HirePaymentForm : Form
    {

        HirePaymentClass hirePayment = null;
        public HirePaymentForm()
        {
            InitializeComponent();
            hirePayment = new HirePaymentClass(this);
        }

           
        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            hirePayment.Balance();
        }

        private void MainMenuBtn_Click_1(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            hirePayment.save();
        }

        private void HirePaymentForm_Load(object sender, EventArgs e)
        {
            hirePayment.Loadforeignkey(HireNocomboBox);
        }

        private void BasicChargeTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Basic_Charge = BasicChargeTextBox.Text;
        }

        private void WaitingChargeTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Waiting_Charge = WaitingChargeTextBox.Text;
        }

        private void DateAndTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Date_and_Time = DateAndTimeTextBox.Text;
        }

        private void DriOverNtChargeTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Driver_Over_Night_Charge = DriOverNtChargeTextBox.Text;
        }

        private void ExKmPayTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Extra_km_Payment = ExKmPayTextBox.Text;
        }

        private void VehiNtParkTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Vehicle_Night_Park = VehiNtParkTextBox.Text;
        }

        private void HireNocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hirePayment.Hire_Number_fk = HireNocomboBox.Text;
        }

        private void HirePayNoTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Hire_Payment_Number = HirePayNoTextBox.Text;
        }

        private void HireAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            hirePayment.Hire_Amount = HireAmountTextBox.Text;
        }

        private void HireNumSearchBtn_Click_1(object sender, EventArgs e)
        {
            hirePayment.Search(TypeHireNumTextBox.Text);
        }
    }
}
