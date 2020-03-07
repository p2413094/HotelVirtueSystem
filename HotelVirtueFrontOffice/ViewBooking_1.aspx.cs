using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ViewBooking_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayBookings();
    }

    protected void btnViewBooking_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_2.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CancelBooking_1.aspx");
    }

    protected void btnPayForBooking_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking.aspx");
    }

    
    void DisplayBookings()
    {
        clsBookingCollection allBookings = new clsBookingCollection();
        clsBookingLineCollection allBookingLines = new clsBookingLineCollection();

        Int32 index = 0;
        Int32 recordCount = allBookings.BookingList.Count;
    
        foreach (clsBookingLine bookingLine in allBookingLines.BookingLineList)
        {
            Int32 calculatedNoOfGuests;

            Panel pnlBooking = new Panel();
            pnlBooking.CssClass = "box";

            Label lblBookingId = new Label();
            lblBookingId.Text = "BookingId: " + bookingLine.BookingId;
            pnlBooking.Controls.Add(lblBookingId);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblCheckIn = new Label();
            lblCheckIn.CssClass = "body";
            lblCheckIn.Text = "Check-in: " + bookingLine.ArrivalDate.ToShortDateString();
            pnlBooking.Controls.Add(lblCheckIn);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblCheckout = new Label();
            lblCheckout.CssClass = "body";
            lblCheckout.Text = "Check-out: " + bookingLine.DepartureDate.ToShortDateString();
            pnlBooking.Controls.Add(lblCheckout);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblNoOfGuests = new Label();
            lblNoOfGuests.CssClass = "body";
            calculatedNoOfGuests = bookingLine.UnderFive + bookingLine.FiveToSixteen + bookingLine.SixteenUpwards;
            lblNoOfGuests.Text = "Number of guests: " + Convert.ToString(calculatedNoOfGuests);
            pnlBooking.Controls.Add(lblNoOfGuests);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblTotal = new Label();
            lblTotal.CssClass = "extrasHeader";
            lblTotal.Text = "Total: £" + allBookings.BookingList[index].Total;
            pnlBooking.Controls.Add(lblTotal);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            this.Controls.Add(pnlBooking);
            this.Controls.Add(new LiteralControl("<br />"));

            index++;           
        }
    }
}