using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
public partial class right2 : System.Web.UI.Page
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
        string id2 = Request.QueryString["cl2_id"];
        string sql = "select * from columnss where cl1_id=" + id;
        Repeater1.DataSource = mydo.rows(sql, "dt");
        Repeater1.DataBind();
        if (id == "1" && id2 == "1")
        {
            Label1.Text = "通知公告";
            Label2.Text = "通知公告";
        }
        else if (id == "2" && id2 == "2")
        {
            Label1.Text = "学院概况";
            Label2.Text = "学院简介";
        }
        else if (id == "2" && id2 == "3")
        {
            Label1.Text = "学院概况";
            Label2.Text = "现任领导";
        }
        else if (id == "2" && id2 == "4")
        {
            Label1.Text = "学院概况";
            Label2.Text = "机构设置";
        }
        else if (id == "3" && id2 == "5")
        {
            Label1.Text = "师资队伍";
            Label2.Text = "俄语系";
        }
        else if (id == "3" && id2 == "6")
        {
            Label1.Text = "师资队伍";
            Label2.Text = "汉语系";
        }
        else if (id == "3" && id2 == "7")
        {
            Label1.Text = "师资队伍";
            Label2.Text = "师资结构";
        }
        else if (id == "4" && id2 == "8")
        {
            Label1.Text = "教学工作";
            Label2.Text = "工作简报";
        }
        else if (id == "4" && id2 == "10")
        {
            Label1.Text = "教学工作";
            Label2.Text = "人才培养";
        }
        else if (id == "4" && id2 == "11")
        {
            Label1.Text = "教学工作";
            Label2.Text = "教学管理";
        }
        else if (id == "5" && id2 == "12")
        {
            Label1.Text = "科研教研";
            Label2.Text = "科研简报";
        }
        else if (id == "5" && id2 == "13")
        {
            Label1.Text = "科研教研";
            Label2.Text = "科研成果";
        }
        else if (id == "5" && id2 == "14")
        {
            Label1.Text = "科研教研";
            Label2.Text = "学术活动";
        }
        else if (id == "6" && id2 == "15")
        {
            Label1.Text = "学团工作";
            Label2.Text = "学团组织";
        }
        else if (id == "6" && id2 == "16")
        {
            Label1.Text = "学团工作";
            Label2.Text = "学生管理";
        }
        else if (id == "6" && id2 == "17")
        {
            Label1.Text = "学团工作";
            Label2.Text = "学子风采";
        }
        else if (id == "7" && id2 == "18")
        {
            Label1.Text = "站长简介";
            Label2.Text = "站长简介";
        }
        else if (id == "8" && id2 == "19")
        {
            Label1.Text = "招生工作";
            Label2.Text = "招生工作";
        }
    }

    protected void bindtorepeater2()
    {
        int currentpage = Convert.ToInt32(current_page.Text);//存储当前页的值
        string id = Request.QueryString["cl2_id"];
        string sql = "select * from dongtai where cl2_id=" + id + " order by datatime desc";
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