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
    public partial class CustomerForm : Form
    {
        CustomerClass customer = new CustomerClass();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            customer.delete();
            customer.view ();
        }

        private void CustomerIDTextBox_TextChanged(object sender, EventArgs e)
        {
            customer.Customer_ID  = CustomerIDTextBox.Text;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customer.dataGridView = CustomerGridView;
            customer.view();
        }
    }
}
