<%@ Page Language="C#" AutoEventWireup="true" CodeFile="useradmin.aspx.cs" Inherits="admin_useradmin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/pintuer.css" />
    <link rel="stylesheet" href="css/admin.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="panel admin-panel">
          <div class="panel-head" ><strong><img alt="" src="images/gl.jpg" />&nbsp;用户管理</strong></div>
          <div class="text">
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                   Width="95%" style="text-align:center;" AllowPaging="True" PageSize="5" 
                   DataKeyNames="username" onpageindexchanging="GridView1_PageIndexChanging" 
                   onrowdeleting="GridView1_RowDeleting">
                   <Columns>
                       <asp:BoundField DataField="username" HeaderText="用户名" />
                       <asp:ImageField DataImageUrlField="pic" HeaderText="头像">
                       </asp:ImageField>
                       <asp:CommandField ShowDeleteButton="True" ControlStyle-CssClass="ys">
<ControlStyle CssClass="ys"></ControlStyle>
                       </asp:CommandField>
                   </Columns>
                   <PagerStyle BorderStyle="None" HorizontalAlign="Center" />
               </asp:GridView>
          </div>
          </div>
    </form>
</body>
</html>
           