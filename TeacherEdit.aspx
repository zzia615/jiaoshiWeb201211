<%@ Page Title="" Language="C#" MasterPageFile="~/EditSite.Master" AutoEventWireup="true" CodeBehind="TeacherEdit.aspx.cs" Inherits="jiaoshiWeb.TeacherEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        #form1{
            margin: 100px auto;
            width:300px;
            padding:20px;
            background:rgba(165, 165, 165, 0.83);

        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="container">
    <form id="form1" runat="server">
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="教工号"></asp:Label></td>
                <td><asp:TextBox ID="tbCode" runat="server" Enabled="false"></asp:TextBox></td>
                <td><asp:Label ID="Label2" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="教工号不能为空" ControlToValidate="tbCode" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label5" runat="server" Text="姓名"></asp:Label></td>
                <td><asp:TextBox ID="tbName" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="用户姓名不能为空" ControlToValidate="tbName" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label7" runat="server" Text="性别"></asp:Label></td>
                <td>
                    <asp:DropDownList ID="tbSex" runat="server">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem>女</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td><asp:Label ID="Label8" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="用户性别不能为空" ControlToValidate="tbSex" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label9" runat="server" Text="出生日期"></asp:Label></td>
                <td><asp:TextBox ID="tbBirtday" type="date" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label10" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="出生日期不能为空" ControlToValidate="tbBirtday" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label3" runat="server" Text="所授课程"></asp:Label></td>
                <td><asp:TextBox ID="tbCourse" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label4" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="所授课程不能为空" ControlToValidate="tbCourse" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label11" runat="server" Text="电话"></asp:Label></td>
                <td><asp:TextBox ID="tbPhone" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label12" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="电话不能为空" ControlToValidate="tbPhone" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
            <tr>
                <td><asp:Label ID="Label13" runat="server" Text="地址"></asp:Label></td>
                <td><asp:TextBox ID="tbAddress" runat="server"></asp:TextBox></td>
                <td><asp:Label ID="Label14" runat="server" Text="*" ForeColor="Red"></asp:Label></td>
            </tr>
            <tr><td colspan="3"><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="地址不能为空" ControlToValidate="tbAddress" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="保存" OnClick="Button1_Click"/>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TeacherList.aspx">返回教师列表</asp:HyperLink>
                </td>
                <td></td>
            </tr>
        </table>
    </form>
</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
