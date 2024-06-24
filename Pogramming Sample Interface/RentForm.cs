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
    public partial class RentForm : Form
    {
        RentClass rent = new RentClass();


        public RentForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void RentNoSearchBtn_Click(object sender, EventArgs e)
        {
            String SQL = "Select*from Rent Join Vehicle on Rent.Vehicle_ID_fk = Vehicle.Vehicle_ID Join Vehicle_Type on Vehicle.Vehicle_Type_ID_fk = Vehicle_Type.Vehicle_Type_ID Join Driver on Rent.Driver_ID_fk = Driver.Driver_ID ";
        }

        private void RentForm_Load(object sender, EventArgs e)
        {
            rent.dataGridView = RentDataGridView;
            rent.view();
        }
    }
}
