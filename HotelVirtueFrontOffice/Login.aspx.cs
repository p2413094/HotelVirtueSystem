using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        //Redirect to the homepage 
        Response.Redirect("PayForBooking_1.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //store -1 imto the session object to indicate this is a new record
        Session["AccountId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("Registration.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //store -1 imto the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("Guest Login.aspx");
    }

    void Add()
    {
        //create an instance of account
        HotelVirtueClasses.clsAccountCollection Account = new HotelVirtueClasses.clsAccountCollection();
        //validate the data on the web form
        String Error = Account.ThisAccount.Valid(txtPassword.Text,txtUserName.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Account.ThisAccount.Password = Convert.ToString(txtPassword.Text);
            Account.ThisAccount.UserName = Convert.ToString(txtUserName.Text);
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