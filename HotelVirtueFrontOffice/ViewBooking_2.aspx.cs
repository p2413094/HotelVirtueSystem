using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ViewBooking_2 : System.Web.UI.Page
{
    Int32 bookingId;
    Int32 bookingLineId;
    Int32 roomId;
    Int32 roomTypeId;
    Int32 singleBed;
    Int32 doubleBed;
    protected void Page_Load(object sender, EventArgs e)
    {

        //bookingLineId = Convert.ToInt32(Session["BookingLineId"]);

        //hard coded for the time being
        bookingLineId = 3;
        //end of hard code

        //bookingLineId = Convert.ToInt32(Session["BookingLineId"]);

        clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
        aBookingLine.thisBookingLine.Find(bookingLineId);

        Label lblHotelName = new Label();
        lblHotelName.Text += "Hard coded: Birmingham";
        pnlBooking.Controls.Add(lblHotelName);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblArrivalDate = new Label();
        lblArrivalDate.CssClass = "body";
        lblArrivalDate.Text = "Arrival date: " +  aBookingLine.thisBookingLine.ArrivalDate.ToShortDateString();
        pnlBooking.Controls.Add(lblArrivalDate);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblDepartureDate = new Label();
        lblDepartureDate.CssClass = "body";
        lblDepartureDate.Text = "Departure date: " + aBookingLine.thisBookingLine.DepartureDate.ToShortDateString();
        pnlBooking.Controls.Add(lblDepartureDate);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblRoomType = new Label();
        lblRoomType.CssClass = "body";
        lblRoomType.Text = "Room type: ";
        roomId = aBookingLine.thisBookingLine.RoomId;

        roomTypeId = GetRoomTypeId();
        GetGetSingleAndDoubleBeds();

        if (singleBed != 0 && doubleBed == 0)
        {
            lblRoomType.Text += "single bed";
        }

        if (singleBed == 0 && doubleBed != 0)
        {
            lblRoomType.Text += "single and double beds";
        }

        if (singleBed != 0 && doubleBed != 0)
        {
            lblRoomType.Text += "double bed";
        }
        pnlBooking.Controls.Add(lblRoomType);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblUnderFive = new Label();
        lblUnderFive.CssClass = "body";
        lblUnderFive.Text = "Under five: " + aBookingLine.thisBookingLine.UnderFive;
        pnlBooking.Controls.Add(lblUnderFive);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblFiveToSixteen = new Label();
        lblFiveToSixteen.CssClass = "body";
        lblFiveToSixteen.Text = "Five to sixteen: " + aBookingLine.thisBookingLine.FiveToSixteen;
        pnlBooking.Controls.Add(lblFiveToSixteen);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblSixteenUpwards = new Label();
        lblSixteenUpwards.CssClass = "body";
        lblSixteenUpwards.Text = "Sixteen upwards: " + aBookingLine.thisBookingLine.SixteenUpwards;
        pnlBooking.Controls.Add(lblSixteenUpwards);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblOther = new Label();
        lblOther.CssClass = "body";
        lblOther.Text = "Other: " + aBookingLine.thisBookingLine.Other;
        pnlBooking.Controls.Add(lblOther);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblExtras = new Label();
        lblExtras.CssClass = "body";
        lblExtras.Text = "Extras";
        pnlBooking.Controls.Add(lblExtras);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));


        Label lblGymAccess = new Label();
        lblGymAccess.CssClass = "body";
        lblGymAccess.Text = "Gym access: ";

        string gymAccess = aBookingLine.thisBookingLine.GymAccess.ToString();
        if (gymAccess == "True")
        {
            lblGymAccess.Text += "Yes";
        }
        else
        {
            lblGymAccess.Text += "No";
        }
        pnlBooking.Controls.Add(lblGymAccess);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblLateCheckout = new Label();
        lblLateCheckout.CssClass = "body";
        lblLateCheckout.Text = "Late checkout: ";
        string lateCheckout = aBookingLine.thisBookingLine.LateCheckout.ToString();
        if (lateCheckout == "True")
        {
            lblLateCheckout.Text += "Yes";
        }
        else
        {
            lblLateCheckout.Text += "No";
        }
        pnlBooking.Controls.Add(lblLateCheckout);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        clsBooking aBooking = new clsBooking();
        bookingId = aBookingLine.thisBookingLine.BookingId;
        aBooking.Find(bookingId);

        Label lblStatus = new Label();
        lblStatus.CssClass = "body leftAlignCost";
        lblStatus.Text = "Status: ";

        string status = aBooking.Cancelled.ToString();
        if (status == "True")
        {
            lblStatus.Text += "Active";
        }
        else
        {
            lblStatus.Text += "Cancelled";
        }
        pnlBooking.Controls.Add(lblStatus);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblTotal = new Label();
        lblTotal.CssClass = "body leftAlignCost";
        lblTotal.Text += "Total: £" + Convert.ToString(aBooking.Total);
        pnlBooking.Controls.Add(lblTotal);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

    pnlBooking.Visible = true;
    }

    Int32 GetRoomTypeId()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@RoomId", roomId);
        DB.Execute("sproc_tblRoom_GetRoomTypeId");
        roomTypeId = Convert.ToInt32(DB.DataTable.Rows[0]["fk2_RoomTypeId"]);

        return roomTypeId;
    }

    void GetGetSingleAndDoubleBeds()
    {
        clsDataConnection DBGetSingleAndDoubleBeds = new clsDataConnection();
        DBGetSingleAndDoubleBeds.AddParameter("RoomTypeId", roomTypeId);
        DBGetSingleAndDoubleBeds.Execute("tblRoomType_GetNoOfSingleDoubleBeds");

        singleBed = Convert.ToInt32(DBGetSingleAndDoubleBeds.DataTable.Rows[0]["SingleBed"]);
        doubleBed = Convert.ToInt32(DBGetSingleAndDoubleBeds.DataTable.Rows[0]["DoubleBed"]);
    }

}