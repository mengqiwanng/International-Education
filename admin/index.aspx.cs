using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class admin1_index : System.Web.UI.Page
{
    DataOperate mydo = new DataOperate();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["username"].ToString();
        if (!Page.IsPostBack)
        {
            bindtoimage();
       }
    }
    protected void bindtoimage()
    {
        string sql = "select * from admin where username='" + Session["username"].ToString() + "'";
        OleDbDataReader dr = mydo.row(sql);
        if(dr.Read())
        {
            Image1.ImageUrl = dr["pic"].ToString();
        }
    }
}