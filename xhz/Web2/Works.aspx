<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Works.aspx.cs" Inherits="Web2.Works" %>
<asp:Content ID="HeadContent"  ContentPlaceHolderID="headContent" runat="server">
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
     <script type="text/javascript" src="js/jquery.sgallery.js"></script>
    <script type="text/javascript" src="js/search_common.js"></script>
    <script type="text/javascript">
        
        $(document).ready(function () {
            //鼠标移动的元素上改变背景色
            $("#pictureurls li").mouseover(function () {
                $(this).css("background-color", "#F3F8FD");

            });
            $("#pictureurls li").mouseout(function () {
                $(this).css("background-color", "");

            });
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
                var Art = $("#pictureurls").attr("Art");
                var Group = $("#pictureurls").attr("Group");
                loadGroupList(Art,Group);
                loadAtlas();
            });
            function loadGroupList(Art,Group) {
               
                $.get("getAtlList.ashx?Art=" + Art + "&Group=" + Group, function (data, status) {
                    $("#pictureurls").html(data);
                });
            };
            function loadAtlas() {
                var Art = $(".pre.picbig").attr("Art");
                var No = $(".pre.picbig").attr("No");
                $.get("getAtlas.ashx?Art=" + Art + "&No=" + No+"&cmd=pre", function (data, status) {
                    $(".pre.picbig").replaceWith(data);
                });
            };



            //加载上一组列表
            $(".pre.picbig").click(function () {
                var Art = $(".pre.picbig").attr("Art");
                var Group = $(".pre.picbig").attr("Group");
                loadGroupList(Art,Group);
            });
            //加载下一组列表
            $(".next.picbig").click(function () {
                var Art = $(".next.picbig").attr("Art");
                var Group = $(".next.picbig").attr("Group");
                loadGroupList(Art, Group);
            });

        });
    </script>
     <script type="text/javascript" src="js/show_picture.js"></script>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="crumbs"><a href="#">首页</a><span> &gt; <a href="http://xyb.zgsfj.net/html/ss/">工笔山水</a> &gt; </span></div>
    <div id="Article">
        	<h1>徐右冰工笔扇面国画作品 1<br/>
			<span>2013-05-07 01:42:03&nbsp;&nbsp;&nbsp;来源：&nbsp;&nbsp;&nbsp;点击：</span><span id="hits">1266</span></h1>
<div class="tool">
        <a title="上一张" class="up" onclick="showpic('pre')" href="javascript:;"><span>上一张</span></a><a title="下一张" class="next" onclick="showpic('next')" href="javascript:;"><span>下一张</span></a><span class="stat" id="picnum">(1/1)</span>
        <div class="Article-Tool"></div>
</div>
    <div class="big-pic" style="height: 650px;">
		<div id="big-pic"><img style="height: 650px;" onload="loadpic(1)" src="#"/></div>
    	<div class="photo_prev"><a title="<上一页" class="btn_pphoto" id="photoPrev" onfocus="this.blur()"  onclick="showpic('pre');" href="javascript:;" target="_self"></a></div>
        <div class="photo_next"><a title="下一页>" class="btn_nphoto" id="photoNext" onfocus="this.blur()"  onclick="showpic('next')" href="javascript:;" target="_self"></a></div>
        <a class="max" onclick="showpic('big');" href="javascript:;">查看原图</a>
        
        
<DIV id="endSelect"><DIV onclick="$('#endSelect').hide();" id="endSelClose"></DIV>
<DIV class=bg></DIV>
<DIV class=E_Cont>
<P>您已经浏览完所有图片</P>
<P><A onclick="showpic('next', 1);" id=rePlayBut href="javascript:void(0)"></A><A id=nextPicsBut href="http://qyx.zgsfj.net/html/2011/qyxpic1_0822/4.html"></A></P></DIV></DIV>
        
    </div>

    
<DIV class=list-pic>
    <DIV class="pre picbig" Art="Works" Group="1" No="1">
        <DIV class=img-wrap><A href="#pre"><IMG title=齐玉新2011年拟古专辑2 style="HEIGHT: 70px; WIDTH: 73px" src="http://www.zgsfj.net/uploadfile/2011/0822/thumb_100_137_20110822014927819.jpg"></A></DIV>
        <A href="#pre">&lt;上一组</A> 
    </DIV>
        <A onclick="showpic('pre')" class=pre-bnt href="javascript:;"  ><SPAN></SPAN></A>
<DIV class=cont style="POSITION: relative"   >
    <div class="clear"></div>
    <UL id="pictureurls" class="cont picbig" style="WIDTH: 1230px; POSITION: absolute; LEFT: 0px" Art="Works" Group="<%=group %>">
        <LI>
            <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><img  height="75" width="100" alt="30" src="#" rel="/Upload/Works/day_140426/201404261125016257.jpg"/></A></DIV>
         </LI>
<%--        <LI>
            <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><img  height="75" width="100" alt="30" src="#" rel="/Upload/Works/day_140426/201404261125016257.jpg"/></A></DIV>
         </LI>
        <LI>
            <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><img  height="75" width="100" alt="30" src="#" rel="/Upload/Works/day_140426/201404261125016257.jpg"/></A></DIV>
         </LI>--%>

    </UL>
   <%-- <asp:Repeater ID="Repeater1" runat="server" >
        <HeaderTemplate>
            <UL id="pictureurls" class="cont picbig" style="WIDTH: 1230px; POSITION: absolute; LEFT: 0px" Art="Works" Group="<%=group %>">
        </HeaderTemplate>
        <ItemTemplate>
         <LI>
            <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><img  height="75" width="100" alt="30" src="#" rel="<%#Eval("Attachment")%>"/></A></DIV>
         </LI>
        </ItemTemplate>
      <FooterTemplate></UL></FooterTemplate>
    </asp:Repeater>--%>
</DIV><A onclick="showpic('next')" class=next-bnt href="javascript:;"><SPAN></SPAN></A>
<DIV class="next picbig" Art="Works" Group="1" No="1">
<DIV class=img-wrap><A title=齐玉新2011年拟古专辑4 href=""><IMG style="HEIGHT: 70px; WIDTH: 71px" src="http://www.zgsfj.net/uploadfile/2011/0822/thumb_100_137_20110822015032473.jpg"></A></DIV>
    <A href="http://qyx.zgsfj.net/html/2011/qyxpic1_0822/4.html">下一组&gt;</A> </DIV></DIV>
            <div class="text" id="picinfo">徐右冰工笔扇面国画作品 1</div>
	        <div class="content">
			</div>
        <div id="myGrouptitle">
            <ul id="myul"><li></li></ul>
        </div>
  </div>
    <div></div>
    <div></div>
</asp:Content>



