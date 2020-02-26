using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class CancelBooking_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        errorPanel.Visible = false;
        lblEnterReason.Visible = false;
        txtReason.Visible = false;
    }

    protected void btnCancelBooking_Click(object sender, EventArgs e)
    {
        string reason;
        if (ddlCancellationReason.SelectedIndex != 5)
        {
            reason = Convert.ToString(ddlCancellationReason.SelectedItem);
        }
        else
        {
            reason = txtReason.Text;
        }

        clsCancellation newCancellation = new clsCancellation();
        newCancellation.Valid(reason);

        Label lblError = new Label();
        lblError.Text = "Error";
        errorPanel.Controls.Add(lblError);
        if (newCancellation.ErrorList.Count != 0)
        {
            foreach (string errorItem in newCancellation.ErrorList)
            {
                errorPanel.Visible = true;
                errorPanel.Controls.Add(new LiteralControl("<br />"));
                Label lblErrorItem = new Label();
                lblErrorItem.Text = errorItem;
                lblErrorItem.CssClass = "body";
                errorPanel.Controls.Add(lblErrorItem);
            }
        }
        else
        {
            clsCancellationCollection cancellations = new clsCancellationCollection();
            cancellations.thisCancellation.BookingLineId = 3;
            cancellations.thisCancellation.DateTimeOfCancellation = DateTime.Now;
            cancellations.thisCancellation.Reason = reason;
            cancellations.Add();
            Response.Redirect("CancelBooking_2.aspx");
        }      
    }

    protected void ddlCancellationReason_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCancellationReason.SelectedIndex == 5)
        {
            lblEnterReason.Visible = true;
            txtReason.Visible = true;
            
        }
    }
}