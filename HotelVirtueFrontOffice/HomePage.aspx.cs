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


    
}