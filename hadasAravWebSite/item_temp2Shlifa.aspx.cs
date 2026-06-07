using System;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // קבלת הערכים שהוזנו בטופס החיפוש
        string hobbyName = Request.Form["hobbyName"];
        string teacherName = Request.Form["teacherName"];

        // שאילתת בסיס שמחזירה את כל החוגים
        string sql = "SELECT * FROM tHobby WHERE 1=1";

        // אם הוזן שם חוג, מוסיף תנאי חיפוש לפי שם החוג
        if (!string.IsNullOrEmpty(hobbyName))
        {
            sql += " AND hobbyName LIKE N'%" + hobbyName + "%'";
        }

        if (!string.IsNullOrEmpty(teacherName))
        {
            sql += " AND techerName LIKE N'%" + teacherName + "%'";
        }

        // ביצוע השאילתה ושמירת התוצאות בטבלת נתונים
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        if (dt.Rows.Count == 0)
        {
            st = "אין נתונים";
            return;
        }

        //בניית טבלה להצגת הנתונים
        st = "<table border='1' style='width:95%; margin:auto; background:pink; border-collapse:collapse;'>";

        st += "<tr>";
        st += "<th>Id</th>";
        st += "<th>שם חוג</th>";
        st += "<th>מחיר</th>";
        st += "<th>מספר משתתפים</th>";
        st += "<th>שם מורה</th>";
        st += "</tr>";

        // מעבר על כל הרשומות שהוחזרו מהמסד
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            st += "<tr>";

            st += "<td>" + dt.Rows[i]["Id"] + "</td>";
            st += "<td>" + dt.Rows[i]["hobbyName"] + "</td>";
            st += "<td>" + dt.Rows[i]["hobbyPrice"] + "</td>";
            st += "<td>" + dt.Rows[i]["numberOfPeopleAllowed"] + "</td>";
            st += "<td>" + dt.Rows[i]["techerName"] + "</td>";

            st += "</tr>";
        }

        st += "</table>";
    }
}