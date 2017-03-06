using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Customer
{
    private string customerId;
    private string name;
    private string address;
    private string phone;
    private string email;

	public Customer(string cid,string nam,string add, string pho,string ema)
	{
        customerId = cid;
        name = nam;
        address = add;
        phone = pho;
        email = ema;
	}

    public string getCustomerId() { return customerId; }
    public string getName() { return name; }
    public string getAddress() { return address; }
    public string getPhone() { return phone; }
    public string getEmail() { return email; }

    public string toString()
    {
        string s = "";
        s = name + "," + phone + "," + email;
        return s;
    }

}