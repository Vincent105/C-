<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_10_0_dropdownlist.aspx.cs" Inherits="ch3_ch3_10_0_dropdownlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
        .auto-style2 {
            color: #FF3300;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>政治</asp:ListItem>
                <asp:ListItem>經濟</asp:ListItem>
                <asp:ListItem>娛樂</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <br />
            AutoPostBack屬性<br />
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>數學</asp:ListItem>
                <asp:ListItem>英文</asp:ListItem>
                <asp:ListItem>國文</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            切換選單後導頁超連結<br />
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="www.Yahoo.com">Yahoo</asp:ListItem>
                <asp:ListItem Value="www.pchome.com">pchome</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <span class="auto-style1">下拉選單的add() method</span><br />
            <asp:DropDownList ID="DropDownList4" runat="server">
            </asp:DropDownList>
            <asp:Button ID="Button2" runat="server" Height="16px" OnClick="Button2_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <br />
            <span class="auto-style2">下拉選單的add() method</span><br />
            請選擇:<asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                <asp:ListItem>科技</asp:ListItem>
                <asp:ListItem>政治</asp:ListItem>
                <asp:ListItem Value="New_Item">我要手動新增一個選項</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                請輸入新的選項<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Submit" />
            </asp:Panel>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
