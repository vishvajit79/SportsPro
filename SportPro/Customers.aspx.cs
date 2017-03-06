using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Customers : System.Web.UI.Page
{
    private Customer cust;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) ddlCustomerNames.DataBind();
        cust = getCustomer();
        lblAddress.Text = cust.getAddress();
        lblPhone.Text = cust.getPhone();
        lblEmail.Text = cust.getEmail();
    }

    private Customer getCustomer()
    {
        DataView customerTable = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
        customerTable.RowFilter = "CustomerID ='" + ddlCustomerNames.SelectedValue + "'";
        DataRowView row = (DataRowView)customerTable[0];

        string customerid = row["CustomerID"].ToString();
        string name = row["Name"].ToString();
        string address = row["Address"].ToString();
        string phone = row["Phone"].ToString();
        string email = row["Email"].ToString();
        this.cust = new Customer(customerid, name, address, phone, email);
        return cust;
    }

    protected void btnAddToContactList_Click(object sender, EventArgs e)
    {
        CallListData cList = CallListData.getCallList();
        Customer customer = cList[this.cust.getName()];
        if (customer == null)
        {
            cList.add(this.cust);
            Response.Redirect("ContactList.aspx");
        }
        else
        {
            lblError.Text = "This customer is already in the contact list.";
        }
    }

    protected void btnDisplayContactList_Click(object sender, EventArgs e)
    {
        Response.Redirect("ContactList.aspx");
    }


    public bool alreadyexists { get; set; }
}