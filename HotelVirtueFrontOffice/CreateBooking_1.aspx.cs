using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class CreateBooking_1 : System.Web.UI.Page
{
    Int32 hotelId;
    string hotelName;
    DateTime arrivalDate;
    DateTime departureDate;
    Int32 underFive;
    Int32 fiveToSixteen;
    Int32 sixteenUpwards;

    Int32 calculatedTotalNumberOfGuests;

    protected void Page_Load(object sender, EventArgs e)
    {
        hotelId = Convert.ToInt32(Session["hotelId"]);
        hotelName = Convert.ToString(Session["hotelName"]);
        arrivalDate = Convert.ToDateTime(Session["arrivalDate"]);
        departureDate = Convert.ToDateTime(Session["departureDate"]);
        underFive = Convert.ToInt32(Session["underFive"]);
        fiveToSixteen = Convert.ToInt32(Session["fiveToSixteen"]);
        sixteenUpwards = Convert.ToInt32(Session["sixteenUpwaards"]);

        calculatedTotalNumberOfGuests = underFive + fiveToSixteen + sixteenUpwards;

        lblHotelName.Text = "T Birmingham";
        lblArrivalDepartureDate.Text = "T 01/03/2020-03/03/2020";
        lblbreakdownOfGuests.Text = "T 1 under five, 1 between five and sixteen and 3 over sixteen";
        lblCost.Text = "T 89.00";

        hotelId = 1;

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@HotelId", hotelId);
        DB.Execute("sproc_tblRoom_SelectAllAvailableRooms");

        string accessible = Convert.ToString(DB.DataTable.Rows[0]["Accessible"]);
        decimal cost = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
        Int32 roomTypeId = Convert.ToInt32(DB.DataTable.Rows[0]["fk2_RoomTypeId"]);

        clsDataConnection DB2 = new clsDataConnection();
        DB2.AddParameter("@RoomTypeId", roomTypeId);
        DB2.Execute("sproc_tblRoomType_FilterByRoomTypeId");

        Int32 singleBed = Convert.ToInt32(DB2.DataTable.Rows[0]["SingleBed"]);
        Int32 doubleBed = Convert.ToInt32(DB2.DataTable.Rows[0]["DoubleBed"]);
        string description = Convert.ToString(DB2.DataTable.Rows[0]["Description "]);

        Response.Write("Accessible: " + accessible);
        Response.Write("<br />");
        Response.Write("Cost: " + cost);
        Response.Write("<br />");
        Response.Write("Single bed: " + singleBed);
        Response.Write("<br />");
        Response.Write("Double bed: " + doubleBed);
        Response.Write("<br />");
        Response.Write("Description: " + description);

    }

    protected void btnContinueToPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }
}