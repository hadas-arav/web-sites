<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddHobby.aspx.cs" Inherits="AddHobby" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script language="javascript">
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
        name = document.getElementById("hobbyName").value;

        if (name.length < 2 || name.length > 30) {
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

        if (number.length < 1 || isNaN(number)) {
            numberErr.innerHTML = "כמות האנשים לא תקינה";
            return false;
        }

        return true;
    }

    function checkTeacherName() {
        teacher = document.getElementById("techerName").value;

        if (teacher.length < 2 || teacher.length > 30) {
            teacherErr.innerHTML = "שם המורה לא תקין";
            return false;
        }

        return true;
    }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>(הוספת פריטים (מנהל</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
<form method="post" onsubmit="return checkAll();">

     שם החוג
    <input type="text" name="hobbyName" id="hobbyName"/>
    <span id="priceErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    מחיר לחוג זה
    <input type="text" name="price" id="price"/>
    <span id="priceErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    כמות אנשים מותרת לחוג זה
    <input type="text" name="numberOfPeopleAllowed" id="numberOfPeopleAllowed" />
    <span id="numberErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    שם המורה לחוג זה
    <input type="text" name="techerName" id="techerName" />
    <span id="teacherErr" style="color:red; display:inline-block; width:150px;"></span>
    <br />

    <input type="submit" name="submit" id="submit"/>

</form>
    <%=st %>
</asp:Content>

