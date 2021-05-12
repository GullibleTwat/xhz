<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="Admin_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
