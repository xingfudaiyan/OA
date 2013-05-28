<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="AddTool.aspx.cs" Inherits="OA.ToolApply.AddTool" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="width:100%">
        <tr>
            <td>
               <h2>办公用品申请表</h2> 
            </td>
            
        </tr>
        <tr>
            <td>
                <table class="Tb_Common" style="width:100%">
                    <tr>
                        <td style="width:5%">序号</td>
                        <td style="width:20%">品名</td>
                        <td style="width:10%">单位</td>
                        <td style="width:15%">申请数量</td>
                        <td style="width:5%">序号</td>
                        <td style="width:20%">品名</td>
                        <td style="width:10%">单位</td>
                        <td style="width:15%">申请数量</td>
                    </tr>
                    <tr>
                        <td>1</td>
                        <td>美工刀（小）</td>
                        <td >把</td>
                        <td><asp:TextBox ID="txt1" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        <td>21</td>
                        <td>三层文件盘</td>
                        <td>个</td>
                        <td><asp:TextBox ID="txt21" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>2</td>
                        <td>剪刀</td>
                        <td>把
                        </td>
                        <td><asp:TextBox ID="txt2" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>22</td>
                        <td>A5笔记本</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt22" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>3</td>
                        <td>订书机</td>
                        <td>台</td>
                        <td><asp:TextBox ID="txt3" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>23</td>
                        <td>纸篓（黑色）</td>
                        <td>
                            个</td>
                        <td><asp:TextBox ID="txt23" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>4</td>
                        <td>订书针</td>
                        <td>盒</td>
                        <td><asp:TextBox ID="txt4" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>24</td>
                        <td>封箱带</td>
                        <td>
                            卷</td>
                        <td><asp:TextBox ID="txt24" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>5</td>
                        <td>起钉器/除针器</td>
                        <td>个</td>
                        <td><asp:TextBox ID="txt5" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>25</td>
                        <td>胶带（小）</td>
                        <td>
                            卷</td>
                        <td><asp:TextBox ID="txt25" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>6</td>
                        <td>回形针</td>
                        <td>盒</td>
                        <td><asp:TextBox ID="txt6" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>26</td>
                        <td>笔筒（黑）</td>
                        <td>
                            个</td>
                        <td><asp:TextBox ID="txt26" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>7</td>
                        <td>大头针</td>
                        <td>盒</td>
                        <td><asp:TextBox ID="txt7" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>27</td>
                        <td>按动圆珠笔 </td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt27" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>8</td>
                        <td>长尾夹</td>
                        <td>盒</td>
                        <td><asp:TextBox ID="txt8" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>28</td>
                        <td>中性笔（黑色）</td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt28" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>9</td>
                        <td>计算器</td>
                        <td>盒</td>
                        <td><asp:TextBox ID="txt9" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>29</td>
                        <td>中性笔（红色）</td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt29" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>10</td>
                        <td>资料册20页</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt10" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>30</td>
                        <td>水笔蕊</td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt30" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>11</td>
                        <td>资料册30页</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt11" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>31</td>
                        <td>铅笔</td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt31" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>12</td>
                        <td>资料册40页</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt12" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>32</td>
                        <td>固体胶</td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt32" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>13</td>
                        <td>资料册60页</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt13" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>33</td>
                        <td>小橡皮</td>
                        <td>
                            块</td>
                        <td><asp:TextBox ID="txt33" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>14</td>
                        <td>通用型双强力文件夹</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt14" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>34</td>
                        <td>记号笔（颜色）</td>
                        <td>
                            支</td>
                        <td><asp:TextBox ID="txt34" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>15</td>
                        <td>单强力文件夹</td>
                        <td>本</td>
                        <td><asp:TextBox ID="txt15" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>35</td>
                        <td>白雪 修正液X-18</td>
                        <td>
                            瓶</td>
                        <td><asp:TextBox ID="txt35" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>16</td>
                        <td>写字板夹</td>
                        <td>只</td>
                        <td><asp:TextBox ID="txt16" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>36</td>
                        <td>白雪 修正带D3560</td>
                        <td>
                            盒</td>
                        <td><asp:TextBox ID="txt36" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>17</td>
                        <td>透明拉边资料袋</td>
                        <td>个</td>
                        <td><asp:TextBox ID="txt17" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>37</td>
                        <td>30cm 直尺</td>
                        <td>
                            把</td>
                        <td><asp:TextBox ID="txt37" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>18</td>
                        <td>透明纽扣文件袋</td>
                        <td>个</td>
                        <td><asp:TextBox ID="txt18" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>38</td>
                        <td>50cm 直尺</td>
                        <td>
                            把</td>
                        <td><asp:TextBox ID="txt38" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>19</td>
                        <td>牛皮纸档案袋（加厚180g）</td>
                        <td>个</td>
                        <td><asp:TextBox ID="txt19" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>39</td>
                        <td>便签纸</td>
                        <td>
                            本</td>
                        <td><asp:TextBox ID="txt39" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>20</td>
                        <td>三栏文件栏</td>
                        <td>个</td>
                        <td><asp:TextBox ID="txt20" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        
                        <td>40</td>
                        <td>名片夹</td>
                        <td>
                            本</td>
                        <td><asp:TextBox ID="txt40" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                    
                    <tr>
                       <td colspan="8">
                            <table class="Blank" style="width:100%;">
                                <tr>
                                       <td style="width:5%;">备注</td>
                                       <td style="width:6%;">市场部</td>
                                       <td style="width:26%;"><asp:TextBox ID="txtMarketMemo" runat="server" TextMode="MultiLine" ></asp:TextBox></td>
                                       <td style="width:6%;">技术部</td>
                                       <td style="width:26%;"><asp:TextBox ID="txtTechMemo" runat="server" TextMode="MultiLine"  ></asp:TextBox></td>
                                       <td style="width:6%;">综合部</td>
                                       <td style="width:26%;"><asp:TextBox ID="txtHrMemo" runat="server" TextMode="MultiLine"  ></asp:TextBox></td>
                                </tr>
                            </table>
                       </td>
                    </tr>
   
                </table>
                 <table class="Tb_Blank" style="width:100%;">
                    <tr>
                        <td style="width:10%;">申请部门</td>
                        <td style="width:10%;"><asp:Label ID="lblDepartName" runat="server"></asp:Label></td>
                        <td style="width:15%;">部门意见</td>
                        <td style="width:25%;"><asp:TextBox ID="txtDepartView" runat="server"></asp:TextBox></td>
                        <td style="width:15%;">总经理意见</td>
                        <td style="width:25%;"><asp:TextBox ID="ManagerView" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content2" runat="server">
<table class="Tb_Blank" style="width:100%;">
    <tr>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="保存" OnClick="btnAdd_Click" />
        </td>
         <td>
            <asp:Button ID="btnCancel" runat="server" Text="返回" ValidationGroup="btn1" OnClick="btnCancel_Click" />
        </td>
    </tr>
</table>
</asp:Content>