using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pogramming_Sample_Interface.CommonClass;
using System.Windows.Forms;
using System.Data;

namespace Pogramming_Sample_Interface
{
    internal class FineClass:DatabaseClass
    {
        public DataGridView dataGridView;
        public void view()
        {
            string sql = "select * from Fine";
            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }
    }
}
