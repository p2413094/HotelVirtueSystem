using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ABooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    void Add()
    {
        clsBookingLine BookingLines = new clsBookingLine();
        //string error = BookingLines.Valid(txtArrivalDate.Text, txtDepartureDate.Text, txtOther.Text, txtRoomId.Text, txtUnderFive.Text,  txtFiveToSixteen.Text, txtSixteenUpwards.Text);
    }
}