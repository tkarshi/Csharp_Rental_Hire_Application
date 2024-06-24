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
    internal class RentClass: DatabaseClass
    {
        public String Rent_Number, Driver_Option, Booking_Date;
        public String Start_Date, End_Date;

        public DataGridView dataGridView;


        public void save()
        {
            String Rent_insert = "INSERT INTO Rent VALUES('" + Rent_Number + "','" + Driver_Option + "','" + Booking_Date + "','" + Start_Date + "','" + End_Date + "')";
            if (executeQuery(Rent_insert, functionType.insert))
            {

            }
        }

        public void update()
        {
            String Rent_update = "Update Rent SET Driver_Option = '" + Driver_Option + "','" + Booking_Date + "','" + Start_Date + "','" + End_Date + " WHERE Rent_Number ='" + Rent_Number + "'";
            if (executeQuery(Rent_update, functionType.update))
            {
                view();
            }
        }
        public void delete()
        {
            String Rent_Delete = "DELETE From Rent WHERE Rent_Number ='" + Rent_Number + "'";
            if (executeQuery(Rent_Delete, functionType.delete))
            {
                view();
            }
        }

        public void view()
        {
            string sql = "select * from Rent";
            LoadDataFromDatabaseInGridView(sql, dataGridView);
        }
    }
}
