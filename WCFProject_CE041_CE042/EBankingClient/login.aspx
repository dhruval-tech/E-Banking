<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="EBankingClient.login" %>

<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">--%>  
<head runat="server">  
    <title>Login</title> 
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.4.1.slim.min.js" integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <style>
        body{
            background:linear-gradient(90deg, rgb(51, 255, 51,0.5) 29%, rgb(128, 223, 255,0.8) 100%);
            font-family:cursive;
            font-size:25px;
        }
        .form-control {
      position: relative;
      border-radius: 0;
      border-width: 0 0 1px;
      height: auto;
      padding: 3px 0 5px;
      color:black;
      &:focus {
        box-shadow: none;
        border:none;
        }
        }
        .btn {
    border:none;
  border-radius: 28px;
  color: #fafafa;
  background: #127fc7;
  padding: 10px 20px 10px 20px;
  text-decoration: none;
}
        .btn:hover {
 background: #00a6ff;
  background-image: linear-gradient(to bottom, #00a6ff, #00e7f7);
  text-decoration: none;
  border:none;
}
    </style>
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
