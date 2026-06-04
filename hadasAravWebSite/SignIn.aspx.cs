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
        // ברירת מחדל לכל מי שנכנס לאתר
        if (Session["username"] == null)
        {
            Session["username"] = "אורח";
        }

        if (Page.IsPostBack)
        {
            string email = Request.Form["email"];
            string pass = Request.Form["password"];

            if (email == "hadas.arav@gmail.com" && pass == "12345") 
            {
                Session["nihul"] = "ok";
                Session["username"] = "מנהל"; // "אם זה המנהל, יכתב לו "מנהל" במקום "אורח
                Response.Redirect("Admin.aspx"); // נשלח אותו לדף הניהול
            }
            else
            {
                string sql =
                    "SELECT * FROM tUsers " +
                    "WHERE Email = N'" + email + "' " +
                    "AND Password = N'" + pass + "'"; // בדיקה אם יש משתמש כזה במסד הנתונים

                DataTable dt = MyAdoHelper.ExecuteDataTable(sql); // מבצע את השאילתה ומקבל את התוצאות בטבלה

                if (dt.Rows.Count == 0) // אם אין משתמש כזה
                {
                    Session["username"] = "אורח";
                    st = "אימייל או סיסמה שגויים";
                }
                else // אם יש משתמש כזה
                {
                    Session["user"] = "ok";
                    Session["username"] = dt.Rows[0]["fullName"]; //  נכתוב את שמו המלא במקום "אורח
                    Response.Redirect("Home.aspx"); //  נשלח אותו לדף הבית
                }
            }
        }
    }
}

