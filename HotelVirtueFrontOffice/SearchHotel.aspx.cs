using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class SearchHotel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {       
        string location = Convert.ToString(Session["Location"]);
        DateTime arrivalDate = Convert.ToDateTime(Session["ArrivalDate"]);
        DateTime departureDate = Convert.ToDateTime(Session["DepartureDate"]);
        Int32 underFive = Convert.ToInt32(Session["underFive"]);
        Int32 fivetoSixteen = Convert.ToInt32(Session["FivetoSixteen"]);
        Int32 sixteenUpwards = Convert.ToInt32(Session["SixteenUpwards"]);

        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@Location", location);
        DB.Execute("sproc_tblHotel_FilterByLocation");

        if (DB.Count != 0)
        {
            lblHotelName.Text = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
        }
    }
}