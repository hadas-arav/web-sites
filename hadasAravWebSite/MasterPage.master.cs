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
            hobbysLink.Visible = true; // גם המנהל רואה את דף החוגים

            exitLink.Visible = true;
            regLink.Visible = false;
            logInlink.Visible = false;
        }

        else if (Session["user"] != null)
        {
            adminLink.Visible = false;
            addHobbyLink.Visible = false;
            hobbysLink.Visible = true; // משתמש רגיל רואה את דף החוגים

            exitLink.Visible = true;
            regLink.Visible = false;
            logInlink.Visible = false;
        }

        else
        {
            adminLink.Visible = false;
            addHobbyLink.Visible = false;
            hobbysLink.Visible = false; // אורח לא רואה את דף החוגים

            exitLink.Visible = false;
            regLink.Visible = true;
            logInlink.Visible = true;
        }
    }
}

