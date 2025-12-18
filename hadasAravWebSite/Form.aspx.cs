using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string name, number;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            name = "Name: " + Request.Form["firstName"];
            number = "Number: " + Request.Form["number"];
        }
    }
}