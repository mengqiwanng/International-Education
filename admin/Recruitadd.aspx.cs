using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_noticeadd : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "insert into se(title,author,content,cl1_id,cl2_id) values('" + title.Text.Trim() + "','" + author.Text.Trim() + "','" + content1.InnerText + "',8,19)";
        if (mydo.adu(sql))
        {
            Response.Write("<script>alert('添加成功')</script>");
            title.Text = "";
            author.Text = "";
            content1.InnerText = "";
        }
    }
}