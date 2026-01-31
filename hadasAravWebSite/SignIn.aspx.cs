using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Default2 : Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["email"];
            string pass = Request.Form["password"];

            string sql =
                "SELECT * FROM tUsers " +
                "WHERE Email = '" + email + "' " +
                "AND UserPassword = '" + pass + "'";

            bool userExists = MyAdoHelper.IsExist(sql);

            if (!userExists)
            {
                st = "אימייל או סיסמה שגויים";
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
