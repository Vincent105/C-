using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch2_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        for (int i = 1; i <= 100 ; i++) {
            sb.Append(i.ToString() + "<br>");
        };
        Response.Write(sb.ToString());
    }
}