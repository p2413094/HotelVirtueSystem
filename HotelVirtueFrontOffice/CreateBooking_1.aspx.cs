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

        lblHotelName.Text = "HC Birmingham";
        lblArrivalDepartureDate.Text = "HC 01/03/2020-03/03/2020";
        lblbreakdownOfGuests.Text = "HC 1 under five, 1 between five and sixteen and 3 over sixteen";
        lblCost.Text = "HC 89.00";

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

        Label lblRoomType = new Label();
        if (singleBed != 0 && doubleBed != 0)
        {
            lblRoomType.Text = "Both single and double beds";
        }
        pnlBooking.Controls.Add(lblRoomType);

        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        Image imgRoom = new Image();
        imgRoom.ImageUrl = "Images/HotelRoom1.jpg";
        imgRoom.CssClass = "image";
        pnlBooking.Controls.Add(imgRoom);

        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        Label lblAccessible = new Label();
        lblAccessible.CssClass = "rateOptions";
        lblAccessible.Text = "Accessible: " + accessible;
        pnlBooking.Controls.Add(lblAccessible);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblSingleBed = new Label();
        lblSingleBed.CssClass = "rateOptions";
        lblSingleBed.Text = "Number of single beds: " + singleBed;
        pnlBooking.Controls.Add(lblSingleBed);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblDoubleBed = new Label();
        lblDoubleBed.CssClass = "rateOptions";
        lblDoubleBed.Text = "Number of double beds: " + doubleBed;
        pnlBooking.Controls.Add(lblDoubleBed);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblDescription = new Label();
        lblDescription.CssClass = "rateOptions";
        lblDescription.Text = "Description: " + description;
        pnlBooking.Controls.Add(lblDescription);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));      

        pnlBooking.Visible = true;
    }

    protected void btnContinueToPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }
}