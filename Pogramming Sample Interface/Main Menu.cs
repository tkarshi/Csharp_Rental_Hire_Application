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
    public partial class Main_MenuForm : Form
    {
        public Main_MenuForm()
        {
            InitializeComponent();
        }

        private void HireFormBtn_Click(object sender, EventArgs e)
        {
            HireForm hire = new HireForm();
            this.Hide();
            hire.Show();
        }

        private void HirePayFormBtn_Click(object sender, EventArgs e)
        {
            HirePaymentForm hirePay = new HirePaymentForm();
            this.Hide();
            hirePay.Show();
        }

        private void RentFormBtn_Click(object sender, EventArgs e)
        {
            RentForm rent = new RentForm();
            this.Hide();
            rent.Show();
        }

        private void RentPayFormBtn_Click(object sender, EventArgs e)
        {
            RentPaymentForm rentPayment = new RentPaymentForm();
            this.Hide();
            rentPayment.Show();
        }

        private void CustomerFormBtn_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            this.Hide();
            customer.Show();
        }

        private void ProviderFormBtn_Click(object sender, EventArgs e)
        {
            ProviderForm provider = new ProviderForm();
            this.Hide();
            provider.Show();
        }

        private void RentBill_Click(object sender, EventArgs e)
        {
            BillRentForm rentBill = new BillRentForm();
            this.Hide();
            rentBill.Show();
        }

        private void HireBill_Click(object sender, EventArgs e)
        {
            BillHireForm hireBill = new BillHireForm();
            this.Hide();
            hireBill.Show();
        }

        private void InsuranceFormBtn_Click(object sender, EventArgs e)
        {
            InsuranceForm insurance = new InsuranceForm();
            this.Hide();
            insurance.Show();
        }

        private void DriverFormBtn_Click(object sender, EventArgs e)
        {
            DriverForm driver = new DriverForm();
            this.Hide();
            driver.Show();
        }

        private void MedicalFormBtn_Click(object sender, EventArgs e)
        {
            MedicalForm medical = new MedicalForm();
            this.Hide();
            medical.Show();
        }

        private void FineFormBtn_Click(object sender, EventArgs e)
        {
            FineForm fine = new FineForm();
            this.Hide();
            fine.Show();
        }

        private void VehicleTypeFormBtn_Click(object sender, EventArgs e)
        {
            VehicleTypeForm vehicleType = new VehicleTypeForm();
            this.Hide();
            vehicleType.Show();
        }

        private void VehicleFormBtn_Click(object sender, EventArgs e)
        {
            VehicleForm vehicle = new VehicleForm();
            this.Hide();
            vehicle.Show();
        }
    }
}
