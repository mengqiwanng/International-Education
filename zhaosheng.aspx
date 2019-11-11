<%@ Page Title="" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="zhaosheng.aspx.cs" Inherits="zhaosheng" StylesheetTheme="zhaosheng"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="content">
       <div id="left6">
          <h3> <asp:Label ID="Label1" runat="server" Text="Label" CssClass ="lab1"></asp:Label></h3>
          <ul>
             <asp:Repeater ID="Repeater1" runat="server">
               <ItemTemplate >
                 <li><a href="zhaosheng.aspx?cl1_id=<%#Eval("cl1_id") %>&cl2_id=<%#Eval("cl2_id") %>"><%#Eval("cl2_content")%></a></li>
               </ItemTemplate>
             </asp:Repeater>
           </ul>   
       </div>
       <div id="right6">
         <h3>
             <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></h3>
              <ul>
                  <asp:Repeater ID="Repeater2" runat="server">
                      <ItemTemplate >
                        <li><a href="xaingxi2.aspx?cl1_id=8&id=<%#Eval ("id")%>"><%#Eval("title")%></a><span><%#Eval("datatime", "{0:yyyy-MM-dd}")%></span></li>
                      </ItemTemplate>
                  </asp:Repeater> 
              </ul> 
         <div id="page">
           <table>
              <tr>
                  <td>当前页码：<asp:Label ID="current_page" runat="server" Text="1"></asp:Label></td>
                  <td >总页码：<asp:Label ID="count_page" runat="server" Text=""></asp:Label></td>
                  <td>
                      <asp:LinkButton ID="first_page" runat="server" onclick="first_page_Click">第一页</asp:LinkButton></td>
                  <td>
                     <asp:LinkButton ID="front_page" runat="server" onclick="front_page_Click">上一页</asp:LinkButton></td>
                 <td>
                    <asp:LinkButton ID="next_page" runat="server" onclick="next_page_Click">下一页</asp:LinkButton></td>
                 <td>
                     <asp:LinkButton ID="last_page" runat="server" onclick="last_page_Click">最后一页</asp:LinkButton></td>
             </tr>
             </table>
         
         </div>
       </div>
     </div>

</asp:Content>

