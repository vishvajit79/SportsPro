using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Incident
{

    public string CustomerID { get; set; }
    public string IncidentID { get; set; }
    public string ProductCode { get; set; }
    public string TechID { get; set; }
    public string DateOpened { get; set; }
    public string DateClosed { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ResolutionNotes { get; set; }

    public Incident(string cusId, string incId, string prodCode, string dateclosed, string title, string dateopened)
    {
        CustomerID = cusId;
        IncidentID = incId;
        ProductCode = prodCode;
        DateOpened = dateopened;
        DateClosed = dateclosed;
        Title = title;
    }


    public string customerIncidentDisplay()
    {
        if(DateClosed.ToString().Length == 0)
            return "Incident for product " + ProductCode + " opened " + DateOpened + " (" + Title + ")";
        else
            return "Incident for product " + ProductCode + " closed " + DateClosed + " (" + Title + ")";
    }

}