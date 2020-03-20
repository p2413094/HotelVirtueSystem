using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class SearchHotel : System.Web.UI.Page
{
    Int32 underFive;
    Int32 fivetoSixteen;
    Int32 sixteenUpwards;
    DateTime arrivalDate;
    DateTime departureDate;
    string hotelName;

    protected void Page_Load(object sender, EventArgs e)
    {
        string location = Convert.ToString(Session["Location"]);
        arrivalDate = Convert.ToDateTime(Session["ArrivalDate"]);
        departureDate = Convert.ToDateTime(Session["DepartureDate"]);
        underFive = Convert.ToInt32(Session["underFive"]);
        fivetoSixteen = Convert.ToInt32(Session["FivetoSixteen"]);
        sixteenUpwards = Convert.ToInt32(Session["SixteenUpwards"]);

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@Location", location);
        DB.Execute("sproc_tblHotel_FilterByLocation");

        Int32 recordCount = DB.Count;
        Int32 index = 0;

        if (DB.Count != 0)
        {
            while (index < recordCount)
            {
                Panel pnlhotel = new Panel();
                pnlhotel.CssClass = "box";
                Label lblHotelId = new Label();
                lblHotelId.Text = "Hotelid" + Convert.ToString(DB.DataTable.Rows[index]["HotelId"]);
                pnlhotel.Controls.Add(lblHotelId);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));
                pnlhotel.Controls.Add(new LiteralControl("<br />"));
                pnlhotel.Controls.Add(new LiteralControl("<br />"));
                pnlhotel.Controls.Add(new LiteralControl("<br />"));
                pnlhotel.Controls.Add(new LiteralControl("<br />"));


                Label lblAddress = new Label();
                lblAddress.CssClass = "body";
                lblAddress.Text = Convert.ToString(DB.DataTable.Rows[index]["Address"]);
                pnlhotel.Controls.Add(lblAddress);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));


                Label lblCity = new Label();
                lblCity.CssClass = "body";
                lblCity.Text = Convert.ToString(DB.DataTable.Rows[index]["City"]);
                pnlhotel.Controls.Add(lblCity);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblDateOfStay = new Label();
                lblDateOfStay.CssClass = "body";
                lblDateOfStay.Text = Convert.ToString(DB.DataTable.Rows[index]["DateOfStay"]);
                pnlhotel.Controls.Add(lblDateOfStay);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblLocation = new Label();
                lblLocation.CssClass = "body";
                lblLocation.Text = Convert.ToString(DB.DataTable.Rows[index]["Location"]);
                pnlhotel.Controls.Add(lblLocation);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblName = new Label();
                lblName.CssClass = "body";
                lblName.Text = Convert.ToString(DB.DataTable.Rows[index]["Name"]);
                pnlhotel.Controls.Add(lblName);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblNoofGuests = new Label();
                lblNoofGuests.CssClass = "body";
                lblNoofGuests.Text = Convert.ToString(DB.DataTable.Rows[index]["NoofGuests"]);
                pnlhotel.Controls.Add(lblNoofGuests);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblPostCode = new Label();
                lblPostCode.CssClass = "body";
                lblPostCode.Text = Convert.ToString(DB.DataTable.Rows[index]["PostCode"]);
                pnlhotel.Controls.Add(lblPostCode);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblGymAccess = new Label();
                lblGymAccess.CssClass = "body";
                lblGymAccess.Text = Convert.ToString(DB.DataTable.Rows[index]["GymAccess"]);
                pnlhotel.Controls.Add(lblGymAccess);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));

                Label lblLateCheckout = new Label();
                lblLateCheckout.CssClass = "body";
                lblLateCheckout.Text = Convert.ToString(DB.DataTable.Rows[index]["LateCheckout"]);
                pnlhotel.Controls.Add(lblLateCheckout);
                pnlhotel.Controls.Add(new LiteralControl("<br />"));



                this.Controls.Add(pnlhotel);
                this.Controls.Add(new LiteralControl("<br />"));
                this.Controls.Add(new LiteralControl("<br />"));
                this.Controls.Add(new LiteralControl("<br />"));

                ddlHotelId.Items.Add(Convert.ToString(DB.DataTable.Rows[index]["HotelId"]));

                index++;
            }


        }


    }

    protected void Buttonchoosebooking_Click(object sender, EventArgs e)
    {
        Int32 hotelId = Convert.ToInt32(ddlHotelId.SelectedValue);
        Session["hotelId"] = hotelId;
        Session["underFive"] = underFive;
        Session["fiveToSixteen"] = fivetoSixteen;
        Session["sixteenUpwards"] = sixteenUpwards;
        Session["arrivalDate"] = arrivalDate;
        Session["departureDate"] = departureDate;
        Response.Redirect("CreateBooking_1.aspx");
    }
}