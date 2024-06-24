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
    public partial class InsuranceForm : Form
    {
        InsuranceClass insurance = null;
        public InsuranceForm()
        {
            InitializeComponent();
            insurance = new InsuranceClass(this);
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void InsuranceForm_Load(object sender, EventArgs e)
        {
            insurance.dataGridView = InsuranceGridView;
            insurance.view();
            
        }
    }
}
