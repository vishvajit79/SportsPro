using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class CustomerList
{
    private List<Customer> customerList;
	public CustomerList()
	{
        customerList = new List<Customer>();
	}

    public void add(Customer c)
    {
        customerList.Add(c);
    }

    public void RemoveAt(int index)
    {
        customerList.RemoveAt(index);
    }

    public void clearAllCustomers()
    {
        customerList.Clear();
    }

    public Customer getCustomerByIndex(int index)
    {
       // Customer c=null;
       // if (index < 0 || index >= numItems()) return null;        
        //return customerList[index]; 
        return customerList.ElementAt(index);
    }

    public Boolean isPresent(Customer c)
    {
        // cycle through all items and find it
        if (customerList.Count == 0 || c==null) return false;

        for (int x = 0; x<customerList.Count; x++)
        {
            if (customerList[x].getCustomerId().Equals(c.getCustomerId()))
                return true;
        }
        return false;
    }

    public static CustomerList getCallList()
    {
        CustomerList cList = (CustomerList)HttpContext.Current.Session["cList"];
        if (cList == null) 
            HttpContext.Current.Session["cList"] = new CustomerList();
        return (CustomerList)HttpContext.Current.Session["cList"];
    }

    public int numItems()
    {
        return customerList.Count;
    }

    public Customer this[int index]
    {
        get
        {
            return customerList[index];
        }
        set
        {
            customerList[index] = value;
        }
    }

    public Customer this[string name]
    {
        get
        {
            foreach (Customer c in customerList)
            {
                if (c.getName() == name)
                    return c;
            }
            return null;
        }
    }
}