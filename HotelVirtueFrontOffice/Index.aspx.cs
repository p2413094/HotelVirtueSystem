using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Button newButton = new Button();
        //newButton.ID = "btnSubmit";
        //newButton.Text = "Submit";
        //newButton.CssClass = "continueButton";
        //EventHandler evh = new EventHandler(btn_Click);
        //Panel1.Controls.Add(newButton);
        //newButton.Click += evh;
    }

    void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.google.co.uk");
    }


    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string Location = txtLocation.Text;
        string ArrivalDate = txtArrivalDate.Text;
        string DepartureDate = txtDepartureDate.Text;
        int underFive = Convert.ToInt32(txtUnderFive.Text);
        int fiveToSixteen = Convert.ToInt32(txtFivetoSixteen.Text);
        int sixteenUpwards = Convert.ToInt32(txtSixteenUpwards.Text);

        Session["Location"] = Location;
        Session["ArrivalDate"] = ArrivalDate;
        Session["DepartureDate"] = DepartureDate;
        Session["underFive"] = underFive;
        Session["FiveToSixteen"] = fiveToSixteen;
        Session["SixteenUpwards"] = sixteenUpwards;
        Response.Redirect("SearchHotel.aspx");
    }
}