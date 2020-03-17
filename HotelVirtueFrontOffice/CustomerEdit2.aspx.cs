using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class CustomerEdit2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

protected void Button1_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("CustomerEdit.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    void Add()
    {
        //create an instance of account
        HotelVirtueClasses.clsAccountCollection Account = new HotelVirtueClasses.clsAccountCollection();
        //validate the data on the web form
        String Error = Account.ThisAccount.Valid(txtCustomerId, txtHouseNo, txtCity, txtPassword, txtPostCode, txtStreet, txtTown, txtUserName);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Account.ThisAccount.CustomerId = Convert.ToInt32(txtCustomerId);
            Account.ThisAccount.HouseNo = Convert.ToString(txtHouseNo);
            Account.ThisAccount.City = Convert.ToString(txtCity);
            Account.ThisAccount.Password = Convert.ToString(txtPassword);
            Account.ThisAccount.PostCode = Convert.ToString(txtPostCode);
            Account.ThisAccount.Street = Convert.ToString(txtStreet);
            Account.ThisAccount.Town = Convert.ToString(txtTown);
            Account.ThisAccount.UserName = Convert.ToString(txtUserName);
            //add the record
            Account.Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerEdit.aspx");
        }
        else
        {
            //report an error
            
        }
    }

    
}