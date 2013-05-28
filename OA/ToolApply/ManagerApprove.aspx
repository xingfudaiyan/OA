<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="ManagerApprove.aspx.cs" Inherits="OA.ToolApply.ManagerApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="width:100%">
        <tr>
            <td>
               <h2>办公用品列表</h2> 
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
                        <td> <asp:Label ID="lbl1" runat="server" ></asp:Label></td>
                        <td>21</td>
                        <td>三层文件盘</td>
                        <td>个</td>
                        <td><asp:Label ID="lbl21" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>2</td>
                        <td>剪刀</td>
                        <td>把
                        </td>
                        <td><asp:Label ID="lbl2" runat="server" ></asp:Label></td>
                        
                        <td>22</td>
                        <td>A5笔记本</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl22" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>3</td>
                        <td>订书机</td>
                        <td>台</td>
                        <td><asp:Label ID="lbl3" runat="server" ></asp:Label></td>
                        
                        <td>23</td>
                        <td>纸篓（黑色）</td>
                        <td>
                            个</td>
                        <td><asp:Label ID="lbl23" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>4</td>
                        <td>订书针</td>
                        <td>盒</td>
                        <td><asp:Label ID="lbl4" runat="server" ></asp:Label></td>
                        
                        <td>24</td>
                        <td>封箱带</td>
                        <td>
                            卷</td>
                        <td><asp:Label ID="lbl24" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>5</td>
                        <td>起钉器/除针器</td>
                        <td>个</td>
                        <td><asp:Label ID="lbl5" runat="server" ></asp:Label></td>
                        
                        <td>25</td>
                        <td>胶带（小）</td>
                        <td>
                            卷</td>
                        <td><asp:Label ID="lbl25" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>6</td>
                        <td>回形针</td>
                        <td>盒</td>
                        <td><asp:Label ID="lbl6" runat="server" ></asp:Label></td>
                        
                        <td>26</td>
                        <td>笔筒（黑）</td>
                        <td>
                            个</td>
                        <td><asp:Label ID="lbl26" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>7</td>
                        <td>大头针</td>
                        <td>盒</td>
                        <td><asp:Label ID="lbl7" runat="server" ></asp:Label></td>
                        
                        <td>27</td>
                        <td>按动圆珠笔 </td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl27" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>8</td>
                        <td>长尾夹</td>
                        <td>盒</td>
                        <td><asp:Label ID="lbl8" runat="server" ></asp:Label></td>
                        
                        <td>28</td>
                        <td>中性笔（黑色）</td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl28" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>9</td>
                        <td>计算器</td>
                        <td>盒</td>
                        <td><asp:Label ID="lbl9" runat="server" ></asp:Label></td>
                        
                        <td>29</td>
                        <td>中性笔（红色）</td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl29" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>10</td>
                        <td>资料册20页</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl10" runat="server" ></asp:Label></td>
                        
                        <td>30</td>
                        <td>水笔蕊</td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl30" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>11</td>
                        <td>资料册30页</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl11" runat="server" ></asp:Label></td>
                        
                        <td>31</td>
                        <td>铅笔</td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl31" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>12</td>
                        <td>资料册40页</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl12" runat="server" ></asp:Label></td>
                        
                        <td>32</td>
                        <td>固体胶</td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl32" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>13</td>
                        <td>资料册60页</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl13" runat="server" ></asp:Label></td>
                        
                        <td>33</td>
                        <td>小橡皮</td>
                        <td>
                            块</td>
                        <td><asp:Label ID="lbl33" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>14</td>
                        <td>通用型双强力文件夹</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl14" runat="server" ></asp:Label></td>
                        
                        <td>34</td>
                        <td>记号笔（颜色）</td>
                        <td>
                            支</td>
                        <td><asp:Label ID="lbl34" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>15</td>
                        <td>单强力文件夹</td>
                        <td>本</td>
                        <td><asp:Label ID="lbl15" runat="server" ></asp:Label></td>
                        
                        <td>35</td>
                        <td>白雪 修正液X-18</td>
                        <td>
                            瓶</td>
                        <td><asp:Label ID="lbl35" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>16</td>
                        <td>写字板夹</td>
                        <td>只</td>
                        <td><asp:Label ID="lbl16" runat="server" ></asp:Label></td>
                        
                        <td>36</td>
                        <td>白雪 修正带D3560</td>
                        <td>
                            盒</td>
                        <td><asp:Label ID="lbl36" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>17</td>
                        <td>透明拉边资料袋</td>
                        <td>个</td>
                        <td><asp:Label ID="lbl17" runat="server" ></asp:Label></td>
                        
                        <td>37</td>
                        <td>30cm 直尺</td>
                        <td>
                            把</td>
                        <td><asp:Label ID="lbl37" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>18</td>
                        <td>透明纽扣文件袋</td>
                        <td>个</td>
                        <td><asp:Label ID="lbl18" runat="server" ></asp:Label></td>
                        
                        <td>38</td>
                        <td>50cm 直尺</td>
                        <td>
                            把</td>
                        <td><asp:Label ID="lbl38" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>19</td>
                        <td>牛皮纸档案袋（加厚180g）</td>
                        <td>个</td>
                        <td><asp:Label ID="lbl19" runat="server" ></asp:Label></td>
                        
                        <td>39</td>
                        <td>便签纸</td>
                        <td>
                            本</td>
                        <td><asp:Label ID="lbl39" runat="server" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td>20</td>
                        <td>三栏文件栏</td>
                        <td>个</td>
                        <td><asp:Label ID="lbl20" runat="server" ></asp:Label></td>
                        
                        <td>40</td>
                        <td>名片夹</td>
                        <td>
                            本</td>
                        <td><asp:Label ID="lbl40" runat="server" ></asp:Label></td>
                    </tr>
                      <tr>
                       <td colspan="8">
                            <table class="Blank" style="width:100%;">
                                <tr>
                                       <td style="width:5%;">备注</td>
                                       <td style="width:6%;">市场部</td>
                                       <td style="width:26%;"><asp:TextBox ID="txtMarketMemo" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox></td>
                                       <td style="width:6%;">技术部</td>
                                       <td style="width:26%;"><asp:TextBox ID="txtTechMemo" runat="server" TextMode="MultiLine"  ReadOnly="true"></asp:TextBox></td>
                                       <td style="width:6%;">综合部</td>
                                       <td style="width:26%;"><asp:TextBox ID="txtHrMemo" runat="server" TextMode="MultiLine"  ReadOnly="true"></asp:TextBox></td>
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
                        <td style="width:25%;"><asp:Label ID="lblDepartView" runat="server"></asp:Label></td>
                        <td style="width:15%;">总经理意见</td>
                        <td style="width:25%;"><asp:TextBox ID="txtManagerView" runat="server"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
             <td style="padding-left:65%;">
                  <asp:RadioButtonList ID="rblOver" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0">修正</asp:ListItem>
                        <asp:ListItem Value="1">通过</asp:ListItem>
                  </asp:RadioButtonList>
             </td>
        </tr>
</table>
<table class="Tb_Blank" style="width:100%;">
    <tr>
        <td>
            <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"    />
        </td>
         <td>
            <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  />
        </td>
    </tr>
</table>
</asp:Content>


