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
        Response.Write(DateTime.Now.ToLongTimeString() + " 首次執行Page_load <br>");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Response.Write(DateTime.Now.ToLongTimeString() + " 謝謝你輸入資料 ");
    }
}