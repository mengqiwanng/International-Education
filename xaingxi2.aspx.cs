using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class xaingxi : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            addcnt();
            bindtorepeater1();
            bindtolable1();
        }
    }

    protected void bindtorepeater1()
    {
        string id = Request.QueryString["cl1_id"];
        string sql = "select * from columnss where cl1_id=" + id;
        Repeater1.DataSource = mydo.rows(sql, "dts");
        Repeater1.DataBind();
        if (id == "1")
        {
            list1.Text = "通知公告";
            right1.Text = "通知公告";
        }
        else if (id == "2")
        {
            list1.Text = "学院概况";
            right1.Text = "学院概况";
        }
        else if (id == "3")
        {
            list1.Text = "师资队伍";
            right1.Text = "师资队伍";
        }
        else if (id == "4")
        {
            list1.Text = "教学工作";
            right1.Text = "教学工作";
        }
        else if (id == "5")
        {
            list1.Text = "科研教研";
            right1.Text = "科研教研";
        }
        else if (id == "6")
        {
            list1.Text = "学团工作";
            right1.Text = "学团工作";
        }
        else if (id == "7")
        {
            list1.Text = "站长简介";
            right1.Text = "站长简介";
        }
        else if (id == "8")
        {
            list1.Text = "招生工作";
            right1.Text = "招生工作";
        }
    }
    protected void bindtolable1()
    {
        string id = Request.QueryString["id"];
        string sql = "select * from se where id=" + id;
        OleDbDataReader dr = mydo.row(sql);
        if (dr.Read())
        {
            right2.Text = dr["title"].ToString();
            datatime.Text = dr["datatime"].ToString().Substring (0,10);
            author.Text = dr["author"].ToString();
            cnt.Text = dr["cnt"].ToString();
            right3.Text = dr["content"].ToString();
        }
    }
    protected void addcnt()
    {
        string id = Request.QueryString["id"];
        string sql = "update se set cnt=cnt+1 where id=" + id;
        mydo.updatedata(sql);
    }
}