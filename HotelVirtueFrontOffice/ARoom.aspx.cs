using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ARoom : System.Web.UI.Page
{
    //var to store the room id number
    Int32 RoomId;
    protected void Page_Load(object sender, EventArgs e)
    {
        RoomId = Convert.ToInt32(Session["RoomId"]);
        DisplayRoom();
    }

   

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the main page
        Response.Redirect("Index.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //var to store any error messages
        string ErrorMsg;
        //create an instance of the room class
        clsRoomCollection RoomList = new clsRoomCollection();
        //use the objects validation method to test the data
        ErrorMsg = RoomList.ThisRoom.Valid(txtHotelId.Text, txtPrice.Text, txtRoomFloor.Text, txtRoomNumber.Text, txtRoomTypeId.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (RoomId == -1)
            {
                //set the Accessible property of the object
                RoomList.ThisRoom.Accessible = chkAccessible.Checked;
                //set the HotelId property
                RoomList.ThisRoom.HotelId = Convert.ToString(txtHotelId.Text);
                //set the Price property
                RoomList.ThisRoom.Price = Convert.ToDecimal(txtPrice.Text);
                //set the RoomFloor property
                RoomList.ThisRoom.RoomFloor = Convert.ToInt32(txtRoomFloor.Text);
                //set the RoomNumber
                RoomList.ThisRoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                RoomList.ThisRoom.RoomTypeId = Convert.ToString(txtRoomTypeId.Text);
                //set the available 
                RoomList.ThisRoom.Available = chkAvailable.Checked;
                
                RoomList.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                RoomList.ThisRoom.Find(RoomId);
                //set the Accessible property
                RoomList.ThisRoom.Accessible = chkAccessible.Checked;
                RoomList.ThisRoom.HotelId = Convert.ToString(txtHotelId.Text);
                //set the Price property
                RoomList.ThisRoom.Price = Convert.ToDecimal(txtPrice.Text);
                //set the RoomFloor property
                RoomList.ThisRoom.RoomFloor = Convert.ToInt32(txtRoomFloor.Text);
                //set the RoomNumber
                RoomList.ThisRoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                RoomList.ThisRoom.RoomTypeId = Convert.ToString(txtRoomTypeId.Text);
                //set the Available
                RoomList.ThisRoom.Available = chkAvailable.Checked;
                //RoomList.Update();
            }
            //all done so redirect back to the main page
            Response.Redirect("Index.aspx");
        }
        else//there are errors
        {
            //display the error message
            lblError.Text = ErrorMsg;
        }
    }

    void DisplayRoom()
    {
        //create an instance of the addresses class
        clsRoomCollection MyRoom = new clsRoomCollection();
        //find the record we want to display
        MyRoom.ThisRoom.Find(RoomId);
        
        chkAccessible.Checked = MyRoom.ThisRoom.Accessible; 
        //diaplay the HotelId
        txtHotelId.Text = Convert.ToString(MyRoom.ThisRoom.HotelId);
        //display the Price
        txtPrice.Text = Convert.ToString(MyRoom.ThisRoom.Price);
        //display the RoomFloor
        txtRoomFloor.Text = Convert.ToString(MyRoom.ThisRoom.RoomFloor);
        //diaply the RoomNumber
        txtRoomNumber.Text = Convert.ToString(MyRoom.ThisRoom.RoomNumber);
        txtRoomTypeId.Text = Convert.ToString(MyRoom.ThisRoom.RoomTypeId);
        chkAvailable.Checked = MyRoom.ThisRoom.Available;

        
    }
}