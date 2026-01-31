using System;
using System.Web.UI;

public partial class Register: Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string fn = Request.Form["name"];
            string email = Request.Form["email"];
            string pass = Request.Form["password"];
            string phone = Request.Form["poneNumber"];
            string age = Request.Form["ageGroup"];
            string hobby = Request.Form["hobby"];
            string sqlInsert =
                "INSERT INTO tUsers VALUES (" +
                "N'" + fn + "'," +
                "N'" + email + "'," + 
                "N'" + pass + "'," + 
                "N'" + phone + "'," + 
                "N'" + age + "'," + 
                "N'" + hobby + "'" +
                ")";

            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);

            bool userExists = MyAdoHelper.IsExist(sqlInsert);

            if (!userExists)
            {
                st = "אימייל או סיסמה שגויים";
            }
            else
            {
                Response.Redirect("home.aspx");
            }
            st = "נרשמת בהצלחה!";
        }
    }
}