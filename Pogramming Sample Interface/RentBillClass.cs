using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Pogramming_Sample_Interface.CommonClass;
using System.Windows.Forms;


namespace Pogramming_Sample_Interface
{
    internal class RentBillClass: DatabaseClass
    {
        BillRentForm billRentForm = null;

        public  String Rent_Payment_Number;

        public RentBillClass(BillRentForm bill_RentForm)
        {

            billRentForm = bill_RentForm;
        }

        public void Search(String Rent_Payment_Number)
        {
            String sql = "Select*From Rent_Payment Where Rent_Payment_Number = '" + Rent_Payment_Number + "'";

            String RentPayNo = billRentForm.TypeRentPayNoTextBox.Text;

            DataTable dt = getDataFromDatabase(sql);

            if (dt.Rows.Count > 0)
            {
                billRentForm.RenPayNo.Text = dt.Rows[0]["Rent_Payment_Number"].ToString();
                billRentForm.RentNo .Text = dt.Rows[0]["Rent_Number_fk"].ToString();
                billRentForm.VehiclePayment.Text = dt.Rows[0]["Vehicle_Payment"].ToString();
                billRentForm.RentAmount.Text = dt.Rows[0]["Rent_Amount"].ToString();
                billRentForm.DriverPayment.Text = dt.Rows[0]["Driver_Payment"].ToString();
                billRentForm.DateTime.Text = dt.Rows[0]["Date_and_Time"].ToString();
            }
        }
    }
}
