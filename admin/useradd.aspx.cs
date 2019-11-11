using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_useradd : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "insert into admin values('" + username.Text.Trim() + "','"+pwd1.Text.Trim() + "','~/admin/images/"+FileUpload1.FileName+ "')";
        if(mydo.adu(sql))
        {
            Response.Write("<script>alert('添加成功')</script>");
        }

        FileUpload1.SaveAs(Server.MapPath("~/admin/images/") + FileUpload1.FileName);

    }
}