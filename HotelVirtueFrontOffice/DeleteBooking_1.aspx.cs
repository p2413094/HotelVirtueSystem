using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class DeleteBookingLine_1 : System.Web.UI.Page
{
    Int32 bookingId;
    Int32 bookingLineId;
    Int32 roomId;
    Int32 roomTypeId;
    Int32 singleBed;
    Int32 doubleBed;

    Int32 paymentId;
    Int32 cancellationId;

    protected void Page_Load(object sender, EventArgs e)
    {
        bookingLineId = Convert.ToInt32(Session["BookingLineId"]);
        clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
        aBookingLine.thisBookingLine.Find(bookingLineId);

        Boolean bookingLineFound = aBookingLine.thisBookingLine.Find(bookingLineId);

        if (bookingLineFound == true)
        {
            Label lblDeleteBookingQuestion = new Label();
            lblDeleteBookingQuestion.Text = "Delete this booking?";
       
            pnlBooking.Controls.Add(lblDeleteBookingQuestion);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblHotelName = new Label();
            lblHotelName.CssClass = "body";
            lblHotelName.Text += "Hard coded: Birmingham";
            pnlBooking.Controls.Add(lblHotelName);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblRoomType = new Label();
            lblRoomType.CssClass = "body";
            lblRoomType.Text = "Room type: ";
            roomId = aBookingLine.thisBookingLine.RoomId;

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
            pnlBooking.Controls.Add(lblRoomType);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblArrivalDate = new Label();
            lblArrivalDate.CssClass = "body";
            lblArrivalDate.Text = "Arrival date: " + aBookingLine.thisBookingLine.ArrivalDate.ToShortDateString();
            pnlBooking.Controls.Add(lblArrivalDate);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblDepartureDate = new Label();
            lblDepartureDate.CssClass = "body";
            lblDepartureDate.Text = "Departure date: " + aBookingLine.thisBookingLine.DepartureDate.ToShortDateString();
            pnlBooking.Controls.Add(lblDepartureDate);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));


            Label lblUnderFive = new Label();
            lblUnderFive.CssClass = "body";
            lblUnderFive.Text = "Under five: " + aBookingLine.thisBookingLine.UnderFive;
            pnlBooking.Controls.Add(lblUnderFive);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblFiveToSixteen = new Label();
            lblFiveToSixteen.CssClass = "body";
            lblFiveToSixteen.Text = "Five to sixteen: " + aBookingLine.thisBookingLine.FiveToSixteen;
            pnlBooking.Controls.Add(lblFiveToSixteen);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblSixteenUpwards = new Label();
            lblSixteenUpwards.CssClass = "body";
            lblSixteenUpwards.Text = "Sixteen upwards: " + aBookingLine.thisBookingLine.SixteenUpwards;
            pnlBooking.Controls.Add(lblSixteenUpwards);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblOther = new Label();
            lblOther.CssClass = "body";
            lblOther.Text = "Other: ";
            string other = aBookingLine.thisBookingLine.Other;

            if (other.Length == 0)
            {
                lblOther.Text += "BLANK";
            }
            else
            {
                lblOther.Text += aBookingLine.thisBookingLine.Other;
            }
            pnlBooking.Controls.Add(lblOther);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblExtras = new Label();
            lblExtras.CssClass = "body";
            lblExtras.Text = "Extras";
            pnlBooking.Controls.Add(lblExtras);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblGymAccess = new Label();
            lblGymAccess.CssClass = "body";
            lblGymAccess.Text = "Gym access: ";

            string gymAccess = aBookingLine.thisBookingLine.GymAccess.ToString();
            if (gymAccess == "True")
            {
                lblGymAccess.Text += "Yes";
            }
            else
            {
                lblGymAccess.Text += "No";
            }
            pnlBooking.Controls.Add(lblGymAccess);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblLateCheckout = new Label();
            lblLateCheckout.CssClass = "body";
            lblLateCheckout.Text = "Late checkout: ";
            string lateCheckout = aBookingLine.thisBookingLine.LateCheckout.ToString();
            if (lateCheckout == "True")
            {
                lblLateCheckout.Text += "Yes";
            }
            else
            {
                lblLateCheckout.Text += "No";
            }
            pnlBooking.Controls.Add(lblLateCheckout);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            clsBooking aBooking = new clsBooking();
            bookingId = aBookingLine.thisBookingLine.BookingId;
            aBooking.Find(bookingId);

            Label lblStatus = new Label();
            lblStatus.CssClass = "body leftAlignCost";
            lblStatus.Text = "Status: ";

            string status = aBooking.Cancelled.ToString();
            if (status == "True")
            {
                lblStatus.Text += "Active";
            }
            else
            {
                lblStatus.Text += "Cancelled";
            }
            pnlBooking.Controls.Add(lblStatus);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Label lblTotal = new Label();
            lblTotal.CssClass = "body leftAlignCost";
            lblTotal.Text += "Total: £" + Convert.ToString(aBooking.Total);
            pnlBooking.Controls.Add(lblTotal);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            Button btnYes = new Button();
            btnYes.CssClass = "leftButton";
            btnYes.Text = "YES";
            btnYes.Click += BtnYes_Click;
            pnlBooking.Controls.Add(btnYes);

            Button btnNo = new Button();
            btnNo.CssClass = "rightButton";
            btnNo.Text = "NO";
            btnNo.Click += BtnNo_Click;
            pnlBooking.Controls.Add(btnNo);
            pnlBooking.Controls.Add(new LiteralControl("<br />"));
            pnlBooking.Controls.Add(new LiteralControl("<br />"));

            pnlBooking.Visible = true;
        }

        else
        {
            DisplayError();
        }
    }

    private void BtnYes_Click(object sender, EventArgs e)
    {
        DeleteBooking();
        Response.Redirect("DeleteBooking_Confirmation.aspx");
    }

    private void BtnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_1.aspx");
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

    void DisplayError()
    {
        Label lblError = new Label();
        lblError.Text = "There was a problem connecting to the database";
        pnlBooking.Controls.Add(lblError);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblRedirectQuestion = new Label();
        lblRedirectQuestion.CssClass = "body";
        lblRedirectQuestion.Text = "Go to current bookings screen or return to home page?";
        pnlBooking.Controls.Add(lblRedirectQuestion);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Button btnReturnToBookings = new Button();
        btnReturnToBookings.CssClass = "leftButton";
        btnReturnToBookings.Text = "RETURN TO BOOKINGS";
        btnReturnToBookings.Click += BtnReturnToBookings_Click;
        pnlBooking.Controls.Add(btnReturnToBookings);

        Button btnReturnToHomePage = new Button();
        btnReturnToHomePage.CssClass = "rightButton";
        btnReturnToHomePage.Text = "RETURN TO HOMEPAGE";
        btnReturnToHomePage.Click += BtnReturnToHomePage_Click;
        pnlBooking.Controls.Add(btnReturnToHomePage);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
    }

    private void BtnReturnToBookings_Click(object sender, EventArgs e)
    {
        Response.Redirect("ViewBooking_1.aspx");
    }

    private void BtnReturnToHomePage_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }





    void DeleteBooking()
    {      
        clsPaymentCollection aPayment = new clsPaymentCollection();
        Boolean paymentExists = GetPaymentId();
        if (paymentExists == true)
        {
            aPayment.ThisPayment.Find(paymentId);
            aPayment.Delete();
        }

        clsCancellationCollection aCancellation = new clsCancellationCollection();
        Boolean cancellationExists = GetCancellationId();
        if (cancellationExists == true)
        {
            aCancellation.thisCancellation.Find(cancellationId);
            aCancellation.Delete();
        }

        clsBookingLineCollection aBookingLine = new clsBookingLineCollection();
        aBookingLine.thisBookingLine.Find(bookingLineId);

        bookingId = aBookingLine.thisBookingLine.BookingId;

        aBookingLine.Delete();

        clsBookingCollection aBooking = new clsBookingCollection();
        aBooking.ThisBooking.BookingId = bookingId;
        aBooking.Delete();
    }




    Boolean GetPaymentId()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("BookingLineId", bookingLineId);
        DB.Execute("sproc_tblPayment_GetPaymentId");

        if (DB.Count == 1)
        {
            paymentId = Convert.ToInt32(DB.DataTable.Rows[0]["PaymentId"]);
            return true;
        }
        else
        {
            return false;
        }
    }

    Boolean GetCancellationId()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("BookingLineId", bookingLineId);
        DB.Execute("sproc_tblCancellation_GetCancellationId");

        if (DB.Count == 1)
        {
            cancellationId = Convert.ToInt32(DB.DataTable.Rows[0]["CancellationId"]);
            return true;
        }
        else
        {
            return false;
        }
    }
}