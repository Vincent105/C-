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
        TextBox3.Text = DropDownList6.SelectedValue;

        if (!Page.IsPostBack) 
        {
            string str = "<select ID=selectID1 Name=selectName1>";
            str += "<optgroup label=AAA>";
            str += "        <option>11111</option>";
            str += "        <option>22222</option>";
            str += "</optgroup>";
            str += "<optgroup label=BBB>";
            str += "        <option>33333</option>";
            str += "        <option>44444</option>";
            str += "</optgroup>";

            Literal1.Text = str;
        }
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

    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox3.Text = DropDownList6.SelectedValue;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (Label3.Text == "")
        {
            Label3.Text = "尚未輸入任何數字";
        }
        else
        {
            Label3.Text = "你輸入的數字是" + DropDownList6.SelectedValue;
        }
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Write("透過ID來抓 --- " + Request["selectID1"]);
        Response.Write("透過Name來抓 --- " + Request["selectName1"]);
    }




}