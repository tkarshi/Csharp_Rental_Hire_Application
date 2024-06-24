using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pogramming_Sample_Interface.CommonClass
{
    enum functionType
    {
        insert,
        update,
        delete
    }
    internal class DatabaseClass
    {

        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-FOM4FAB\MSSQLSERVER01;Initial Catalog=DB_AyboDrive;Integrated Security=True");


        public bool executeQuery(String sql, functionType _funType)
        {

            bool functionRunStatus = false;
            String viewMessage = "";
            bool functionStatus = false;

            try
            {
                if (_funType == functionType.insert)
                {
                    if(MessageBox.Show("Do you want to insert?", "Save Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question )== DialogResult.Yes)
                    {
                        functionRunStatus = true;
                        viewMessage = "Saved Successfully";
                    }
                }

                else if (_funType == functionType.update)
                {
                    if(MessageBox.Show("Do you want to update?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        functionRunStatus = true;
                        viewMessage = "Updated Successfully";
                    }
                }

                //Commmon Delete Function
                else if(_funType == functionType.delete) //check the function Type. If the function type is delete, delete function will execute
                {
                    //Confirmation for delete for the entered ID, if the confirmation result is yes , delete function will execute
                    //and particular ID entire record will be delete from the table 
                    if (MessageBox.Show("Do you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //check the functionRun Status
                        functionRunStatus = true;
                        viewMessage = "Deleted Successfully"; //Delete function message of successfully deleted
                    }
                }

                if (functionRunStatus)
                {


                    SqlCommand cmd = new SqlCommand(sql, con);

                    con.Open();

                    int rowsCount = cmd.ExecuteNonQuery();

                    if (rowsCount > 0)
                    {
                        MessageBox.Show(viewMessage );
                        functionStatus = true;
                    }
                    else
                    {
                        MessageBox.Show("Data not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally
            {
                con.Close();
               
            }

            return functionStatus;
        }

        public void LoadDataFromDatabaseInGridView(String sql, DataGridView _loadTableFun )
        {
            
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _loadTableFun.DataSource = dt;

        }


        public DataTable getDataFromDatabase(String sql)
        {

            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public void LoadforeignkeyInComboBox(string sql, ComboBox comboBox, String Vehicle_Type_IDColumnName, String Vehicle_NameColumnName)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = Vehicle_NameColumnName;
            comboBox .ValueMember= Vehicle_Type_IDColumnName;
        }

        public void LoadforeignkeyInComboBox(string sql, ComboBox comboBox, String Hire_NumberColumnName)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = Hire_NumberColumnName;
            comboBox.ValueMember = Hire_NumberColumnName;
        }

        //public void LoadforeignkeyInComboBox(string sql, ComboBox comboBox, String Rent_NumberColumnName)
        //{
        //    SqlDataAdapter da = new SqlDataAdapter(sql, con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    comboBox.DataSource = dt;
        //    comboBox.DisplayMember = Rent_NumberColumnName;
        //    comboBox.ValueMember = Rent_NumberColumnName;
        //}

    }
}
