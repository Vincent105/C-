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
        Response.BufferOutput = true;
        Response.Write("將文字輸入放進緩衝區域，第一次");
        Response.Clear();
        //清除緩衝區域

        Response.Write("將文字輸入放進緩衝區域，第二次");
        Response.Flush();
    }
}