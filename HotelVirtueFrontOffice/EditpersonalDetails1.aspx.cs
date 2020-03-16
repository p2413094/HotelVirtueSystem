using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditpersonalDetails1 : System.Web.UI.Page
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
        DropDownList1.DataSource = Accounts.AccountList;
        //set name of the primary key
        DropDownList1.DataValueField = "AccountId";
        //set the data field to display
        DropDownList1.DataTextField = "City";
        //bind the data to list
        DropDownList1.DataBind();
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
}