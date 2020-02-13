using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CancelBooking_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCancelBooking_Click(object sender, EventArgs e)
    {
        Response.Redirect("CancelBooking_2.aspx");
    }
}