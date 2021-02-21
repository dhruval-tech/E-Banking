<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EBankingClient.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
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
        .auto-style1 {
            margin-left: 578px;
            margin-right: 0;
            margin-top: 78px;
        }
        .auto-style2 {
            margin-left: 250px;
            margin-top: 193px;
        }
        .auto-style3 {
            margin-top: 0;
            margin-left: 0;
        }
    </style>

</head>
<body style="background-color:cornsilk; height: 464px;">
    <form id="form1" runat="server">
    <h1 style="text-align:center;">Welcome
        <asp:Label ID="Label1" runat="server"></asp:Label>
        </h1>
        <div>
            <%--<asp:Button ID="Profile" runat="server" OnClick="Profile_Click" Text="Profile" />--%>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Profile_Click" Text="Profile" BackColor="Yellow" CssClass="auto-style3" Height="110px" Width="282px" />

            <asp:Button ID="Transaction" runat="server" OnClick="Transaction_Click" Text="Transaction" BackColor="Yellow" CssClass="auto-style2" Height="116px" Width="340px" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" BackColor="#FF5050" CssClass="auto-style1" Height="60px" Width="208px" />
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </form>
</body>
</html>
