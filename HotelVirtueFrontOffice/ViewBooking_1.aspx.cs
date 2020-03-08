using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ViewBooking_1 : System.Web.UI.Page
{
    DropDownList ddlBookingLineId = new DropDownList();
    clsBookingCollection allBookings = new clsBookingCollection();
    clsBookingLineCollection allBookingLines = new clsBookingLineCollection();

    Int32 bookingLineId;

    protected void Page_Load(object sender, EventArgs e)
    {
        DisplayBookings();
        CreateViewBookingSection();
    }

    void DisplayBookings()
    {     
        Int32 index = 0;
        Int32 recordCount = allBookings.BookingList.Count;
    
        foreach (clsBookingLine bookingLine in allBookingLines.BookingLineList)
        {
            Int32 calculatedNoOfGuests;

            Panel pnlBooking = new Panel();
            pnlBooking.CssClass = "box";

            Label lblBookingLineId = new Label();
            lblBookingLineId.Text = "BookingLineId: " + bookingLine.BookingLineId;
            pnlBooking.Controls.Add(lblBookingLineId);
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

    void CreateViewBookingSection()
    {
        Int32 index = 0;
        Int32 recordCount = allBookingLines.BookingLineList.Count;

        Panel pnlChooseBooking = new Panel();
        pnlChooseBooking.CssClass = "box";

        Label lblChooseBooking = new Label();
        lblChooseBooking.Text = "Please choose the booking that you wish to view";
        pnlChooseBooking.Controls.Add(lblChooseBooking);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));

        while (index < recordCount)
        {
            ddlBookingLineId.Items.Add((Convert.ToString(allBookingLines.BookingLineList[index].BookingLineId)));
            index++;
        }

        pnlChooseBooking.Controls.Add(ddlBookingLineId);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));

        Form.Controls.Add(pnlChooseBooking);
        Form.Controls.Add(new LiteralControl("<br />"));

        Button btnViewThisBooking = new Button();
        btnViewThisBooking.CssClass = "continueButton";
        btnViewThisBooking.Text = "VIEW BOOKING";
        btnViewThisBooking.Click += BtnViewThisBooking_Click;
        pnlChooseBooking.Controls.Add(btnViewThisBooking);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
    }

    private void BtnViewThisBooking_Click(object sender, EventArgs e)
    {
        bookingLineId = Convert.ToInt32(ddlBookingLineId.SelectedValue);
        Session["BookingLineId"] = bookingLineId;
        Response.Redirect("ViewBooking_2.aspx");
    }
}