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

        clsBookingLine aBookingLine = new clsBookingLine();
        aBookingLine.Find(bookingLineId);
        lblHotelName.Text += "Hard coded: Birmingham";
        lblCheckIn.Text += aBookingLine.ArrivalDate.ToShortDateString();
        lblCheckout.Text += aBookingLine.DepartureDate.ToShortDateString();
        roomId = aBookingLine.RoomId;

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

        lblUnderFive.Text += aBookingLine.UnderFive;
        lblFiveToSixteen.Text += aBookingLine.FiveToSixteen;
        lblSixteenUpwards.Text += aBookingLine.SixteenUpwards;
        lblOther.Text += aBookingLine.Other;
        lblGymAccess.Text += aBookingLine.GymAccess;
        lblLateCheckout.Text += aBookingLine.LateCheckout.ToString();

        clsBooking aBooking = new clsBooking();
        bookingId = aBookingLine.BookingId;
        aBooking.Find(bookingId);

        string status = aBooking.Cancelled.ToString();
        if (status == "True")
        {
            lblStatus.Text += "Active";
        }
        else
        {
            lblStatus.Text = "Cancelled";
        }

        lblTotal.Text += Convert.ToString(aBooking.Total);

        lblHotelName.Visible = true;
        lblCheckIn.Visible = true;
        lblCheckout.Visible = true;
        lblRoomType.Visible = true;
        lblUnderFive.Visible = true;
        lblFiveToSixteen.Visible = true;
        lblSixteenUpwards.Visible = true;
        lblGymAccess.Visible = true;
        lblLateCheckout.Visible = true;
        lblStatus.Visible = true;
        lblTotal.Visible = true;
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