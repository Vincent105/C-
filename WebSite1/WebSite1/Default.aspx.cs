using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Response.IsClientConnected)
        {
            Response.Write("連線中...");
        }
        else {
            Response.Write("已離線...");
        }
        //註解
        Response.Write("<br>Hello World<br>");
        Response.WriteFile("123.txt");
        Response.End();
        Response.Redirect("http://google.com.tw");
    }
}