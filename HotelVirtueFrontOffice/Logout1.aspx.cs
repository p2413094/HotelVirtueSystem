using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click2(object sender, EventArgs e)
    {
        Response.Redirect("Logout2.aspx");
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        Response.Redirect("AccountPage.aspx");
    }
}