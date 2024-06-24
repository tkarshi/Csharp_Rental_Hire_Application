using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pogramming_Sample_Interface.CommonClass;
using System.Windows.Forms;
using System.Data;

namespace Pogramming_Sample_Interface.ApplicationClass
{
    internal class VehicleClass:DatabaseClass 
    {

        public String  Vehicle_License;
        public String  Vehicle_Number, Vehicle_Registration_Number, Renewal_Date, Start_km_Reading, Last_km_Reading;
        public String Vehicle_Type_ID;
        public String Vehicle_ID;

        public DataGridView dataGridView;


        VehicleForm vehicleForm = null;

        public VehicleClass(VehicleForm vehicleform)
        {

            vehicleForm = vehicleform;
        }

        public void save()
        {

            String Vehicle_insert = "INSERT INTO Vehicle VALUES('" + Vehicle_License + "','" + Vehicle_Number + "','" + Vehicle_Registration_Number + "','" + Renewal_Date + "','"+ Start_km_Reading + "','" + Last_km_Reading + "')";
           if(executeQuery(Vehicle_insert, functionType.insert))
            {
                view();
            }
        }

        public void update()
        {
            String Vehicle_update = "Update Vehicle SET Vehicle_Number = '"+ Vehicle_Number+"','"+ Vehicle_License+"','"+Vehicle_Registration_Number+"','"+Start_km_Reading+"','"+Last_km_Reading+"','"+Renewal_Date+" WHERE Vehicle_ID ='"+Vehicle_ID+"'";
            if(executeQuery(Vehicle_update, functionType.update))
            {
                view();
            }
        }

        //Delete Function which is created in the Vehicle Class for execute the delete function on the Vehicle Table
        public void delete()
        {
            String Vehicle_Delete = "DELETE From Vehicle WHERE Vehicle_ID = '" + Vehicle_ID + "'";
            if(executeQuery(Vehicle_Delete, functionType.delete))
            {
                view();
            }
        }

        //view function for view the Vehicle Table in the DataGridview of the Vehicle Form
        public void view()
        {

            string sql = "select * from Vehicle"; //Select query for view the Vehicle Table from the Database

            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }

        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Vehicle_Type";
            LoadforeignkeyInComboBox(sql, comboBox, "Vehicle_Type_ID", "Vehicle_Name");
        }
    }
}
