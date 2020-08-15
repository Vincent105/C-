using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_ch3_7_0_label : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = "1.程式首先會執行";
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Label2.Visible = true;
        Label2.Text = "2.謝謝你輸入資料";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label3.Visible = true;
        Label3.Text = "<font color = red>";
        Label3.Text += "3. 您按下按鈕囉！您輸入的文字是---- <Script Language=\"Javascript\">window.alert(\"警告視窗！\");</Script>" + TextBox1.Text;
        Label3.Text += "</font>";
        Response.Write("輸入的文字是:" + TextBox1.Text);
    }
}