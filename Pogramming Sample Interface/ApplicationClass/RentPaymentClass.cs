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
    internal class RentPaymentClass: DatabaseClass
    {
        //public String Rent_Payment_ID, Vehicle_Payment, Driver_Payment, Rent_Amount;
        //public String Date_and_Time, Rent_Number_fk;

       


        //-------------------------------------------
        // to access the form coding, when call the view function form's label have to accessable

        RentPaymentForm rentPayForm = null;

        // create constructer, send RentPaymentForm and assign form in rentPaymentForm

        // create constructer, send RentForm and assign form in rentForm


        public RentPaymentClass(RentPaymentForm rentPaymentForm)
        {
            // assign return from constructor as rentPaymentForm will be in my Form

            rentPayForm = rentPaymentForm;




        }

        //--------------------------------------------

        public void save()
        {

            String Vehicle_Payment = rentPayForm.VehiclePayTextBox.Text;
            String Rent_Number_fk = rentPayForm.RentNumberComboBox.Text;
            String Driver_Payment = rentPayForm.DriverPayTextBox.Text;
            String Date_and_Time = rentPayForm.DateAndTimeTextBox.Text;
            String Rent_Amount = rentPayForm.RentAmountTextBox.Text;

            String RentPayment_insert = "INSERT INTO Rent_Payment VALUES('" + Vehicle_Payment + "','" + Driver_Payment + "','"  + Date_and_Time + "','" + Rent_Number_fk + "','" + Rent_Amount + "')";
            if (executeQuery(RentPayment_insert, functionType.insert))
            {
                
            }
        }

        //public void update()
        //{
        //    String RentPayment_update = "Update Rent_Payment SET Vehicle_Payment = '" + Vehicle_Payment + "','" + Driver_Payment + "','" + Date_and_Time  +  " WHERE Vehicle_ID ='" + Rent_Payment_ID  + "'";
        //    if (executeQuery(RentPayment_update, functionType.update))
        //    {
        //        view();
        //    }
        //}

        //public void delete()
        //{
        //    String RentPayment_Delete = "DELETE From Vehicle WHERE Rent_Payment_ID ='" + Rent_Payment_ID + "'";
        //    if (executeQuery(RentPayment_Delete, functionType.delete))
        //    {
        //        view();
        //    }
        //}

       

      public void search(string Rent_Number)
       { 
         //Join query is used to gather the data from the different tables to calculate the Rent Callculation. In this query, Vehicle and the Vehicle Type Table Join for
         //Calculate the Vehcile Payment, Driver Table is Join for calculate the Driver Payment and the Customer Table is Join for reterived the Customer details of 
         //the particular Rent. 
           
         string sql = "Select*from Rent R Join Vehicle V on R.Vehicle_ID_fk = V.Vehicle_ID Join Vehicle_Type VT on V.Vehicle_Type_ID_fk = VT.Vehicle_Type_ID Join Driver D on R.Driver_ID_fk = D.Driver_ID Join Customer C on R.Customer_ID_fk = C.Customer_ID Where Rent_Number ='" + Rent_Number + "'";
            
         // assign the value which is entered in the "TypeRentNoTextBox" for "RentNo" variable. From this details of the Rent Number which is entered will gather from the Aybo Drive Database
            
         string RentNo = rentPayForm.TypeRentNoTextBox.Text;

         // This is the step gather data according to the Rent Number from the SQL
               
         rentPayForm.RentNumberComboBox.Text = RentNo;  //Rent Number which is stored in the "RentNo" variable, display in the Rent Number Combo Box

            DataTable dt = getDataFromDatabase(sql);

            //If the entered Rent Number is stored already in the Database, if statement will execute by reterived the information about the affected Rows Count

            if(dt.Rows.Count > 0)
            {
                // Here data will gather according to the JOIN query from the tables which are join in the JOIN query

                //"rentPayForm" is the object which is created for reterived the Rent Paymet Class Function 

                rentPayForm.vehicleIDLabel.Text = dt.Rows[0]["Vehicle_ID"].ToString();
                rentPayForm.vehicleNumberLabel.Text = dt.Rows[0]["Vehicle_Number"].ToString();
                rentPayForm.driverIDLabel.Text = dt.Rows[0]["Driver_ID"].ToString();
                rentPayForm.driverNameLabel.Text = dt.Rows[0]["Name"].ToString();
                rentPayForm.driverPaymentLabel.Text = dt.Rows[0]["Driver_Charge"].ToString();
                rentPayForm.vehicleTyIDLabel.Text = dt.Rows[0]["Vehicle_Type_ID"].ToString();
                rentPayForm.vehicleNameLabel.Text = dt.Rows[0]["Vehicle_Name"].ToString();             
                rentPayForm.PerDayLabel.Text = dt.Rows[0]["Per_Day"].ToString();
                rentPayForm.PerWeekLabel.Text = dt.Rows[0]["Per_Week"].ToString();
                rentPayForm.PerMonthLabel.Text = dt.Rows[0]["Per_Month"].ToString();
                rentPayForm.StartDateLabel.Text = dt.Rows[0]["Start_Date"].ToString();
                rentPayForm.EndDateLabel.Text = dt.Rows[0]["End_Date"].ToString();
                rentPayForm.rentTypeLabel.Text = dt.Rows[0]["Rent_Type"].ToString();
                rentPayForm.rentNoLabel.Text = dt.Rows[0]["Rent_Number"].ToString();
                rentPayForm.bookingDateLabel.Text = dt.Rows[0]["Booking_Date"].ToString();
                rentPayForm.customerIDLabel.Text = dt.Rows[0]["Customer_ID"].ToString();
                rentPayForm.customerNameLabel.Text = dt.Rows[0]["Name"].ToString();
                rentPayForm.contactNoLabel.Text = dt.Rows[0]["Contact_Number"].ToString();

               

                // Calculate the Total Days count. Start Date value will receive from the "StartDateLabel" as the text format and it will convert to the DateTime format and store in the 
                // "startDate" variable same as for End Date and store the conver value in the "endDate"

                DateTime startDate = Convert.ToDateTime(rentPayForm.StartDateLabel.Text);
                DateTime endDate = Convert.ToDateTime(rentPayForm.EndDateLabel.Text);

                //Subtract the startDate from the endDate and the value will store as the integer type in the "totalDays" variable
                int totalDays = (endDate - startDate).Days; 

                //the integer type variable "totalDays" will convert to String type and display in the "totalDaysLabel" 

                this.rentPayForm.totalDaysLabel.Text = totalDays.ToString();
               
                //This is the Calcualte function where the Rent Payment Calculation is created. By calling this function, Rent Payment Calculation will execute

                Calculate();
            }

            // If the enter Rent Number is invalid that means it cannot exist, else statement will execute

            else
            { 
                //Message Box will shows the Rent Number is invalid

                MessageBox.Show("Invalid Rent Number", "Warning Message", MessageBoxButtons.OK);
            }
             
        }

        // This is the Calculate function where the Rent Payment Calculation is created
        public void Calculate()
        {
            //Declare the variables and convert the variables in the Integer format. When use the arithmetic operator Integer Format is help for maitain the accuracy value for the variables

            // data will receive from the label as text format and convert into the Integer format and store in the variables

            int TotalDays = Convert.ToInt32(this.rentPayForm.totalDaysLabel.Text);
            int PerDay = Convert.ToInt32(this.rentPayForm.PerDayLabel.Text);
            int PerWeek = Convert.ToInt32(this.rentPayForm.PerWeekLabel.Text);
            int PerMonth = Convert.ToInt32(this.rentPayForm.PerMonthLabel.Text);
            int DriverPayment = Convert.ToInt32(this.rentPayForm.driverPaymentLabel.Text);

            // Rent Type will receive as data for calculate the Rent Payment. From the "rentTypeLabel" , Rent Type will receive and store as String type in the "RentType"variable.

            string RentType = rentPayForm.rentTypeLabel.Text;

            //declare the variables which are use in the Calcuation

            int tempDays = TotalDays;
            int month = 0;
            int week = 0;
            int days = 0;

            double Driver_Amount, Rent_Amount, Vehicle_Amount = 0;                //double data type is used for store the large amount of numeric value data


            if (tempDays >= 30)              //if the "tempDays" contained more than 30 or equal to 30 this condition will execute
            { 

                month = tempDays / 30;      //Calculation of month count. Divide by 30 

                tempDays -= month * 30;     //Sbtract the month multiplication by the 30 value from the "tempDays" .
                                            //Multiplication is used to calculate the number of days contained by the "month" variable
            }
            if (tempDays >= 7)              //if the "tempDays" contained more than 7 or equal to 7 this condition will execute
            {
                week = tempDays / 7;        //Calculation of week count. Dividing by 7

                tempDays -= week * 7;       //Sbtract the week multiplication by the 7 value from the "tempDays". 
                                            //Multiplication is used to calculate the number of days contained by the "week" variable
            }

            //"tempDays" value wil assign for "days"variable
            //
            days = tempDays;  

            //Calculation for Vehicle Amount. The value of calculation will store in the "Vehicle_Amount" variable

            Vehicle_Amount = month * PerMonth + week * PerWeek + days * PerDay;

            //If the "RentType" variable contain "WithDriver" value, this if statement will execute

            if(RentType == "WithDriver")
            {
               //Driver Amount Calculation. Multiply the value of "days" variable and the "DriverPayment" which is reterived from the database in the driver table

                Driver_Amount = days * DriverPayment;  

               //Rent_Amount calculation. The Total Rent Amount is adding vehicle amount form the "Vehicle_Amount" variable and driver amount form the "Driver_Amount"variable.
               //Addition value will store in the "Rent_Amount"

                 Rent_Amount = Vehicle_Amount + Driver_Amount;

                String totalDriverPayLabel = Driver_Amount.ToString();         //"Driver_Amount" value is convert ToString format and store in the "totalDriverPayLabel"

                rentPayForm.totalDriverPayLabel.Text = totalDriverPayLabel;    // "totalDriverPayLabel" value will display in the Form in totalDriverPayLabel.

                rentPayForm.DriverPayTextBox.Text = totalDriverPayLabel;
            }
            else //If the "Rent Type" check condition is false else statement will execute
            {
                //Rent Amount will calculate without Driver Payment and only Vehicle amount is applicable. "Vehicle_Amount" variable value is assign for "Rent_Amount"variable

                Rent_Amount = Vehicle_Amount; 
               
            }

            String vehiclePayLabel = Vehicle_Amount.ToString(); //"Vehicle_Amount" value is convert ToString format and store in the "vehiclePayLabel"

            rentPayForm.vehiclePayLabel.Text = vehiclePayLabel; // "vehiclePayLabel" value will display in the Form in vehiclePayLabel.
            rentPayForm.VehiclePayTextBox.Text = vehiclePayLabel; // "vehiclePayLabel" value will display in the Form in VehiclePayTextBox. 


            String TotalAmountTextBox = Rent_Amount.ToString(); //"Rent_Amount" value is convert ToString format and store in the "TotalAmountTextBox"

            rentPayForm.TotalAmountTextBox.Text = TotalAmountTextBox; //"TotalAmountTextBox" value will display in the Form TotalAmount Text Box.

            rentPayForm.RentAmountTextBox.Text = TotalAmountTextBox;  //"TotalAmountTextBox" value will display in the Form RentAmount Text Box.

        }

        //This is the function for calculate the Balance Amount of Rent Payment
        public void Balance()
        {

          //Intial Amount TextBox value, Rent Amount Text Box value are convert to double format from string type. Because for the arithmetic calculation string type is not applicable. 
          //The converting values are store in the "Intial_Amount" and "Rebnt_Amount"

            double Intial_Amount = Convert.ToDouble(this.rentPayForm.InitialAmountTextBox.Text);
            double Rent_Amount = Convert.ToDouble(this.rentPayForm.TotalAmountTextBox.Text);

                double Balance = Rent_Amount - Intial_Amount; //Subtract the Intial Amount from the Rent Amount, Balance Amount will calculate

                String BalanceAmountTextBox = Balance.ToString();      //"Balance" value is convert ToString format and store in the "BalanceAmountTextBox"
                                                                       
            rentPayForm.BalanceAmountTextBox.Text = BalanceAmountTextBox;   //"BalanceAmountTextBox" value will display in the Form BalanceAmount Text Box.
        }
      
        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Rent";           
            LoadforeignkeyInComboBox(sql, comboBox, "Rent_Number");
        }

    }
}
