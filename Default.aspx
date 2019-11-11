<%@ Page Title="" Debug="true" Language="C#" MasterPageFile="~/main.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="content">
        <div id="left">
            <%--焦点图超链接--%>
             <div id="solid">
             <div class="solid0"></div><div class="solid1"></div><div class="solid2"></div> 
             <a href="xaingxi.aspx?cl1_id=2&id=132">
                 <ul>
                    <li><img src="images/l1.png" alt=""  title="学院简介"/></li>
                    <li><img src="images/l2.png" alt=""  title="学院简介"/></li>
                    <li><img src="images/l3.png" alt=""  title="学院简介"/></li>
                    <li><img src="images/l4.jpg" alt=""  title="学院简介"/></li>
                 </ul>
             </a>
             </div>
             <script src="js/fordboy.js" type="text/javascript"></script>
            <!--图片下面的超链接-->
            <a href="xaingxi.aspx?cl1_id=2&id=132">国际教育学院是黑河学院对外交流与合作的教学与管理部门，是面向来华留学生进行汉语和中国文化教学，以及中国赴俄…</a>
            <%--页面跳转--%>
            <div style="width:245px;height:35px;background:url('images/left-z.png') no-repeat;">
            &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="24px" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="198px" 
                    AutoPostBack="True">
                <asp:ListItem Value="0">-------俄方高校链接-------</asp:ListItem>
                <asp:ListItem Value="1">布拉戈维申斯克国立师范大学</asp:ListItem>
                <asp:ListItem Value="2">阿穆尔国立人文师范大学</asp:ListItem>
                <asp:ListItem Value="3">维亚特卡国立人文大学</asp:ListItem>
            </asp:DropDownList>
            </div>
            <br />    
            <%--联系方式的盒子--%>
            <div style="width:245px;height:75px;background:url('images/left-x.png') no-repeat;">
            <p>电话：04566842603<br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;18945713773<br />
            邮箱：1291561730@qq.com</p>
            </div>
            <br />  
        </div>
        <div id="middle">
            <div id="middle1"style="width:463px;height:330px;background:url('images/midk.bmp') no-repeat;">
                <div id="biaoti1"><img src="images/tubiao2.png" alt=""  title=""/> <p ><b>学院新闻</b></p></div>
                  <div id="hotpic">
                        <div id="NewsPic">
                            <a style="visibility: visible; display: block;">
                                <img width="455px" height="260px" src="images/1.png" class="Picture" alt="测试用图片" title="国际教育学院留学生首届古诗文朗诵会" /></a>
                            <a style="visibility: hidden; display: none;"  >
                                <img class="Picture" src="images/2.jpg" style="width: 455px; height: 260px;" alt="测试用图片" title="黑河学院国际化教育项目推介（俄文宣传片）" /></a> 
                            <a style="visibility: hidden; display: none;" >
                                <img class="Picture" src="images/4.jpg" style="width: 455px; height: 260px;" alt="测试用图片" title="黑河学院来华留学项目推介（中文宣传片）" /></a>
                            <a style="visibility: hidden; display: none;" >
                                <img width="455px" height="260px" src="images/5.jpg" class="Picture" alt="测试用图片" title="黑河学院国际化教育项目推介(宣传片)" /></a>
                            <div class="Nav">
                                <span class="Normal">4</span>
                                <span class="Normal">3</span>
                                <span class="Normal">2</span>
                                <span class="Cur">1</span>
                            </div>
                        </div>
                        <div id="NewsPicTxt" style="width: 370px; overflow: hidden"><a target="_blank" >国际教育学院留学生首届古诗文朗诵会</a></div>
                    </div>
                    <script type="text/javascript">
                        $('#hotpic').liteNav(1000);
                    </script>

                    </div>
            <div class="clear"></div>
            <div id="middle2"style="width:463px;height:200px;background:url('images/midk2.bmp') no-repeat;">
                <div id="biaoti2"><img src="images/tubiao2.png" alt=""  title=""/> <p ><b>招生信息</b></p>
                    <a href="zhaosheng.aspx?cl1_id=8" style="visibility: visible; display: block;">
                             <img width="38px" height="13px" src="images/gd.png" class="gd " alt="" title=""/></a>
                </div>
                <div id="wenzi1">
                    <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate >
                         <li><a href="zhaosheng.aspx?cl1_id=8&id=<%#Eval ("id")%>"><%#Eval ("title")%></a><span><%#Eval("datatime", "{0:yyyy-MM-dd}")%></span></li>
                      </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>
        <div id="right">
            <div id="right1"style="background:url('images/right1.png') no-repeat;">
                <div id="biaoti3"><img src="images/tubiao3.png" alt=""  title=""/> <p ><b>通知公告</b></p>
                    <a href="list.aspx?cl1_id=1" style="visibility: visible; display: block;">
                         <img width="38px" height="13px" src="images/gd.png" class="gd " alt="" title=""/></a>
                </div>
                 <marquee height="290px" direction="up" scrollamount="2" onmouseout="this.start()" onmouseover="this.stop()">
                        <div id="wenzi2">
                        <asp:Repeater ID="Repeater2" runat="server">
                          <ItemTemplate >
                             <li><a href="xaingxi.aspx?cl1_id=1&id=<%#Eval ("id")%>"><%#Eval ("title")%></a><span><%#Eval("datatime", "{0:yyyy-MM-dd}")%></span></li>
                          </ItemTemplate>
                        </asp:Repeater>
                </div></marquee>
                    </div>
            <div id="right2"style="width:280px;height:180px;background:url('images/right2.png') no-repeat;">
            <div id="biaoti4"><img src="images/tubiao3.png" alt=""  title=""/> <p ><b>学团工作</b></p>
                <a href="list.aspx?cl1_id=6" style="visibility: visible; display: block;">
                         <img width="38px" height="13px" src="images/gd.png" class="gd " alt="" title=""/></a>
             </div>
              <div id="wenzi3">
                <asp:Repeater ID="Repeater3" runat="server">
                      <ItemTemplate >
                          <li><a href="xaingxi.aspx?cl1_id=6&id=<%#Eval ("id")%>"><%#Eval ("title")%></a><span><%#Eval("datatime", "{0:yyyy-MM-dd}")%></span></li>
                       </ItemTemplate>
                </asp:Repeater>
              </div>
            </div>
        </div>
    </div>
</asp:Content>