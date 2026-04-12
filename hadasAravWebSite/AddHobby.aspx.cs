using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddHobby : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string hobbyPrice = Request.Form["price"];
            string numberOfPeopleAllowed = Request.Form["numberOfPeopleAllowed"];
            string techerName = Request.Form["techerName"];

            string sqlInsert = "INSERT INTO tHobby (hobbyPrice, numberOfPeopleAllowed, techerName) VALUES (" +
                 hobbyPrice + ", " +
                 numberOfPeopleAllowed + ", " +
                "N'" + techerName + "')";

            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert);
            st = "DONE";
        }

    }
}