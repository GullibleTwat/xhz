<%@ Page Title="" Language="C#" MasterPageFile="~/xhz/Main.master" AutoEventWireup="true"
    ValidateRequest="false" CodeFile="AddNew.aspx.cs" Inherits="Admin_AddNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

<script type="text/javascript" src="Scripts/jquery-1.4.4.min.js"></script>

<script type="text/javascript" src="Scripts/xhEditor/xheditor-1.2.1.min.js"></script>

<script type="text/javascript" src="Scripts/xhEditor/xheditor_lang/zh-cn.js"></script>

<script type="text/javascript">
    $(function () {
        $('#elm1').xheditor({ localUrlTest: /^https?:\/\/[^\/]*?(xheditor\.com)\//i, remoteImgSaveUrl: 'saveremoteimg.aspx', shortcuts: { 'ctrl+enter': submitForm} });
    });
    function submitForm() { $('#frmDemo').submit(); }
</script>   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <label>
            新闻标题：</label><asp:TextBox ID="TitleText" runat="server" Width="237px"></asp:TextBox>
             <label>
            新闻分类：</label><asp:DropDownList ID="DropDownList1" runat="server" >
            </asp:DropDownList><a href="EditItems.aspx">分类管理</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <span><a href="Help.aspx" 
            style="text-decoration: none">帮助&gt;&gt;</a>&nbsp;&nbsp;</span>
            <br />
        <div style="width: 850px">
            <textarea id="elm1" runat="server" name="content" class="xheditor {width:'900',height:'800',upImgUrl:'upload.aspx'}" >test</textarea>
        </div>
        <br />
        <asp:CheckBox ID="CheckOpen" Text="显示此活动" runat="server" Checked="true" /><br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click" />
    </div>
</asp:Content>
