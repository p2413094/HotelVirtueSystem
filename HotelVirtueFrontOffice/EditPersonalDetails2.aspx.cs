using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditPersonalDetails2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click2(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("EditPersonalDetails3.aspx");
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("EditpersonalDetails1.aspx");
    }
}