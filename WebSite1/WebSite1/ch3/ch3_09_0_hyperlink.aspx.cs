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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HyperLink2.Text = "Yahoo";
        HyperLink2.NavigateUrl = "http://www.yahoo.com.tw";
        HyperLink2.Target = "_blank";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        HyperLink2.Text = "Yahoo2";
        HyperLink2.NavigateUrl = "http://www.yahoo.com.tw";
        HyperLink2.Target = "_top";
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        HyperLink2.Text = "Yahoo3";
        HyperLink2.NavigateUrl = "http://www.yahoo.com.tw";
        HyperLink2.Target = "_top";
    }
}