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
        int a = Convert.ToInt32(Request["u_number"]);

        if (a > 10)
        {
            Response.Write(a + " 大於10");
        }
        else
        {
            if (Convert.ToInt32(Request["u_number"]) == 10)
                Response.Write(a + "剛好等於10");
            else {
                Response.Write(a + "小於10");
            }
        }
    }
}