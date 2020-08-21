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

    protected void Button1_click(object sender, EventArgs e)
    {
        int sum = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text) + Convert.ToInt32(TextBox3.Text);

        //Label1.Text = string.Format("{0:C}", sum);
        Label1.Text = string.Format("{0: NT$ 0,0.00}", sum);

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string s = string.Format("(C) Currency:..........{0:C}" + "<BR>" +
                                 "(D) Decimal:...........{0:D}" + "<BR>" +
                                 "(E) Scientific:........{1:E}" + "<BR>" +
                                 "(F) Fixed point:.......{0:F}" + "<BR>" +
                                 "(G) Genernal:..........{0:G}" + "<BR>" +
                                 "Default................{0}" + "<BR>" +
                                 "(N) Number:............{0:N}" + "<BR>" +
                                 "(P) Percent:...........{1:P}" + "<BR>" +
                                 "(R) Round:.............{1:R}" + "<BR>" +
                                 "(R) Round:.............{0:X}" + "<BR>"
                                 , -123 ,-123.45F);

        Label2.Text = s;

        string d = string.Format("{0:D} " + "<BR>" +
                                 "{0:t} " + "<BR>" +
                                 "{0:T} " + "<BR>" +
                                 "{0:f} " + "<BR>" +
                                 "{0:F} " + "<BR>" +
                                 "{0:g} " + "<BR>" +
                                 "{0:G} " + "<BR>" +
                                 "{0} " + "<BR>" +
                                 "{0:M} " + "<BR>" +
                                 "{0:R} " + "<BR>" +
                                 "{0:s} " + "<BR>" +
                                 "{0:u} " + "<BR>" +
                                 "{0:U} " + "<BR>" +
                                 "{0:Y} " + "<BR>" 
            , DateTime.Now);

        Label3.Text = d;

        string myDatetime = System.DateTime.Now.ToLongDateString();

        int myInt = 10000;

        Response.Write(string.Format("日期{0},金額{1}", myDatetime, myInt));
        Response.Write("<br>");
        Response.Write(string.Format("日期{0:yyyy/MM/dd},金額{1:C}", myDatetime, myInt));


        var name = "vincent";
        var day = "11";

        Response.Write($"hello {name},{day}");

    }
}