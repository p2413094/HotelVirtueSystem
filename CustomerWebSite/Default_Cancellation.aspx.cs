using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Default_Cancellation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCancellations();           
        }
    }  

    protected void btnApply_Click(object sender, EventArgs e)
    {

    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CancellationId"] = -1;
        Response.Redirect("ACancellation.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 cancellationId;
        if (lstAddresses.SelectedIndex != -1)
        {
            cancellationId = Convert.ToInt32(lstAddresses.SelectedValue);
            Session["CancellationId"] = cancellationId;
            Response.Redirect("Delete_Cancellation.aspx");
        }
        else
        {
            lblError.Text = "Select an item first";
        }
    }

    void DisplayCancellations()
    {
        clsCancellationCollection cancellations = new clsCancellationCollection();
        lstAddresses.DataSource = cancellations.CancellationList;
        lstAddresses.DataValueField = "CancellationId";
        lstAddresses.DataTextField = "Reason";
        lstAddresses.DataBind();
    }
}