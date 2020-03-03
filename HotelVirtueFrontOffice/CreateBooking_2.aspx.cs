using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateBooking_2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblArrivalDate.Text = Convert.ToString(Session["ArrivalDate"]);
        lblArrivalDate.Visible = true;

        lblDepartureDate.Text = Convert.ToString(Session["DepartureDate"]);
        lblDepartureDate.Visible = true;
    }

    protected void btnPayNow_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }

    protected void btnPayLater_Click(object sender, EventArgs e)
    {

    }
}