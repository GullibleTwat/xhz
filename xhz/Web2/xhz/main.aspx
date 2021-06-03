<%@ Page Title="" Language="C#" MasterPageFile="~/xhz/Main.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Web2.xhz.main" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellspacing="0" cellpadding="0" width="90%" align="center" border="0">
        <tbody>
            <tr height="100">
                <td align="center" width="100">
                    <img height="100" alt="" src="images/admin_p.gif" width="90">
                </td>
                <td width="60">
                    &nbsp;
                </td>
                <td>
                    <table height="100" cellspacing="0" cellpadding="0" width="100%" border="0">
                        <tbody>
                            <tr>
                                <td>
                                    当前时间：<asp:Label ID="TimeLabel" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td style="font-weight: bold; font-size: 16px">
                                    <asp:Label ID="UsernameLabel1" runat="server" Text="Label"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    欢迎进入网站管理中心！
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3" height="10">
                </td>
            </tr>
        </tbody>
    </table>
    <table cellspacing="0" cellpadding="0" width="95%" align="center" border="0">
        <tbody>
            <tr height="20">
                <td>
                </td>
            </tr>
            <tr height="22">
                <td style="padding-left: 20px; font-weight: bold; color: #ffffff" align="middle"
                    background="images/title_bg2.jpg">
                    您的相关信息
                </td>
            </tr>
            <tr bgcolor="#ecf4fc" height="12">
                <td>
                </td>
            </tr>
            <tr height="20">
                <td>
                </td>
            </tr>
        </tbody>
    </table>
    <table cellspacing="0" cellpadding="2" width="95%" align="center" border="0">
        <tbody>
            <tr>
                <td align="right" width="100">
                    登陆帐号：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="UsernameLabel2" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="right">
                    管理身份：
                </td>
                <td style="color: #880000">
                    <asp:Label ID="UserTypeLabel" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>
