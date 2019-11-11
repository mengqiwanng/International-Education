<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_admin1_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
		<%--<meta charset="UTF-8" content=""/>--%>
		<title>国际教育后台登录</title>
		<link rel="stylesheet" type="text/css" href="css/login.css"/>
        <%--<script src="js/jquery-1.9.1.min.js" type="text/javascript" charset="utf-8"></script>--%>
</head>
<body>
    <form id="form1" runat="server">
    <div class="login">
			<div class="content">
<%--				<div class="content-left">
					<div class="logo">
						<img src="images/logo.png" alt=""/>
						<p>国际教育后台登录</p>
					</div>
				</div>
				<div class="shu"></div>--%>
				<div class="content-right">
					<div class="login-form">
						<h2>用户登录/LOGIN</h2>
						<div id="name">
							<span>账　号：</span>
                            <asp:TextBox ID="username" runat="server"></asp:TextBox>
						</div>
						<div id="pwd">
							<span>密　码：</span>
                            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
						</div>
						<div id="cod">
							<span>验证码：</span>
                            <asp:TextBox ID="code" runat="server" Height="33px" Width="80px"></asp:TextBox>&nbsp;
                            <asp:Image Runat="server" ID="ImageCheck" ImageUrl="ValidateCode.aspx" CssClass="image" Height="33px" Width="60px" ></asp:Image>&nbsp;
                            <asp:LinkButton ID="LinkButton1" runat="server" CssClass="zz">看不清</asp:LinkButton>
							
						</div>
                        <asp:Button ID="Button1" runat="server" Text="登录" CssClass="btn"  onclick="Button1_Click"/>		
				</div>
			</div>
		</div>
    </div>
    </form>
</body>
</html>
