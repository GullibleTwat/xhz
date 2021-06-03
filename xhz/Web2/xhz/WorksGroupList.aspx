<%@ Page Title="" Language="C#" MasterPageFile="~/xhz/Main.Master" AutoEventWireup="true" CodeBehind="WorksGroupList.aspx.cs" Inherits="Web2.xhz.WorksGroupList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="GridView1" runat="server">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
