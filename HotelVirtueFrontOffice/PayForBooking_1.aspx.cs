using System;
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
    decimal total;
    Int32 bookingLineId;
    Int32 bookingId;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            errorPanel.Visible = false;
            pnlBillingDetails.Visible = false;
            guest = Convert.ToBoolean(Session["Guest"]);
            firstName = Convert.ToString(Session["firstName"]);
            lastName = Convert.ToString(Session["LastName"]);
            hotelName = "Birmingham";//Convert.ToString(Session["Name"]);
            customerId = Convert.ToInt32(Session["customerId"]);
            bookingLineId = Convert.ToInt32(Session["bookingLineId"]);
            total = Convert.ToDecimal(Session["Total"]);

            guest = true;

            if (guest == true)
            {
                lblFullName.Text = "Welcome, Guest";
                lblFullName.CssClass = "centreSlantedHeader";
                lblFullName.Visible = true;

                pnlBillingDetails.Visible = true;
            }
            else
            {
                firstName = Convert.ToString(Session["FirstName"]);
                lastName = Convert.ToString(Session["LastName"]);
                customerId = Convert.ToInt32(Session["CustomerId"]);
            }

            clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
            aBookingLine.thisBookingLine.Find(bookingLineId);
            lblBookingId.Text = "BookingLineId: " + aBookingLine.thisBookingLine.BookingLineId;
            lblHotelName.Text = hotelName;
            lblArrivalDate.Text = "Arrival date: " + aBookingLine.thisBookingLine.ArrivalDate.ToShortDateString();
            lblDepartureDate.Text = "Departure date: " + aBookingLine.thisBookingLine.DepartureDate.ToShortDateString();
            lblUnderFive.Text = "Under five: " + aBookingLine.thisBookingLine.UnderFive;
            lblFiveToSixteen.Text = "Five to sixteen: " + aBookingLine.thisBookingLine.FiveToSixteen;
            lblSixteenUpwards.Text = "Sixteen upwards: " + aBookingLine.thisBookingLine.SixteenUpwards;
            lblGymAccess.Text = "Gym access: " + aBookingLine.thisBookingLine.GymAccess;
            lblLateCheckout.Text = "Late checkout: " + aBookingLine.thisBookingLine.LateCheckout;
            lblTotal.Text = "Total: £" + total;
        }
        catch
        {
            DisplayError();
        }  
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        string cardNumber = txtCardNumber.Text;
        string nameOnCard = txtNameOnCard.Text;
        string cardExpiryDate = txtExpiryDate.Text;
        string cardSecurityCode = txtSecurityCode.Text;

        clsPayment newPayment = new clsPayment();
        string error = newPayment.Valid(cardNumber, nameOnCard, cardExpiryDate, cardSecurityCode);

        if (newPayment.ErrorList.Count != 0)
        {
            Label lblError = new Label();
            lblError.Text = "Error";
            errorPanel.Controls.Add(lblError);
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
            try
            {
                string firstName;
                string lastName;
                string emailAddress;
                Int32 contactNumber;

                if (guest == true)
                {
                    firstName = txtFirstName.Text;
                    lastName = txtLastName.Text;
                    emailAddress = txtEmailAddress.Text;
                    contactNumber = Convert.ToInt32(txtContactNumber.Text);
                    clsDataConnection DB = new clsDataConnection();
                    DB.AddParameter("@FirstName", firstName);
                    DB.AddParameter("@LastName", lastName);
                    DB.AddParameter("@EmailAddress", emailAddress);
                    DB.AddParameter("@ContactNumber", contactNumber);
                    customerId = DB.Execute("sproc_tblCustomer_Insert");
                }


                clsPaymentCollection payments = new clsPaymentCollection();
                //this should be added depending upon whether the customer chooses gust or log in checkout 
                payments.ThisPayment.CustomerId = customerId;                                                    
                payments.ThisPayment.BookingLineId = bookingLineId;//newBookingLineId;
                payments.ThisPayment.DateTimeOfPayment = DateTime.Now;
                payments.ThisPayment.Amount = total;
                payments.ThisPayment.CardNumber = txtCardNumber.Text;
                payments.ThisPayment.NameOnCard = txtNameOnCard.Text;
                payments.ThisPayment.ExpiryDate = txtExpiryDate.Text;
                payments.ThisPayment.SecurityCode = txtSecurityCode.Text;
                payments.ThisPayment.CardType = ddlCardType.SelectedValue;
                payments.Add();
                Response.Redirect("PayForBooking_Success.aspx");
            }
            catch
            {
                DisplayError();
            }

        }
    }

    void DisplayError()
    {
        pnlBookingInformation.Visible = false;
        pnlCardEntry.Visible = false;

        Label lblError = new Label();
        lblError.Text = "There was a problem connecting to the database";
        errorPanel.Controls.Add(lblError);
        errorPanel.Controls.Add(new LiteralControl("<br />"));
        errorPanel.Controls.Add(new LiteralControl("<br />"));

        Label lblRedirectQuestion = new Label();
        lblRedirectQuestion.CssClass = "body";
        lblRedirectQuestion.Text = "Go to current bookings screen or return to home page?";
        errorPanel.Controls.Add(lblRedirectQuestion);
        errorPanel.Controls.Add(new LiteralControl("<br />"));
        errorPanel.Controls.Add(new LiteralControl("<br />"));

        Button btnReturnToBookingPage = new Button();
        btnReturnToBookingPage.CssClass = "leftButton";
        btnReturnToBookingPage.Text = "RETURN TO BOOKINGS";
        btnReturnToBookingPage.Click += BtnReturnToBookingPage_Click;
        errorPanel.Controls.Add(btnReturnToBookingPage);

        Button btnReturnToIndex = new Button();
        btnReturnToIndex.CssClass = "rightButton";
        btnReturnToIndex.Text = "RETURN TO HOME PAGE";
        btnReturnToIndex.Click += BtnReturnToIndex_Click;
        errorPanel.Controls.Add(btnReturnToIndex);
        errorPanel.Controls.Add(new LiteralControl("<br />"));
        errorPanel.Controls.Add(new LiteralControl("<br />"));

        errorPanel.Visible = true;
    }

    private void BtnReturnToBookingPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_1.aspx");
    }

    private void BtnReturnToIndex_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DisplayError();
    }
}