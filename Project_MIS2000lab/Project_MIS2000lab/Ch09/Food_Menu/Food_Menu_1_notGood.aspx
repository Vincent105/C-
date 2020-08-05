﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Food_Menu_1_notGood.aspx.cs" Inherits="Book_Sample_B06_DataBinding_Food_Menu_Food_Menu_1_notGood" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
        <style type="text/css">
        .style1
        {
            color: #FF0000;
            font-weight: bold;
        }
    </style>
</head>
<body>

    <p>
        資料表：Food_Menu</p>
    <p>
        點選食物種類，就會出現相關的菜名：<span class="style1">（有一點小小的Bug）</span></p>
    <form id="form1" runat="server">
    <p>
        食物種類：
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="SqlDataSource1" DataTextField="food_class" 
            DataValueField="food_class" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList> （請使用 AutoPostBack）
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:testConnectionString %>" 
            SelectCommand="SELECT DISTINCT [food_class] FROM [Food_Menu]">
        </asp:SqlDataSource>
        
    </p>
    <div>
    
        <br />
        <br />
    
        與這個分類有關的菜名： 
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
            DataSourceID = "SqlDataSource2"
            DataTextField="food_name" DataValueField="food_name" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>（請使用 AutoPostBack，<span 
            class="style1">這裡有一點小Bug，程式一開始執行，人家都還沒選，這裡就出現資料了？！</span>）
    
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
            ConnectionString="<%$ ConnectionStrings:testConnectionString %>" 
            
            SelectCommand="SELECT [food_name], [food_class] FROM [Food_Menu] WHERE ([food_class] = @food_class)">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="food_class" 
                    PropertyName="SelectedValue" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <hr />
    <br />
    
        您剛剛點選的「食物種類」：<asp:Label ID="Label1" runat="server" style="font-weight: 700; color: #009900"></asp:Label>
        <br />
        <br />
        點&nbsp;&nbsp;&nbsp; 菜：&nbsp;&nbsp;&nbsp; <asp:Label ID="Label2" runat="server" style="font-weight: 700; color: #CC0000"></asp:Label>
    
    </div>
    </form>
</body>
</html>