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
        string ArrivalDate = txtDepartureDate.Text;
        string DepartureDate = txtDepartureDate.Text;
        string NumberOfGuests = txtNumberOfGuests.Text;
        string NumberOfRooms = txtNumberOfRooms.Text;

        Session["Location"] = Location;
        Session["ArrivalDate"] = ArrivalDate;
        Session["DepartureDate"] = DepartureDate;
        Session["NumberofGuests"] = NumberOfGuests;
        Session["NumberofRooms"] = NumberOfRooms;


    }
}