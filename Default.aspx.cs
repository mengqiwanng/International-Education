using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bindtorepeater1();
            bindtorepeater2();
            bindtorepeater3();
        }
    }
    /*招生信息*/
    protected void bindtorepeater1()
    {
        try
        {
            string sql = "select top 5 * from se order by datatime desc";
            Repeater1.DataSource = mydo.rows(sql, "dt");
            Repeater1.DataBind();
        }
        catch (Exception error)
        {
            Response.Write(error.Message.ToString());
        }
    }
    /*通知公告*/
    protected void bindtorepeater2()
    {
        try
        {
            string sql = "select top 10 * from dongtai where cl1_id=1 order by datatime desc";
            Repeater2.DataSource = mydo.rows(sql, "dt");
            Repeater2.DataBind();
        }
        catch (Exception error)
        {
            Response.Write(error.Message.ToString());
        }
    }
    /*学团工作*/
    protected void bindtorepeater3()
    {
        try
        {
            string sql = "select top 5 * from dongtai where cl1_id=6 order by datatime desc";
            Repeater3.DataSource = mydo.rows(sql, "dt");
            Repeater3.DataBind();
        }
        catch (Exception error)
        {
            Response.Write(error.Message.ToString());
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 1)
        {
            Response.Redirect("http://www.bgpu.ru/index.jsp");
        }
        else if (DropDownList1.SelectedIndex == 2)
        {
            Response.Redirect("http://www.amgpgu.ru/");
        }
        else if (DropDownList1.SelectedIndex == 3)
        {
            Response.Redirect("https://vggu.ru/");
        }
    }
}