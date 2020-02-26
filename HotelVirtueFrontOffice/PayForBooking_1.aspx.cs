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


        List<string> errorList = new List<string>();




        if (error != "")
        {
            errorPanel.Visible = true;

            Label lblError = new Label();
            lblError.Text = "Error";
            errorPanel.Controls.Add(lblError);

            errorPanel.Controls.Add(new LiteralControl("<br />"));

            Label lblInclude = new Label();
            lblInclude.Text = error;
            lblInclude.CssClass = "body";
            errorPanel.Controls.Add(lblInclude);

        }

        
 
    }
}