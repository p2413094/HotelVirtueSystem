using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditpersonalDetails1 : System.Web.UI.Page
{
    Int32 AccountId;

    protected void Page_Load(object sender, EventArgs e)
    {
        AccountId = Convert.ToInt32(Session["AccountId"]);
        if (IsPostBack == false)
        {
            DisplayAccounts();
        }
    }


    void Update()
    {
        //create an instance of account
        HotelVirtueClasses.clsAccountCollection Account = new HotelVirtueClasses.clsAccountCollection();
        //validate the data on the web form
        String Error = Account.ThisAccount.Valid(txtCustomerId.Text, txtHouseNo.Text, txtCity.Text, txtPassword.Text, txtPostCode.Text, txtStreet.Text, txtTown.Text, txtUserName.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Account.ThisAccount.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            Account.ThisAccount.HouseNo = Convert.ToString(txtHouseNo.Text);
            Account.ThisAccount.City = Convert.ToString(txtCity.Text);
            Account.ThisAccount.Password = Convert.ToString(txtPassword.Text);
            Account.ThisAccount.PostCode = Convert.ToString(txtPostCode.Text);
            Account.ThisAccount.Street = Convert.ToString(txtStreet.Text);
            Account.ThisAccount.Town = Convert.ToString(txtTown.Text);
            Account.ThisAccount.UserName = Convert.ToString(txtUserName.Text);
            //add the record
            Account.Update();
            //all done so redirect back to the main page
            Response.Redirect("EditPersonalDetails2.aspx");
        }
        else
        {
            //report an error

        }
    }



    protected void Button1_Click1(object sender, EventArgs e)
    {

    }
}