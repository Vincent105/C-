<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_12_0_checkboxlist.aspx.cs" Inherits="ch3_webcontrol_ch3_12_0_checkboxlist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <hr />
            <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 21px" Text="計算總分" />
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
