using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PayForBooking_Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnReturnToHomePage_Click1(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}