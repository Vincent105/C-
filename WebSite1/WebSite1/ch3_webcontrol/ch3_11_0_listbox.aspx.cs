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


    protected void Button2_Click(object sender, EventArgs e)
    {//左移動至右
        int a = 0;

        for (int i = 0; i < ListBox2.Items.Count; i++) 
        {
            if (ListBox2.Items[i].Selected) 
            {
                ListBox3.Items.Add(ListBox2.Items[i].Text);
                a += 1;

                ListBox2.Items.Remove(ListBox2.Items[i].Text);
                break;
            }
        }

        if (a == 0) {
            Label2.Text = "<font color=red>警告!未輸入選項</font>";
        }
        else
        {
            Label2.Text = "<font color=green>移動成功</font>";
        }
        

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int b = 0;

        for (int i = 0; i < ListBox3.Items.Count; i++)
        {
            if (ListBox3.Items[i].Selected)
            {
                ListBox2.Items.Add(ListBox3.Items[i].Text);
                b += 1;

                ListBox3.Items.Remove(ListBox3.Items[i].Text);
                break;
            }
        }

        if (b == 0)
        {
            Label2.Text = "警告!未輸入選項";
        }
        else
        {
            Label2.Text = "移動成功";
        }
    }

}