using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class APayment : System.Web.UI.Page
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
        clsPaymentCollection payments = new clsPaymentCollection();
        string error = payments.ThisPayment.Valid(txtCardNumber.Text, txtNameOnCard.Text, txtExpiryDate.Text,
                                                  txtSecurityCode.Text);

        if (error == "")
        {
            payments.ThisPayment.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            payments.ThisPayment.BookingLineId = Convert.ToInt32(txtBookingLineId.Text);
            payments.ThisPayment.DateTimeOfPayment = DateTime.Now;
            payments.ThisPayment.Amount = Convert.ToDecimal(txtAmount.Text);
            payments.ThisPayment.CardNumber = txtCardNumber.Text;
            payments.ThisPayment.NameOnCard = txtNameOnCard.Text;
            payments.ThisPayment.ExpiryDate = txtExpiryDate.Text;
            payments.ThisPayment.SecurityCode = txtSecurityCode.Text;
            payments.ThisPayment.CardType = txtCardType.Text;
            payments.Add();
            Response.Redirect("Default_Payment.aspx");
        }
        else
        {
            lblError.Text = error;
        }
    }
}