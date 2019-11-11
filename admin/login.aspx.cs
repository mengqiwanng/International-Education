using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin_admin1_Default : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (code.Text == Session["CheckCode"].ToString())
        {
            string sql = "select * from admin where username='" + username.Text.Trim() + "' and password='" + password.Text.Trim() + "'";
            OleDbDataReader dr = mydo.row(sql);
            if (dr.Read())
            {
                Session["username"] = username.Text.Trim();
                Response.Redirect("index.aspx");
            }
            else 
            {
                Response.Write("<script>alert('用户名或密码不正确');window.location.href='login.aspx'</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('验证码不正确');window.location.href='login.aspx'</script>");
        }
    }
}