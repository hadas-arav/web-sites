<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script language ="javascript">
        function checkAll(); {
            return true;
        }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h1>Form</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width:400px; margin:0 auto;">

    <table border="0" dir="rtl">

        <!-- Full Name -->
        <tr>
            <td style="width:150px;">שם מלא</td>
            <td>
                <input type="text" name="name" id="name" style="width:96%; height:25px;" />
                <span id="fnErr" style="font-size:15px; color:red;"></span>
            </td>
            <td></td>
        </tr>

        <!-- Email -->
        <tr>
            <td>אימייל</td>
            <td>
                <input type="email" name="email" id="email" style="width:96%; height:25px;" />
                <span id="emailErr" style="font-size:15px; color:red;"></span>
            </td>
            <td></td>
        </tr>

        <!-- Password -->
        <tr>
            <td>סיסמא</td>
            <td>
                <input type="password" name="password" id="password" style="width:96%; height:25px;" />
            </td>
            <td></td>
        </tr>

        <!-- Confirm Password -->
        <tr>
            <td>אימות סיסמא</td>
            <td>
                <input type="password" name="password2" id="password2" style="width:96%; height:25px;" />
            </td>
            <td></td>
        </tr>

        <!-- Phone -->
        <tr>
            <td>טלפון</td>
            <td>
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

                -
                <input type="tel" name="tel2" id="tel2" style="width:60%;" />
            </td>
            <td></td>
        </tr>

        <!-- Age -->
        <tr>
            <td>גיל</td>
            <td>
                <input type="radio" name="age" id="little" value="little"> גילאי גן
                <input type="radio" name="age" id="first" value="first"> גיל 7-9
                <input type="radio" name="age" id="second" value="second"> גיל 10-12
                <input type="radio" name="age" id="third" value="third"> גיל 13-15
                <input type="radio" name="age" id="fourth" value="fourth"> גיל 16-18
                <input type="radio" name="age" id="fifth" value="fifth"> +גיל 18
            </td>
            <td></td>
        </tr>

        <!-- Hobbies -->
        <tr>
            <td>תחומים</td>
            <td>
                <input type="checkbox" name="hobby" id="dance" value="dance"> ריקוד
                <input type="checkbox" name="hobby" id="yoga" value="yoga"> ספורט גוף-נפש
                <input type="checkbox" name="hobby" id="sea" value="sea"> ספורט ימי
                <input type="checkbox" name="hobby" id="nerd" value="nerd"> מחשבתי
                <input type="checkbox" name="hobby" id="ball" value="ball"> משחקי כדור
            </td>
            <td></td>
        </tr>

        <!-- Submit -->
        <tr>
            <td></td>
            <td>
                <input type="submit" name="submit" id="submit" value="שלח" style="width:120px; height:35px;" />
            </td>
        </tr>

    </table>
        </div>
    <%=st %>
</asp:Content>