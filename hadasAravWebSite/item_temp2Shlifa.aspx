<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="item_temp2Shlifa.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>החוגים שלנו</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">

        <h3>הכנס את שם החוג או את שם המורה של אחד החוגים בשביל למצוא את החוג הספציפי שאתה מחפש</h3>
         <input type="text" name="name" id="name"/> שם החוג <br />
    <input type="email" name="email" id="email" /> שם המורה<br />
    <input type="submit" name="submit" id="submit"/> <br />
    <%= st%>

</asp:Content>

