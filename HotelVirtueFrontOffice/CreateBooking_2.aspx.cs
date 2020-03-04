using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateBooking_2 : System.Web.UI.Page
{
    Int32 hotelId;
    string hotelName;
    Int32 roomId;
    Int32 customerId;
    string arrivalDate;
    string departureDate;
    Int32 underFive;
    Int32 fiveToSixteen;
    Int32 sixteenUpwards;
    decimal total;
    Boolean gymAccess;
    Boolean lateCheckout;

    protected void Page_Load(object sender, EventArgs e)
    {
        //these are temporary
        hotelId = 1;
        hotelName = "Birmimgham";
        roomId = 1;
        customerId = 1;
        arrivalDate = Convert.ToDateTime("06/03/2020").ToShortDateString();
        departureDate = Convert.ToDateTime("09/03/2020").ToShortDateString();
        underFive = 1;
        fiveToSixteen = 1;
        sixteenUpwards = 1;
        total = 250.00m;
        gymAccess = true;
        lateCheckout = true;

        lblHotelName.Text = "Hotel: " + hotelName;
        lblArrivalDate.Text = "Arrival date: " + arrivalDate;
        lblDepartureDate.Text = "Departure date: " + departureDate;
        lblUnderFive.Text = "Number of under fives: " + underFive;
        lblFiveToSixteen.Text = "Number of five to sixteens: " + fiveToSixteen;
        lblSixteenUpwards.Text = "Sixteen upwards: " + sixteenUpwards;
        lblGymAccess.Text = "Gym access: " + gymAccess;
        lblLateCheckout.Text = "Late checkout: " + lateCheckout;
        lblCost.Text = "Total cost: £" + total;

        txtOther.Rows = 10;
        //lblHotelName.Text = Convert.ToString(Session["HotelName"]);

        //lblArrivalDate.Text = Convert.ToString(Session["ArrivalDate"]);
        //lblArrivalDate.Visible = true;

        //lblDepartureDate.Text = Convert.ToString(Session["DepartureDate"]);
        //lblDepartureDate.Visible = true;
    }

    protected void btnPayNow_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }

    protected void btnPayLater_Click(object sender, EventArgs e)
    {

    }
}