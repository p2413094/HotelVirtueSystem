using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;

public partial class Login : System.Web.UI.Page
{
    Boolean createBooking = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        createBooking = Convert.ToBoolean(Session["createBooking"]);
        if (createBooking == false)
        {
            Button4.Visible = false;
        }
        else
        {
            Button4.Visible = true;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SearchForUser();
        //Add();
        //Response.Redirect("CustomerEdit.aspx");     
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //store -1 imto the session object to indicate this is a new record
        Session["AccountId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("Registration.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //store -1 imto the session object to indicate this is a new record
        Session["CustomerId"] = -1;
        //redirect to the data entry page 
        Response.Redirect("Guest Login.aspx");
    }

    void Add()
    {
        //create an instance of account
        HotelVirtueClasses.clsAccountCollection Account = new HotelVirtueClasses.clsAccountCollection();
        //validate the data on the web form
        String Error = Account.ThisAccount.Valid(txtPassword.Text,txtUserName.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Account.ThisAccount.Password = Convert.ToString(txtPassword.Text);
            Account.ThisAccount.UserName = Convert.ToString(txtUserName.Text);
            //add the record
            Account.Add();
            //all done so redirect back to the main page
            Response.Redirect("CustomerEdit.aspx");
        }
        else
        {
            //report an error

        }
    }

    void SearchForUser()
    {
        if (createBooking == true)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", username);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_tblAccount_SearchForAccount");

            if (DB.Count != 0)
            {
                Int32 customerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                Session["CustomerId"] = customerId;
                Response.Redirect("CreateBooking_2.aspx");
            }
        }
        else
        {
            Response.Redirect("AccountPage.aspx");
        }
        
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Boolean guest = true;
        Session["guest"] = guest;
        Response.Redirect("CreateBooking_2.aspx");
    }
}