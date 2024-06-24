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
    public partial class BillHireForm : Form
    {
        HireBillClass hireBill = null;
        public BillHireForm()
        {
            InitializeComponent();
            hireBill = new HireBillClass(this);
        }

        private void BillHireForm_Load(object sender, EventArgs e)
        {
            hireBillGroupbox.Enabled = false;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            hireBill.Search(TypeHirePayNoTextBox.Text);
            SearchGroupBox.Hide();
            hireBillGroupbox.Enabled = true;
        }
    }
}
