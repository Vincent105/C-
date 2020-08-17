using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_webcontrol_ch3_12_0_checkboxlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int s_summary = 0;

        for (int i = 0; i < CheckBoxList1.Items.Count; i++) 
        {
            if (CheckBoxList1.Items[i].Selected) 
            {
                s_summary += Convert.ToInt32(CheckBoxList1.Items[i].Value);
            }
        }
        
        for (int i = 0; i < CheckBoxList2.Items.Count; i++)
        {
            if (CheckBoxList2.Items[i].Selected)
            {
                s_summary += Convert.ToInt32(CheckBoxList2.Items[i].Value);
            }
        }

        Label1.Text = s_summary.ToString();
    }
}