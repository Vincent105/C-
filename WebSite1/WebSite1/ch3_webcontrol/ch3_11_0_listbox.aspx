<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_11_0_listbox.aspx.cs" Inherits="ch3_webcontrol_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style2 {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <span class="auto-style2">Listbox data binding</span><br />
    <form id="form1" runat="server">
            <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="BusinessEntityID" Height="142px" Width="351px" SelectionMode="Multiple"></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:AdventureWorks2016ConnectionString %>" SelectCommand="SELECT top 100 * FROM Sales.Store"></asp:SqlDataSource>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 21px" Text="選擇好之後按下去" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            Listbox 移動<br />
            <asp:ListBox ID="ListBox2" runat="server">
                <asp:ListItem>左一</asp:ListItem>
                <asp:ListItem>左二</asp:ListItem>
                <asp:ListItem>左三</asp:ListItem>
            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox3" runat="server">
                <asp:ListItem>右一</asp:ListItem>
                <asp:ListItem>右二</asp:ListItem>
                <asp:ListItem>右三</asp:ListItem>
            </asp:ListBox>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="移動到右邊-&gt;" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="移動至左邊&lt;-" />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
    </form>
</body>
</html>
