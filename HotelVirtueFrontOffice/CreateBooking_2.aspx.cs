using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class CreateBooking_2 : System.Web.UI.Page
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

    Int32 createdBookingId;
    Int32 createdBookingLineId;

    Boolean guest;
    TextBox txtOther = new TextBox();
    TextBox txtFirstName = new TextBox();
    TextBox txtLastName = new TextBox();
    TextBox txtContactNumber = new TextBox();
    TextBox txtEmailAddress = new TextBox();


    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pnlError.Visible = false;
            //this will be implemented during integration
            //customerId = Convert.ToInt32(Session["CustomerId"]);
            //guest = Convert.ToBoolean(Session["Guest"]);

            if (guest != true)
            {
                customerId = Convert.ToInt32(Session["CustomerId"]);
            }

            //these are temporary
            hotelId = 1;
            hotelName = "Birmimgham";
            roomId = Convert.ToInt32(Session["RoomId"]);
            customerId = 1;
            arrivalDate = Convert.ToDateTime("06/03/2020").ToShortDateString();
            departureDate = Convert.ToDateTime("09/03/2020").ToShortDateString();
            underFive = Convert.ToInt32(Session["UnderFive"]);
            fiveToSixteen = Convert.ToInt32(Session["FiveToSixteen"]);
            sixteenUpwards = Convert.ToInt32(Session["SixteenUpwards"]);
            total = Convert.ToDecimal(Session["Total"]);
            gymAccess = Convert.ToBoolean(Session["GymAccess"]);
            lateCheckout = Convert.ToBoolean(Session["LateCheckout"]);

            Label lblHotelName = new Label();
            lblHotelName.Text = "Hotel: " + hotelName;
            pnlBookingInformation.Controls.Add(lblHotelName);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblArrivalDate = new Label();
            lblArrivalDate.CssClass = "body";
            lblArrivalDate.Text = "Arrival date: " + arrivalDate;
            pnlBookingInformation.Controls.Add(lblArrivalDate);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblDepartureDate = new Label();
            lblDepartureDate.CssClass = "body";
            lblDepartureDate.Text = "Departure date: " + departureDate;
            pnlBookingInformation.Controls.Add(lblDepartureDate);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblUnderFive = new Label();
            lblUnderFive.CssClass = "body";
            lblUnderFive.Text = "Under five: " + underFive;
            pnlBookingInformation.Controls.Add(lblUnderFive);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblFiveToSixteen = new Label();
            lblFiveToSixteen.CssClass = "body";
            lblFiveToSixteen.Text = "Five to sixteen: " + fiveToSixteen;
            pnlBookingInformation.Controls.Add(lblFiveToSixteen);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblSixteenUpwards = new Label();
            lblSixteenUpwards.CssClass = "body";
            lblSixteenUpwards.Text = "Sixteen upwards: " + sixteenUpwards;
            pnlBookingInformation.Controls.Add(lblSixteenUpwards);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblExtras = new Label();
            lblExtras.CssClass = "body";
            lblExtras.Text = "Extras";
            pnlBookingInformation.Controls.Add(lblExtras);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblGymAccess = new Label();
            lblGymAccess.CssClass = "body";
            lblGymAccess.Text = "Gym access: " + gymAccess;
            pnlBookingInformation.Controls.Add(lblGymAccess);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblLateCheckout = new Label();
            lblLateCheckout.CssClass = "body";
            lblLateCheckout.Text = "Late checkout: " + lateCheckout;
            pnlBookingInformation.Controls.Add(lblLateCheckout);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Label lblTotal = new Label();
            lblTotal.CssClass = "body leftAlignCost";
            lblTotal.Text = "Total: £" + total;
            pnlBookingInformation.Controls.Add(lblTotal);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            if (guest == true)
            {
                Label lblEnterGuestInformation = new Label();
                lblEnterGuestInformation.CssClass = "body";
                lblEnterGuestInformation.Text = "Please enter in the information requested:";
                pnlBookingInformation.Controls.Add(lblEnterGuestInformation);
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));


                Label lblFirstName = new Label();
                lblFirstName.CssClass = "body left";
                lblFirstName.Text = "First name: ";
                pnlBookingInformation.Controls.Add(lblFirstName);
                txtFirstName.CssClass = "body guestEntryField";
                pnlBookingInformation.Controls.Add(txtFirstName);
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

                Label lblLastName = new Label();
                lblLastName.CssClass = "body left";
                lblLastName.Text = "Last name: ";
                pnlBookingInformation.Controls.Add(lblLastName);
                txtLastName.CssClass = "body guestEntryField";
                pnlBookingInformation.Controls.Add(txtLastName);
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

                Label lblContactNumber = new Label();
                lblContactNumber.CssClass = "body left";
                lblContactNumber.Text = "Contact number: ";
                pnlBookingInformation.Controls.Add(lblContactNumber);
                txtContactNumber.CssClass = "body guestEntryField";
                pnlBookingInformation.Controls.Add(txtContactNumber);
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

                Label lblEmailAddress = new Label();
                lblEmailAddress.CssClass = "body left";
                lblEmailAddress.Text = "Email address: ";
                pnlBookingInformation.Controls.Add(lblEmailAddress);
                txtEmailAddress.CssClass = "body guestEntryField";
                pnlBookingInformation.Controls.Add(txtEmailAddress);
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
                pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            }

            Label lblOther = new Label();
            lblOther.CssClass = "body";
            lblOther.Text = "Please add any notes for the booking in the field below";
            pnlBookingInformation.Controls.Add(lblOther);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            txtOther.CssClass = "multiLineTextField";
            txtOther.TextMode = TextBoxMode.MultiLine;
            txtOther.Rows = 10;
            pnlBookingInformation.Controls.Add(txtOther);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));

            Button btnPayNow = new Button();
            btnPayNow.CssClass = "leftButton";
            btnPayNow.Text = "PAY NOW";
            btnPayNow.Click += BtnPayNow_Click;
            pnlBookingInformation.Controls.Add(btnPayNow);

            Button btnPayLater = new Button();
            btnPayLater.CssClass = "rightButton";
            btnPayLater.Text = "PAY LATER";
            btnPayLater.Click += BtnPayLater_Click;
            pnlBookingInformation.Controls.Add(btnPayLater);
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
            pnlBookingInformation.Controls.Add(new LiteralControl("<br />"));
        }

        catch
        {
            pnlBookingInformation.Visible = false;
            pnlError.Visible = true;

            Label lblError = new Label();
            lblError.Text = "There was a problem connecting to the database";
            pnlError.Controls.Add(lblError);
            pnlError.Controls.Add(new LiteralControl("<br />"));
            pnlError.Controls.Add(new LiteralControl("<br />"));

            Label lblRedirectQuestion = new Label();
            lblRedirectQuestion.CssClass = "body";
            lblRedirectQuestion.Text = "Go to current bookings screen or return to home page?";
            pnlError.Controls.Add(lblRedirectQuestion);
            pnlError.Controls.Add(new LiteralControl("<br />"));
            pnlError.Controls.Add(new LiteralControl("<br />"));

            Button btnReturnToBookings = new Button();
            btnReturnToBookings.CssClass = "leftButton";
            btnReturnToBookings.Text = "RETURN TO BOOKINGS";
            btnReturnToBookings.Click += BtnReturnToBookings_Click;
            pnlError.Controls.Add(btnReturnToBookings);

            Button btnReturnToHomePage = new Button();
            btnReturnToHomePage.CssClass = "rightButton";
            btnReturnToHomePage.Text = "RETURN TO HOMEPAGE";
            btnReturnToHomePage.Click += BtnReturnToHomePage_Click;
            pnlError.Controls.Add(btnReturnToHomePage);
            pnlError.Controls.Add(new LiteralControl("<br />"));
            pnlError.Controls.Add(new LiteralControl("<br />"));
        }

    }

    private void BtnPayLater_Click(object sender, EventArgs e)
    {
        Add();
        Response.Redirect("CreateBooking_Confirmation.aspx");
    }

    private void BtnPayNow_Click(object sender, EventArgs e)
    {
        Add();
        Session["BookingId"] = createdBookingId;
        Session["BookingLineId"] = createdBookingLineId;
        Session["Total"] = total;

        Response.Redirect("PayForBooking_1.aspx");
    }

    void Add()
    {
        if (guest == true)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string contactNumber = txtContactNumber.Text;
            string emailAddress = txtEmailAddress.Text;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@FirstName", firstName);
            DB.AddParameter("@LastName", lastName);
            DB.AddParameter("@EmailAddress", emailAddress);
            DB.AddParameter("@ContactNumber", contactNumber);
            customerId = DB.Execute("sproc_tblCustomer_Insert");
        }
        //if they're a registered customer 
        else
        {
            clsBookingCollection allBookings = new clsBookingCollection();
            clsBooking newBooking = new clsBooking();
            newBooking.HotelId = hotelId;

            //this needs looking at 
            newBooking.AdminId = 1;
            //
            //this needs looking at
            newBooking.CustomerId = customerId;

            newBooking.DateTimeOfBooking = DateTime.Now;
            newBooking.Total = total;
            allBookings.ThisBooking = newBooking;
            Int32 createdBookingId = allBookings.Add();

            clsBookingLineCollection allBookingLines = new clsBookingLineCollection();
            clsBookingLine newBookingLine = new clsBookingLine();
            newBookingLine.ArrivalDate = Convert.ToDateTime(arrivalDate);
            newBookingLine.DepartureDate = Convert.ToDateTime(departureDate);
            newBookingLine.BookingId = createdBookingId;
            newBookingLine.RoomId = roomId;
            newBookingLine.UnderFive = underFive;
            newBookingLine.FiveToSixteen = fiveToSixteen;
            newBookingLine.SixteenUpwards = sixteenUpwards;
            newBookingLine.GymAccess = gymAccess;
            newBookingLine.LateCheckout = lateCheckout;
            newBookingLine.Other = txtOther.Text;

            allBookingLines.thisBookingLine = newBookingLine;
            createdBookingLineId = allBookingLines.Add();

            Boolean newBookingFound = newBooking.Find(createdBookingId);
            Boolean newBookingLineIdFound = newBookingLine.Find(createdBookingLineId);
        } 
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