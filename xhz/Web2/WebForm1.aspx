<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
        <script type="text/javascript">
            $(document).ready(function () {
                $("#myul").html("Hello");
                $(".btn1").click(function () {
                    $("#myul").html("Hello world");
                });
            });
</script>
</head>
<body>
<ul id="myul"><li></li></ul>
<p>This is another paragraph.</p>
<button class="btn1">改变 p 元素的内容</button>
</body>
</html>
