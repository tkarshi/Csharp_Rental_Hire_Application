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
    public partial class MedicalForm : Form
    {
        MedicalClass medical = new MedicalClass();
        public MedicalForm()
        {
            InitializeComponent();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {

        }

        private void MedicalForm_Load(object sender, EventArgs e)
        {
            medical.dataGridView = MedicalGridView;
            medical.view();
        }
    }
}
