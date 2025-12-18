<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Form</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
     <input type="text" name="firstName" id="firstName"/> Enter your first name <br />
    <input type="number" name="number" id="number" /> Enter your number <br />
    <input type="radio" name="subject" id="math" value="math"/> Math <br />
    <input type="radio" name="subject" id="english" value="english"/> English <br />
     <input type="radio" name="subject" id="software angineer " value="software angineer "/> software angineer <br />
    <input type="radio" name="subject" id="hebrow" value="hebrow"/> hebrow <br />
    <input type="submit" name="submit" id="submit"/> <br />
    <%=name %>
    <%=number %>
    <%=subject %>
</asp:Content>