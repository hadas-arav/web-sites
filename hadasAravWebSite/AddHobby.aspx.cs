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
            string hobbyName = Request.Form["hobbyName"]; // קבלת הערכים מהטופס
            string hobbyPrice = Request.Form["price"];
            string numberOfPeopleAllowed = Request.Form["numberOfPeopleAllowed"];
            string techerName = Request.Form["techerName"];

            string sqlInsert = "INSERT INTO tHobby (hobbyName, hobbyPrice, numberOfPeopleAllowed, techerName) VALUES (N'" +
                 hobbyName + "', '" +
                 hobbyPrice + "', '" +
                 numberOfPeopleAllowed + "', N'" + // N לפני מחרוזת בעברית כדי לציין שמדובר בטקסט
                 techerName + "')"; // הוספת עמודה לטבלה

            MyAdoHelper.DoQuery("MyDB.mdf", sqlInsert); // ביצוע השאילתה להוספת תחביב חדש
            st = "בוצע";
        }

    }
}