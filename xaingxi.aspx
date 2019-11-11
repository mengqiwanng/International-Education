<%@ Page Title="" Language="C#" Debug="true" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="xaingxi.aspx.cs" Inherits="xaingxi" StylesheetTheme="xiangxi"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="content">
       <div id="left">
           <div id="left4">
           <h3> <asp:Label ID="list1" runat="server" Text="Label" CssClass ="lab1"></asp:Label></h3>
              <ul>
                 <asp:Repeater ID="Repeater1" runat="server">
                   <ItemTemplate >
                     <li><a href="right2.aspx?cl1_id=<%#Eval("cl1_id") %>&cl2_id=<%#Eval("cl2_id") %>"><%#Eval("cl2_content")%></a></li>
                   </ItemTemplate>
                 </asp:Repeater>
               </ul>     
           </div>
           <%--<div id="pic"><img src="images/down.jpg" alt="" />  </div>--%>
       </div>
       <div id="right4">
         <h3> 
            <asp:Label ID="right1" runat="server" Text="Label"></asp:Label>
         </h3>
         <div class="r1">
             <p>
             <b>
                 <asp:Label ID="right2" runat="server" Text="Label"></asp:Label><br />
             </b> 
             </p>
          </div>
          <br />
          <div class="r3">
             <p >

                日期:<asp:Label ID="datatime" runat="server" Text="Label"></asp:Label> &nbsp;&nbsp;&nbsp;
                发布人:<asp:Label ID="author" runat="server" Text="Label"></asp:Label>&nbsp;&nbsp;&nbsp; 
                点击量:<asp:Label ID="cnt" runat="server" Text="Label"></asp:Label>
             </p>
         </div>
         <hr /><br />
         <div class="r2">
             <p >
                 <asp:Label ID="right3" runat="server" Text="Label"></asp:Label>
             </p> 
         </div>
         <div id="gb"><a href="Default.aspx">【关闭窗口】</a></div>
       </div>
     </div>
     <div class="clear"></div>

</asp:Content>

