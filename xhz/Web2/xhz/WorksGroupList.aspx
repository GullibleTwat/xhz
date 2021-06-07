<%@ Page Title="" Language="C#" MasterPageFile="~/xhz/Main.Master" AutoEventWireup="true" CodeBehind="WorksGroupList.aspx.cs" Inherits="Web2.xhz.WorksGroupList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="ID" ForeColor="#333333" GridLines="None" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDeleting="GridView1_RowDeleting" PageSize="8">
            <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="No" HeaderText="序号" />
            <asp:BoundField DataField="Title" HeaderText="标题" />
            <asp:BoundField DataField="Info" HeaderText="内容简介" />
            <asp:BoundField DataField="Time" HeaderText="时间" />
            <asp:BoundField DataField="Mark" HeaderText="标记" />
            <asp:BoundField DataField="Click" HeaderText="点击次数" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="WorksGroupAlter.aspx?Id={0}" HeaderText="编辑" Text="编辑" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Works.aspx?Id={0}" HeaderText="添加图片" Text="添加" />
            <asp:CommandField ShowDeleteButton="True" />
        </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
    
</asp:Content>
