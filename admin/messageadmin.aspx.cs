using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_messageadmin : System.Web.UI.Page
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
        string sql = "select * from dongtai";
        GridView1.DataSource = mydo.rows(sql, "gv1").DefaultView;
        GridView1.DataBind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sql = "delete from dongtai where id=" + GridView1.DataKeys[e.RowIndex].Value;
        if (mydo.adu(sql))
        {
            Response.Write("<script>alert('删除成功');window.location.href='messageadmin.aspx'</script>");
        }
        else
        {

        }
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        bingtogridview1();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        bingtogridview1();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox id, title, content, author, cnt;
        id = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];
        title = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
        content = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
        author = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
        cnt = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
        string sql = "update dongtai set title='" + title.Text.Trim() + "',content='" + content.Text.Trim() + "',author='" + author.Text.Trim() + "',cnt=" + cnt.Text.Trim() + " where id=" + GridView1.DataKeys[e.RowIndex].Value;
        if (mydo.adu(sql))
        {
            GridView1.EditIndex = -1;
            Response.Write("<script>alert('更新成功');window.location.href='messageadmin.aspx'</script>");
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        bingtogridview1();
    }
}