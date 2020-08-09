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
        double a = 27;
        double b = 191;

        double end = (double)a / b;

        Response.Write(end.ToString() + "<br>");

        Response.Write(end.ToString("P") + "<br>");


        int c = 27;
        int d = 191;

        int end2 = c / d;

        Response.Write(end2.ToString() + "<br>");

        Response.Write(end2.ToString("P"));
    }
}