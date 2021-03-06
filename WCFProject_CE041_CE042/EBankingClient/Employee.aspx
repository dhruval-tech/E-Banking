﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EBankingClient.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:cornsilk">
    <form id="form1" runat="server">
        <h4>Employee Management&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Logout" />
        </h4>
<asp:Label ID="lblMsg" runat="server"></asp:Label>
<table>
    <tr>
        <td>
            Employee Id :
        </td>
        <td>
            <asp:TextBox ID="txtEmpId" runat="server" Enabled="false" />
        </td>
    </tr>
    <tr>
        <td>
            Name :
        </td>
        <td>
            <asp:TextBox ID="txtName" runat="server" style="width: 300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            Salary :
        </td>
        <td>
            <asp:TextBox ID="txtSalary" runat="server" style="width: 300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
           DeptId :
        </td>
        <td>
            <asp:TextBox ID="txtDeptId" runat="server" style="width: 300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            DeptName :
        </td>
        <td>
            <asp:TextBox ID="txtDeptName" runat="server" style="width: 300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Button ID="ButtonInsert" runat="server" Text="Add" OnClick="InsertButton_Click"/>
            <asp:Button ID="ButtonUpdate" runat="server" visible="false" Text="Update" OnClick="UpdateButton_Click"/>
            <asp:Button ID="ButtonDelete" runat="server" visible="false" Text="Delete" OnClick="DeleteButton_Click"/>
            <asp:Button ID="ButtonCancel" runat="server" visible="false" Text="Cancel" OnClick="CancelButton_Click"/>
        </td>
    </tr>
</table>
<asp:GridView ID="GridViewStudentDetails" DataKeyNames="EmpId" AutoGenerateColumns="false"
        runat="server" OnSelectedIndexChanged="GridViewStudentDetails_SelectedIndexChanged" Width="700">
        <HeaderStyle BackColor="#0A9A9A" ForeColor="White" Font-Bold="true" Height="30" />
        <AlternatingRowStyle BackColor="#f5f5f5" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lbtnSelect" runat="server" CommandName="Select" Text="Select" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("Name") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Salary">
                <ItemTemplate>
                    <asp:Label ID="lblLastName" runat="server" Text='<%#Eval("Salary") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dept ID">
                <ItemTemplate>
                    <asp:Label ID="lblRegisterNo" runat="server" Text='<%#Eval("DeptId") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Department">
                <ItemTemplate>
                    <asp:Label ID="lblDepartment" runat="server" Text='<%#Eval("DeptName") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
