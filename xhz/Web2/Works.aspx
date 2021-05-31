<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Works.aspx.cs" Inherits="Web2.Works" %>
<asp:Content ID="HeadContent"  ContentPlaceHolderID="headContent" runat="server">
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="js/Atl.js"></script>
    <link href="cs/Atl.css" rel="stylesheet" />
    <script type="text/javascript">
        
        $(document).ready(function () {

            //获取图片列表mini缩略图
            //$("#pictureurls li").each(function () {
            //    var ourl = $("img",this).attr("rel");
            //    var name = "mini_" + ourl.substring(ourl.lastIndexOf("/")+1);
            //    var url = ourl.substring(0, ourl.lastIndexOf("/")+1) + name;
            //    $("img", this).attr("src",url);
            //});
            //获取上/下一组图片
            //$("#myGrouptitle").html = "hhhh";
            //$("#myul").html("Hello");
            $(function () {
                var Art = $("#Article").attr("Art");
                var No = $("#Article").attr("No");

                $.get("GetAtl.ashx?Art=" + Art + "&No=" + No, function (data, status) {
                    $("#Article").html(data);
                });
            });
            
            //加载上一组列表
            $(".pre.picbig").click(function () {
                var Art = $(".pre.picbig").attr("Art");
                var No = $(".pre.picbig").attr("No");
                $.get("GetAtl.ashx?Art=" + Art + "&No=" + No, function (data, status) {
                    $("#Article").html(data);
                });
            });
            //加载下一组列表
            $(".next.picbig").click(function () {
                var Art = $(".next.picbig").attr("Art");
                var No = $(".next.picbig").attr("No");
                $.get("GetAtl.ashx?Art=" + Art + "&No=" + No, function (data, status) {
                    $("#Article").html(data);
                });
            });
            //鼠标移动的元素上改变背景色
            $("#pictureurls li").mouseover(function () {
                $(this).css("background-color", "#F3F8FD");

            });
            $("#pictureurls li").mouseout(function () {
                $(this).css("background-color", "");

            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="crumbs"><a href="#">首页</a><span> &gt; <a href="http://xyb.zgsfj.net/html/ss/">工笔山水</a> &gt; </span></div>
    <div id="Article" Art="Works" No="1">
        
  </div>
    <div></div>
    <div></div>
</asp:Content>



