<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddHobby.aspx.cs" Inherits="AddHobby" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript">
        // מאפס את הודעות השגיאה לפני הבדיקה
        function checkAll() {
        nameErr.innerHTML = "";
        priceErr.innerHTML = "";
        numberErr.innerHTML = "";
        teacherErr.innerHTML = "";

        f = true;

        f = checkName() && f;
        f = checkPrice() && f;
        f = checkNumberOfPeople() && f;
        f = checkTeacherName() && f;

        return f;
    }

        function checkName() {
            // מקבל את שם החוג שהוזן
        name = document.getElementById("hobbyName").value;

        if (name.length < 2 || name.length > 30) { //בודק שהשם בין 2 ל30 תווים
            nameErr.innerHTML = "שם החוג לא תקין";
            return false;
        }

        return true;
    }

    function checkPrice() {
        price = document.getElementById("price").value;

        if (price.length < 1 || isNaN(price)) {  //בודק שזה מספר ושזה גדול מ1
            priceErr.innerHTML = "המחיר לא תקין";
            return false;
        }

        return true;
    }

    function checkNumberOfPeople() {
        number = document.getElementById("numberOfPeopleAllowed").value;

        if (number.length < 1 || isNaN(number)) { //בודק שזה מספר ושזה גדול מ1
            numberErr.innerHTML = "כמות האנשים לא תקינה";
            return false;
        }

        return true;
    }

    function checkTeacherName() {
        teacher = document.getElementById("techerName").value;

        if (teacher.length < 2 || teacher.length > 30) { //בודק שהשם בין 2 ל30 תווים
            teacherErr.innerHTML = "שם המורה לא תקין";
            return false;
        }

        return true;
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>הוספת חוגים</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <h3>הכנס את הפרטים של החוג שאתה רוצה להוסיף </h3>
<form method="post" onsubmit="return checkAll();">

    <input type="text" name="hobbyName" id="hobbyName"/>
     שם החוג
    <span id="nameErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    <input type="text" name="price" id="price"/>
    מחיר לחוג זה
    <span id="priceErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    <input type="text" name="numberOfPeopleAllowed" id="numberOfPeopleAllowed" />
    כמות אנשים מותרת לחוג זה
    <span id="numberErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    <input type="text" name="techerName" id="techerName" />
    שם המורה לחוג זה
    <span id="teacherErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    <input type="submit" name="submit" id="submit"/>

</form>
    <%=st %>
</asp:Content>

