<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_02_0_textbox.aspx.cs" Inherits="ch3_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Width="126px">預設值(Default Value)</asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="button1_click" Text="Button" />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="Double" TextMode="Email"></asp:TextBox>
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" />
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True"></asp:TextBox>
        </div>
    </form>
</body>
</html>
