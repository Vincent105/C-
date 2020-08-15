<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_05_4_button.aspx.cs" Inherits="ch3_ch3_5_4_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="https://tw.yahoo.com/?p=us">導頁至其他網站</asp:LinkButton>
            <br />
            <br />
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/ch3/ch3_4_2_autopostback.aspx">導頁至其他頁面</asp:LinkButton>
            <br />
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/ch3/MIS2000Lab_book_image/Q1131.gif" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="button_click1" Text="Button" />
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                這裡輸入特殊控制區域 預設為隱藏的</asp:Panel>
            <br />
            <asp:Button ID="Button2" runat="server" OnClientClick="window.alert(&quot;警告!&quot;)" Text="按鈕附帶javascript" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClientClick="javascript:this.disabled=true;this.document.form.submit();" Text="Button" UseSubmitBehavior="False" />
            <br />
            <br />
            底下的按鈕只能送出一次<br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="click / 送出" UseSubmitBehavior="False" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="click / 送出2" />
            <br />
        </div>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
