using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // שאילתה בסיסית - מציגה את כל המשתמשים
        string sql = "SELECT * FROM tUsers";

        // אם נשלח טופס החיפוש
        if (Page.IsPostBack)
        {
            // קבלת הערכים מהטופס
            string fn = Request.Form["name"];
            string email = Request.Form["email"];
            string hobby = Request.Form["Hobby"];

            // מאפשר להוסיף תנאי חיפוש בקלות
            sql += " WHERE 1=1";

            // חיפוש לפי שם מלא
            if (!string.IsNullOrEmpty(fn))
            {
                sql += " AND FullName LIKE N'%" + fn + "%'";
            }

            // חיפוש לפי אימייל
            if (!string.IsNullOrEmpty(email))
            {
                sql += " AND Email LIKE N'%" + email + "%'";
            }

            // חיפוש לפי חוג
            if (!string.IsNullOrEmpty(hobby))
            {
                sql += " AND Hobby = N'" + hobby + "'";
            }
        }

        // ביצוע השאילתה ושמירת התוצאות בטבלה
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        // אם לא נמצאו תוצאות
        if (dt.Rows.Count == 0)
        {
            st = "אין נתונים";
        }
        else
        {
            // פתיחת הטבלה
            st = "<table border='1' style='width:95%; margin:auto; background-color:pink; border-collapse:collapse;'>";

            // שורת הכותרות
            st += "<tr>";
            st += "<th>שם מלא</th>";
            st += "<th>מייל</th>";
            st += "<th>סיסמה</th>";
            st += "<th>מספר טלפון</th>";
            st += "<th>קבוצת גיל</th>";
            st += "<th>תחביבים</th>";
            st += "</tr>";

            // מעבר על כל הרשומות
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                st += "<tr>";

                // מעבר על כל העמודות של הרשומה הנוכחית
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    st += "<td>" + dt.Rows[i][j] + "</td>";
                }

                st += "</tr>";
            }

            // סגירת הטבלה
            st += "</table>";
        }
    }
}