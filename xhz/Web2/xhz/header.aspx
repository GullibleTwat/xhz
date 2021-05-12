<%@ Page Language="C#" AutoEventWireup="true" CodeFile="header.aspx.cs" Inherits="Admin_header" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/admin.css" type="text/css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
    <table cellspacing="0" cellpadding="0" width="100%" background="images/header_bg.jpg"
        border="0">
        <tr height="56">
            <td width="260">
                <img height="56" alt="" src="images/header_left.jpg" width="260">
            </td>
            <td style="font-weight: bold; color: #fff; padding-top: 20px" align="middle">
                当前用户：<asp:Label ID="UserLabel" runat="server" Text="Label"></asp:Label> &nbsp;&nbsp; <a style="color: #fff" id="PasswordChange" target="main" runat="server" >修改口令</a> &nbsp;&nbsp;
                <asp:LinkButton ID="LogoutButton" OnClientClick="return confirm('确认要退出吗？');" 
                    runat="server" ForeColor="White" onclick="LogoutButton_Click">退出系统</asp:LinkButton>
            </td>
            <td align="right" width="268">
                <img height="56" src="images/header_right.jpg" width="268">
            </td>
        </tr>
    </table>
    <table cellspacing="0" cellpadding="0" width="100%" border="0">
        <tr bgcolor="#1c5db6" height="4">
            <td>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
