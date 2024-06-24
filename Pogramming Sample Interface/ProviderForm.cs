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
    public partial class ProviderForm : Form
    {
        ProviderClass provider = null;
        public ProviderForm()
        {
            InitializeComponent();

            provider = new ProviderClass(this);
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            Main_MenuForm mainMenu = new Main_MenuForm();
            this.Hide();
            mainMenu.Show();
        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            provider.dataGridView = ProviderGridView;
            provider.view();
        }
    }
}
