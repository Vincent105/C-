using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_webcontrol_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string my_nation_text = "";

        for (int i = 0; i < (ListBox1.Items.Count); i++)
        {
            if (ListBox1.Items[i].Selected)
            {
                my_nation_text += "#" + ListBox1.Items[i].Text;
            }
        }

        Label1.Text = my_nation_text;
    }

}