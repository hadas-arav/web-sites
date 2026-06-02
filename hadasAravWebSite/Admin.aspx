<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>מנהל</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="server">
     
    <h3>הכנס שם מלא ואימייל (או רק את אחד מהם) של אחד הרשומים בשביל למצוא אותו</h3>
         <input type="text" name="name" id="name"/> שם מלא <br />
    <input type="email" name="email" id="email" /> אימייל<br />
    <input type="submit" name="submit" id="submit"/> <br />
     <%=st %>
</asp:Content>