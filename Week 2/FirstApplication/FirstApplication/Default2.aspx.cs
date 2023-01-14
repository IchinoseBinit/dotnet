using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string name = Session["name"].ToString();
        string address = Session["address"].ToString();
        string age = Session["age"].ToString();
        lblDetails.Text = "Thanks for registering, " + name + " from " + address + " at such a young age of " + age + ". We wish you all the best for your future";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}