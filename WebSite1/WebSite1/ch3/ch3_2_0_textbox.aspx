<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_2_0_textbox.aspx.cs" Inherits="ch3_Default" %>

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
        </div>
    </form>
</body>
</html>
