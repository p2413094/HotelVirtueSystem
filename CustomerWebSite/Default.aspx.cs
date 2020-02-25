using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //redirect to the editing form
        Response.Redirect("AnAddress.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //redirect to the editing form
        Response.Redirect("AnAddress.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //redirect to the delete form
        Response.Redirect("Delete.aspx");
    }
}