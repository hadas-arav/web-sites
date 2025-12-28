<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Form</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
     <input type="text" name="name" id="name"/> שם מלא <br />
    <input type="email" name="email" id="email" /> אימייל<br />
    <input type="password" name="password" id="password" /> סיסמא<br />
    <input type="password" name="password2" id="password2" /> אימות סיסמא<br />
    <select name="tel" id="tel">
        <option value="050">050</option>
        <option value="051">051</option>
        <option value="052">052</option>
        <option value="053">053</option>
        <option value="054">054</option>
        <option value="055">055</option>
        <option value="056">056</option>
        <option value="057">057</option>
        <option value="058">058</option>
        <option value="059">059</option>
    </select>
    <input type="tel" name="tel" id="tel" /> מספר טלפון<br />
    <p>בחר את טווח הגילאים של שלך/ של הילד/ה שלך</p>
    <input type="radio" name="age" id="little" value="little"/> גילאי גן <br />
    <input type="radio" name="age" id="first" value="first"/> גיל 7-9 <br />
     <input type="radio" name="age" id="second " value="second"/> גיל 10-12 <br />
    <input type="radio" name="age" id="third" value="third"/> גיל 13-15 <br />
    <input type="radio" name="age" id="fourth" value="fourth"/> גיל 16-18 <br />
    <input type="radio" name="age" id="fifth" value="fifth"/> +גיל 18 <br />
    <input type="submit" name="submit" id="submit"/> <br />
    <%="Welcome to the website,"+ name +"!" %>
</asp:Content>