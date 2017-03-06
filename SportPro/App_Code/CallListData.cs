using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class CallListData
{
    private List<Customer> callList;
	public CallListData()
	{
        callList = new List<Customer>();
	}

    public void add(Customer c)
    {
        callList.Add(c);
    }

    public void RemoveAt(int index)
    {
        callList.RemoveAt(index);
    }

    public void clearAllCustomers()
    {
        callList.Clear();
    }

    public Customer getCustomerByIndex(int index)
    {
       // Customer c=null;
       // if (index < 0 || index >= numItems()) return null;        
        //return callList[index]; 
        return callList.ElementAt(index);
    }

    public Boolean isPresent(Customer c)
    {
        // cycle through all items and find it
        if (callList.Count == 0 || c==null) return false;

        for (int x = 0; x<callList.Count; x++)
        {
            if (callList[x].getCustomerId().Equals(c.getCustomerId()))
                return true;
        }
        return false;
    }

    public static CallListData getCallList()
    {
        CallListData cList = (CallListData)HttpContext.Current.Session["cList"];
        if (cList == null) 
            HttpContext.Current.Session["cList"] = new CallListData();
        return (CallListData)HttpContext.Current.Session["cList"];
    }

    public int numItems()
    {
        return callList.Count;
    }

    public Customer this[int index]
    {
        get
        {
            return callList[index];
        }
        set
        {
            callList[index] = value;
        }
    }

    public Customer this[string name]
    {
        get
        {
            foreach (Customer c in callList)
            {
                if (c.getName() == name)
                    return c;
            }
            return null;
        }
    }
}