<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_07_0_label.aspx.cs" Inherits="ch3_ch3_7_0_label" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label1"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label2" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label3" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
