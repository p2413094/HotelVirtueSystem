using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Default_Payment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayPayments();
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
        Session["PaymentId"] = -1;
        Response.Redirect("APayment.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {

    }

    void DisplayPayments()
    {
        clsPaymentCollection payments = new clsPaymentCollection();
        lstAddresses.DataSource = payments.PaymentList;
        lstAddresses.DataValueField = "PaymentId";
        lstAddresses.DataTextField = "DateTimeOfPayment";
        lstAddresses.DataBind();
    }
}