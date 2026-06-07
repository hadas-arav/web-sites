using System;
using System.Data;
using System.Web.UI;

public partial class Admin : Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // שאילתת בסיס שמחזירה את כל המשתמשים
        string sql = "SELECT * FROM tUsers WHERE 1=1";

        if (Page.IsPostBack)
        {
            string fn = Request.Form["name"];
            string email = Request.Form["email"];

            // אם הוזן שם, מוסיף תנאי חיפוש לפי שם
            if (!string.IsNullOrEmpty(fn))
            {
                sql += " AND FullName LIKE N'%" + fn + "%'";
            }

            // אם הוזן אימייל, מוסיף תנאי חיפוש לפי אימייל
            if (!string.IsNullOrEmpty(email))
            {
                sql += " AND Email LIKE N'%" + email + "%'";
            }
        }

        // ביצוע השאילתה ושמירת התוצאות בטבלת נתונים
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        // אם לא נמצאו תוצאות
        if (dt.Rows.Count == 0)
        {
            st = "אין נתונים";
        }
        else
        {
            //יצירת טבלה עם עיצוב ורוד
            st = "<table border='1' style='width:95%; margin:auto; background-color:pink; border-collapse:collapse;'>";

            // יצירת שורת הכותרות
            st += "<tr>";
            st += "<th>שם מלא</th>";
            st += "<th>אימייל</th>";
            st += "<th>סיסמה</th>";
            st += "<th>טלפון</th>";
            st += "<th>קבוצת גיל</th>";
            st += "<th>תחום</th>";
            st += "<th>שעה מועדפת</th>";
            st += "</tr>";

            // מעבר על כל הרשומות שהוחזרו מהמסד
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                st += "<tr>";

                // הוספת הנתונים של כל משתמש לתאים בטבלה
                st += "<td>" + dt.Rows[i]["FullName"] + "</td>";
                st += "<td>" + dt.Rows[i]["Email"] + "</td>";
                st += "<td>" + dt.Rows[i]["Password"] + "</td>";
                st += "<td>" + dt.Rows[i]["PhoneNumber"] + "</td>";
                st += "<td>" + dt.Rows[i]["AgeGroup"] + "</td>";
                st += "<td>" + dt.Rows[i]["Hobby"] + "</td>";
                st += "<td>" + dt.Rows[i]["hour"] + "</td>";

                st += "</tr>";
            }

            st += "</table>";
        }
    }
}