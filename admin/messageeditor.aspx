<%@ Page Language="C#" AutoEventWireup="true" CodeFile="messageeditor.aspx.cs" Inherits="admin_messageeditor" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
 <link rel="stylesheet" href="css/pintuer.css" />
    <link rel="stylesheet" href="css/admin.css" />

    <!--文本编辑器-->
    <link href="editor/themes/default/default.css" rel="stylesheet" type="text/css" />
    <link href="editor/plugins/code/prettify.css" rel="stylesheet" type="text/css" />
    <script src="editor/kindeditor-all.js" type="text/javascript"></script>
    <script src="editor/lang/zh-CN.js" type="text/javascript"></script>
    <script src="editor/plugins/code/prettify.js" type="text/javascript"></script>
	<script type="">
	    KindEditor.ready(function (K) {
	        var editor1 = K.create('#content1', {
	            cssPath: 'editor/plugins/code/prettify.css',
	            uploadJson: 'editor/asp.net/upload_json.ashx',
	            fileManagerJson: 'editor/asp.net/file_manager_json.ashx',
	            allowFileManager: true,
	            afterCreate: function () {
	                var self = this;
	                K.ctrl(document, 13, function () {
	                    self.sync();
	                    K('form[name=example]')[0].submit();
	                });
	                K.ctrl(self.edit.doc, 13, function () {
	                    self.sync();
	                    K('form[name=example]')[0].submit();
	                });
	            }
	        });
	        prettyPrint();
	    });
	</script>
</head>
<body>
    <form id="form1" runat="server">
      <div class="panel admin-panel">
      <div class="panel-head"><strong><img alt="" src="images/jia.jpg" />&nbsp; 添加近况</strong></div>
      <div class="body-content"> 
          <div class="form-group">
            <div class="label">
              <label for="sitename">标题：</label>
            </div>
            <div class="field">
                <asp:TextBox ID="title" runat="server" CssClass="input w50" ></asp:TextBox>
            </div>
          </div>      
          <div class="form-group">
            <div class="label">
              <label for="sitename">发布人：</label>
            </div>
            <div class="field">
             <asp:TextBox ID="author" runat="server" CssClass="input w50" ></asp:TextBox> 
            </div>
          </div>
          <div class="form-group">
            <div class="label">
              <label for="sitename">内容：</label>
            </div>
            <div class="field">
            <textarea id="content1" runat="server" rows="8" cols="100" style="width:700px;height:300px;"></textarea>
            </div>
          </div>
          <div class="form-group">
            <div class="label">
              <label></label>
            </div>
            <div class="field">
                <asp:Button ID="Button1" runat="server" Text="修改" 
                    CssClass="button bg-main icon-check-square-o" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="重置" CssClass="button bg-main icon-check-square-i"/>
                <asp:LinkButton ID="LinkButton1" runat="server" 
                    CssClass="button bg-main icon-check-square-u" onclick="LinkButton1_Click">取消</asp:LinkButton>
            </div>
          </div> 
      </div>
      </div>
    </form>
</body>
</html>

