using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Form : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        
        string name = txtBoxName.Text;
        string address = txtBoxAddress.Text;
        string age = txtBoxAge.Text;

        string details = "The name of the user is " + name + ", address is " + address + " and the age is " + age;
        lblDetails.Text = details;

        Session["name"] = name;
        Session["address"] = address;
        Session["age"] = age;
        Response.Redirect("~/Default2.aspx");
        
        // path
        // database insert
        // Page reload
    }
}