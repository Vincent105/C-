<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_4_1_string_format.aspx.cs" Inherits="ch3_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; +<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;+
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;=
            <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="開始計算" OnClick="Button1_click" Width="353px" />
        </div>
    </form>
</body>
</html>
