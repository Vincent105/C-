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
        string strA = "ABCDEFG";

        //length attr
        Response.Write(strA.Length+"<br>");

        //replace method
        Response.Write(strA.Replace("A", "B") + "<br>");

        //contain method
        Response.Write(strA.Contains("E") + "<br>");

        //indexOf method
        Response.Write(strA.IndexOf("A") + "<br>");

        //string method
        string words = "This is a book,:with: punctuation. @ 中文 我愛你";
        string[] resultArray = words.Split(' ');

        foreach (string s in resultArray) {
            Response.Write("<br>" + s);
        }

        Response.Write("<br>");

        //substring method
        string wordss = "    This is a list of words.";
        Response.Write(wordss.Substring(5, 10) + "<br>");

        //ToUpper method
        Response.Write(wordss.ToUpper() + "<br>");

        //ToLower method
        Response.Write(wordss.ToLower() + "<br>");

        //Trim
        Response.Write(wordss.Trim() + "<br>");

    }
}