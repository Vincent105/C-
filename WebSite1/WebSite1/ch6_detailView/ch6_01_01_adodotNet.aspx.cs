using System;
using System.Collections;
using System.Configuration;
using System.Data;
//**********************
using System.Data.SqlClient;
//**********************

using System.Web;
//**********************
using System.Web.Configuration;
//**********************
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Ch06_1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection Conn = new SqlConnection(WebConfigurationManager.ConnectionStrings["AdventureWorks2016ConnectionString"].ConnectionString);
        Conn.Open();   //第一、連結資料庫

        SqlCommand cmd = new SqlCommand("select Top 10 AddressID,AddressLine1,City from person.Address", Conn);
        SqlDataReader dr = cmd.ExecuteReader();   //第二、執行SQL指令，取出資料

        //第三，自由發揮
        while (dr.Read())
        {
            Response.Write("地址ID：" + dr["AddressID"].ToString() + "<br>");
            Response.Write("地址：" + dr["AddressLine1"].ToString() + "<br>");
            Response.Write("城市：" + dr["City"].ToString());
            Response.Write("<hr>");
        }
        cmd.Cancel();
        dr.Close();
        Conn.Close();   //第四、關閉資料庫的連接與相關資源

    }
}
