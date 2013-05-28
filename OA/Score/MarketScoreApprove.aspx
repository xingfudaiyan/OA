<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketScoreApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.MarketScoreApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<script type="text/javascript">
        function Score(str1,str2,str3)
        {
           if(document.getElementById(str1).value=="")
           {
                document.getElementById(str1).value="0";
                document.getElementById(str3).innerText=0.4*parseFloat(document.getElementById(str2).innerText);
           }
            var x=parseFloat(document.getElementById(str1).value);
            var y=parseFloat(document.getElementById(str2).innerText);//lblSelfProject1.ClientID
            document.getElementById(str3).innerText=parseFloat(0.4*y+0.6*x).toFixed(2);//lblSectProject1.ClientI
            SumScore();
 
        }
        
        function SumScore()
        {
           if(document.getElementById("<%=lblSecms1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms1.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecms2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms2.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms3.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms4.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms5.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms6.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms7.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms8.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms8.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms9.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms10.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms11.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms12.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms13.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms14.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms14.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms15.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms15.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms16.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms16.ClientID %>").innerText="0";
           }
            
           if(document.getElementById("<%=lblSecms17.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms17.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms18.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms18.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms19.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms19.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms20.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms20.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms21.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms21.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms22.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms22.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecms23.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms23.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecms24.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecms24.ClientID %>").innerText="0";
           }
           var x1=parseFloat(document.getElementById("<%=lblSecms1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecms2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecms3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecms4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecms5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecms6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecms7.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSecms8.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSecms9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSecms10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSecms11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSecms12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSecms13.ClientID %>").innerText);
           var x14=parseFloat(document.getElementById("<%=lblSecms14.ClientID %>").innerText);
           var x15=parseFloat(document.getElementById("<%=lblSecms15.ClientID %>").innerText);
           var x16=parseFloat(document.getElementById("<%=lblSecms16.ClientID %>").innerText);
           var x17=parseFloat(document.getElementById("<%=lblSecms17.ClientID %>").innerText);
           var x18=parseFloat(document.getElementById("<%=lblSecms18.ClientID %>").innerText);
           var x19=parseFloat(document.getElementById("<%=lblSecms19.ClientID %>").innerText);
           var x20=parseFloat(document.getElementById("<%=lblSecms20.ClientID %>").innerText);
           var x21=parseFloat(document.getElementById("<%=lblSecms21.ClientID %>").innerText);
           var x22=parseFloat(document.getElementById("<%=lblSecms22.ClientID %>").innerText);
           var x23=parseFloat(document.getElementById("<%=lblSecms23.ClientID %>").innerText);
           var x24=parseFloat(document.getElementById("<%=lblSecms24.ClientID %>").innerText);
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x8+x9+x10+x11+x12+x13+x14+x15+x16+x17+x18+x19+x20+x21+x22+x23+x24).toFixed(2) ;
           document.getElementById("<%=lblTotalScore.ClientID %>").innerText=sum;
           document.getElementById('hid').value=sum;
           
         
           
        }
    </script>
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>总经理助理绩效考核表</h3></td></tr>
             <tr>
                <td style="text-align:right;">时间：<asp:Label ID="lblDate" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <table class="Tb_Common" style="width:100%;">
                        <tr>
                            <td colspan="2" style="width:16%;">姓名</td>
                            <td colspan="2" style="width:18%;"><asp:Label ID="lblName" runat="server"></asp:Label></td>
                            <td colspan="2" style="width:16%;">职务</td>
                            <td colspan="2" style="width:18%;"><asp:Label ID="lblPosition" runat="server"></asp:Label></td>
                            <td colspan="2" style="width:16%;">评价人</td>
                            <td colspan="2" style="width:16%;">祁大为</td>
                        </tr>
                        <tr>
                            <td colspan="2">评价内容</td>
                            <td colspan="6"></td>
                            <td>自评</td>
                            <td>领导评</td>
                            <td>本栏得分</td>
                            <td>满分</td>
                        </tr>
                        <tr>
                            <td rowspan="19">公司营运管理</td>
                            <td rowspan="6">营运管理</td>
                            <td colspan="6">服从总经理的统一指挥，认真执行其工作指令</td>
                            <td><asp:Label ID="lblSelfms1" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms1" name="Upms1"   class="Input1" onblur="Score('Upms1','<%=lblSelfms1.ClientID %>','<%=lblSecms1.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms1" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                             <td colspan="6">能够协助总经理协调好各部门工作和处理日常事务</td>
                            <td>
                                <asp:Label ID="lblSelfms2" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms2"  name="Upms2"   class="Input1" onblur="Score('Upms2','<%=lblSelfms2.ClientID %>','<%=lblSecms2.ClientID %>')" />
                                </td>
                            <td>
                                <asp:Label ID="lblSecms2" runat="server"></asp:Label></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">参与公司发展规划的拟定，年度经营计划的编制和公司重大决策事项的讨论</td>
                            <td>
                                <asp:Label ID="lblSelfms3" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms3"  name="Upms3"   class="Input1" onblur="Score('Upms3','<%=lblSelfms3.ClientID %>','<%=lblSecms3.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms3" runat="server"></asp:Label></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">能协助各类管理制度的拟定、讨论、修改工作，负责监督各部门对制度的执行情况</td>
                            <td>
                                <asp:Label ID="lblSelfms4" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms4"  name="Upms4"   class="Input1" onblur="Score('Upms4','<%=lblSelfms4.ClientID %>','<%=lblSecms4.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms4" runat="server"></asp:Label></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">能做到及时收集和了解各部门的工作动态，协助总经理及各部门之间的业务工作，<br />掌控公司主要生产经营情况和业务拓展情况</td>
                            <td>
                                <asp:Label ID="lblSelfms5" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms5"  name="Upms5"  class="Input1" onblur="Score('Upms5','<%=lblSelfms5.ClientID %>','<%=lblSecms5.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms5" runat="server"></asp:Label></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">能按要求完成公司运营项目的洽谈、调研等有关工作，认真做好项目的监督管理工作</td>
                            <td>
                                <asp:Label ID="lblSelfms6" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms6"  name="Upms6"  class="Input1" onblur="Score('Upms6','<%=lblSelfms6.ClientID %>','<%=lblSecms6.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms6" runat="server"></asp:Label></td>
                            <td>3</td>
                        </tr>
                        <tr>
                            <td rowspan="6">市场管理</td>
                            <td colspan="6">销售计划完成率：当季度的销售指标实际完成情况</td>
                             <td>
                                 <asp:Label ID="lblSelfms7" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms7"  name="Upms7"   class="Input1" onblur="Score('Upms7','<%=lblSelfms7.ClientID %>','<%=lblSecms7.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms7" runat="server"></asp:Label></td>
                            <td>20</td>
                        </tr>
                        <tr>
                             <td colspan="6">营销费用控制：当季度营销费用控制情况，是否超出公司规定预算</td>
                             <td>
                                 <asp:Label ID="lblSelfms8" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms8" name="Upms8"  class="Input1" onblur="Score('Upms8','<%=lblSelfms8.ClientID %>','<%=lblSecms8.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms8" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                        <tr>
                            <td colspan="6">款项回收情况考核：款项回收是否及时，是否有呆账坏账产生</td>
                            <td>
                                <asp:Label ID="lblSelfms9" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms9"  name="Upms9"  class="Input1" onblur="Score('Upms9','<%=lblSelfms9.ClientID %>','<%=lblSecms9.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms9" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                         <tr>
                            <td colspan="6">战略客户的关系维护：对重要客户的人脉关系建立，维护情况，是否保持良好。</td>
                            <td>
                                <asp:Label ID="lblSelfms10" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms10"  name="Upms10"  class="Input1" onblur="Score('Upms10','<%=lblSelfms10.ClientID %>','<%=lblSecms10.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms10" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr> 
                        <tr>
                            <td colspan="6">营销系统内部管理制度的修订和执行的有效性</td>
                            <td>
                                <asp:Label ID="lblSelfms11" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms11"  name="Upms11"   class="Input1" onblur="Score('Upms11','<%=lblSelfms11.ClientID %>','<%=lblSecms11.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms11" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                         <tr>
                            <td colspan="6">营销系统内部员工绩效考核等综合管理</td>
                            <td>
                                <asp:Label ID="lblSelfms12" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms12"  name="Upms12"   class="Input1" onblur="Score('Upms12','<%=lblSelfms12.ClientID %>','<%=lblSecms12.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms12" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                        <tr>
                            <td rowspan="5">行政人事<br />管理</td>
                            <td colspan="6">严格遵守公司规章制度，认真履行其工作职责。</td>
                            <td>
                                <asp:Label ID="lblSelfms13" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms13"  name="Upms13"   class="Input1" onblur="Score('Upms13','<%=lblSelfms13.ClientID %>','<%=lblSecms13.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms13" runat="server"></asp:Label></td>
                            <td>2</td>
                        </tr>
                        <tr>
                            <td colspan="6">检查、督促会议决议的贯彻实施</td>
                            <td>
                                <asp:Label ID="lblSelfms14" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms14"  name="Upms14"  class="Input1" onblur="Score('Upms14','<%=lblSelfms14.ClientID %>','<%=lblSecms14.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms14" runat="server"></asp:Label></td>
                            <td>2</td>
                        </tr>
                         <tr>
                            <td colspan="6">对公司的所有资料、数据、经营状况高度保密，决不对外泄露</td>
                            <td>
                                <asp:Label ID="lblSelfms15" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms15"  name="Upms15"   class="Input1" onblur="Score('Upms15','<%=lblSelfms15.ClientID %>','<%=lblSecms15.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms15" runat="server"></asp:Label></td>
                            <td>2</td>
                        </tr>
                         <tr>
                            <td colspan="6">根据公司发展要求配合人力资源部完善公司的人力资源结构，及员工的潜力开发</td>
                            <td>
                                <asp:Label ID="lblSelfms16" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms16"  name="Upms16"  class="Input1" onblur="Score('Upms16','<%=lblSelfms16.ClientID %>','<%=lblSecms16.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms16" runat="server"></asp:Label></td>
                            <td>2</td>
                        </tr>
                        <tr>
                            <td colspan="6">定期沟通、收集公司员工的意见和建议，了解员工的思想状况，<br />能自己处理的及时处理，不能处理的及时向总经理反应</td>
                            <td>
                                <asp:Label ID="lblSelfms17" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms17"  name="Upms17"  class="Input1" onblur="Score('Upms17','<%=lblSelfms17.ClientID %>','<%=lblSecms17.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms17" runat="server"></asp:Label></td>
                            <td>2</td>
                        </tr>
                        <tr>
                            <td rowspan="2">对外关系<br />维护</td>
                            <td colspan="6">协助总经理做好各级政府、主管部门及业务单位的联系、接待工作，<br />协调好公司的社会关系</td>
                            <td>
                                <asp:Label ID="lblSelfms18" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms18"  name="Upms18"  class="Input1" onblur="Score('Upms18','<%=lblSelfms18.ClientID %>','<%=lblSecms18.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms18" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td colspan="6">负责做好公司的经营宣传和企业文化建设工作</td>
                            <td>
                                <asp:Label ID="lblSelfms19" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms19"  name="Upms19"   class="Input1" onblur="Score('Upms19','<%=lblSelfms19.ClientID %>','<%=lblSecms19.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms19" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td rowspan="5">工作能力</td>
                            <td>计划性</td>
                            <td colspan="6">工作事前计划程度，对工作（内容、时间、数量、程序）安排分配的合理性、有效性</td>
                            <td>
                                <asp:Label ID="lblSelfms20" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms20"  name="Upms20"   class="Input1" onblur="Score('Upms20','<%=lblSelfms20.ClientID %>','<%=lblSecms20.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms20" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                        <tr>
                             <td>应变力</td>
                            <td colspan="6">正对客观变化，具有迅速采取措施（行动）的主动性、有效性，<br />在工作中对突发事件的处理具有灵活的应变能力</td>
                            <td>
                                <asp:Label ID="lblSelfms21" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms21"  name="Upms21"  class="Input1" onblur="Score('Upms21','<%=lblSelfms21.ClientID %>','<%=lblSecms21.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms21" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                         <tr>
                             <td>职务技能</td>
                            <td colspan="6">具备专业的职务技能，能收敛的掌握及运用相关知识</td>
                            <td>
                                <asp:Label ID="lblSelfms22" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms22"  name="Upms22"  class="Input1" onblur="Score('Upms22','<%=lblSelfms22.ClientID %>','<%=lblSecms22.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms22" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                         <tr>
                             <td>周全慎密</td>
                            <td colspan="6">工作认真、细致、深入，考虑问题全面、遗漏率非常低</td>
                            <td>
                                <asp:Label ID="lblSelfms23" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upms23"  name="Upms23"   class="Input1" onblur="Score('Upms23','<%=lblSelfms23.ClientID %>','<%=lblSecms23.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms23" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                         <tr>
                             <td>创新能力</td>
                            <td colspan="6">具有创新意识，对工作有不断完善、开拓创新的思维</td>
                            <td>
                                <asp:Label ID="lblSelfms24" runat="server"></asp:Label></td>
                            <td><input type="text"  id="Upms24"  name="Upms24"  class="Input1" onblur="Score('Upms24','<%=lblSelfms24.ClientID %>','<%=lblSecms24.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecms24" runat="server"></asp:Label></td>
                            <td>4</td>
                        </tr>
                        <tr>
                            <td colspan="2">总分</td>
                            <td colspan="9"> <input type="hidden" id="hid" name="hid" >
                            <asp:Label ID="lblTotalScore" runat="server"></asp:Label>  </td>
                            <td>100</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                评分者意见
                            </td>
                            <td colspan="10">
                            <textarea id="tViews" name="tViews" style="width:97%;"></textarea>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
  <table class="Tb_Blank" style="width:100%;">
        <tr>
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
        </tr>
    </table> 
</asp:Content>