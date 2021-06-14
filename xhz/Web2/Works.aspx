<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Works.aspx.cs" Inherits="Web2.Works" %>
<asp:Content ID="HeadContent"  ContentPlaceHolderID="headContent" runat="server">
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="js/Atl.js"></script>
    <link href="cs/Atl.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="ContentPlaceHolder1">
    <div class="crumbs"><a href="#">首页</a><span> &gt; <a href="http://xyb.zgsfj.net/html/ss/">工笔山水</a> &gt; </span></div>
    <div id="Article" Art="<%=Art %>" No="<%=No %>">
        
  </div>
    <div></div>
    <div></div>
</asp:Content>



