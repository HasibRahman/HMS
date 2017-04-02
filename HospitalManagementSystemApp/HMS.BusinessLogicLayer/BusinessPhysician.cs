using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DataAccessLayer;
using HMS.EntityLayer;

namespace HMS.BusinessLogicLayer
{
    public class BusinessPhysician
    {
        DataTable departmentDataTable = new DataTable();
        DataTable stateDataTable=new DataTable();
        DataTable insuranceDataTable = new DataTable();
        DataPatient dataPatient = new DataPatient();
        DataPhysician dataPhysician = new DataPhysician();

        public DataTable BusinessFillDepartment()
        {
            departmentDataTable.Clear();
            departmentDataTable = dataPhysician.DataFillDepartment().Tables["Department"];
            return departmentDataTable;
        }
        public DataTable BusinessFillStateData()
        {
            stateDataTable.Clear();
            stateDataTable = dataPhysician.DataFillStateData().Tables["State"];
            return stateDataTable;

        }

        public DataTable BusinessFillInsuranceData()
        {
            insuranceDataTable.Clear();
            insuranceDataTable = dataPhysician.DataFillInsuranceData().Tables["Plan"];
            return insuranceDataTable;
        }

        public string AddPhysician(Physician physician)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@FirstName",SqlDbType.VarChar),
                new SqlParameter("@LastName",SqlDbType.VarChar),
                new SqlParameter("@DepartmentId",SqlDbType.VarChar),
                new SqlParameter("@EducationalQualification",SqlDbType.VarChar),
                new SqlParameter("@YearsOfExperience",SqlDbType.Int),
                new SqlParameter("@State",SqlDbType.VarChar),
                new SqlParameter("@Plan",SqlDbType.VarChar),
                
                //This is output parameter 
                new SqlParameter("@PhysicianId",SqlDbType.VarChar)
 
            };
            sqlParameters[0].Value = physician.FirstName;
            sqlParameters[1].Value = physician.LastName;
            sqlParameters[2].Value = physician.DepartmentId;
            sqlParameters[3].Value = physician.Qualifications;
            sqlParameters[4].Value = physician.Experience;
            sqlParameters[5].Value = physician.State;
            sqlParameters[6].Value = physician.Plan;

            sqlParameters[7].Direction = ParameterDirection.Output;
            sqlParameters[7].Size = 50;

            string result = dataPhysician.DataAddPhysician(sqlParameters);
            return result;
        }
    }
}
