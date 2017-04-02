using System;
using System.Data;
using HMS.EntityLayer;
using HMS.BusinessLogicLayer;

namespace HospitalManagementSystemApp
{

    public partial class WebForm3 : System.Web.UI.Page
    {
        SearchPatient sPatient = new SearchPatient();
        BusinessPatient businessPatient = new BusinessPatient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtId.Text==string.Empty)
            {
                sPatient.Id = 0;
            }
            else
            {
                sPatient.Id = Convert.ToInt32(txtId.Text);
            }
            
            
            
            sPatient.FirstName = txtFirstName.Text;
            int i = Convert.ToInt32(RadioButtonList1.SelectedValue);
            
            DataTable dt =  businessPatient.SearchPatient(sPatient,i);
            if (dt.Rows.Count==0)
            {
                lblnoResult.Text = "No Result Found ";
            }
            GridView.DataSource = dt;
            GridView.DataBind();
            GridView.Visible = true;
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtFirstName.Text = string.Empty;            
            GridView.Visible = false;
            lblnoResult.Text = string.Empty;
        }
    }
}