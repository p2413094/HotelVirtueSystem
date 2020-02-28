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

        Label lblHotelName = new Label();
        lblHotelName.Text = "Session";
        pnlBookings.Controls.Add(lblHotelName);

        pnlBookings.Visible = true;

        clsBookingLineCollection allBookingLines = new clsBookingLineCollection();

        foreach (clsBooking booking in allBookings.BookingList)
        {
            pnlBookings.Controls.Add(new LiteralControl("<br />"));
            Label lblBookingId = new Label();
            lblBookingId.Text = "BookingId: " + booking.BookingId;
            pnlBookings.Controls.Add(lblBookingId);

            Int32 calculatedNoOfGuests;    

            foreach (clsBookingLine bookingLine in allBookingLines.BookingLineList)
            {
                Label lblCheckIn = new Label();
                lblCheckIn.CssClass = "body";
                lblCheckIn.Text = "Check-in: " + Convert.ToString(bookingLine.ArrivalDate.ToShortDateString());
                pnlBookings.Controls.Add(lblCheckIn);
                pnlBookings.Controls.Add(new LiteralControl("<br />"));

                Label lblCheckout = new Label();
                lblCheckout.CssClass = "body";
                lblCheckout.Text = "Check-out: " + Convert.ToString(bookingLine.DepartureDate.ToShortDateString());
                pnlBookings.Controls.Add(lblCheckout);
                pnlBookings.Controls.Add(new LiteralControl("<br />"));

                Label lblNoOfGuests = new Label();
                lblNoOfGuests.CssClass = "body";
                calculatedNoOfGuests = bookingLine.UnderFive + bookingLine.FiveToSixteen + bookingLine.SixteenUpwards;
                lblNoOfGuests.Text = "Number of guests: " + Convert.ToString(calculatedNoOfGuests);
                pnlBookings.Controls.Add(lblNoOfGuests);
            }

            pnlBookings.Controls.Add(new LiteralControl("<br />"));

            Label lblCost = new Label();
            lblCost.CssClass = "body";
            lblCost.Text = "Cost: ";
            pnlBookings.Controls.Add(lblCost);
        }
    }
}