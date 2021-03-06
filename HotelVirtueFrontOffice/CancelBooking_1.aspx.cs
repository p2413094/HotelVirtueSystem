﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class CancelBooking_1 : System.Web.UI.Page
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

    Int32 bookingId;
    Int32 bookingLineId;

    protected void Page_Load(object sender, EventArgs e)
    {
        bookingLineId = Convert.ToInt32(Session["BookingLineId"]);
        clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
        Boolean bookingLineIdFound = aBookingLine.thisBookingLine.Find(bookingLineId);
        if (bookingLineIdFound == true)
        {
            bookingId = aBookingLine.thisBookingLine.BookingId;
            lblBookingLineId.Text = "BookingLineId: " + aBookingLine.thisBookingLine.BookingLineId;
            lblCheckIn.Text = "Arrival date: " + aBookingLine.thisBookingLine.ArrivalDate.ToShortDateString();
            lblCheckOut.Text = "Departure date: " + aBookingLine.thisBookingLine.DepartureDate.ToShortDateString();
            lblUnderFive.Text = "Under Five: " + aBookingLine.thisBookingLine.UnderFive;
            lblFiveToSixteen.Text = "Five to sixteen: " + aBookingLine.thisBookingLine.FiveToSixteen;
            lblSixteenUpwards.Text = "Sixteen upwards: " + aBookingLine.thisBookingLine.SixteenUpwards;

            lblGymAccess.Text = "Gym access: " + aBookingLine.thisBookingLine.GymAccess;
            lblLateCheckout.Text = "Late checkout: " + aBookingLine.thisBookingLine.LateCheckout;

            errorPanel.Visible = false;
            lblEnterReason.Visible = false;
            txtReason.Visible = false;
        }
        else
        {
            pnlBooking.Visible = false;
            DisplayError();
        }        
    }

    protected void btnCancelBooking_Click(object sender, EventArgs e)
    {
        string reason;
        if (ddlCancellationReason.SelectedIndex != 5)
        {
            reason = Convert.ToString(ddlCancellationReason.SelectedItem);
        }
        else
        {
            reason = txtReason.Text;
        }

        clsCancellation newCancellation = new clsCancellation();
        newCancellation.Valid(reason);

        Label lblError = new Label();
        lblError.Text = "Error";
        errorPanel.Controls.Add(lblError);
        if (newCancellation.ErrorList.Count != 0)
        {
            foreach (string errorItem in newCancellation.ErrorList)
            {
                errorPanel.Visible = true;
                errorPanel.Controls.Add(new LiteralControl("<br />"));
                Label lblErrorItem = new Label();
                lblErrorItem.Text = errorItem;
                lblErrorItem.CssClass = "body";
                errorPanel.Controls.Add(lblErrorItem);
            }
        }
        else
        {
            clsCancellationCollection cancellations = new clsCancellationCollection();
            cancellations.thisCancellation.BookingLineId = bookingLineId;
            cancellations.thisCancellation.DateTimeOfCancellation = DateTime.Now;
            cancellations.thisCancellation.Reason = reason;
            cancellations.Add();

            //bookingId = 1;
            clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
            aBookingLine.thisBookingLine.Find(bookingLineId);
            bookingId = aBookingLine.thisBookingLine.BookingId;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@BookingId", bookingId);
            DB.Execute("sproc_tblBooking_UpdateBookingToCancelled");
            Response.Redirect("CancelBooking_2.aspx");
        }      
    }

    protected void ddlCancellationReason_SelectedIndexChanged(object sender, EventArgs e)
    {       
        if (ddlCancellationReason.SelectedIndex == 5)
        {
            lblEnterReason.Visible = true;
            txtReason.Visible = true;
        }       
    }

    void DisplayError()
    {
        Label lblError = new Label();
        lblError.Text = "There was a problem connecting to the database";
        errorPanel.Controls.Add(lblError);
        errorPanel.Controls.Add(new LiteralControl("<br />"));
        errorPanel.Controls.Add(new LiteralControl("<br />"));

        Label lblRedirectQuestion = new Label();
        lblRedirectQuestion.CssClass = "body";
        lblRedirectQuestion.Text = "Go to current bookings or return to home page?";
        errorPanel.Controls.Add(lblRedirectQuestion);
        errorPanel.Controls.Add(new LiteralControl("<br />"));
        errorPanel.Controls.Add(new LiteralControl("<br />"));

        Button btnReturnToBookings = new Button();
        btnReturnToBookings.CssClass = "leftButton";
        btnReturnToBookings.Text = "RETURN TO BOOKINGS";
        btnReturnToBookings.Click += BtnReturnToBookings_Click;
        errorPanel.Controls.Add(btnReturnToBookings);

        Button btnReturnToHomePage = new Button();
        btnReturnToHomePage.CssClass = "rightButton";
        btnReturnToHomePage.Text = "RETURN TO HOMEPAGE";
        btnReturnToHomePage.Click += BtnReturnToHomePage_Click;
        errorPanel.Controls.Add(btnReturnToHomePage);
        errorPanel.Controls.Add(new LiteralControl("<br />"));
        errorPanel.Controls.Add(new LiteralControl("<br />"));
    }

    private void BtnReturnToBookings_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_1.aspx");
    }

    private void BtnReturnToHomePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}