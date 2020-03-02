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

    Int32 calculatedTotalNumberOfGuests;

    protected void Page_Load(object sender, EventArgs e)
    {

        hotelId = Convert.ToInt32(Session["hotelId"]);
        hotelName = Convert.ToString(Session["hotelName"]);
        arrivalDate = Convert.ToDateTime(Session["arrivalDate"]);
        departureDate = Convert.ToDateTime(Session["departureDate"]);
        underFive = Convert.ToInt32(Session["underFive"]);
        fiveToSixteen = Convert.ToInt32(Session["fiveToSixteen"]);
        sixteenUpwards = Convert.ToInt32(Session["sixteenUpwaards"]);

        calculatedTotalNumberOfGuests = underFive + fiveToSixteen + sixteenUpwards;

        lblHotelName.Text = "HC Birmingham";
        lblArrivalDepartureDate.Text = "HC 01/03/2020-03/03/2020";
        lblbreakdownOfGuests.Text = "HC 1 under five, 1 between five and sixteen and 3 over sixteen";
        lblCost.Text = "HC 89.00";

        hotelId = 1;

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@HotelId", hotelId);
        DB.Execute("sproc_tblRoom_SelectAllAvailableRooms");

        if (IsPostBack == false)
        {
            Int32 index = 0;
            while (index < DB.Count)
            {
                ddlRoomId.Items.Add(DB.DataTable.Rows[index]["RoomId"].ToString());
                index++;
            }
        }
       

        Int32 newIndex = 0;
        while (newIndex < DB.Count)
        {
            Int32 roomTypeId = Convert.ToInt32(DB.DataTable.Rows[newIndex]["fk2_RoomTypeId"]);

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
                Panel pnlBooking = new Panel();
                pnlBooking.CssClass = "box";
                Label lblroomType = new Label();
                lblroomType.Text = "Single bed";
                pnlBooking.Controls.Add(lblroomType);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

                Image imgSingleBed = new Image();
                imgSingleBed.ImageUrl = "Images/SingleBed.jpg";
                imgSingleBed.CssClass = "clearfix image";
                pnlBooking.Controls.Add(imgSingleBed);
               
                Label lblSingleBed = new Label();
                lblSingleBed.CssClass = "rateOptions";
                lblSingleBed.Text = "Number of single beds: " + singleBed;
                pnlBooking.Controls.Add(lblSingleBed);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

                Label lblDescription = new Label();
                lblDescription.CssClass = "rateOptions";
                lblDescription.Text = "Description: " + description;
                pnlBooking.Controls.Add(lblDescription);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

                for (int i = 0; i < 6; i += 1)
                {
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));
                }

                this.Controls.Add(pnlBooking);
            }

            //double bed 
            if (singleBed == 0 && doubleBed != 0)
            {
                this.Controls.Add(new LiteralControl("<br />"));
                Panel pnlBooking = new Panel();
                pnlBooking.CssClass = "box";
                Label lblroomType = new Label();
                lblroomType.Text = "Double bed";
                pnlBooking.Controls.Add(lblroomType);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

                Image imgDoubleBed = new Image();
                imgDoubleBed.ImageUrl = "Images/DoubleBed.jpg";
                imgDoubleBed.CssClass = "clearfix image";
                pnlBooking.Controls.Add(imgDoubleBed);

                Label lblDoubleBed = new Label();
                lblDoubleBed.CssClass = "rateOptions";
                lblDoubleBed.Text = "Number of double beds: " + doubleBed;
                pnlBooking.Controls.Add(lblDoubleBed);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

                Label lblDescription = new Label();
                lblDescription.CssClass = "rateOptions";
                lblDescription.Text = "Description: " + description;
                pnlBooking.Controls.Add(lblDescription);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

                for (int i = 0; i < 9; i += 1)
                {
                    pnlBooking.Controls.Add(new LiteralControl("<br />"));
                }

                this.Controls.Add(pnlBooking);
            }

            //single and double bed 
            if (singleBed != 0 && doubleBed != 0)
            {
                this.Controls.Add(new LiteralControl("<br />"));
                Panel pnlBooking = new Panel();
                pnlBooking.CssClass = "box";
                Label lblroomType = new Label();
                lblroomType.Text = "Single and double beds";
                pnlBooking.Controls.Add(lblroomType);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

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

                Label lblDescription = new Label();
                lblDescription.CssClass = "rateOptions";
                lblDescription.Text = "Description: " + description;
                pnlBooking.Controls.Add(lblDescription);
                pnlBooking.Controls.Add(new LiteralControl("<br />"));

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
                lblGymAccess.Visible = true;
                imgGym.Visible = true;
            }
            else
            {
                lblGymAccess.Visible = false;
                imgGym.Visible = false;
            }

            if (lateCheckout == true)
            {
                lblLateCheckout.Visible = true;
                imgLateCheckout.Visible = true;
            }
            else
            {
                lblLateCheckout.Visible = false;
                lblLateCheckout.Visible = false;
            }

            pnlExtras.Visible = true;
        }
        else
        {
            pnlExtras.Visible = false;
        }
                 

        Panel pnlStaySummary = new Panel();
        pnlStaySummary.CssClass = "box";

        Label lblYourBooking = new Label();
        lblYourBooking.Text = "Your booking";
        pnlStaySummary.Controls.Add(lblYourBooking);
        pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

        Label lblRoomType = new Label();
        lblRoomType.CssClass = "body";
        lblRoomType.Text = "Room type: ";
        pnlStaySummary.Controls.Add(lblRoomType);
        pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

        Label lblTotal = new Label();
        lblTotal.CssClass = "body";
        lblTotal.Text = "Total: £";
        pnlStaySummary.Controls.Add(lblTotal);
        pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

        Button btnContinue = new Button();
        btnContinue.CssClass = "continueButton";
        btnContinue.Text = "CONTINUE";
        btnContinue.Click += BtnContinue_Click;
        pnlStaySummary.Controls.Add(btnContinue);

        pnlStaySummary.Controls.Add(new LiteralControl("<br />"));
        pnlStaySummary.Controls.Add(new LiteralControl("<br />"));

        Form.Controls.Add(pnlStaySummary);

        //string accessible = Convert.ToString(DB.DataTable.Rows[0]["Accessible"]);
        //decimal cost = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);     


        //pnlBooking.Controls.Add(new LiteralControl("<br />"));
        //Label lblAccessible = new Label();
        //lblAccessible.CssClass = "rateOptions";
        //lblAccessible.Text = "Accessible: " + accessible;
        //pnlBooking.Controls.Add(lblAccessible);
        //pnlBooking.Controls.Add(new LiteralControl("<br />")); 
    }

    private void BtnContinue_Click(object sender, EventArgs e)
    {
        //redirect to confirmation page
        //on confirmation page, you then out pay now/ later 
    }

    private void rdoBtnListGymOptions_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnContinueToPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }

}