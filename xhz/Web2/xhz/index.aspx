<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web2.xhz.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>管理中心 V1.0</title>
    <link href="css/admin.css" type="text/css" rel="stylesheet">
</head>

    <frameset border="0" framespacing="0" rows="60, *" frameborder="0">
        <frame name="header" src="header.aspx" frameborder="0" noresize="noresize" scrolling="no"/>
        <frameset cols="170, *">
            <frame name="menu" src="menu.aspx" frameborder="0" noresize="noresize" />
            <frame name="main" src="main.aspx" frameborder="0" noresize="noresize" scrolling="yes"/>
        </frameset>
    </frameset>
<noframes>
框架无法显示
</noframes>
</html>
