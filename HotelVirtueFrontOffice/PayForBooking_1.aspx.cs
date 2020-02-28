﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class PayForBooking_1 : System.Web.UI.Page
{
    Boolean guest;
    string firstName;
    string lastName;
    string hotelName;
    Int32 customerId;
    Int32 newBookingLineId;


    protected void Page_Load(object sender, EventArgs e)
    {

        guest = Convert.ToBoolean(Session["Guest"]);
        firstName = Convert.ToString(Session["firstName"]);
        lastName = Convert.ToString(Session["LastName"]);
        hotelName = Convert.ToString(Session["Name"]);
        customerId = Convert.ToInt32(Session["customerId"]);
        newBookingLineId = Convert.ToInt32(Session["bookingLineId"]);

        //guest = true;
        guest = false;

        if (guest == true)
        {
            lblFullName.Text = "Welcome, Guest";
            lblFullName.CssClass = "centreSlantedHeader";
            lblFullName.Visible = true;

            lblFirstName.Visible = true;
            txtFirstName.Visible = true;
            lblLastName.Visible = true;
            txtFirstName.Visible = true;
            lblEmailAddress.Visible = true;
            lblEmailAddress.Visible = true;
            lblBillingDetails.Visible = true;
        }
        else
        {
            lblBillingDetails.Visible = false;
            lblFirstName.Visible = false;
            txtFirstName.Visible = false;
            lblLastName.Visible = false;
            txtLastName.Visible = false;
            lblEmailAddress.Visible = false;
            txtEmailAddress.Visible = false;

            firstName = Convert.ToString(Session["FirstName"]);
            lastName = Convert.ToString(Session["LastName"]);
            customerId = Convert.ToInt32(Session["CustomerId"]);
            //bookingLineId = Convert.ToInt32(Session["BookingLineId"]);
        } 

        errorPanel.Visible = false;


        Int32 bookingLineId = 3;
        clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
        aBookingLine.thisBookingLine.Find(bookingLineId);
        lblBookingId.Text = "BookingLineId: " + aBookingLine.thisBookingLine.BookingLineId;
        lblArrivalDate.Text = "Arrival date: " + aBookingLine.thisBookingLine.ArrivalDate.ToShortDateString();
        lblDepartureDate.Text = "Departure date: " + aBookingLine.thisBookingLine.DepartureDate.ToShortDateString();
        lblUnderFive.Text = "Under five: " + aBookingLine.thisBookingLine.UnderFive;
        lblFiveToSixteen.Text = "Five to sixteen: " + aBookingLine.thisBookingLine.FiveToSixteen;
        lblSixteenUpwards.Text = "Sixteen upwards: " + aBookingLine.thisBookingLine.SixteenUpwards;
        lblGymAccess.Text = "Gym access: " + aBookingLine.thisBookingLine.GymAccess;
        lblLateCheckout.Text = "Late checkout: " + aBookingLine.thisBookingLine.LateCheckout;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string cardNumber = txtCardNumber.Text;
        string nameOnCard = txtNameOnCard.Text;
        string cardExpiryDate = txtExpiryDate.Text;
        string cardSecurityCode = txtSecurityCode.Text;

        clsPayment newPayment = new clsPayment();
        string error = newPayment.Valid(cardNumber, nameOnCard, cardExpiryDate, cardSecurityCode);


        Label lblError = new Label();
        lblError.Text = "Error";
        errorPanel.Controls.Add(lblError);

        if (newPayment.ErrorList.Count != 0)
        {
            errorPanel.Visible = true;
            foreach (string errorItem in newPayment.ErrorList)
            {
                errorPanel.Controls.Add(new LiteralControl("<br />"));
                Label lblErrorItem = new Label();
                lblErrorItem.Text = errorItem;
                lblErrorItem.CssClass = "body";
                errorPanel.Controls.Add(lblErrorItem);
            }
        }
        else
        {
            clsPaymentCollection payments = new clsPaymentCollection();
            payments.ThisPayment.CustomerId = customerId;
            payments.ThisPayment.BookingLineId = 3;
            payments.ThisPayment.DateTimeOfPayment = DateTime.Now;
            payments.ThisPayment.Amount = 79.99m;
            payments.ThisPayment.CardNumber = txtCardNumber.Text;
            payments.ThisPayment.NameOnCard = txtNameOnCard.Text;
            payments.ThisPayment.ExpiryDate = txtExpiryDate.Text;
            payments.ThisPayment.SecurityCode = txtSecurityCode.Text;
            payments.ThisPayment.CardType = ddlCardType.SelectedValue;
            payments.Add();
            Response.Redirect("PayForBooking_Success.aspx");
        }
        
    }
}