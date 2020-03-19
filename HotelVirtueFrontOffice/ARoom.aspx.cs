using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class ARoom : System.Web.UI.Page
{
    //var to store the address number
    Int32 RoomId;
    protected void Page_Load(object sender, EventArgs e)
    {
        RoomId = Convert.ToInt32(Session["RoomId"]);
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
            //lblError.Text = "You must select an Room off the list first to edit it.";
        }

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
        //create an instance of the address class
        clsRoomCollection RoomList = new clsRoomCollection();
        //use the objects validation method to test the data
        ErrorMsg = RoomList.ThisRoom.Valid(txtHotelId.Text, txtPrice.Text, txtRoomFloor.Text, txtRoomNumber.Text, txtRoomTypeId.Text);
        //if there is no error message
        if (ErrorMsg == "")
        {
            //if we are adding a new record
            if (RoomId == -1)
            {
                //set the house number property of the object
                RoomList.ThisRoom.Accessible = chkAccessible.Checked;
                //set the street property
                RoomList.ThisRoom.HotelId = Convert.ToInt32(txtHotelId.Text);
                //set the town property
                RoomList.ThisRoom.Price = Convert.ToDecimal(txtPrice.Text);
                //set the post code property
                RoomList.ThisRoom.RoomFloor = Convert.ToInt32(txtRoomFloor.Text);
                //set the data added
                RoomList.ThisRoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                RoomList.ThisRoom.RoomTypeId = Convert.ToInt32(txtRoomTypeId.Text);
                //set the county code
                RoomList.ThisRoom.Available = chkAvailable.Checked;
                
                RoomList.Add();
            }
            else//this is an existing record to update
            {
                //find the record to be updated
                RoomList.ThisRoom.Find(RoomId);
                //set the house no property
                RoomList.ThisRoom.Accessible = chkAccessible.Checked;
                RoomList.ThisRoom.HotelId = Convert.ToInt32(txtHotelId.Text);
                //set the town property
                RoomList.ThisRoom.Price = Convert.ToDecimal(txtPrice.Text);
                //set the post code property
                RoomList.ThisRoom.RoomFloor = Convert.ToInt32(txtRoomFloor.Text);
                //set the data added
                RoomList.ThisRoom.RoomNumber = Convert.ToInt32(txtRoomNumber.Text);
                RoomList.ThisRoom.RoomTypeId = Convert.ToInt32(txtRoomTypeId.Text);
                //set the county code
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
        //display the house no
        chkAccessible.Checked = MyRoom.ThisRoom.Accessible; 
        //diaplay the street
        txtHotelId.Text = Convert.ToString(MyRoom.ThisRoom.HotelId);
        //display the town
        txtPrice.Text = Convert.ToString(MyRoom.ThisRoom.Price);
        //display the post code
        txtRoomFloor.Text = Convert.ToString(MyRoom.ThisRoom.RoomFloor);
        //diaply the data added
        txtRoomNumber.Text = Convert.ToString(MyRoom.ThisRoom.RoomNumber);
        txtRoomTypeId.Text = Convert.ToString(MyRoom.ThisRoom.RoomTypeId);
        chkAvailable.Checked = MyRoom.ThisRoom.Available;

        
    }
}