using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contactlist : System.Web.UI.Page
{
    private CallListData cList;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        cList = CallListData.getCallList();
        // Customer currentCust = (Customer)HttpContext.Current.Session["presentCustomer"];
        if (!IsPostBack)
            DisplayList();
    }

    private void DisplayList()
    {
        lstCall.Items.Clear();

        for (int i = 0; i < cList.numItems(); i++)
        {
            Customer c = cList.getCustomerByIndex(i);
            if (c != null)
                lstCall.Items.Add(c.toString());
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (cList.numItems() > 0)
        {
            lstCall.Items.Clear();
            cList.clearAllCustomers();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (cList.numItems() > 0)
        {
            if (lstCall.SelectedIndex >= 0)
            {
                cList.RemoveAt(lstCall.SelectedIndex);
                DisplayList();
            }

        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Customers.aspx");
    }
}