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
        if (Request["u_number"] == null || Convert.ToInt32(Request["u_number"]) > 3)
        {
            Response.Write("使用者必須輸入1個數字，並且限定1~3");
            Response.Write("<br>輸入訊息有誤");
        }
        else {
            if (Convert.ToInt32(Request["u_number"]) == 1) { 
                Response.Redirect("http://google.com.tw");
            }
            if (Convert.ToInt32(Request["u_number"]) == 2) {
                Response.Redirect("http://www.yahoo.com.tw");
            }
            if (Convert.ToInt32(Request["u_number"]) == 3) { 
                Response.Redirect("http://www.pchome.com.tw"); 
            }
        }
    }
}