<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_06_0_sender.aspx.cs" Inherits="ch3_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <span class="auto-style1"><strong>Sender案例一</strong></span><br />
            <asp:Button ID="Button1" runat="server" CommandArgument="button1" OnClick="Button1_Click" Text="Button1" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" CommandArgument="button2" OnClick="Button1_Click" Text="Button2" />
            <br />
            <br />
            <span class="auto-style1"><strong>Sender案例二</strong></span><br />
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged">請輸入文字</asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox1_TextChanged">請輸入文字</asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="按下" />
            <br />
            <br />
            <span class="auto-style1"><strong>Sender案例三(事件寫在code behind)<br />
            <asp:Button ID="Button4" runat="server" Text="Button4" />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Button5" />
            <br />
            <asp:Button ID="Button6" runat="server" Text="Button6" />
            <br />
            <br />
            </strong></span>
        </div>
    </form>
</body>
</html>
