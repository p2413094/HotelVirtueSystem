using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditpersonalDetails1.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateBooking_2.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Logout1.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_1.aspx");
    }
}