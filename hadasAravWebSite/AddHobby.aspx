<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AddHobby.aspx.cs" Inherits="AddHobby" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
        <form>
         <input type="text" name="price" id="price"/> מחיר לחוג זה <br />
    <input type="text" name="numberOfPeopleAllowed" id="numberOfPeopleAllowed" /> כמות אנשים מותרת לחוג זה<br />
    <input type="text" name="techerName" id="techerName" /> שם המורה לחוג זה<br />
       <input type="submit" name="submit" id="submit"/> <br />
   </form>
    <%=st %>
</asp:Content>

