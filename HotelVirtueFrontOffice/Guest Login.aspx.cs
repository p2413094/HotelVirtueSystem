using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Guest_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("PayForBooking_1.aspx");
    }

    void Add()
    {
        //create an instance of account
        HotelVirtueClasses.clsCustomerCollection Customer= new HotelVirtueClasses.clsCustomerCollection();
        //validate the data on the web form
        String Error = Customer.ThisCustomer.Valid(FirstNametxt.Text, LastNametxt.Text, EmailAddresstxt.Text, ContactNumbertxt.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Customer.ThisCustomer.EmailAddress = Convert.ToString(EmailAddresstxt.Text);
            Customer.ThisCustomer.FirstName = Convert.ToString(FirstNametxt.Text);
            Customer.ThisCustomer.LastName = Convert.ToString(LastNametxt.Text);
            Customer.ThisCustomer.ContactNumber= Convert.ToInt32(ContactNumbertxt.Text);
            //add the record
            Customer.Add();
            //all done so redirect back to the main page
            Response.Redirect("PayForBooking_1.aspx");
        }
        else
        {
            //report an error

        }
    }
}