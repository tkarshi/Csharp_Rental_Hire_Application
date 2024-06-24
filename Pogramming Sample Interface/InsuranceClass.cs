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
    internal class InsuranceClass:DatabaseClass
    {
        public DataGridView dataGridView;

        InsuranceForm insuranceForm = null;
       public InsuranceClass(InsuranceForm insurance_Form)
        {
            insuranceForm = insurance_Form;
        }
        public void view()
        {
            string sql = "select * from Insurance"; //Select query for view the Vehicle Table from the Database

            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }
    }
}
