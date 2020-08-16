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
        <div>
        </div>
    </form>
</body>
</html>
