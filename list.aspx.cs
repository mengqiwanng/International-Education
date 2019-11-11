using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class list : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindtorepeater1();
            bindtorepeater2();
        }
    }

    protected void bindtorepeater1()
    {
        string id = Request.QueryString["cl1_id"];
        Session["cl1_id"] = id;
        string sql = "select * from columnss where cl1_id=" + id;
        Repeater1.DataSource = mydo.rows(sql, "dt");
        Repeater1.DataBind();
        if (id == "1")
        {
            Label1.Text = "通知公告";
            Label2.Text = "通知公告";
        }
        else if (id == "2")
        {
            Label1.Text = "学院概况";
            Label2.Text = "学院概况";
        }
        else if (id == "3")
        {
            Label1.Text = "师资队伍";
            Label2.Text = "师资队伍";
        }
        else if (id == "4")
        {
            Label1.Text = "教学工作";
            Label2.Text = "教学工作";
        }
        else if (id == "5")
        {
            Label1.Text = "科研教研";
            Label2.Text = "科研教研";
        }
        else if (id == "6")
        {
            Label1.Text = "学团工作";
            Label2.Text = "学团工作";
        }
        else if (id == "7")
        {
            Label1.Text = "站长简介";
            Label2.Text = "站长简介";
        }
        else if (id == "8")
        {
            Label1.Text = "招生工作";
            Label2.Text = "招生工作";
        }
    }

    protected void bindtorepeater2()
    {
        int currentpage = Convert.ToInt32(current_page.Text);//存储当前页的值
        string id = Request.QueryString["cl1_id"];
        string sql = "select * from dongtai where cl1_id=" + id + " order by datatime desc";
        PagedDataSource ps = new PagedDataSource();//实例化
        ps.AllowPaging = true;//允许分页
        ps.PageSize = 8;//每页上显示的行数
        ps.DataSource = mydo.rows(sql, "list").DefaultView;
        count_page.Text = Convert.ToString(ps.PageCount);//给总页码标签赋值
        first_page.Enabled = true;
        front_page.Enabled = true;
        next_page.Enabled = true;
        last_page.Enabled = true;

        if (currentpage == 1)
        {
            first_page.Enabled = false;
            front_page.Enabled = false;
        }
        if (currentpage == ps.PageCount)
        {
            next_page.Enabled = false;
            last_page.Enabled = false;
        }
        ps.CurrentPageIndex = currentpage - 1;

        Repeater2.DataSource = ps;
        Repeater2.DataBind();
    }
    protected void first_page_Click(object sender, EventArgs e)
    {
        current_page.Text = "1";
        bindtorepeater2();
    }
    protected void front_page_Click(object sender, EventArgs e)
    {
        current_page.Text = Convert.ToString(Convert.ToInt32(current_page.Text) - 1);
        bindtorepeater2();
    }
    protected void next_page_Click(object sender, EventArgs e)
    {
        current_page.Text = Convert.ToString(Convert.ToInt32(current_page.Text) + 1);
        bindtorepeater2();
    }
    protected void last_page_Click(object sender, EventArgs e)
    {
        current_page.Text = count_page.Text;
        bindtorepeater2();
    }
}