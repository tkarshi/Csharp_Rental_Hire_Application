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
    internal class VehicleTypeClass:DatabaseClass
    {

        public String Vehicle_Type_ID;
        public String Per_Day, Per_Week, Per_Month;
        public String Vehicle_Name;

        public DataGridView dataGridView;

        VehicleTypeForm vehicleTyForm  = null;

        public VehicleTypeClass (VehicleTypeForm vehicleTypeForm)
        {

            vehicleTyForm  = vehicleTypeForm;
        }

        // Save Function which is created in Vehicle Type Class and applicaple in the Vehicle Form source code
        public void save()
        {

            String VehicleType_insert = "INSERT INTO Vehicle_Type VALUES('"  + Per_Day + "','" + Per_Week + "','" + Per_Month+"','"+Vehicle_Name+  "')";
            if (executeQuery(VehicleType_insert, functionType.insert))
            {
                view(); //view function for view the Vehicle Type table in the dataGridview of the Vehicle Type Form
            }
        }

        // Update Function which is created in Vehicle Type Class and applicaple in the Vehicle Form source code
        public void update()
        {
                
            String VehicleType_update = "UPDATE VehicLe_Type SET Per_Day = '"+Per_Day+"', Per_Week = '"+Per_Week+"', Per_Month = '"+Per_Month+ "', Vehicle_Name = '" + Vehicle_Name + "' WHERE Vehicle_Type_ID = '" + Vehicle_Type_ID+"'";
            if (executeQuery(VehicleType_update, functionType.update))
            {
                view(); //view function for view the Vehicle Type table in the dataGridview of the Vehicle Type Form
            }
        }

        public void delete()
        {
            String VehicleType_Delete = "DELETE From Vehicle_Type WHERE Vehicle_Type_ID ='" + Vehicle_Type_ID + "'";
            if (executeQuery(VehicleType_Delete, functionType.delete))
            {
                view();
            }
        }

        public void search(string Vehicle_Type_ID)
        {
            String sql = "SELECT*FROM Vehicle_Type WHERE Vehicle_Type_ID ='" + Vehicle_Type_ID + "'";

            string VehicleTyNo = vehicleTyForm.TypeVehicleTypeIDTextBox.Text;

            DataTable dt = getDataFromDatabase(sql);


            if (dt.Rows.Count > 0)
            {
                vehicleTyForm.VehicleTyIDTextBox.Text = dt.Rows[0]["Vehicle_Type_ID"].ToString();
                vehicleTyForm.PerDayTextBox.Text = dt.Rows[0]["Per_Day"].ToString();
                vehicleTyForm.PerWeekBox.Text = dt.Rows[0]["Per_Week"].ToString();
                vehicleTyForm.PerMonthTextBox .Text = dt.Rows[0]["Per_Month"].ToString();
                vehicleTyForm.VehicleNameTextBox .Text = dt.Rows[0]["Vehicle_Name"].ToString();
            }

            else
            {
                MessageBox.Show("Invalid Vehicle Type ID", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void view()
        {
            string sql = "select * from Vehicle_Type";
            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }

       
    }
}
