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
    public partial class DriverForm : Form
    {
        DriverClass driver = new DriverClass();
        public DriverForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void DriverForm_Load(object sender, EventArgs e)
        {
            driver.dataGridView = DriverGridView;
            driver.view();
        }
    }
}
