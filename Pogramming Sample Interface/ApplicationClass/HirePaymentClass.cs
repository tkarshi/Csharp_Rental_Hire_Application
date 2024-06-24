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
    internal class HirePaymentClass: DatabaseClass
    {
        public String Hire_Payment_Number, Basic_Charge, Waiting_Charge, Driver_Over_Night_Charge;
        public String Date_and_Time, Extra_km_Payment, Vehicle_Night_Park, Hire_Number_fk, Hire_Amount;

        HirePaymentForm hirePayForm = null;

        public HirePaymentClass(HirePaymentForm hirePaymentForm)
        {

            hirePayForm = hirePaymentForm;
        }

        public void save()
        {

            String HirePayment_insert = "INSERT INTO Hire_Payment VALUES('" + Basic_Charge + "','" + Waiting_Charge + "','" + Driver_Over_Night_Charge + "','" + Date_and_Time + "','" + Extra_km_Payment + "','" + Vehicle_Night_Park + "','" + Hire_Number_fk + "','" + Hire_Amount + "')";
            if (executeQuery(HirePayment_insert, functionType.insert))
            {

            }
        }

        public void Search(string Hire_Number)
        {
            //Join query is used to gather the data from the different tables to calculate the Hire Amount. 
            //In this query, Hire Package Table Join for reterived Basic Charge based on the Hire Package 
            //Vehicle and the Vehicle Type Table Join for Calculate the Vehcile nightpark Payment,
            //Driver Table is Join for calculate the Driver overnight Payment 
            //and the Customer Table is Join for reterived the Customer details of the particular Hire. 

            string sql = "Select*from Hire H Join Vehicle V on H.Vehicle_ID_fk = V.Vehicle_ID Join Vehicle_Type VT on V.Vehicle_Type_ID_fk = VT.Vehicle_Type_ID Join Hire_Package HP on H.HirePackage_ID_fk = HP.HirePackage_ID Join Driver D on H.Driver_ID_fk = D.Driver_ID Where Hire_Number = '" + Hire_Number +"'";

            // assign the value which is entered in the "TypeHireNumTextBox" for "HirePayNo" variable.
            // From this details of the Hire Number which is entered will gather from the Aybo Drive Database

            string HirePayNo = hirePayForm.TypeHireNumTextBox.Text;

            //This is the step to load the Hire Number in the Combo Box which is in the Hire Payment Form
            //Hire Number is a foreignkey in the Hire Payment Table 

            hirePayForm.HireNocomboBox.Text = HirePayNo;

            DataTable dt = getDataFromDatabase(sql);   // This is the step gather data according to the Hire Number from the SQL

            //If the entered Hire Number is stored already in the Database, if statement will execute by reterived the information about the affected Rows Count

            if (dt.Rows.Count > 0)
            {
                // Data will reteriverd according to the JOIN query from the tables which are join in the JOIN query based on the Hire Number

                //"hirePayForm" is the object which is created for reterived the Hire Paymet Class Function 

                hirePayForm.hireNumberLabel.Text = dt.Rows[0]["Hire_Number"].ToString();
                hirePayForm.vehicleIDLabel.Text = dt.Rows[0]["Vehicle_ID"].ToString();
                hirePayForm.vehicleNumberLabel.Text = dt.Rows[0]["Vehicle_Number"].ToString();
                hirePayForm.perDayLabel.Text = dt.Rows[0]["Per_Day"].ToString();
                hirePayForm.hirePackageIDLabel.Text = dt.Rows[0]["HirePackage_ID"].ToString();
                hirePayForm.hirePackageTyLabel.Text = dt.Rows[0]["Hire_Package_Type"].ToString();
                hirePayForm.tourTyLabel.Text = dt.Rows[0]["Tour_Type"].ToString();
                hirePayForm.startTimeLabel.Text = dt.Rows[0]["Start_Time"].ToString();
                hirePayForm.endTimeLabel.Text = dt.Rows[0]["End_Time"].ToString();
                hirePayForm.startKmReadLabel.Text = dt.Rows[0]["Start_km_Reading"].ToString();
                hirePayForm.endKmReadLabel.Text = dt.Rows[0]["End_km_Reading"].ToString();
                hirePayForm.exPerHourChargeLabel.Text = dt.Rows[0]["Extra_Per_Hour_Charge"].ToString();
                hirePayForm.exPerKmChargeLabel.Text = dt.Rows[0]["Extra_Per_km_Charge"].ToString();
                hirePayForm.maxkmLabel.Text = dt.Rows[0]["Maximum_km"].ToString();
                hirePayForm.maxHourLabel.Text = dt.Rows[0]["Maximum_Hours"].ToString();
                hirePayForm.basicChargeLabel.Text = dt.Rows[0]["Amount"].ToString();
                hirePayForm.startDateLabel.Text = dt.Rows[0]["Start_Date"].ToString();
                hirePayForm.endDateLabel.Text = dt.Rows[0]["End_Date"].ToString();
                hirePayForm.driverIDLabel.Text = dt.Rows[0]["Driver_ID"].ToString();
                hirePayForm.driverNameLabel.Text = dt.Rows[0]["Name"].ToString();
                hirePayForm.driverPaymentLabel.Text = dt.Rows[0]["Driver_Charge"].ToString();


               // Calculate the Total Hours count. Start Time value will receive from the "startTimeLabel" as the text format and it will convert to the DateTime format and store  
              // in the "startTime" variable same as for End Time and store the convert value in the "endDate"

               DateTime startTime = Convert.ToDateTime(hirePayForm.startTimeLabel.Text);
               DateTime endTime = Convert.ToDateTime(hirePayForm.endTimeLabel.Text);

               int totalHours = (endTime - startTime).Hours; //Subtract the startTime from the endTime and the value will store as the integer type in the "totalHours" variable

               this.hirePayForm.totalHoursLabel.Text = totalHours.ToString(); //the integer type variable "totalHours" will convert to String type and display in the "totalHoursLabel" 

                // Calculate the Total Days count. Start Date value will receive from the "startDateLabel" as the text format and it will convert to the DateTime format and store  
                // in the "startDate" variable same as for End Date and store the convert value in the "endDate"

                DateTime startDate = Convert.ToDateTime(hirePayForm.startDateLabel.Text);
                DateTime endDate = Convert.ToDateTime(hirePayForm.endDateLabel.Text);

                int totalDays = (endDate - startDate).Days; //Subtract the startDate from the endDate and the value will store as the integer type in the "totalDays" variable

                this.hirePayForm.totalDaysLabel.Text = totalDays.ToString(); //the integer type variable "totalDays" will convert to String type and display in the "totalDaysLabel" 

                // Calculate the Total km count. Start km value will receive from the "startKmReadLabel" as the text format and it will convert to the integer format and store  
                // in the "startkm" variable same as for End km and store the convert value in the "endDate"

                int startkm = Convert.ToInt32(hirePayForm.startKmReadLabel.Text);
                int endkm = Convert.ToInt32(hirePayForm.endKmReadLabel.Text);

                int totalkm = (endkm - startkm);  //Subtract the startkm from the endkm and the value will store as the integer type in the "totalHours" variable

                this.hirePayForm.totalKmLabel.Text = totalkm.ToString(); //the integer type variable "totalkm" will convert to String type and display in the "totalKmLabel" 

                //This is the Calcualte function where the Hire Payment Calculation is created. By calling this function, Hire Payment Calculation will execute 
                //based on the Tour Type the Hire Amount calculation will calculate

                calculate();
            
            }

            // If the enter Hire Number is invalid that means it cannot exist, else statement will execute

            else

            {
                //Message Box will shows the Hire Number which is entered in the Hire NumberSearch Box is invalid

                MessageBox.Show("Invalid Hire Number", "Warning Message", MessageBoxButtons.OK);
                
            }


        }


        // This is the Calculate function where the Hire Payment Calculation is created
        public void calculate()
        {
            //Declare the variables and convert the variables in the Integer format.
            //When use the arithmetic operator Integer Format is help for maintain the accuracy value for the variables
            // data will receive from the label as text format and convert into the Integer format and store in the variables

            int Totalkm = Convert.ToInt32(this.hirePayForm.totalKmLabel.Text);
            int TotalHour = Convert.ToInt32(this.hirePayForm.totalHoursLabel.Text);
            int DriverPayment = Convert.ToInt32(this.hirePayForm.driverPaymentLabel.Text);
            int ExtraPerHour_Charge = Convert.ToInt32(this.hirePayForm.exPerHourChargeLabel.Text);
            int ExtraPerkm_Charge = Convert.ToInt32(this.hirePayForm.exPerKmChargeLabel.Text);
            int Maximum_km = Convert.ToInt32(this.hirePayForm.maxkmLabel.Text);
            int Basic_Charge = Convert.ToInt32(this.hirePayForm.basicChargeLabel.Text);
            int Maximum_Hours = Convert.ToInt32(this.hirePayForm.maxHourLabel.Text);
            int TotalDays = Convert.ToInt32 (this.hirePayForm.totalDaysLabel.Text);
            int PerdayVehiclePark_Charge = Convert.ToInt32(this.hirePayForm.perDayLabel.Text);

            //receive data from "tourTyLabel" and store in the "Tour_Type" variable in String Format

            String Tour_Type = hirePayForm.tourTyLabel.Text;

            //declare  variables which are use in the Calcuation

            int Extra_Hours = 0;
            int Extra_km = 0;
            double ExtrakmCharge = 0;
            double Waiting_Charge = 0;
            double Driver_Overnight_Charge = 0;
            double Vehicle_NightPark_Charge = 0;

            //assign the value of "TotalDays" to "overnightCount"

            int overnightCount = TotalDays;

            //Calculate the Extrakm and ExtrakmCharge, this is applicable for Day Tour and Long Tour

            if (Totalkm > Maximum_km)
            {
                Extra_km = Totalkm - Maximum_km; //Calculate the Extrakm

                ExtrakmCharge = Extra_km * ExtraPerkm_Charge; //Extrakm charge

            }

            //Day Tour Calculation

            if (Tour_Type == "Day Tour")  //If the Tour Type is equal to "Day Tour", Day Tour Calculation will execute
            {
                //Waiting Charge Calulation 

                if (TotalHour > Maximum_Hours)
                {
                     Extra_Hours =  TotalHour - Maximum_Hours;
                     Waiting_Charge = Extra_Hours * ExtraPerHour_Charge;
                }

                double Hire_Amount = Basic_Charge + ExtrakmCharge + Waiting_Charge; //Total Day Tour Hire Amount

                //Display the calculated Amounts such as Hire Amount, ExtrakmCharge, Waiting Charge and Basic Charge in the Hire Payment Form

                String TotalAmountTextBox = Hire_Amount.ToString();  //"Hire_Amount" value is convert ToString format and store in the "TotalAmountTextBox"
                hirePayForm.totalHireAmountTextBox.Text = TotalAmountTextBox; //"TotalAmountTextBox" value will display in the Form in totalHireAmountTextBox.
                hirePayForm.HireAmountTextBox.Text = TotalAmountTextBox; // "TotalAmountTextBox" value will display in the Form in HireAmountTextBox. 

                String ExtraPerkmChargeLabel = ExtrakmCharge.ToString();
                hirePayForm.extrakmchargeLabel.Text = ExtraPerkmChargeLabel;
                hirePayForm.ExKmPayTextBox.Text = ExtraPerkmChargeLabel;

                String waitingChargeLabel = Waiting_Charge.ToString();
                hirePayForm.waitingChargeLabel.Text = waitingChargeLabel;
                hirePayForm.WaitingChargeTextBox.Text = waitingChargeLabel;

                String BasicchargeLabel = Basic_Charge.ToString();
                hirePayForm.basicLabel.Text = BasicchargeLabel;
                hirePayForm.BasicChargeTextBox.Text = BasicchargeLabel;
            }


            //If the Tour Type is not a Day Tour else statement will execute
            else
            {
                //Long Tour Calculation
                if(Tour_Type == "Long Tour") //If the Tour Type is equal to "Day Tour", Day Tour Calculation will execute
                {
                    //If the Total Days greater thanor equal to 2, Driver overnight charge and Vehicle nightpark charge is applicable
                    if (TotalDays >= 2)
                    {
                        Driver_Overnight_Charge = overnightCount * DriverPayment; //Driver Overnight Charge calculation
                        Vehicle_NightPark_Charge = overnightCount * PerdayVehiclePark_Charge; //Vehicle nightpark Charge calculation
                    }

                 double Hire_Amount = Basic_Charge + ExtrakmCharge + Driver_Overnight_Charge + Vehicle_NightPark_Charge; //Total Long Tour Hire Amount

                    //Display the calculated Amounts such as Hire Amount, ExtrakmCharge, Driver overnight charge, Vehicle nightpark charge and Basic Charge in the Hire Payment Form

                    String TotalAmountTextBox = Hire_Amount.ToString();
                    hirePayForm.totalHireAmountTextBox.Text = TotalAmountTextBox;
                    hirePayForm.HireAmountTextBox.Text = TotalAmountTextBox;

                    String DriverOvernightCharge = Driver_Overnight_Charge.ToString();
                    hirePayForm.driverovernightchargeLabel.Text = DriverOvernightCharge;
                    hirePayForm.DriOverNtChargeTextBox.Text = DriverOvernightCharge;

                    String ExtraPerkmChargeLabel = ExtrakmCharge.ToString(); //"ExtraPerkmCharge" value is convert ToString format and store in the "ExtraPerkmChargeLabel"
                    hirePayForm.extrakmchargeLabel.Text = ExtraPerkmChargeLabel; // "ExtraPerkmChargeLabel" value will display in the Form in extrakmchargeLabel.
                    hirePayForm.ExKmPayTextBox.Text = ExtraPerkmChargeLabel;     // "ExtraPerkmChargeLabel" value will display in the Form in ExKmPayTextBox. 

                    String BasicchargeLabel = Basic_Charge.ToString();
                    hirePayForm.basicLabel.Text = BasicchargeLabel;
                    hirePayForm.BasicChargeTextBox.Text = BasicchargeLabel;

                    String VehicleparkchargeLabel = Vehicle_NightPark_Charge.ToString();
                    hirePayForm.vehnighparkchargeLabel.Text = VehicleparkchargeLabel;
                    hirePayForm.VehiNtParkTextBox.Text = VehicleparkchargeLabel;

                }


                else
                {

                }
                

            }


            // double Total_Hire_Amount = Basic_Charge + Vehicle_Park_Charge + Driver_Overnight_Charge + Waiting_Charge + ExtraPerHour_Charge;

            // String TotalAmountTextBox = Total_Hire_Amount.ToString();
            // hirePayForm.totalHireAmountTextBox.Text = TotalAmountTextBox;



        }

        public void Balance()
        {
            double Intial_Amount = Convert.ToDouble(this.hirePayForm.intialPayTextBox.Text);
            double Hire_Amount = Convert.ToDouble(this.hirePayForm.totalHireAmountTextBox.Text);
            double Balance = Hire_Amount - Intial_Amount;

            String BalanceAmountTextBox = Balance.ToString();
            hirePayForm.balancePayTextBox.Text = BalanceAmountTextBox;
        }

        public void Loadforeignkey(ComboBox comboBox)
        {
            String sql = "select * from Hire";
            LoadforeignkeyInComboBox(sql, comboBox, "Hire_Number");
        }
    }
}
