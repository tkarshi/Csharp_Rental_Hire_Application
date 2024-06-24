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
    public partial class FineForm : Form
    {
        FineClass fine = new FineClass();
        public FineForm()
        {
            InitializeComponent();
        }

        private void DriverMenuBtn_Click(object sender, EventArgs e)
        {
            DriverMenu driver = new DriverMenu();
            this.Hide();
            driver.Show();
                
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void FineForm_Load(object sender, EventArgs e)
        {
            fine.dataGridView = FineGridView;
            fine.view();
        }
    }
}
