using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            DisplayAccounts();
        }

    }

    void DisplayAccounts()
    {
        //create an instance of Account Collection
        HotelVirtueClasses.clsAccountCollection Accounts = new HotelVirtueClasses.clsAccountCollection();
        //Set the data source to the list of accounts
        ListBox1.DataSource = Accounts.AllAccounts;
        //set name of the primary key
        ListBox1.DataValueField = "AccountId";
        //set the data field to display
        ListBox1.DataTextField = "AccountId";
        //bind the data to list
        ListBox1.DataBind();
    }



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //store -1 imto the session object to indicate this is a new record
        Session["AccountId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("CustomerEdit2.aspx");
    }
}