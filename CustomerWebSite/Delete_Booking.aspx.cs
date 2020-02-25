using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Delete_Booking : System.Web.UI.Page
{

    Int32 bookingLineId;

    protected void Page_Load(object sender, EventArgs e)
    {
        bookingLineId = Convert.ToInt32(Session["bookingLineId"]);       
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteBooking();
        Response.Redirect("Default_Booking.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }

    void DeleteBooking()
    {
        clsBookingLineCollection bookings = new clsBookingLineCollection();
        bookings.thisBookingLine.Find(bookingLineId);
        bookings.Delete();
    }
}