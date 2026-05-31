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
        if (Session["nihul"] != null)
        {
            adminLink.Visible = true;
            addHobbyLink.Visible = true;
            hobbysLink.Visible = false; // admin doesn't see it

            exitLink.Visible = true;
            regLink.Visible = false;
            logInlink.Visible = false;
        }

        else if (Session["user"] != null)
        {
            adminLink.Visible = false;
            addHobbyLink.Visible = false;
            hobbysLink.Visible = true; // regular users see it

            exitLink.Visible = true;
            regLink.Visible = false;
            logInlink.Visible = false;
        }

        else
        {
            adminLink.Visible = false;
            addHobbyLink.Visible = false;
            hobbysLink.Visible = false; // guests don't see it

            exitLink.Visible = false;
            regLink.Visible = true;
            logInlink.Visible = true;
        }
    }
}

