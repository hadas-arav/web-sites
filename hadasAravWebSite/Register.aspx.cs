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
            string phone1 = Request.Form["tel"];
            string phone2 = Request.Form["tel2"];
            string age = Request.Form["age"];
            string hobby = Request.Form["hobby"];

            string sql =
    "SELECT * FROM tUsers " +
    "WHERE Email = N'" + email + "' ";

            bool userExists = MyAdoHelper.IsExist(sql);

            if (userExists)
            {
                st = "המשתמש הזה כבר רשום";
            }
            else
            {

                string sqlInsert =
    "INSERT INTO tUsers VALUES (" +
    "N'" + fn + "'," +
    "N'" + email + "'," +
    "N'" + pass + "'," +
    "N'" + phone1+"-"+phone2 + "'," +
    "N'" + age + "'," +
    "N'" + hobby + "'" +
    ")";

                MyAdoHelper.DoQuery("mydb.mdf",sqlInsert);
                st = "נרשמת בהצלחה!";
                Response.Redirect("SignIn.aspx");
            }
           
        }
    }
}