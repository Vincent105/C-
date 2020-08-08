using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int u_int = Convert.ToInt32(Request["u_number"]);

        switch (u_int) {
            case 1:
                Response.Redirect("http://google.com.tw");
                break;
            case 2:
                Response.Redirect("http://www.yahoo.com.tw");
                break;
            case 3:
                Response.Redirect("http://www.pchome.com.tw");
                break;
            default:
                Response.Write("<br>輸入訊息有誤");
                break;
        }
    }
}