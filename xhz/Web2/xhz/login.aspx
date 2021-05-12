<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web2.xhz.login1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>管理中心登陆 V1.0</title>
    <link href="css/admin.css" type="text/css" rel="stylesheet">
</head>
<body bgcolor="#002779" style="height:600px;">
<div style="background-color:#002779; height:100%;">
    <table height="100%" cellspacing="0" cellpadding="0" width="100%" bgcolor="#002779"
        border="0">
        <tr>
            <td align="center">
                <table cellspacing="0" cellpadding="0" width="468" border="0">
                    <tr>
                        <td>
                            <img height="23" alt="" src="images/login_1.jpg" width="468"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <img height="147" alt="" src="images/login_2.jpg" width="468"/>
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="468" bgcolor="#ffffff" border="0">
                    <tr>
                        <td width="16">
                            <img height="122" alt="" src="images/login_3.jpg" width="16"/>
                        </td>
                        <td align="center">
                            <table cellspacing="0" cellpadding="0" width="230" border="0">
                                <form id="Form1" name="form1" runat="server">
                                <tr height="5">
                                    <td width="5">
                                    </td>
                                    <td width="56">
                                    </td>
                                    <td>
                                    </td>
                                </tr>
                                <tr height="36">
                                    <td>
                                    </td>
                                    <td>
                                        用户名
                                    </td>
                                    <td>
                                        <asp:TextBox ID="UsernameText" Width="160" runat="server"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr height="36">
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        口 令
                                    </td>
                                    <td>
                                        <asp:TextBox ID="PasswordText" Width="160" runat="server" TextMode="Password"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr height="5">
                                    <td colspan="3">
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        &nbsp;
                                    </td>
                                    <td>
                                        <asp:ImageButton ID="ImageButton1" ImageUrl="images/bt_login.gif" 
                                            runat="server" onclick="ImageButton1_Click" />
                                        
                                    </td>
                                </tr>
                                </form>
                            </table>
                        </td>
                        <td width="16">
                            <img height="122" alt="" src="images/login_4.jpg" width="16"/>
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="468" border="0">
                    <tr>
                        <td>
                            <img height="16" alt="" src="images/login_5.jpg" width="468"/>
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="468" border="0">
                    <tr>
                        <td align="right">
                            
                                <img height="26" alt="" src="images/login_6.gif" width="165" border="0"/>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table></div>
</body>
</html>
