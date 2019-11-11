<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userchange.aspx.cs" Inherits="admin_userchange" %>

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
  <div class="panel-head"><strong><span class="icon-key"></span> 修改会员密码</strong></div>
  <div class="body-content">  
      <div class="form-group">
        <div class="label">
          <label for="sitename">用户名：</label>
        </div>
        <div class="field">
           <asp:TextBox ID="username1" runat="server" CssClass="input w50"  
                placeholder="请输入用户名" data-validate="required:请输入用户名" ReadOnly="True" ></asp:TextBox>     
        </div>
      </div>      
      <div class="form-group">
        <div class="label">
          <label for="sitename">新密码：</label>
        </div>
        <div class="field">
          <asp:TextBox ID="pwd11" runat="server" CssClass="input w50"   
                placeholder="请输入新密码" data-validate="required:请输入新密码,length#>=5:新密码不能小于5位" 
                TextMode="Password"></asp:TextBox>       
        </div>
      </div>
      <div class="form-group">
        <div class="label">
          <label for="sitename">确认新密码：</label>
        </div>
        <div class="field">
          <asp:TextBox ID="pwd22" runat="server" CssClass="input w50"  
                placeholder="请再次输入新密码" 
                data-validate="required:请再次输入新密码,repeat#newpass:两次输入的密码不一致" 
                TextMode="Password"  ></asp:TextBox>         
        </div>
      </div>
      
      <div class="form-group">
        <div class="label">
          <label></label>
        </div>
        <div class="field">
            <asp:Button ID="Button1" runat="server" Text="提交" 
                CssClass="button bg-main icon-check-square-o" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="重置" CssClass="button bg-main icon-check-square-i"/>
        </div>
      </div> 
  </div>
</div>
    </form>
</body>
</html>
