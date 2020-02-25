using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Default_Booking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayBookings();
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 bookingLineId;

        if (lstAddresses.SelectedIndex != -1)
        {
            bookingLineId = Convert.ToInt32(lstAddresses.SelectedValue);
            Session["bookingLineId"] = bookingLineId;
            Response.Redirect("Delete_Booking.aspx");
        }
        else
        {
            lblError.Text = "Choose a record from the list";
        }
    }

    void DisplayBookings()
    {
        clsBookingLineCollection bookings = new clsBookingLineCollection();
        lstAddresses.DataSource = bookings.BookingLineList;
        lstAddresses.DataValueField = "BookingLineId";
        lstAddresses.DataTextField = "BookingLineId";
        lstAddresses.DataBind();
    }
}