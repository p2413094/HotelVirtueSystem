using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button newButton = new Button();
        newButton.ID = "btnSubmit";
        newButton.Text = "Submit";
        newButton.CssClass = "continueButton";
        EventHandler evh = new EventHandler(btn_Click);
        Panel1.Controls.Add(newButton);
        newButton.Click += evh;

        
    }

    void btn_Click(object sender, EventArgs e)
    {
        Response.Redirect("http://www.google.co.uk");
    }




    protected void Button1_Click(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("HomePage.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("Registration.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("Guest Login.aspx");
    }

    protected void Button2_Click1(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("HomePage.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("EditPersonalDetails2.aspx");
    }

    protected void Button2_Click2(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("EditPersonalDetails3.aspx");
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("EditpersonalDetails1.aspx");
    }

    protected void Button1_Click3(object sender, EventArgs e)
    {
        //Redirect to the homepage 
        Response.Redirect("Registration2.aspx");
    }





    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}