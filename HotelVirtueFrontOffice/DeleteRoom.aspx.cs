using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class DeleteRoom : System.Web.UI.Page
{
    Int32 RoomId;
    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of the address to be deleted from the session object
        RoomId = Convert.ToInt32(Session["RoomId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create instance of clsAddress called AnAddress used to control addresses in the database
        clsRoomCollection MyRoom = new clsRoomCollection();
        //find the record to be deleted
        MyRoom.ThisRoom.Find(RoomId);
        //call the delete method of the object
        MyRoom.Delete();
        //redirect back to the main page
        Response.Redirect("Index.aspx");
    }
}