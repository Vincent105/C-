﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_5_1_button.aspx.cs" Inherits="ch3_ch3_5_1_button" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            欄位一&nbsp; 
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="Textbox1_TextChanged"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
