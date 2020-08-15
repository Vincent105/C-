using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_ch3_5_1_button : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("1.程式首先執行Page Load" + DateTime.Now.ToLongTimeString() + "<br>");
    }

    protected void Textbox1_TextChanged(object sender, EventArgs e)
    {
        Response.Write("<br>" + "2.謝謝您輸入資料" + DateTime.Now.ToLongTimeString() + "<br>");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<br>" + "3.謝謝您按下按鈕" + DateTime.Now.ToLongTimeString()+"<br>");
        Response.Write("<br>你輸入的文字是" + TextBox1.Text + "<br>");
    }
}