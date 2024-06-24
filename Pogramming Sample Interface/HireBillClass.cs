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
    internal class HireBillClass: DatabaseClass
    {
        BillHireForm billHireForm = null;

        public String Hire_Payment_Number;

        public HireBillClass(BillHireForm billHire)
        {
            billHireForm = billHire;
        }

        public void Search(String Hire_Payment_Number)
        {
            String sql = "Select*From Hire_Payment Where Hire_Payment_Number = '" + Hire_Payment_Number + "'";

            String HirePayNo = billHireForm.TypeHirePayNoTextBox.Text;

            DataTable dt = getDataFromDatabase(sql);


            if (dt.Rows.Count > 0)
            {
                billHireForm.HirePayNo.Text = dt.Rows[0]["Hire_Payment_Number"].ToString();
                billHireForm.HireNo.Text = dt.Rows[0]["Hire_Number_fk"].ToString();
                billHireForm.BasicCharge.Text = dt.Rows[0]["Basic_Charge"].ToString();
                billHireForm.DateTime.Text = dt.Rows[0]["Date_and_Time"].ToString();
                billHireForm.WaitingCharge.Text = dt.Rows[0]["Waiting_Charge"].ToString();
                billHireForm.Driverovernightcharge.Text = dt.Rows[0]["Driver_Over_Night_Charge"].ToString();
                billHireForm.ExkmCharge.Text = dt.Rows[0]["Extra_km_Payment"].ToString();
                billHireForm.Vehiclenightparkcharge.Text = dt.Rows[0]["Vehicle_Night_Park"].ToString();
                billHireForm.HireAmount.Text = dt.Rows[0]["Hire_Amount"].ToString();
            }
        }
    }
}
