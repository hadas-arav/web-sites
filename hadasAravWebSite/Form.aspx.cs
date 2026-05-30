using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string name, number, subject;
    public string tableKefel = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            name = "Name: " + Request.Form["firstName"];
            number = "Number: " + Request.Form["number"];
            subject = "Subject: " + Request.Form["subject"];
        }

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