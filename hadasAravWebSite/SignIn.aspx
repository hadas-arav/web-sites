<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Sign In</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <h1  style="text-align:center">This is a page for signing in</h1>
    <h3>This is a page for signing</h3>
       <input type="email" name="email" id="email" /> אימייל<br />
   <input type="password" name="password" id="password" /> סיסמא<br />
</asp:Content>