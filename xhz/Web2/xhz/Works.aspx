<%@ Page Title="" Language="C#" MasterPageFile="~/xhz/Main.master" AutoEventWireup="true" CodeBehind="Works.aspx.cs" Inherits="Web2.xhz.Works" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
.tb{width:88px; float:left; text-align:right; }
.margin-top20{ margin-top:8px;}
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="margin-top20"><div class="tb">主题:</div><div><asp:TextBox ID="txtTitle" runat="server" Text=""></asp:TextBox></div></div>
     <div class="margin-top20"> <div class="tb">分类:</div><div><asp:DropDownList ID="ItemsList" runat="server"></asp:DropDownList></div></div>
     <div class="margin-top20"><div class="tb">分组:</div><div><asp:DropDownList ID="GroupList" runat="server"></asp:DropDownList></div></div>
    
        <div class="margin-top20"><div class="tb">简介:</div><div><asp:TextBox ID="txtsum" runat="server" Text="" Height="129px" 
                TextMode="MultiLine" Width="280px"></asp:TextBox></div></div>
        
        
        <div class="margin-top20"><div class="tb">图片:</div><div><asp:FileUpload ID="FileUpload1" runat="server" /></div></div>
    
    <div class="margin-top20"><div class="tb"><asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" /></div></div>
    <asp:Label ID="label1" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
