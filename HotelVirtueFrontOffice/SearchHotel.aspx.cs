using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchHotel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        string location = Convert.ToString(Session["Location"]);
        DateTime arrivalDate = Convert.ToDateTime(Session["ArrivalDate"]);
        DateTime departureDate = Convert.ToDateTime(Session["DepartureDate"]);
        Int32 numberofGuests = Convert.ToInt32(Session["NumberofGuests"]);
        Int32 fivetoSixteen = Convert.ToInt32(Session["FivetoSixteen"]);
        Int32 sixteenUpwards = Convert.ToInt32(Session["SixteenUpwards"]);
        Int32 numberofRooms = Convert.ToInt32(Session["NumberOfRooms"]);
    }
}