using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class main : System.Web.UI.MasterPage
{
     DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
       /* if (!Page.IsPostBack)
        {
            bindtorepeater1();
        }
    }

    protected void bindtorepeater1()
    {
        string id = Request.QueryString["cl1_id"];
        string sql = "select * from columnss where cl1_id=" + id;
        //Repeater1.DataSource = mydo.rows(sql, "dts");
       // Repeater1.DataBind();
        if (id == "1")
        {
            tiao1.Text = "通知公告";
        }
        else if (id == "2")
        {
            tiao1.Text =  "学院概况";
            
        }
        else if (id == "3")
        {
            tiao1.Text = "师资队伍";
        }
        else if (id == "4")
        {
            tiao1.Text = "教学工作";
        }
        else if (id == "5")
        {
            tiao1.Text = "科研教研";
        }
        else if (id == "6")
        {
            tiao1.Text = "学团工作";
        }
        else if (id == "7")
        {
            tiao1.Text = "站长简介";
        }
        else if (id == "8")
        {
            tiao1.Text = "招生工作";
        }*/
    }



   /*DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           // addcnt();
            bindtolable1();
        }
    }
    protected void bindtolable1()
    {
        string id = Request.QueryString["id"];
        string sql = "select * from fw where id=1";
        OleDbDataReader dr = mydo.row(sql);
        if (dr.Read())
        {
            cnt.Text = dr["cnt"].ToString();
        }
    }
    protected void addcnt()
    {
        string sql = "update fw set cnt=cnt+1 where id=1" ;
        mydo.updatedata(sql);
    }*/

}
