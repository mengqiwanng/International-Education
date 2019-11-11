using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
///DataOperate 的摘要说明
/// </summary>
public class DataOperate
{
	public DataOperate()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    //连接
    public OleDbConnection createconnection()
    {
        OleDbConnection conn = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=|DataDirectory|dongtai.accdb");
        return conn;
    }
    //查询多行
    public DataTable rows(string sql, string table)
    {
        OleDbConnection conn = createconnection();
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds, table);
        return ds.Tables [table];
    }
    //查询单行
    public OleDbDataReader  row(string sql)
    {
        OleDbConnection conn = createconnection();
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        OleDbDataReader dr = cmd.ExecuteReader();
        return dr;
    }
    public Boolean adddelata(string sql)
    {
        OleDbConnection conn = createconnection();
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        if (cmd.ExecuteNonQuery() >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void updatedata(string sql)
    {
        OleDbConnection conn = createconnection();
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
    }

   
    public Boolean adu(string sql)
    {
        OleDbConnection conn = createconnection();
        OleDbCommand cmd = new OleDbCommand(sql, conn);
        conn.Open();
        if (cmd.ExecuteNonQuery() >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}