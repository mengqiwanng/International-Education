using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_useradmin : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            bingtogridview1();
        }
    }
    protected void bingtogridview1()
    {
        string sql = "select * from admin";
        GridView1.DataSource = mydo.rows(sql, "gv1").DefaultView;
        GridView1.DataBind();
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bingtogridview1();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sql = "delete from admin where username='" + GridView1.DataKeys[e.RowIndex].Value + "'";
        if(mydo.adu(sql))
        {
            Response.Write("<script>alert('删除成功');window.location.href='useradmin.aspx'</script>");
        }
    }
}