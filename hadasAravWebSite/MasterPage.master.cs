using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userName"] != "מנהל")
        {
            adminLink.Visible = false;
            adminLinkTwo.Visible = false;
        }

        if (Session["userName"] == "אורח")
        {
            regLink.Visible = true;
            exitLink.Visible = false;
        }

        if (Session["user"] != null || Session["nihul"] != null)
        {
            exitLink.Visible = true;
            regLink.Visible = false;
            logInlink.Visible = false;
        }
        else
        {
            exitLink.Visible = false;
            regLink.Visible = true;
            logInlink.Visible = true;
        }
    }
}