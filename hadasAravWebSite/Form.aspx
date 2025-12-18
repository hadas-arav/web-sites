<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Form</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
     <input type="text" name="firstName" id="firstName"/> Enter your first name
    <input type="number" name="number" id="number" /> Enter your number
    <input type="submit" name="submit" id="submit"/> <br />
    <%=name %>
    <%=number %>
</asp:Content>