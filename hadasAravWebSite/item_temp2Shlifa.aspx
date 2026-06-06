<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="item_temp2Shlifa.aspx.cs"
    Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>צפייה בחוגים</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h3>הכנס את שם החוג או שם המורה שאת/ה רוצה למצוא</h3>

    <div>
        <input type="text" name="hobbyName" />
        <label>:שם החוג</label>
  </div>

    <div>
        <input type="text" name="teacherName" />
        <label>:שם המורה</label>
    </div>

    <input type="submit" value="חפש" />

    <br /><br />

    <%= st %>

</asp:Content>