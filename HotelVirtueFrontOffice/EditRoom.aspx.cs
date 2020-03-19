using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditRoom : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //clear any existing error messages
        lblError.Text = "";
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //populate the list and display the number of records found
            lblError.Text = DisplayRooms("") + " records in the database";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 RoomId;
        //if a record has been selected from the list
        if (lstRooms.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            RoomId = Convert.ToInt32(lstRooms.SelectedValue);
            //store the data in the session object
            Session["RoomId"] = RoomId;
            //redirect to the edit page
            Response.Redirect("ARoom.aspx");
        }
        else//if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    Int32 DisplayRooms(string RoomIdFilter)
    {
        ///this function accepts one parameter - the post code to filter the list on
        ///it populates the list box with data from the middle layer class
        ///it returns a single value, the number of records found

        //create a new instance of the clsAddress
        clsRoomCollection MyRoom = new clsRoomCollection();
        //var to store the count of records
        Int32 RecordCount;
        
        //var to store the index
        Int32 Index = 0;
        //clear the list of any existing items
        lstRooms.Items.Clear();
        //call the filter by post code method
        MyRoom.ReportByPostCode(RoomIdFilter);
        //get the count of records found
        RecordCount = MyRoom.Count;
        //loop through each record found using the index to point to each record in the data table
        while (Index < RecordCount)
        {
            
            //get the address no from the query results
            RoomId = Convert.ToString(MyRoom.AddressList[Index].RoomId);
            //set up a new object of class list item 
            ListItem NewItem = new ListItem(RoomId);
            //add the new item to the list
            lstRooms.Items.Add(NewItem);
            //increment the index
            Index++;
        }
        //return the number of records found
        return RecordCount;
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        //var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayRooms("");
        //display the number of records found
        lblError.Text = RecordCount + " records in the database";
        //clear the post code filter text box
        txtRoomId.Text = "";
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //declare var to store the record count
        Int32 RecordCount;
        //assign the results of the DisplayAddresses function to the record count var
        RecordCount = DisplayRooms(txtRoomId.Text);
        //display the number of records found
        lblError.Text = RecordCount + " records found";
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 RoomId;
        //if a record has been selected from the list
        if (lstRooms.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            RoomId = Convert.ToInt32(lstRooms.SelectedValue);
            //store the data in the session object
            Session["RoomId"] = RoomId;
            //redirect to the delete page
            Response.Redirect("DeleteRoom.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}