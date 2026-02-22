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
        if (Page.IsPostBack)
        {
            string fn = Request.Form["name"];
            string email = Request.Form["email"];

            string sql = "SELECT * FROM tUsers WHERE " +
                "FullName LIKE N'%" + fn + "%' AND " +
                "Email LIKE N'%" + email + "%'";

            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                st = "אין נתונים";
            }
            else
            {
                st += "<table border='1'>";
                st += "<tr>";
                st += "<th>שם מלא</th>";
                st += "<th>מייל</th>";
                st += "<th>סיסמא</th>";
                st += "<th>מספר טלפון</th>";
                st += "<th>קבוצת גיל</th>";
                st += "<th>תחביבים</th>";
                st += "</tr>";

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    st += "<tr>";

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        st += "<td>" + dt.Rows[i][j] + "</td>";
                    }

                    st += "</tr>";
                }
                st += "</table>";
            }
        }
    }
}