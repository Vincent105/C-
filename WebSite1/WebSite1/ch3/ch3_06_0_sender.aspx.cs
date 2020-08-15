using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Button4.Click += new System.EventHandler(this.Button1_Click_mix);
        Button5.Click += new System.EventHandler(this.Button1_Click_mix);
        Button6.Click += new System.EventHandler(this.Button1_Click_mix);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Button btn = (Button)sender;

        Response.Write("你剛剛按下的按鈕 其commandArgument屬性為" + btn.CommandArgument);
        Response.Write("網頁執行時間：" + DateTime.Now.ToLongTimeString());
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        TextBox TB = (TextBox)sender;
        Response.Write("<br>" + TB.Text + "<br>");
        Response.Write("<br>" + TB.ID + "<br>");
    }

    protected void Button1_Click_mix(object sender, EventArgs e)
    {
        Response.Write("<br>" + "Hello" + "<br>");
        Response.Write("網頁執行時間：" + DateTime.Now.ToLongTimeString());
    }
}