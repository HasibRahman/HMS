using System;
using System.Data;
using HMS.EntityLayer;
using HMS.BusinessLogicLayer;

namespace HospitalManagementSystemApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        BusinessPhysician businessPhysician = new BusinessPhysician();
        Physician physician = new Physician();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDropDownlist(); 
            }
            
        }

        private void LoadDropDownlist()
        {
            
            DataTable dt0 = businessPhysician.BusinessFillDepartment();           
            dpdDepartment.DataTextField = dt0.Columns[1].ToString();
            dpdDepartment.DataValueField = dt0.Columns[0].ToString();
            dpdDepartment.DataSource = dt0;
            dpdDepartment.DataBind();
            dpdDepartment.Items.Insert(0,"--Select--");

            DataTable dt = businessPhysician.BusinessFillStateData();
            dpdStatePhysician.DataTextField = dt.Columns[1].ToString();
            dpdStatePhysician.DataValueField = dt.Columns[0].ToString();
            dpdStatePhysician.DataSource = dt;
            dpdStatePhysician.DataBind();
            dpdStatePhysician.Items.Insert(0,"--Select--");

            DataTable dt1 = businessPhysician.BusinessFillInsuranceData();
            dpdPlanPhysician.DataTextField = dt1.Columns[1].ToString();
            dpdPlanPhysician.DataValueField = dt1.Columns[0].ToString();
            dpdPlanPhysician.DataSource = dt1;
            dpdPlanPhysician.DataBind();
            dpdPlanPhysician.Items.Insert(0, "--Select--");
        }

        protected void btnRegisterPhysician_Click(object sender, EventArgs e)
        {
            physician.FirstName = txtFirstNamePhysician.Text;
            physician.LastName = txtLastNamePhysician.Text;
            physician.DepartmentId = dpdDepartment.Text;
            physician.Qualifications = txtQualification.Text;
            physician.Experience = Convert.ToInt32(txtExperience.Text);
            physician.State = dpdStatePhysician.Text;
            physician.Plan = dpdPlanPhysician.Text;

            string result = businessPhysician.AddPhysician(physician);
            lblRegSuccess.Text = result;
        }

        protected void clear()
        {
            txtFirstNamePhysician.Text=string.Empty;
            txtLastNamePhysician.Text = string.Empty;
            dpdDepartment.SelectedIndex = -1;
            txtQualification.Text = string.Empty;
            txtExperience.Text = string.Empty;
            dpdStatePhysician.SelectedIndex=-1;
            dpdPlanPhysician.SelectedIndex=-1;
            lblRegSuccess.Text = string.Empty;
        }

        protected void btnResetPhysician_Click(object sender, EventArgs e)
        {
            clear();
        }


    }
}