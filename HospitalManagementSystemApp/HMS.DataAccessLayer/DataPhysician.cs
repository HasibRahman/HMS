using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.DataAccessLayer
{
    public class DataPhysician
    {
        SqlConnection conn = new SqlConnection(FetchConfiguration());
        SqlCommand scmd = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = new DataSet();
        DataSet dataSet1 = new DataSet();

        public string DataAddPhysician(SqlParameter[] sqlParameters)
        {
            string query = "SP_AddPhysician";
            scmd = new SqlCommand(query, conn);
            scmd.CommandType = CommandType.StoredProcedure;
            scmd.Parameters.AddRange(sqlParameters);

            try
            {
                conn.Open();
                int result = scmd.ExecuteNonQuery();

                if (result == 1)
                {
                    string idOut = Convert.ToString(sqlParameters[7].Value);

                    return "Physician Successfully Registered with physician Id :" + " " + idOut;
                }

                else
                {
                    return "Physician Registration Failed";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet DataFillDepartment()
        {
            string query = "Select * from Department";
            dataAdapter = new SqlDataAdapter(query, conn);

            conn.Open();
            dataAdapter.Fill(dataSet, "Department");
            conn.Close();
            return dataSet;
        }
        public DataSet DataFillStateData()
        {
            string query = "Select * from State";
            dataAdapter = new SqlDataAdapter(query, conn);

            conn.Open();
            dataAdapter.Fill(dataSet, "State");
            conn.Close();
            return dataSet;
        }

        public DataSet DataFillInsuranceData()
        {
            string query = "Select * from [Plan]";

            dataAdapter = new SqlDataAdapter(query, conn);

            conn.Open();
            dataAdapter.Fill(dataSet, "Plan");
            conn.Close();
            return dataSet;
        }

        protected static string FetchConfiguration()
        {
            string conn = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            return conn;
        }
    }
}
