<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestAtl.aspx.cs" Inherits="Web2.TestAtl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="js/Atl.js"></script>
    <link href="cs/Atl.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="Article"  Art="Works" Group="1" No="1">
        	<h1>徐右冰工笔扇面国画作品 1<br/>
			<span>2013-05-07 01:42:03&nbsp;&nbsp;&nbsp;来源：&nbsp;&nbsp;&nbsp;点击：</span><span id="hits">1266</span></h1>
    <div class="tool">
            <A name="pic"></A>
            <a title="上一张" class="up" onclick="showpic('pre')" href="javascript:;"><span>上一张</span></a>
            <a title="下一张" class="next" onclick="showpic('next')" href="javascript:;"><span>下一张</span></a>
            <span class="stat" id="picnum">(1/1)</span>
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
            <P><A onclick="showpic('next', 1);" id=rePlayBut href="javascript:void(0)"></A><A id=nextPicsBut href="http://qyx.zgsfj.net/html/2011/qyxpic1_0822/4.html"></A></P>

            </DIV>

            </DIV>
        
        </div>

    
    <DIV class=list-pic>
        <DIV class="pre picbig" Art="Works" Group="1" No="1">
            <DIV class=img-wrap><A href="#pre"><IMG title=齐玉新2011年拟古专辑2 style="HEIGHT: 70px; WIDTH: 73px" src="http://www.zgsfj.net/uploadfile/2011/0822/thumb_100_137_20110822014927819.jpg"></A></DIV>
            <A href="#pre">&lt;上一组</A> 
        </DIV>
            <A onclick="showpic('pre')" class=pre-bnt href="javascript:;"  ><SPAN></SPAN></A>
    <DIV class=cont style="POSITION: relative"   >
        <div class="clear"></div>
        <UL id="pictureurls" class="cont picbig" style="WIDTH: 1230px; POSITION: absolute; LEFT: 0px" Art="Works" Group="6">
            <LI>
                <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><IMG style="HEIGHT: 67px; WIDTH: 100px" alt="齐玉新国画扇面《山林之意》 (1)" src="http://www.zgsfj.net/uploadfile/2013/0706/thumb_100_137_20130706122750449.jpg" rel="http://www.zgsfj.net/uploadfile/2013/0706/20130706122750449.jpg"></A></DIV>
             </LI>
            <LI>
                <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><IMG style="HEIGHT: 50px; WIDTH: 100px" alt=齐玉新国画扇面《山林之意》 src="http://www.zgsfj.net/uploadfile/2013/0706/thumb_100_137_20130706122752887.jpg" rel="http://www.zgsfj.net/uploadfile/2013/0706/20130706122752887.jpg"></A></DIV>
             </LI>
            <LI>
                <DIV class=img-wrap ><A hideFocus href="javascript:;"  ><IMG style="HEIGHT: 50px; WIDTH: 100px" alt=齐玉新国画扇面《山林之意》 src="http://www.zgsfj.net/uploadfile/2013/0706/thumb_100_137_20130706122752887.jpg" rel="http://www.zgsfj.net/uploadfile/2013/0706/20130706122752887.jpg"></A></DIV>
             </LI>
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
    </DIV>
        <A onclick="showpic('next')" class=next-bnt href="javascript:;"><SPAN></SPAN></A>
    <DIV class="next picbig" Art="Works" Group="1" No="1">
    <DIV class=img-wrap><A title=齐玉新2011年拟古专辑4 href=""><IMG style="HEIGHT: 70px; WIDTH: 71px" src="http://www.zgsfj.net/uploadfile/2011/0822/thumb_100_137_20110822015032473.jpg"></A></DIV>
        <A href="http://qyx.zgsfj.net/html/2011/qyxpic1_0822/4.html">下一组&gt;</A> </DIV>

    </DIV>
            <div class="text" id="picinfo">徐右冰工笔扇面国画作品 1</div>
	        <div class="content">
			</div>
  </div>
    </div>
    </form>
</body>
</html>
