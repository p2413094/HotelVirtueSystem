﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateBooking_1 : System.Web.UI.Page
{
    Int32 hotelId;
    string hotelName;
    string arrivalDate;
    string departureDate;
    Int32 underFive;
    Int32 fiveToSixteen;
    Int32 SixteenUpwards;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnContinueToPayment_Click(object sender, EventArgs e)
    {
        Response.Redirect("PayForBooking_1.aspx");
    }
}