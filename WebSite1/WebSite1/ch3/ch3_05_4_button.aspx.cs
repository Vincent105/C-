using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_ch3_5_4_button : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button_click1(object sender, EventArgs e)
    {
        if (Panel1.Visible == false)
        {
            Panel1.Visible = true;
        }
        else 
        {
            Panel1.Visible = false;
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Write("這個按鈕只能夠按下一次");

        Button4.Text = "資料處理中";
        Button4.Enabled = false;
    }
}