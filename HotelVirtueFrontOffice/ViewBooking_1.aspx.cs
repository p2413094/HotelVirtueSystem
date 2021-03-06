﻿using System;
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
        try
        {
            pnlError.Visible = false;
            Int32 index = 0;
            Int32 recordCount = allBookings.BookingList.Count;

            if (allBookingLines.BookingLineList.Count > 0)
            {
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
                    clsBooking aBooking = new clsBooking();
                    Int32 bookingId;
                    bookingId = bookingLine.BookingId;
                    aBooking.Find(bookingId);
                    lblTotal.Text = "Total: £" + aBooking.Total;
                    pnlBooking.Controls.Add(lblTotal);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    this.Controls.Add(pnlBooking);
                    this.Controls.Add(new LiteralControl("<br />"));

                    index++;
                }
                CreateViewBookingSection();
            }
            else
            {
                Label lblNoBookingsToBeDisplayed = new Label();
                lblNoBookingsToBeDisplayed.Text = "There are no bookings to display";
                pnlError.Controls.Add(lblNoBookingsToBeDisplayed);
                pnlError.Visible = true;
            }
            
        }
        catch
        {
            Label lblError = new Label();
            lblError.Text = "There was a problem connecting to the database";
            pnlError.Controls.Add(lblError);
            pnlError.Controls.Add(new LiteralControl("<br />"));
            pnlError.Controls.Add(new LiteralControl("<br />"));

            Label lblRedirectToHomePage = new Label();
            lblRedirectToHomePage.CssClass = "body";
            lblRedirectToHomePage.Text = "Click the button below to redirect to the home page";
            pnlError.Controls.Add(lblRedirectToHomePage);
            pnlError.Controls.Add(new LiteralControl("<br />"));
            pnlError.Controls.Add(new LiteralControl("<br />"));

            Button btnReturnToHomePage = new Button();
            btnReturnToHomePage.CssClass = "leftButton";
            btnReturnToHomePage.Text = "RETURN TO HOMEPAGE";
            btnReturnToHomePage.Click += BtnReturnToHomePage_Click;
            pnlError.Controls.Add(btnReturnToHomePage);
            pnlError.Controls.Add(new LiteralControl("<br />"));
            pnlError.Controls.Add(new LiteralControl("<br />"));

            pnlError.Visible = true;
        }
    }


    private void BtnReturnToHomePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    void CreateViewBookingSection()
    {
        Int32 index = 0;
        Int32 recordCount = allBookingLines.BookingLineList.Count;

        Panel pnlChooseBooking = new Panel();
        pnlChooseBooking.CssClass = "box";

        Label lblChooseBookingOption = new Label();
        lblChooseBookingOption.Text = "Please choose the bookingLine that you wish to interact with";
        pnlChooseBooking.Controls.Add(lblChooseBookingOption);
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
        btnViewThisBooking.CssClass = "rightButton";
        btnViewThisBooking.Text = "VIEW BOOKING";
        btnViewThisBooking.Click += BtnViewThisBooking_Click;
        pnlChooseBooking.Controls.Add(btnViewThisBooking);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));

        Button btnCancelThisBooking = new Button();
        btnCancelThisBooking.CssClass = "rightButton";
        btnCancelThisBooking.Text = "CANCEL THIS BOOKING";
        btnCancelThisBooking.Click += BtnCancelThisBooking_Click;
        pnlChooseBooking.Controls.Add(btnCancelThisBooking);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));

        Button btnDelete = new Button();
        btnDelete.CssClass = "rightButton";
        btnDelete.Text = "DELETE THIS BOOKING";
        btnDelete.Click += BtnDelete_Click;
        pnlChooseBooking.Controls.Add(btnDelete);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));

        Button btnUpdate = new Button();
        btnUpdate.CssClass = "rightButton";
        btnUpdate.Text = "UPDATE THIS BOOKING";
        btnUpdate.Click += BtnUpdate_Click;
        pnlChooseBooking.Controls.Add(btnUpdate);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));

        Button btnPayForThisBooking = new Button();
        btnPayForThisBooking.CssClass = "rightButton";
        btnPayForThisBooking.Text = "PAY FOR THIS BOOKING";
        btnPayForThisBooking.Click += BtnPayForThisBooking_Click;
        pnlChooseBooking.Controls.Add(btnPayForThisBooking);
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
        pnlChooseBooking.Controls.Add(new LiteralControl("<br />"));
    }

    private void BtnPayForThisBooking_Click(object sender, EventArgs e)
    {
        GetAndSaveBookingLineId();

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@BookingLineId", bookingLineId);
        DB.Execute("sproc_tblPayment_GetPaymentId");

        if (DB.Count == 1)
        {
            Label lblError = new Label();
            lblError.Text = "Error";
            pnlError.Controls.Add(lblError);
            pnlError.Controls.Add(new LiteralControl("<br />"));

            Label lblPaymentExistsMessage = new Label();
            lblPaymentExistsMessage.CssClass = "body";
            lblPaymentExistsMessage.Text = "A payment already exists for this booking. Please try again";
            pnlError.Controls.Add(lblPaymentExistsMessage);
            pnlError.Controls.Add(new LiteralControl("<br />"));

            pnlError.Visible = true;
        }
        else
        {
            decimal total;
            clsBookingLine aBookingLine = new clsBookingLine();
            aBookingLine.Find(bookingLineId);
            Int32 bookingId = aBookingLine.BookingId;

            clsBooking aBooking = new clsBooking();
            aBooking.Find(bookingId);
            total = aBooking.Total;
            Session["Total"] = total;
            Response.Redirect("PayForBooking_1.aspx");
        }
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        Session["updateBooking"] = true;
        GetAndSaveBookingLineId();
        Response.Redirect("ViewBooking_2.aspx");
    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        GetAndSaveBookingLineId();
        allBookingLines.thisBookingLine.Find(bookingLineId);
        Int32 bookingId = allBookingLines.thisBookingLine.BookingId;
        Session["BookingId"] = bookingId;
        Response.Redirect("DeleteBooking_1.aspx");
    }

    private void BtnCancelThisBooking_Click(object sender, EventArgs e)
    {
        GetAndSaveBookingLineId();

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@BookingLineId", bookingLineId);
        DB.Execute("sproc_tblCancellation_GetCancellationId");

        if (DB.Count >= 1)
        {
            Label lblError = new Label();
            lblError.Text = "Error";
            pnlError.Controls.Add(lblError);
            pnlError.Controls.Add(new LiteralControl("<br />"));

            Label lblCancellationExistsMessage = new Label();
            lblCancellationExistsMessage.CssClass = "body";
            lblCancellationExistsMessage.Text = "A cancellation already exists for this booking. Please try again";
            pnlError.Controls.Add(lblCancellationExistsMessage);
            pnlError.Controls.Add(new LiteralControl("<br />"));

            pnlError.Visible = true;
        }
        else
        {
            Response.Redirect("CancelBooking_1.aspx");
        }
    }

    private void BtnViewThisBooking_Click(object sender, EventArgs e)
    {
        GetAndSaveBookingLineId();
        Response.Redirect("ViewBooking_2.aspx");
    }

    Int32 GetAndSaveBookingLineId()
    {
        bookingLineId = Convert.ToInt32(ddlBookingLineId.SelectedValue);
        Session["BookingLineId"] = bookingLineId;
        return bookingLineId;
    }
}