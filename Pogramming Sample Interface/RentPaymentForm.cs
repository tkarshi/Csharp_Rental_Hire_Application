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
    public partial class RentPaymentForm : Form
    {
        RentPaymentClass rentPayment = null;
        public RentPaymentForm()
        {
            InitializeComponent();
            rentPayment = new RentPaymentClass(this);
        }

        private void RentPaymentForm_Load(object sender, EventArgs e)
        {
            rentPayment .Loadforeignkey(RentNumberComboBox);
            //rentPayment.dataGridView = RentPayGridView;
            //rentPayment.view();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            rentPayment.save();
            RentNumberComboBox .SelectedValue.ToString();
        }

      
        private void RentPayNoSearchBtn_Click(object sender, EventArgs e)
        {
            rentPayment.search(TypeRentNoTextBox.Text);

        }

        private void BalanceBtn_Click(object sender, EventArgs e)
        {
            rentPayment.Balance();
        }
    }
}
