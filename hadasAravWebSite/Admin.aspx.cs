using System;
using System.Data;
using System.Web.UI;

public partial class Admin : Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        string sql = "SELECT * FROM tUsers WHERE 1=1";

        if (Page.IsPostBack)
        {
            string fn = Request.Form["name"];
            string email = Request.Form["email"];

            if (!string.IsNullOrEmpty(fn))
            {
                sql += " AND FullName LIKE N'%" + fn + "%'";
            }

            if (!string.IsNullOrEmpty(email))
            {
                sql += " AND Email LIKE N'%" + email + "%'";
            }
        }

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        if (dt.Rows.Count == 0)
        {
            st = "אין נתונים";
        }
        else
        {
            st = "<table border='1' style='width:95%; margin:auto; background-color:pink; border-collapse:collapse;'>";

            st += "<tr>";
            st += "<th>שם מלא</th>";
            st += "<th>אימייל</th>";
            st += "<th>סיסמה</th>";
            st += "<th>טלפון</th>";
            st += "<th>קבוצת גיל</th>";
            st += "<th>תחום</th>";
            st += "<th>שעה מועדפת</th>";
            st += "</tr>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                st += "<tr>";

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