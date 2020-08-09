<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ch3_1_2_postback.aspx.cs" Inherits="ch3_Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            Postback 練習二<br />
            <br />
            在畫面（Page）上，按下任何按鈕或是點選控制項，<br />
            <strong id="Label2">重新載入頁面時，再次觸發 Page的Load事件。<br />
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="#FF3399" Text="0"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" EnableTheming="True" Text="Button" OnClick="button1_click"/>
            <br />
            <br />
            </strong>
            <input id="Submit1" type="submit" value="HTML_Submit，仍會累加" /><br />
            <br />
            <input id="Button2" type="button" value="HTML_Button" />
        </div>
    </form>
</body>
</html>
