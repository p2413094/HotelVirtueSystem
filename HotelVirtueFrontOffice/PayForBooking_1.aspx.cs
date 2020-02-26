using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class PayForBooking_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        errorPanel.Visible = false;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        string cardNumber = txtCardNumber.Text;
        string nameOnCard = txtNameOnCard.Text;
        string cardExpiryDate = txtExpiryDate.Text;
        string cardSecurityCode = txtSecurityCode.Text;

        clsPayment newPayment = new clsPayment();
        string error = newPayment.Valid(cardNumber, nameOnCard, cardExpiryDate, cardSecurityCode);


        Label lblError = new Label();
        lblError.Text = "Error";
        errorPanel.Controls.Add(lblError);

        if (newPayment.ErrorList.Count != 0)
        {
            errorPanel.Visible = true;
            foreach (string errorItem in newPayment.ErrorList)
            {
                errorPanel.Controls.Add(new LiteralControl("<br />"));
                Label lblErrorItem = new Label();
                lblErrorItem.Text = errorItem;
                lblErrorItem.CssClass = "body";
                errorPanel.Controls.Add(lblErrorItem);
            }
        }
        else
        {

            clsPaymentCollection payments = new clsPaymentCollection();
            payments.ThisPayment.CustomerId = 1;
            payments.ThisPayment.BookingLineId = 3;
            payments.ThisPayment.DateTimeOfPayment = DateTime.Now;
            payments.ThisPayment.Amount = 79.99m;
            payments.ThisPayment.CardNumber = txtCardNumber.Text;
            payments.ThisPayment.NameOnCard = txtNameOnCard.Text;
            payments.ThisPayment.ExpiryDate = txtExpiryDate.Text;
            payments.ThisPayment.SecurityCode = txtSecurityCode.Text;
            payments.ThisPayment.CardType = ddlCardType.SelectedValue;
            payments.Add();
            Response.Redirect("PayForBooking_Success.aspx");
        }
        
    }
}