<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="introduce.aspx.cs" Inherits="introduce" StylesheetTheme="introduce"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
       <div id="left7">
          <h3>站长简介</h3>
          <ul>
            <li><a href="introduce.aspx">站长简介</a></li>
          </ul>   
       </div>
       <div id="right7">
          <h3>站长简介</h3>
           <p><b>
               姓名：王 梦 琦 <br /><br />
               学号：2 0 1 6 5 9 3 0 4 3<br /><br />
               联系方式：1 3 7 * * * * * * * *
           </b></p>
           <hr />
                <div style="position:absolute;top:450px;left:460px;">
                   <img src="images\my.jpg"  width="150"  height="200" alt="图片" title="桌面"/>
                </div>
                <div style="position:absolute;top:450px;left:460px;">
                  <embed src="flash\6.swf" width="150" height="300" wmode="transparent"></embed>
                </div>
        </div>
</div>
</asp:Content>

