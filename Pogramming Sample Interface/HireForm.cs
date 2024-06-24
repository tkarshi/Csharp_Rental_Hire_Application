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
    public partial class HireForm : Form
    {
        HireClass hire = new HireClass();
        public HireForm()
        {
            InitializeComponent();
        }

        
        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void MainMenuBtn_Click_1(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void HireForm_Load(object sender, EventArgs e)
        {
            hire.dataGridView = HireDataGridView;
            hire.view();
        }
    }
}
