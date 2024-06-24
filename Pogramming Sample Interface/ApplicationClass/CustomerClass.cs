using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pogramming_Sample_Interface.CommonClass;
using System.Windows.Forms;

namespace Pogramming_Sample_Interface
{
    internal class CustomerClass:DatabaseClass
    {
        public String Customer_ID, Name;
        public DataGridView dataGridView;


        public void delete()
        {
            String VehicleType_Delete = "DELETE From Customer WHERE Customer_ID ='" + Customer_ID + "'";
            if (executeQuery(VehicleType_Delete, functionType.delete))
            {
                view();
            }
        }

        public void view()
        {
            string sql = "select * from Customer";
            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }

    }
}


