using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class SurveyComplete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool contact = (bool)Session["Contact"];
        lblContactCheck.Text = "Thank you for your feedback!";
        if (contact)
        {
            lblContactCheck.Text += "<br />A customer service representative "
                + "will contact you within 24 hours.";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Survey_Page.aspx");
    }
}