using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class Default2 : Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string email = Request.Form["email"];
            string pass = Request.Form["password"];

            if (email == "hadas.arav@gmail.com" && pass == "12345")
            {
                Session["nihul"] = "ok";
                Session["username"] = "מנהל";
                Response.Redirect("Admin.aspx");
            }
            else
            {
                string sql =
                    "SELECT * FROM tUsers " +
                    "WHERE Email = N'" + email + "' " +
                    "AND Password = N'" + pass + "'";

                DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

                if (dt.Rows.Count == 0)
                {
                    Session["username"] = "אורח";
                    st = "אימייל או סיסמה שגויים";
                }
                else
                {
                    Session["user"] = "ok";
                    Session["username"] = dt.Rows[0]["fullName"];
                    Response.Redirect("Home.aspx");
                }
            }
        }
    }
}

