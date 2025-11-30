using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AspNet : System.Web.UI.Page
{
    public string str2;
    protected void Page_Load(object sender, EventArgs e)
    {
        str2 = "<table>";
        for(int i=1; i<=10; i++)
        {
            str2 += "<tr>";
            for (int j = 1; j <= 10; j++)
            {
                str2 += "<td>" + i * j + "<td>";
            }
            str2 += "</tr>";
             
        }
        str2 += "</table>";
    }
}