using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Net.Cache;
using System.Runtime.Remoting.Messaging;


namespace HMS.DataAccessLayer
{
    public class DataPatient
    {
        SqlConnection conn = new SqlConnection(FetchConfiguration());
        SqlCommand scmd = null;
        SqlDataAdapter dataAdapter = null;
        DataSet dataSet = new DataSet();
        DataSet dataSet1 = new DataSet();
        DataTable dataTable = new DataTable();

        public string DataAddPatient(SqlParameter[] sqlParameters)
        {
            string query = "SP_AddPatient";
            scmd = new SqlCommand(query, conn);
            scmd.CommandType = CommandType.StoredProcedure;
            scmd.Parameters.AddRange(sqlParameters);

            try
            {
                conn.Open();
                int result = scmd.ExecuteNonQuery();

                if (result == 1)
                {
                    int idOut = Convert.ToInt32(sqlParameters[7].Value);

                    return "Patient Successfully Registered with Patient Id :" + " " + idOut.ToString();
                }

                else
                {
                    return "Patient Registration Failed";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
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

        public DataTable DataSearchPatient(SqlParameter[] sqlParameters,int i)
        {
            string query;
            if (i==1)
            {
                query = "SP_SearchPatientById";
                scmd = new SqlCommand(query, conn);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.Add(sqlParameters[0]);

                dataAdapter = new SqlDataAdapter(scmd);
                conn.Open();
                dataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            else
            {
                query = "SP_SearchPatientByName";                
                scmd = new SqlCommand(query, conn);
                scmd.CommandType = CommandType.StoredProcedure;
                scmd.Parameters.Add(sqlParameters[1]);

                dataAdapter = new SqlDataAdapter(scmd);
                conn.Open();
                dataAdapter.Fill(dataTable);
                conn.Close();
                return dataTable;
            }
            

            
        }

        protected static string FetchConfiguration()
        {
            string conn = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            return conn;
        }
    }
}
