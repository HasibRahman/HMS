using System;
using System.Data;
using HMS.BusinessLogicLayer;
using HMS.EntityLayer;

namespace HospitalManagementSystemApp
{
    public partial class RegisterPatient : System.Web.UI.Page
    {
        Patient patient = new Patient();
        BusinessPatient businessPatient = new BusinessPatient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDownlist();

            }
            
        }

        private void LoadDropDownlist()
        {
            DataTable dt = businessPatient.BusinessFillStateData();
            dpdState.DataTextField = dt.Columns[1].ToString();
            dpdState.DataValueField = dt.Columns[0].ToString();
            dpdState.DataSource = dt;
            dpdState.DataBind();

            DataTable dt1 = businessPatient.BusinessFillInsuranceData();
            dpdInsurancePlan.DataTextField = dt1.Columns[1].ToString();
            dpdInsurancePlan.DataValueField = dt1.Columns[0].ToString();
            dpdInsurancePlan.DataSource = dt1;
            dpdInsurancePlan.DataBind();
            
            
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //Set Property values 
            patient.FirstName = txtFirstName.Text;
            patient.LastName = txtLastName.Text;
            patient.DateOfBirth = txtDateOfBirth.Text;
            patient.Phone = Convert.ToInt64(txtPhoneNumber.Text);
            patient.Email = txtEmail.Text;
            patient.State = dpdState.Text;
            patient.InsurancePlan = dpdInsurancePlan.Text;

            string result = businessPatient.BusinessAddPatient(patient);
            //Response.Write(result);
            //Response.Write("<script>alert('"+result+"');</script>");
            lblRegSuccess.Text = result;
            
        }

        protected void Clear()
        {
            lblRegSuccess.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dpdState.SelectedIndex = -1;
            dpdInsurancePlan.SelectedIndex = -1;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}