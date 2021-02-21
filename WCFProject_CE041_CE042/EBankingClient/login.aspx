<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EBankingClient.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title>Login</title>  
    <style type="text/css">
        .auto-style1 {
            width: 434px;
            margin-left: 506px;
        }
    </style>
</head>  
<body style="background-color:cornsilk">  
    <h1 style="text-align:center;">Login Yourself!!!</h1>
    <form id="form1" runat="server"  style="align-self:center;">  
    <table style="font-family:Arial" class="auto-style1">  
        <tr>  
            <td>  
                <asp:Label ID="Label1" runat="server" Text="User Email"></asp:Label></td>  
            <td></td>  
            <td>  
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>  
        </tr>  
        <tr>  
            <td></td>  
            <td></td>  
            <td></td>  
        </tr>  
         <tr>  
            <td>  
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label></td>  
            <td></td>  
            <td>  
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>  
        </tr>  
        <tr>  
            <td></td>  
            <td></td>  
            <td></td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td>  
            <td></td>  
            <td>  
                <asp:Button ID="Button2" runat="server" Text="New User?" OnClick="Button2_Click" /></td>  
        </tr>  
        <tr>  
            <td></td>  
            <td></td>  
            <td></td>  
        </tr>  
        <tr>  
            <td></td>  
            <td colspan="3">  
                <asp:Label ID="Label3" runat="server"></asp:Label></td>  
            <td></td>  
        </tr>  
    </table>  
    </form>  
</body>  
</html>
