using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_userchange : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        username1.Text = Session["username"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "update admin set [password]='" + pwd11.Text + "' where [username]='" + Session["username"].ToString() + "'";
        if (mydo.adu(sql))
        {
            Response.Write("<script>alert('修改成功')</script>");
        }  
    }
}