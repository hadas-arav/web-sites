using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string nopa = Request.Form["numberOfPeopleAllowed"]; // קבלת הערך מהטופס

        string sql = "SELECT * FROM tHobby"; // שאילתא לבחירת כל הנתונים מטבלת החוגים

        if (!string.IsNullOrEmpty(nopa)) // בדיקה אם המשתמש הזין ערך
        {
            sql += " WHERE numberOfPeopleAllowed <= " + nopa; // הוספת תנאי לשאילתא כדי לסנן את החוגים לפי מספר האנשים המותר
        }

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql); // ביצוע השאילתא וקבלת התוצאות בטבלה

        if (dt.Rows.Count == 0) // בדיקה אם אין נתונים להציג
        {
            st = "אין נתונים";
        }
        else
        {
            st = "<table border='1' style='width:95%; margin:auto; background-color:pink;'>"; // יצירת טבלה עם עיצוב
            st += "<th style='background-color: dark pink;'>id</th>";
            st += "<th style='background-color:pink;'>שם החוג</th>";
            st += "<th style='background-color:pink;'>מחיר החוג</th>";
            st += "<th style='background-color:pink;'>מספר אנשים מותר</th>";
            st += "<th style='background-color:pink;'>שם המורה</th>";
            st += "<tr>";

            for (int i = 0; i < dt.Rows.Count; i++) // לולאה לעבור על כל השורות בטבלה ולהוסיף אותן לטבלה שנוצרה
            {
                st += "<tr>";

                for (int j = 0; j < dt.Columns.Count; j++) // לולאה לעבור על כל העמודות בשורה ולהוסיף את הערכים לתאים בטבלה
                {
                    st += "<td>" + dt.Rows[i][j] + "</td>";
                }

                st += "</tr>";
            }

            st += "</table>";
        }
    }
}