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
    public partial class BillRentForm : Form
    {
        RentBillClass rentBill = null;
        public BillRentForm()
        {
            InitializeComponent();
            rentBill = new RentBillClass(this);
        }

        private void RentPayNoSearchBtn_Click(object sender, EventArgs e)
        {
            rentBill.Search(TypeRentPayNoTextBox.Text);
            RentBillGroupBox.Enabled = true;
            SearchRentPayGroupBox.Hide();
         }

        private void BillRentForm_Load(object sender, EventArgs e)
        {
            RentBillGroupBox.Enabled = false;
        }
    }
}
