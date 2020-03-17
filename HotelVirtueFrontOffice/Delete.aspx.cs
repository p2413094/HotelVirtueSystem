using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelVirtueClasses;
public partial class Delete : System.Web.UI.Page
{
    Int32 AccountId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number 
        AccountId = Convert.ToInt32(Session["AccountId"]);
    }

    void DeleteAccount()
    {
        clsAccountCollection Account = new clsAccountCollection();
        //find therecord
        Account.ThisAccount.Find(AccountId);
        //delete
        Account.Delete();
    }

    protected void Button2_Click2(object sender, EventArgs e)
    {
        DeleteAccount();
        //redirect
        Response.Redirect("CustomerEdit.aspx");
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {

    }
}