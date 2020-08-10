<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_4_2_autopostback.aspx.cs" Inherits="ch3_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True"></asp:TextBox>
            +<asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"></asp:TextBox>
            +<asp:TextBox ID="TextBox3" runat="server" AutoPostBack="True" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
            =<asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
