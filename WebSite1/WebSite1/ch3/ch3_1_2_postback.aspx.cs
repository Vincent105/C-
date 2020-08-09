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
        if (!Page.IsPostBack)
        {
            //第一次執行
            Response.Write("第一次執行Page_Load事件<br />");
        }
        else
        {
            int i = Convert.ToInt32(Label3.Text) + 1;
            Label3.Text = i.ToString();
            Response.Write("網頁重新執行Page_Load事件<br />");
        }        
    }

    protected void button1_click(object sender, EventArgs e) 
    {
        Response.Write("按下[按鈕]的事件<br />");
    }
}