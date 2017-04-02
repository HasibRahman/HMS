using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.EntityLayer;
using HMS.DataAccessLayer;

namespace HMS.BusinessLogicLayer
{
    public class BusinessPatient
    {
        DataPatient dataPatient = new DataPatient();
        DataTable stateDataTable = new DataTable();
        DataTable insuranceDataTable = new DataTable();
        public string BusinessAddPatient(Patient patient)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@FirstName",SqlDbType.VarChar),
                new SqlParameter("@LastName",SqlDbType.VarChar),
                new SqlParameter("@DateOfBirth",SqlDbType.VarChar),
                new SqlParameter("@Phone",SqlDbType.BigInt),
                new SqlParameter("@Email",SqlDbType.VarChar),
                new SqlParameter("@State",SqlDbType.VarChar),
                new SqlParameter("@InsurancePlan",SqlDbType.VarChar),
                
                //This is output parameter 
                new SqlParameter("@Id",SqlDbType.Int),
 
            };
            sqlParameters[0].Value = patient.FirstName;
            sqlParameters[1].Value = patient.LastName;
            sqlParameters[2].Value = patient.DateOfBirth;
            sqlParameters[3].Value = patient.Phone;
            sqlParameters[4].Value = patient.Email;
            sqlParameters[5].Value = patient.State;
            sqlParameters[6].Value = patient.InsurancePlan;
            
            sqlParameters[7].Direction=ParameterDirection.Output;

            string result = dataPatient.DataAddPatient(sqlParameters);
            return result;
        }

        public DataTable BusinessFillStateData()
        {
            stateDataTable.Clear();
            stateDataTable = dataPatient.DataFillStateData().Tables["State"];
            return stateDataTable;

        }

        public DataTable BusinessFillInsuranceData()
        {
            insuranceDataTable.Clear();
            insuranceDataTable = dataPatient.DataFillInsuranceData().Tables["Plan"];
            return insuranceDataTable;
        }

        public DataTable SearchPatient(SearchPatient sPatient,int i)
        {
            
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Id",SqlDbType.Int),
                new SqlParameter("@FirstName",SqlDbType.VarChar),
                
                                
            };
            sqlParameters[0].Value = sPatient.Id;
            sqlParameters[1].Value = sPatient.FirstName;            

            DataTable dt = dataPatient.DataSearchPatient(sqlParameters,i);
            return dt;
        }
    }
}
