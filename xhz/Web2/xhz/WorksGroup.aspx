<%@ Page Title="" Language="C#" MasterPageFile="~/xhz/Main.Master" AutoEventWireup="true" CodeBehind="WorksGroup.aspx.cs" Inherits="Web2.xhz.WorksGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <div class="margin-top20"><div class="tb">主题:</div><div><asp:TextBox ID="txtTitle" runat="server" Text=""></asp:TextBox></div></div>

     <div class="margin-top20"><div class="tb">标记:</div><div><asp:TextBox ID="txtMark" runat="server"></asp:TextBox></div></div>
    
        <div class="margin-top20"><div class="tb">简介:</div><div><asp:TextBox ID="txtsum" runat="server" Text="" Height="129px" 
                TextMode="MultiLine" Width="280px"></asp:TextBox></div></div>
        <div class="margin-top20"><div class="tb">图片:</div><div><asp:FileUpload ID="FileUpload1" runat="server" /></div></div>
    <div class="margin-top20"><div class="tb"><asp:Button ID="Button1" runat="server" Text="提交" onclick="Button1_Click" /></div></div>
    <asp:Label ID="label1" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
