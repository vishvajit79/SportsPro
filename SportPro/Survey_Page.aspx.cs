using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssignmentOne;

public partial class Survey_Page : System.Web.UI.Page
{
    private Incident incident;

    protected void Page_Load(object sender, EventArgs e)
    {
        txtCustomerID.Focus();
        if (!IsPostBack)
        {
            DataBind();
        }
        lbIncidentDisplay.Enabled = false;
        RadioButtonList1.Enabled = false;
        RadioButtonList2.Enabled = false;
        RadioButtonList3.Enabled = false;
        txtComment.Enabled = false;
        cbContact.Enabled = false;
        contactByEmail.Enabled = false;
        contactByPhone.Enabled = false;
        Button3.Enabled = false;
        lblInvalid.Visible = false;

    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        
        lbIncidentDisplay.Items.Clear();
        DataView incidentTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        incidentTable.RowFilter = "CustomerID =" + txtCustomerID.Text + " And DateClosed Is Not Null";
        if (incidentTable.Count > 0)
        {
            lbIncidentDisplay.Enabled = true;
            RadioButtonList1.Enabled = true;
            RadioButtonList2.Enabled = true;
            RadioButtonList3.Enabled = true;
            txtComment.Enabled = true;
            cbContact.Enabled = true;
            contactByEmail.Enabled = true;
            contactByPhone.Enabled = true;
            Button3.Enabled = true;
            lblInvalid.Visible = false;
            DataRowView row = (DataRowView)incidentTable[0];

            string incidentID = row["IncidentID"].ToString();
            string customerid = row["CustomerID"].ToString();
            string productCode = row["ProductCode"].ToString();
            string techID = row["TechID"].ToString();
            string dateOpened = row["DateOpened"].ToString();
            string dateClosed = row["DateClosed"].ToString();
            string title = row["Title"].ToString();
            string description = row["Description"].ToString();
            string resolutionNotes = row["ResolutionNotes"].ToString();
            this.incident = new Incident(customerid, incidentID, productCode, dateClosed, title, dateOpened);
            lbIncidentDisplay.Items.Add(incident.customerIncidentDisplay());
            lbIncidentDisplay.SelectedIndex = 0;
        }
        else {
            lblInvalid.Visible = true;
        }
        
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            Survey survey = new Survey();
            //survey.IncidentID = Convert.ToInt32(lbIncidentDisplay.SelectedValue);
            if (RadioButtonList1.SelectedIndex != -1)
            {
                survey.ResponseTime = Convert.ToInt32(RadioButtonList1.SelectedValue);
            }
            if (RadioButtonList2.SelectedIndex != -1)
            {
                survey.TechEfficiency = Convert.ToInt32(RadioButtonList2.SelectedValue);
            }
            if (RadioButtonList3.SelectedIndex != -1)
            {
                survey.Resolution = Convert.ToInt32(RadioButtonList3.SelectedValue);
            }
            survey.Comments = txtComment.Text;
            if (cbContact.Checked)
            {
                survey.Contact = true;
                if (contactByEmail.Checked)
                    survey.ContactBy = "Email";
                else
                    survey.ContactBy = "Phone";
                Session.Add("Contact", true);
            }
            else
            {
                survey.Contact = false;
                Session.Add("Contact", false);
            }
            Response.Redirect("SurveyComplete.aspx");
        }
    }

    /*public string CustomerID { get; set; }

    public int IncidentID { get; set; }

    public int ResponseTime { get; set; }

    public int TechEfficiency { get; set; }

    public int Resolution { get; set; }

    public string Comments { get; set; }

    public bool Contact { get; set; }

    public string ContactBy { get; set; }*/
}