using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateBooking_1 : System.Web.UI.Page
{
    Int32 hotelId;
    string hotelName;
    DateTime arrivalDate;
    DateTime departureDate;
    Int32 underFive;
    Int32 fiveToSixteen;
    Int32 sixteenUpwards;

    protected void Page_Load(object sender, EventArgs e)
    {
        hotelId = Convert.ToInt32(Session["hotelId"]);
        hotelName = Convert.ToString(Session["hotelName"]);
        arrivalDate = Convert.ToDateTime(Session["arrivalDate"]);
        departureDate = Convert.ToDateTime(Session["departureDate"]);
        underFive = Convert.ToInt32(Session["underFive"]);
        fiveToSixteen = Convert.ToInt32(Session["fiveToSixteen"]);
        sixteenUpwards = Convert.ToInt32(Session["sixteenUpwaards"]);

        lblHotelName.Text = "T Birmingham";
        lblArrivalDepartureDate.Text = "T 01/03/2020-03/03/2020";
        lblbreakdownOfGuests.Text = "T 1 under five, 1 between five and sixteen and 3 over sixteen";
        lblCost.Text = "T 89.00";
    }

    protected void btnContinueToPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }
}