using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ABooking : System.Web.UI.Page
{
    Int32 bookingLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        bookingLineId = Convert.ToInt32(Session["bookingLineId"]);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (bookingLineId == -1)
        {
            Add();
        }
        else
        {
            Update();
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    void Add()
    {
        clsBookingLineCollection bookingLines = new clsBookingLineCollection();
        //string error = BookingLines.Valid(txtArrivalDate.Text, txtDepartureDate.Text, txtOther.Text, txtRoomId.Text, txtUnderFive.Text,  txtFiveToSixteen.Text, txtSixteenUpwards.Text);
        bookingLines.thisBookingLine.RoomId = Convert.ToInt32(txtRoomId.Text);
        bookingLines.thisBookingLine.UnderFive = Convert.ToInt32(txtUnderFive.Text);
        bookingLines.thisBookingLine.FiveToSixteen = Convert.ToInt32(txtFiveToSixteen.Text);
        bookingLines.thisBookingLine.SixteenUpwards = Convert.ToInt32(txtSixteenUpwards.Text);
        bookingLines.thisBookingLine.ArrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
        bookingLines.thisBookingLine.DepartureDate = Convert.ToDateTime(txtDepartureDate.Text);
        bookingLines.thisBookingLine.GymAccess = Convert.ToBoolean(chkGymAccess.Checked);
        bookingLines.thisBookingLine.LateCheckout = Convert.ToBoolean(chkLateCheckout.Checked);
        bookingLines.thisBookingLine.Other = Convert.ToString(txtOther.Text);

        bookingLines.Add();
        Response.Redirect("Default_Booking.aspx");
    }

    void Update()
    {
        clsBookingLineCollection bookingLines = new clsBookingLineCollection();
        bookingLines.thisBookingLine.Find(bookingLineId);
        bookingLines.thisBookingLine.GymAccess = chkGymAccess.Checked;
        bookingLines.thisBookingLine.LateCheckout = chkLateCheckout.Checked;
        bookingLines.thisBookingLine.Other = Convert.ToString(txtOther.Text);

        bookingLines.Update();
        Response.Redirect("Default_Booking.aspx");
    }
}