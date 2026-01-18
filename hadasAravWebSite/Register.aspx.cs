using System;
using System.Web.UI;

public partial class harshama : Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string fn = Request.Form["name"];
            string age = Request.Form["age"];

            string sqlInsert =
                "INSERT INTO tUsers VALUES (" +
                "N'" + fn + "'," +
                age +
                ")";

            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

            st = "נרשמת בהצלחה!";
        }
    }
}

}