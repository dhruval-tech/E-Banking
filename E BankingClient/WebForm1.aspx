<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="E_BankingClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 696px;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            margin-left: 120px;
        }
    </style>
</head>
<body >
    <form id="form1" runat="server" class="auto-style1">  

    <%--<div style="width:100%;">  
        <fieldset style="width:40%;">  
            <legend>Perform CRUD Operations using WCF</legend>   
            <table style="width:100%;">  
                <tr>  
                    <td>Employee ID</td>  
                    <td><asp:TextBox ID="txtEmpID" runat="server" CssClass="textBox" ></asp:TextBox></td>  
                </tr>
                <tr>  
                    <td>Name</td>  
                    <td>  
                        <asp:TextBox ID="txtName" runat="server" ></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>Salary</td>  
                    <td>  
                        <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td>DeptId</td>  
                    <td>  
                        <asp:TextBox ID="txtDeptId" runat="server"></asp:TextBox>  
                    </td>  
                </tr> 
                 <tr>  
                    <td>DeptName</td>  
                    <td>  
                        <asp:TextBox ID="txtDeptName" runat="server"></asp:TextBox>  
                    </td>  
                </tr> 
                <tr>  
                    <td></td>  
                    <td class="style1">  
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />  
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />  
                    </td>  
                </tr>  
                <tr>  
                    <td colspan="2">  
                        <asp:Label ID="lblStatus" runat="server"></asp:Label>  
                    </td>  
                </tr>  
                <tr>  
                    <td colspan="2">  
                        <br />  
                    </td>  
                </tr>  
                <tr>  
                    <td colspan="2">  
                        <asp:GridView ID="grdWcfTest" runat="server" AutoGenerateColumns="False" DataKeyNames="Id"  
CellPadding="5" Width="100%">  
                            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />  
                            <Columns>  
                                <asp:TemplateField HeaderText="Name">  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name")%>'>  
                                        </asp:Label>  
                                        <asp:Label ID="lblId" runat="server" Visible="false" Text='<%#Eval("Id")%>'>  
                                        </asp:Label>  
                                    </ItemTemplate>  
                                </asp:TemplateField>  
                                <asp:TemplateField HeaderText="Salary">  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblSalary" runat="server" Text='<%#Eval("Salary") %>'>  
                                        </asp:Label>  
                                    </ItemTemplate>  
                                </asp:TemplateField>  
                                <asp:TemplateField HeaderText="DeptId">  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblDeptId" runat="server" Text='<%#Eval("DeptId") %>'>  
                                        </asp:Label>  
                                    </ItemTemplate>  
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DeptId">  
                                    <ItemTemplate>  
                                        <asp:Label ID="lblDeptId" runat="server" Text='<%#Eval("DeptName") %>'>  
                                        </asp:Label>  
                                    </ItemTemplate>  
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Edit">  
                                    <ItemTemplate>  
                                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CausesValidation="false"  
CommandArgument=' <%#Eval("Id") %>' OnCommand="lnkEdit_Command" ToolTip="Edit" />  
                                        </ItemTemplate>  
                                    </asp:TemplateField>  
                                    <asp:TemplateField HeaderText="Delete">  
                                        <ItemTemplate>  
                                            <asp:LinkButton ID="lnkDelete" runat="server" Text="Delete" CausesValidation="false"  
  
CommandArgument='  
                                                <%#Eval("Id") %>' CommandName="Delete" OnCommand="lnkDelete_Command"  
  
OnClientClick="return confirm('Are you sure you want to delete?')" ToolTip="Delete" />  
                                            </ItemTemplate>  
                                        </asp:TemplateField>  
                                    </Columns>  
                                </asp:GridView>  
                            </td>  
                        </tr>  
                </table>  
        </fieldset>  
    </div> --%>
        <%--<div class="auto-style2" style="background-color: #66FFFF; font-size: 21px; text-align: center;">&nbsp;<asp:Label ID="Label1" runat="server" Text="Employee Registration Form" Font-Bold="True" Font-Italic="True"></asp:Label></div>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Name" runat="server" Text="Name"></asp:Label>
        :
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="Salary" runat="server" Text="Salary"></asp:Label>
            :
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="DeptId" runat="server" Text="DeptId"></asp:Label>
        :
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<p>
            <asp:Label ID="DeptName" runat="server" Text="DeptName"></asp:Label>
            :
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p class="auto-style3">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="message" runat="server" Text="Label"></asp:Label>
        </p>
        <p class="auto-style3">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Search" />
        </p>
        <p class="auto-style3">
            &nbsp;</p>
        <p class="auto-style3">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>--%>
        <h4>Emplyee Management</h4>
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
            <asp:TemplateField HeaderText="First Name">
                <ItemTemplate>
                    <asp:Label ID="lblFirstName" runat="server" Text='<%#Eval("Name") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Last Name">
                <ItemTemplate>
                    <asp:Label ID="lblLastName" runat="server" Text='<%#Eval("Salary") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Register No.">
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
