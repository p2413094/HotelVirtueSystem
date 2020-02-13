using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CancelBooking_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnReturnToHomeScreen_Click(object sender, EventArgs e)
    {
        Response.Redirect("HomePage.aspx");
    }
}