using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewBooking_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnViewBooking_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_2.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CancelBooking_1.aspx");
    }

    protected void btnPayForBooking_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking.aspx");
    }
}