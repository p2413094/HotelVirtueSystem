using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class CreateBooking_1 : System.Web.UI.Page
{
    Int32 hotelId;
    string hotelName;
    DateTime arrivalDate;
    DateTime departureDate;
    Int32 underFive;
    Int32 fiveToSixteen;
    Int32 sixteenUpwards;
    
    Int32 roomId;

    DropDownList ddlRoomId = new DropDownList();
    Label lblTotal = new Label();

    Panel pnlBooking = new Panel();
    Image imgDoubleBed = new Image();

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            pnlError.Visible = false;
            hotelId = Convert.ToInt32(Session["hotelId"]); //fine
            hotelName = Convert.ToString(Session["hotelName"]); //never changed 
            arrivalDate = Convert.ToDateTime(Session["arrivalDate"]); //never changed
            departureDate = Convert.ToDateTime(Session["departureDate"]); //never changed 
            underFive = Convert.ToInt32(Session["underFive"]); //never changed 
            fiveToSixteen = Convert.ToInt32(Session["fiveToSixteen"]); //never changed
            sixteenUpwards = Convert.ToInt32(Session["sixteenUpwards"]); //never changed 

            lblHotelName.Text = "HC Birmingham";
            lblArrivalDepartureDate.Text = arrivalDate + "-" + departureDate;
            lblbreakdownOfGuests.Text = underFive + " under five" + fiveToSixteen + " between five and sixteen" + sixteenUpwards + " and 3 over sixteen";

            //temporarily 
            //hotelId = 1;

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@HotelId", hotelId);
            DB.Execute("sproc_tblRoom_SelectAllAvailableRooms");

            Int32 newIndex = 0;
            while (newIndex < DB.Count)
            {
                Int32 roomId;
                decimal price;
                roomId = Convert.ToInt32(DB.DataTable.Rows[newIndex]["RoomID"]);
                Boolean accessible = Convert.ToBoolean(DB.DataTable.Rows[newIndex]["Accessible"]);
                price = Convert.ToDecimal(DB.DataTable.Rows[newIndex]["Price"]);

                Int32 roomTypeId = Convert.ToInt32(DB.DataTable.Rows[newIndex]["RoomTypeId"]);

                clsDataConnection DB2 = new clsDataConnection();
                DB2.AddParameter("@RoomTypeId", roomTypeId);
                DB2.Execute("sproc_tblRoomType_FilterByRoomTypeId");

                Int32 singleBed = Convert.ToInt32(DB2.DataTable.Rows[0]["SingleBed"]);
                Int32 doubleBed = Convert.ToInt32(DB2.DataTable.Rows[0]["DoubleBed"]);
                string description = Convert.ToString(DB2.DataTable.Rows[0]["Description "]);

                //single bed 
                if (singleBed != 0 && doubleBed == 0)
                {
                    this.Controls.Add(new LiteralControl("<br />"));
                    pnlBooking.CssClass = "box";
                    Label lblroomType = new Label();
                    lblroomType.Text = "Single bed";
                    pnlBooking.Controls.Add(lblroomType);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayRoomId(roomId);

                    DisplaySingleBedImage();

                    Label lblSingleBed = new Label();
                    lblSingleBed.CssClass = "rateOptions";
                    lblSingleBed.Text = "Number of single beds: " + singleBed;
                    pnlBooking.Controls.Add(lblSingleBed);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayDetails(description, accessible, price);

                    CreateLineBreak(3);

                    this.Controls.Add(pnlBooking);
                }

                //double bed 
                if (singleBed == 0 && doubleBed != 0)
                {
                    pnlBooking.CssClass = "box";
                    Label lblroomType = new Label();
                    lblroomType.Text = "Double bed";
                    pnlBooking.Controls.Add(lblroomType);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayRoomId(roomId);

                    imgDoubleBed = new Image();
                    DisplayDoubleBedImage();

                    Label lblDoubleBed = new Label();
                    lblDoubleBed.CssClass = "rateOptions";
                    lblDoubleBed.Text = "Number of double beds: " + doubleBed;
                    pnlBooking.Controls.Add(lblDoubleBed);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayDetails(description, accessible, price);

                    CreateLineBreak(6);

                    this.Controls.Add(pnlBooking);
                }

                //single and double bed 
                if (singleBed != 0 && doubleBed != 0)
                {
                    this.Controls.Add(new LiteralControl("<br />"));
                    pnlBooking.CssClass = "box";
                    Label lblroomType = new Label();
                    lblroomType.Text = "Single and double beds";
                    pnlBooking.Controls.Add(lblroomType);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayRoomId(roomId);

                    DisplaySingleBedImage();

                    Label lblSingleBed = new Label();
                    lblSingleBed.CssClass = "rateOptions";
                    lblSingleBed.Text = "Number of single beds: " + singleBed;
                    pnlBooking.Controls.Add(lblSingleBed);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    Label lblDoubleBed = new Label();
                    lblDoubleBed.CssClass = "rateOptions";
                    lblDoubleBed.Text = "Number of double beds: " + doubleBed;
                    pnlBooking.Controls.Add(lblDoubleBed);
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayDetails(description, accessible, price);

                    pnlBooking.Controls.Add(new LiteralControl("<br />"));
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));

                    DisplayDoubleBedImage();

                    if (DB2.Count == 1)
                    {
                        CreateLineBreak(11);
                    }

                    this.Controls.Add(pnlBooking);
                }
                newIndex++;
            }

            clsDataConnection DBGymAndLateCheckout = new clsDataConnection();
            DBGymAndLateCheckout.AddParameter("@HotelID", hotelId);
            DBGymAndLateCheckout.Execute("sproc_tblHotel_GetGymAndLateCheckout");

            Boolean gymAccess = Convert.ToBoolean(DBGymAndLateCheckout.DataTable.Rows[0]["GymAccess"]);
            Boolean lateCheckout = Convert.ToBoolean(DBGymAndLateCheckout.DataTable.Rows[0]["LateCheckout"]);

            if (gymAccess != false || lateCheckout != false)
            {
                if (gymAccess == true)
                {
                    pnlExtras.Visible = true;

                    if (lateCheckout == true)
                    {
                        for (int i = 0; i < 6; i += 1)
                        {
                            pnlExtras.Controls.Add(new LiteralControl("<br />"));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i += 1)
                        {
                            pnlExtras.Controls.Add(new LiteralControl("<br />"));
                        }
                    }
                }
                else
                {
                    lblGymAccess.Visible = false;
                    imgGym.Visible = false;
                    lblAddGymToBooking.Visible = false;
                    rdobtnlstGymCost.Visible = false;
                    pnlExtras.Visible = false;
                }

                if (lateCheckout == true)
                {
                    lblLateCheckout.Visible = true;
                    lblAddLateCheckoutToBooking.Visible = true;
                    pnlExtras.Controls.Add(new LiteralControl("<br />"));
                    imgLateCheckout.Visible = true;
                    rdobtnlstLateCheckout.Visible = true;
                    for (int i = 0; i < 8; i += 1)
                    {
                        pnlLateCheckout.Controls.Add(new LiteralControl("<br />"));
                    }
                }
                else
                {
                    lblLateCheckout.Visible = false;
                    lblAddLateCheckoutToBooking.Visible = false;
                    imgLateCheckout.Visible = false;
                    rdobtnlstLateCheckout.Visible = false;
                }

                pnlExtras.Visible = true;
            }
            else
            {
                pnlMainExtras.Visible = false;            
            }

            Panel pnlStaySummary = new Panel();
            pnlStaySummary.CssClass = "box";

            Label lblYourBooking = new Label();
            lblYourBooking.Text = "Your booking";
            pnlStaySummary.Controls.Add(lblYourBooking);
            pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

            Label lblChooseRoom = new Label();
            lblChooseRoom.CssClass = "body";
            lblChooseRoom.Text = "Please choose the room that you would like: ";
            pnlStaySummary.Controls.Add(lblChooseRoom);

            Int32 index = 0;
            while (index < DB.Count)
            {
                ddlRoomId.Items.Add(DB.DataTable.Rows[index]["RoomId"].ToString());
                index++;
            }
            pnlStaySummary.Controls.Add(ddlRoomId);
            pnlStaySummary.Controls.Add(new LiteralControl("<br />"));
            pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

            Button btnContinue = new Button();
            btnContinue.CssClass = "continueButton";
            btnContinue.Text = "CONTINUE";
            btnContinue.Click += BtnContinue_Click;
            pnlStaySummary.Controls.Add(btnContinue);

            pnlStaySummary.Controls.Add(new LiteralControl("<br />"));
            pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

            Form.Controls.Add(pnlStaySummary);

            if (IsPostBack == false)
            {
                rdobtnlstGymCost.SelectedValue = "True";
                rdobtnlstLateCheckout.SelectedValue = "True";
            }
        }
        catch
        {
            tblBookingInformation.Visible = false;
            pnlMainExtras.Visible = false;
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

    private void BtnContinue_Click(object sender, EventArgs e)
    {   
        CalculateCost();
        GetValues();
        Response.Redirect("CreateBooking_2.aspx");
    }

    decimal CalculateCost()
    {
        arrivalDate = Convert.ToDateTime("03/03/2020");
        departureDate = Convert.ToDateTime("06/03/2020");
     
        Int32 numberOfDays = (departureDate - arrivalDate).Days;
    
        roomId = Convert.ToInt32(ddlRoomId.SelectedValue);

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@RoomId", roomId);
        DB.Execute("sproc_tblRoom_FilterByRoomId");
        decimal roomCost = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);

        decimal totalCost;
        totalCost = numberOfDays * roomCost;

        if (rdobtnlstGymCost.SelectedValue != "No")
        {
            totalCost += 10.00m;
        }

        if (rdobtnlstLateCheckout.SelectedValue != "No")
        {
            totalCost += 10.00m;
        }

        return totalCost;
    }

    void GetValues()
    {
        Boolean gymAccess = Convert.ToBoolean(rdobtnlstGymCost.SelectedValue);
        Boolean lateCheckout = Convert.ToBoolean(rdobtnlstLateCheckout.SelectedValue);

        string shortenedArrivalDate = arrivalDate.ToShortDateString();
        string shortenedDepartureDate = departureDate.ToShortDateString();

        Session["HotelId"] = hotelId;
        Session["HotelName"] = "Birmingham";
        Session["Total"] = CalculateCost();
        Session["RoomId"] = roomId;
        Session["UnderFive"] = underFive;
        Session["FiveToSixteen"] = fiveToSixteen;
        Session["SixteenUpwards"] = sixteenUpwards;
        Session["ArrivalDate"] = shortenedArrivalDate;
        Session["DepartureDate"] = shortenedDepartureDate;
        Session["GymAccess"] = rdobtnlstGymCost.SelectedValue;
        Session["LateCheckout"] = rdobtnlstLateCheckout.SelectedValue;

        Session["createBooking"] = true;
        Response.Redirect("Login.aspx");
    }

    void DisplayRoomId(Int32 roomId)
    {
        Label lblRoomId = new Label();
        lblRoomId.CssClass = "body";
        lblRoomId.Text = "RoomId: " + roomId;
        pnlBooking.Controls.Add(lblRoomId);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));
    }

    void DisplaySingleBedImage()
    {
        Image imgSingleBed = new Image();
        imgSingleBed.ImageUrl = "Images/SingleBed.jpg";
        imgSingleBed.CssClass = "clearfix image";
        pnlBooking.Controls.Add(imgSingleBed);
    }

    void DisplayDoubleBedImage()
    {
        Image imgDoubleBed = new Image();
        imgDoubleBed.ImageUrl = "Images/DoubleBed.jpg";
        imgDoubleBed.CssClass = "clearfix image";
        pnlBooking.Controls.Add(imgDoubleBed);
    }

    void DisplayDetails(string description, Boolean accessible, decimal price)
    {
        Label lblDescription = new Label();
        lblDescription = new Label();
        lblDescription.CssClass = "rateOptions";
        lblDescription.Text = "Description: " + description;
        pnlBooking.Controls.Add(lblDescription);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblAccessible = new Label();
        lblAccessible.CssClass = "rateOptions";
        lblAccessible.Text = "Accessible: " + accessible;
        pnlBooking.Controls.Add(lblAccessible);
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        pnlBooking.Controls.Add(new LiteralControl("<br />"));
        pnlBooking.Controls.Add(new LiteralControl("<br />"));

        Label lblPrice = new Label();
        lblPrice.CssClass = "rateOptions";
        lblPrice.Text = "Price: £" + price;
        pnlBooking.Controls.Add(lblPrice);
    }

    void CreateLineBreak(Int32 numberOfLines)
    {
        for (int i = 0; i < numberOfLines; i += 1)
        {
            pnlBooking.Controls.Add(new LiteralControl("<br />"));
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