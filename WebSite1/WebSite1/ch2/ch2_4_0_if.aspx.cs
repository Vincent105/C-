using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int a = 15;

        if (a > 10)
        {
            Response.Write("恭喜 " + a + " 大於10");
        }
        else { 
            Response.Write("恭喜 " + a + " 小於10");
        }
    }
}