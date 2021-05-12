
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Works.aspx.cs" Inherits="Works" %>


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
		<div id="big-pic"><img style="height: 650px;" onload="loadpic(1)" src="http://www.zgsfj.net/uploadfile/2013/0507/20130507014415808.jpg"/></div>
    	<div class="photo_prev"><a title="<上一页" class="btn_pphoto" id="photoPrev" onfocus="this.blur()"  onclick="showpic('pre');" href="javascript:;" target="_self"></a></div>
        <div class="photo_next"><a title="下一页>" class="btn_nphoto" id="photoNext" onfocus="this.blur()"  onclick="showpic('next')" href="javascript:;" target="_self"></a></div>
        <a class="max" onclick="showpic('big');" href="javascript:;">查看原图</a>
        
        <div id="endSelect" style="display: none;">
			<div id="endSelClose" onclick="$('#endSelect').hide();"></div>
			<div class="bg"></div>
			<div class="E_Cont">
				<p>您已经浏览完所有图片</p>
				<p><a id="rePlayBut" onclick="showpic('next', 1);" href="javascript:void(0)"></a><a id="nextPicsBut" href="http://xyb.zgsfj.net/html/2013/ss_0507/72.html"></a></p>	
			</div>
		</div>
        
    </div>

    <div class="list-pic">
        <div class="pre picbig">
        	<div class="img-wrap"><a href="http://xyb.zgsfj.net/html/2013/ss_0507/70.html"><img title="徐右冰工笔扇面国画作品 2" style="width: 100px; height: 50px;" src="http://www.zgsfj.net/uploadfile/2013/0507/thumb_100_137_20130507014154877.jpg"></a></div><a href="http://xyb.zgsfj.net/html/2013/ss_0507/70.html">&lt;上一组</a>
        </div>
        <a class="pre-bnt" onclick="showpic('pre')" href="javascript:;"><span></span></a>
		<div class="cont" style="position: relative;">
			<ul class="cont picbig" id="pictureurls" style="left: 0px; width: 123px; position: absolute;">
						 <li class="on"><div class="img-wrap"><a hidefocus="true" href="javascript:;"><img style="width: 100px; height: 51px;" alt="徐右冰工笔扇面国画作品 1" src="http://www.zgsfj.net/uploadfile/2013/0507/thumb_100_137_20130507014213373.jpg" rel="http://www.zgsfj.net/uploadfile/2013/0507/20130507014213373.jpg"></a></div></li>
						</ul>
		</div>
        <a class="next-bnt" onclick="showpic('next')" href="javascript:;"><span></span></a>
        <div class="next picbig">
        	<div class="img-wrap"><a title="徐右冰工笔扇面国画作品" href="http://xyb.zgsfj.net/html/2013/ss_0507/72.html"><img style="width: 100px; height: 50px;" src="http://www.zgsfj.net/uploadfile/2013/0507/thumb_100_137_20130507014232608.jpg"></a></div><a href="http://xyb.zgsfj.net/html/2013/ss_0507/72.html">下一组&gt;</a>
        </div>
    </div>
            <div class="text" id="picinfo">徐右冰工笔扇面国画作品 1</div>
	<div class="content">
			</div>
  </div>
    <div></div>
    <div></div>
</asp:Content>