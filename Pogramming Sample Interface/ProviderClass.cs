using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Pogramming_Sample_Interface.CommonClass;

namespace Pogramming_Sample_Interface
{
    internal class ProviderClass: DatabaseClass
    {
        public DataGridView dataGridView;

        ProviderForm  providerForm = null;
        public ProviderClass(ProviderForm provider_Form)
        {
            providerForm = provider_Form;
        }
        public void view()
        {
            string sql = "select * from Provider"; //Select query for view the Vehicle Table from the Database

            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }

    }
}
