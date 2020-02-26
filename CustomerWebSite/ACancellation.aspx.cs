using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ACancellation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    void Add()
    {
        clsCancellationCollection cancellations = new clsCancellationCollection();
        string error = cancellations.thisCancellation.Valid(txtReason.Text);
        if (error == "")
        {
            cancellations.thisCancellation.BookingLineId = Convert.ToInt32(txtBookingLineId.Text);
            cancellations.thisCancellation.DateTimeOfCancellation = DateTime.Now;
            cancellations.thisCancellation.Reason = txtReason.Text;
            cancellations.Add();
            Response.Redirect("Default_Cancellation.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }
}