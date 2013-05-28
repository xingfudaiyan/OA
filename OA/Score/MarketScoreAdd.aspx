<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MarketScoreAdd.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.MarketScoreAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>总经理助理绩效考核表</h3></td></tr>
             <tr>
                <td style="text-align:right;"><span style="color:red">*</span>时间：<asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>年<asp:DropDownList ID="ddlMonth" runat="server"></asp:DropDownList>月</td>
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
                            <td><input  type="text" id="Selfms1" name="Selfms1"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                        </tr>
                        <tr>
                             <td colspan="6">能够协助总经理协调好各部门工作和处理日常事务</td>
                            <td><input type="text" id="Selfms2" name="Selfms2"  class="Input1" /></td>
                            <td>
                                </td>
                            <td></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">参与公司发展规划的拟定，年度经营计划的编制和公司重大决策事项的讨论</td>
                            <td><input type="text" id="Selfms3" name="Selfms3"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">能协助各类管理制度的拟定、讨论、修改工作，负责监督各部门对制度的执行情况</td>
                            <td><input type="text" id="Selfms4" name="Selfms4"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">能做到及时收集和了解各部门的工作动态，协助总经理及各部门之间的业务工作，<br />掌控公司主要生产经营情况和业务拓展情况</td>
                            <td><input type="text" id="Selfms5" name="Selfms5"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>3</td>
                        </tr>
                         <tr>
                             <td colspan="6">能按要求完成公司运营项目的洽谈、调研等有关工作，认真做好项目的监督管理工作</td>
                            <td><input type="text" id="Selfms6" name="Selfms6"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>3</td>
                        </tr>
                        <tr>
                            <td rowspan="6">市场管理</td>
                            <td colspan="6">销售计划完成率：当季度的销售指标实际完成情况</td>
                             <td><input type="text" id="Selfms7" name="Selfms7"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>20</td>
                        </tr>
                        <tr>
                             <td colspan="6">营销费用控制：当季度营销费用控制情况，是否超出公司规定预算</td>
                             <td><input type="text" id="Selfms8" name="Selfms8"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                        <tr>
                            <td colspan="6">款项回收情况考核：款项回收是否及时，是否有呆账坏账产生</td>
                            <td><input type="text" id="Selfms9" name="Selfms9"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                         <tr>
                            <td colspan="6">战略客户的关系维护：对重要客户的人脉关系建立，维护情况，是否保持良好。</td>
                            <td><input type="text" id="Selfms10" name="Selfms10"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr> 
                        <tr>
                            <td colspan="6">营销系统内部管理制度的修订和执行的有效性</td>
                            <td><input type="text" id="Selfms11" name="Selfms11"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                         <tr>
                            <td colspan="6">营销系统内部员工绩效考核等综合管理</td>
                            <td><input type="text" id="Selfms12" name="Selfms12"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                        <tr>
                            <td rowspan="5">行政人事<br />管理</td>
                            <td colspan="6">严格遵守公司规章制度，认真履行其工作职责。</td>
                            <td><input type="text" id="Selfms13" name="Selfms13"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>2</td>
                        </tr>
                        <tr>
                            <td colspan="6">检查、督促会议决议的贯彻实施</td>
                            <td><input type="text" id="Selfms14" name="Selfms14"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>2</td>
                        </tr>
                         <tr>
                            <td colspan="6">对公司的所有资料、数据、经营状况高度保密，决不对外泄露</td>
                            <td><input type="text" id="Selfms15" name="Selfms15"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>2</td>
                        </tr>
                         <tr>
                            <td colspan="6">根据公司发展要求配合人力资源部完善公司的人力资源结构，及员工的潜力开发</td>
                            <td><input type="text" id="Selfms16" name="Selfms16"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>2</td>
                        </tr>
                        <tr>
                            <td colspan="6">定期沟通、收集公司员工的意见和建议，了解员工的思想状况，<br />能自己处理的及时处理，不能处理的及时向总经理反应</td>
                            <td><input type="text" id="Selfms17" name="Selfms17"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>2</td>
                        </tr>
                        <tr>
                            <td rowspan="2">对外关系<br />维护</td>
                            <td colspan="6">协助总经理做好各级政府、主管部门及业务单位的联系、接待工作，<br />协调好公司的社会关系</td>
                            <td><input type="text" id="Selfms18" name="Selfms18"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td colspan="6">负责做好公司的经营宣传和企业文化建设工作</td>
                            <td><input type="text" id="Selfms19" name="Selfms19"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td rowspan="5">工作能力</td>
                            <td>计划性</td>
                            <td colspan="6">工作事前计划程度，对工作（内容、时间、数量、程序）安排分配的合理性、有效性</td>
                            <td><input type="text" id="Selfms20" name="Selfms20"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                        <tr>
                             <td>应变力</td>
                            <td colspan="6">正对客观变化，具有迅速采取措施（行动）的主动性、有效性，<br />在工作中对突发事件的处理具有灵活的应变能力</td>
                            <td><input type="text" id="Selfms21" name="Selfms21"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                         <tr>
                             <td>职务技能</td>
                            <td colspan="6">具备专业的职务技能，能收敛的掌握及运用相关知识</td>
                            <td><input type="text" id="Selfms22" name="Selfms22"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                         <tr>
                             <td>周全慎密</td>
                            <td colspan="6">工作认真、细致、深入，考虑问题全面、遗漏率非常低</td>
                            <td><input type="text" id="Selfms23" name="Selfms23"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                         <tr>
                             <td>创新能力</td>
                            <td colspan="6">具有创新意识，对工作有不断完善、开拓创新的思维</td>
                            <td><input type="text" id="Selfms24" name="Selfms24"  class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                        </tr>
                        <tr>
                            <td colspan="2">总分</td>
                            <td colspan="9"></td>
                            <td>100</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                评分者意见
                            </td>
                            <td colspan="10"></td>
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