<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="Web2.xhz.menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="css/admin.css" type="text/css" rel="stylesheet"/>
    <script type="text/javascript" language="javascript">
        function expand(el) {
            childObj = document.getElementById("child" + el);

            if (childObj.style.display == 'none') {
                childObj.style.display = 'block';
            }
            else {
                childObj.style.display = 'none';
            }
            return;
        }

    </script>
    <style type="text/css">
        .style1
        {
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table height="100%" cellspacing="0" cellpadding="0" width="170" background="images/menu_bg.jpg"
        border="0">
        <tr>
            <td valign="top" align="middle">
                <table cellspacing="0" cellpadding="0" width="100%" border="0">
                    <tr>
                        <td height="10">
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="150" border="0">
                    <tr height="22">
                        <td style="padding-left: 30px" background="images/menu_bt.jpg">
                            <a class="menuParent" onclick="expand(1)" href="javascript:void(0);">关于我们</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="child1" style="display: none" cellspacing="0" cellpadding="0" width="150"
                    border="0">
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="#" target="main">公司简介</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="#" target="main">荣誉资质</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="#" target="main">分类管理</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="#" target="main">子类管理</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td colspan="2">
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="150" border="0">
                    <tr height="22">
                        <td style="padding-left: 30px" background="images/menu_bt.jpg">
                            <a class="menuParent" onclick="expand(2)" href="javascript:void(0);">新闻资讯</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="child2" style="display: none" cellspacing="0" cellpadding="0" width="150"
                    border="0">
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="AddNew.aspx" target="main">添加新闻</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="NewsManager/NewsList.aspx" target="main">新闻列表</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="AddActivity.aspx" target="main">添加艺人艺事</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="ActivityManager/ActivityList.aspx" target="main">艺人艺事列表</a>
                        </td>
                    </tr>

                    <tr height="4">
                        <td colspan="2">
                        </td>
                    </tr>
                </table>

                <asp:Panel ID="Panel1" runat="server">
              


                <table cellspacing="0" cellpadding="0" width="150" border="0">
                    <tr height="22">
                        <td style="padding-left: 30px" background="images/menu_bt.jpg">
                            <a class="menuParent" onclick="expand(3)" href="javascript:void(0);">管理员管理</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="child3" style="display: none" cellspacing="0" cellpadding="0" width="150"
                    border="0">
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="AdminManager/AddAdmin.aspx" target="main">添加管理员</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="AdminManager/AdminList.aspx" target="main">管理员列表</a>
                        </td>
                    </tr>
                   
                    <tr height="4">
                        <td colspan="2">
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="150" border="0">
                    <tr>
                        <td style="padding-left: 30px" background="images/menu_bt.jpg" class="style1">
                            <a class="menuParent" onclick="expand(4)" href="javascript:void(0);">随笔小记</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="child4" style="display: none" cellspacing="0" cellpadding="0" width="150"
                    border="0">
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="UserManager/AddUser.aspx" target="main">添加随笔</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="UserManager/UserList.aspx" target="main">随笔列表</a>
                        </td>
                    </tr>
                    
                    <tr height="4">
                        <td colspan="2">
                        </td>
                    </tr>
                </table>
                  </asp:Panel>
                <table cellspacing="0" cellpadding="0" width="150" border="0">
                    <tr height="22">
                        <td style="padding-left: 30px" background="images/menu_bt.jpg">
                            <a class="menuParent" onclick="expand(5)" href="javascript:void(0);">作品管理</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="child5" style="display: none" cellspacing="0" cellpadding="0" width="150"
                    border="0">
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="WorksGroup.aspx" target="main">添加作品</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="WorksGroupList.aspx" target="main">作品列表</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td colspan="2">
                        </td>
                    </tr>
                </table>
                <table cellspacing="0" cellpadding="0" width="150" border="0">
                    <tr height="22">
                        <td style="padding-left: 30px" background="images/menu_bt.jpg">
                            <a class="menuParent" onclick="expand(10)" href="javascript:void(0);">同行评价</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td>
                        </td>
                    </tr>
                </table>
                <table id="child10" style="display: none" cellspacing="0" cellpadding="0" width="150"
                    border="0">
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="ThesisManager/AddThesis.aspx" target="main">添加评价</a>
                        </td>
                    </tr>
                    <tr height="20">
                        <td align="middle" width="30">
                            <img height="9" src="images/menu_icon.gif" width="9">
                        </td>
                        <td>
                            <a class="menuChild" href="ThesisManager/ThesisList.aspx" target="main">评价列表</a>
                        </td>
                    </tr>
                    <tr height="4">
                        <td colspan="2">
                        </td>
                    </tr>
                </table>
                
           </td>
         </tr>
     </table>
    </form>
</body>
</html>
