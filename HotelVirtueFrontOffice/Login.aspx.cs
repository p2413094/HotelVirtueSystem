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
        //Redirect to the homepage 
        Response.Redirect("Guest Login.aspx");
    }
}