<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web2.Default" %>

<asp:Content ID="Head_content" ContentPlaceHolderID="headContent" runat="server">

<script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
    <%--cycle 图片滚动 --%>
<script type="text/javascript" src="js/jquery.cycle2.min.js"></script>
    <script type="text/javascript" src="js/js.js"></script>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">

    <div id="col_left">
        
	<div class="slider">	
					<a href="#" id="prev" class="prev"></a> 
					<a href="#" id="next" class="next"></a>
					<div class="cycle-boder">
					<div class="cycle-slideshow" 
					    data-cycle-fx="scrollHorz"
					    data-cycle-timeout="2000"
					    data-cycle-prev="#prev"
					    data-cycle-next="#next"
					    data-cycle-pager-event="mouseover"
					    >
					    <!-- empty element for pager links -->
					    
					 	<div class="cycle-pager"></div>
                        <asp:Repeater ID="Repeater1" runat="server">
                            <ItemTemplate><a href="Works.aspx?Art=Works&No=<%#Eval("No") %>"><img alt="<%#Eval("Title") %>" src="<%#Eval("Atlas") %>" style="width:575px;height:283px;"/></a></ItemTemplate>
                        </asp:Repeater>
					 <%--   <img src="images/home_slider/s1.jpg" style="width:575px;height:283px;"/>
					    <img src="images/home_slider/s2.jpg"/>
					    <img src="images/home_slider/s3.jpg"/>
					    <img src="images/home_slider/s4.jpg"/>--%>
					</div>
					</div>
				</div>        
        <div class="demo box">
                <h5 class="title-2">作品展示</h5>
    <div class="bx_wrap">
        <div class="bx_container">
          <ul id="demo1">
              <asp:Repeater runat="server" ID="Works">
                  <ItemTemplate><li><a href="Works.aspx?Art=Works&No=<%#Eval("No") %>"><img  alt="<%#Eval("Title") %>" width="120" height="135" src="<%#Eval("Atlas") %>"/>
        	<%#Eval("Title") %><br/><%#Eval("Time") %></a></li></ItemTemplate>
              </asp:Repeater>
        	<%--<li><a href="#"><img  alt="#" width="120" height="135" src="#"/>
        	楷体 作品1<br/>时间</a></li>
            <li><a href="#"><img  alt="#" width="120" height="135" src="#"/>楷体 作品1<br/>时间</a></li>
              <li><a href="#"><img  alt="#" width="120" height="135" src="#"/>楷体 作品1<br/>时间</a></li>
              <li><a href="#"><img  alt="#" width="120" height="135" src="#"/>楷体 作品1<br/>时间</a></li>
              <li><a href="#"><img  alt="#" width="120" height="135" src="#"/>楷体 作品1<br/>时间</a></li>
              <li><a href="#"><img  alt="#" width="120" height="135" src="#"/>楷体 作品1<br/>时间</a></li>--%>
          </ul>
        </div>
      </div>
	</div>	
        <div id="news" class="box">
            <h5 class="title-2">最新动态</h5>
            <ul>
                <asp:Repeater runat="server" ID="RepeaterNews">
                    <ItemTemplate><li><a href="Works.aspx?Art=News&No=<%#Eval("No") %>"><%#Eval("Title") %></a></li></ItemTemplate>
                </asp:Repeater>
                
            </ul>
        </div>
          <div id="news2"class="box">
            <h5 class="title-2">同行评价</h5>
            <ul>
               <asp:Repeater runat="server" ID="RepeaterEva">
                    <ItemTemplate><li><a href="Works.aspx?Art=Evaluate&No=<%#Eval("No") %>"><%#Eval("Title") %></a></li></ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
          <div id="Div1"class="box">
            <h5 class="title-2">个人荣誉</h5>
      
        </div>
    </div>
    <div id="col_auto">
        <div class="box">
            <h5 class="title-2">馆主简介</h5>
            <div id="po_pt"><img width="236" alt="尹子菁" src="/images/psb.jpg"/></div>
                邢怀章， 别署澄心居士，斋号汉游堂。现为中国书法家协会会员，河南省书法家协会会员，中国硬笔书法家协会会员，河南省书法家协会理事，河南省书画院特聘书法家，商丘市书法艺术研究院特聘书法家，郸城县政协委员，郸城县青少年书法协会会长，2002年被评为“中国书法百杰”称号，2008年被中国硬笔书法家协会授予“全国优秀中青年书法家”称号。著名当代青年实力派书法家 中国书法家协会会员。
                <br />邢怀章----艺术追踪 全国最具有升值潜力的50名书法家之一。润格；小楷每平尺3000元，隶书每平尺2000元，行草每平尺2000元，国画每平尺2000元，点题加倍。
                <br />幼承家训，软硬兼施，书法作品曾获全国首届正书展获奖提名，入展墨舞神州-全国电视书法大赛，全国首届职工展，全国重庆渝中书法艺术节，全国华坪金达杯全国书法大展，入选全国第一届大字书法展，全国首届册页书法展，全国书画小品展，全国三届扇面书法展，全国四届新人展等。河南省第五届青少年书法选拔赛精品奖 最高奖，纪念改革开放30周年“中原书画大奖赛”获奖，首届《国际少林武术节杯》全国书法大赛金奖，新“盖天力杯”全国书法大赛三等奖，第七届中国钢笔书法大赛二等奖...
                <span><a href="/html/gongsijieshao/gongsijianjie/">[更多]</a></span>
            
        </div>
        <div class="box">
            <h5 class="title-2">作品润格</h5>
            作品润格
            
        </div>
        <div class="box">
            <h5 class="title-2">联系方式</h5>

            
        </div>
    </div>
</asp:Content>

