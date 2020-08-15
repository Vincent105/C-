using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ch3_ch3_10_0_dropdownlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write(DropDownList1.SelectedValue);
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(DropDownList2.SelectedItem.Text);
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("http://" + DropDownList3.SelectedValue);
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect(DropDownList3.SelectedValue);
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        DropDownList4.Items.Add(TextBox1.Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Text = DropDownList4.SelectedItem.Text;
        Label2.Text = DropDownList4.SelectedItem.Value;
    }

    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList5.SelectedValue == "New_Item") {
            Panel1.Visible = true;
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        DropDownList5.Items.Add(TextBox2.Text);
        Panel1.Visible = false;
    }
}