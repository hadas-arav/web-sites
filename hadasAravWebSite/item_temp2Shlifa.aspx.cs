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
        if (Page.IsPostBack)
        {
            string pr = Request.Form["price"];
            string nopa = Request.Form["numberOfPeopleAllowed"];
            string tn = Request.Form["techerName"];

            string sql = "SELECT * FROM tHobby WHERE " +
                "numberOfPeopleAllowed <= " + nopa;

            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                st = "אין נתונים";
            }
            else
            {
                st += "<table border='1'>";
                st += "<tr>";
                st += "<th>id</th>";
                st += "<th>hobbyPrice</th>";
                st += "<th>numberOfPeopleAllowed</th>";
                st += "<th>teacherName</th>";
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