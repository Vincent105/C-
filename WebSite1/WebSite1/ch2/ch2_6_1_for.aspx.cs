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
        int my_sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            my_sum = my_sum + i;
            Response.Write("a" + i + ":" + i + "<br>");
        }
        Response.Write("1+...+100=" + my_sum);
    }
}