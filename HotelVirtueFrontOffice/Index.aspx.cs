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
        string Location = "Leicester";//txtLocation.Text;
        string ArrivalDate = "19/03/2020";//txtDepartureDate.Text;
        string DepartureDate = "21/03/2020"; //txtDepartureDate.Text;
        int underFive = 1;
        int fiveToSixteen = 1;
        int sixteenUpwards = 1;

        Session["Location"] = Location;
        Session["ArrivalDate"] = ArrivalDate;
        Session["DepartureDate"] = DepartureDate;
        Session["underFive"] = underFive;
        Session["FiveToSixteen"] = fiveToSixteen;
        Session["SixteenUpwards"] = sixteenUpwards;
        Response.Redirect("SearchHotel.aspx");
    }
}