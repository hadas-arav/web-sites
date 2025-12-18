using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public string tableKefel = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        tableKefel = "<table style='text-align:center;border-collapse:collapse;'>";

        tableKefel += "<tr>";
        tableKefel += "<th style='border:1px solid black; padding:10px; background-color:#827C7A;'></th>";
        for (int j = 1; j <= 10; j++)
            tableKefel += "<th style='border:1px solid black; padding:10px; background-color:#827C7A;'>" + j + "</th>";
        tableKefel += "</tr>";

        for (int i = 1; i <= 10; i++)
        {
            tableKefel += "<tr>";
            tableKefel += "<th style='border:1px solid black; padding:10px; background-color:#827C7A;'>" + i + "</th>";
            for (int j = 1; j <= 10; j++)
                tableKefel += "<td style='border:1px solid black; padding:10px;'>" + (i * j) + "</td>";
            tableKefel += "</tr>";
        }

        tableKefel += "</table>";
    }
}