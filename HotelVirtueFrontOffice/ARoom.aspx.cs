using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ARoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lblEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        String RoomId;
        //check the list has been clicked first 
        if (lstRooms.SelectedIndex != -1)
        {
            //get the primary key value from the list box
            RoomId = Convert.ToString(lstRooms.SelectedValue);
            //store the data in the session object
            Session["RoomId"] = RoomId;
            //redirect to the editing page 
            Response.Redirect("ARoom.aspx?RoomId=" + RoomId);
        }
        else
        {
            //display an error
            lblError.Text = "You must select an Room off the list first to edit it.";
        }

    }
}