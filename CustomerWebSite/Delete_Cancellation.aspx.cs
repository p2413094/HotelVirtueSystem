using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Delete_Cancellation : System.Web.UI.Page
{
    Int32 cancellationId;

    protected void Page_Load(object sender, EventArgs e)
    {
        cancellationId = Convert.ToInt32(Session["CancellationId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteCancellation();
        Response.Redirect("Default_Cancellation.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }

    void DeleteCancellation()
    {
        clsCancellationCollection cancellations = new clsCancellationCollection();
        cancellations.thisCancellation.Find(cancellationId);
        cancellations.Delete();
    }
}