<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsistantScoreEdit.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.AsistantScoreEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>综合部经理绩效考核表</h3></td></tr>
            <tr>
                <td style="text-align:right;"><span style="color:red">*</span>时间：<asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>年<asp:DropDownList ID="ddlMonth" runat="server"></asp:DropDownList>月</td>
            </tr>
            <tr>
                <td>
                    <table class="Tb_Common" style="width:100%;">
                       <tr>
                        <td style="width:11%;">部门</td>
                        <td style="width:20%;"><asp:Label ID="lblDepart" runat="server"></asp:Label></td>
                        <td style="width:11%;">姓名</td>
                        <td style="width:20%;"><asp:Label ID="lblName" runat="server"></asp:Label></td>
                        <td style="width:10%;">职务</td>
                        <td colspan="4" style="width:28%;"><asp:Label ID="lblPosition" runat="server"></asp:Label></td>
                       </tr>
                       <tr>
                        <td>考核项目</td>
                        <td colspan="4">
                            评价内容</td>
                        <td style="width:7%;">自评</td>
                        <td style="width:7%;">领导评</td>
                        <td style="width:7%;">本栏得分</td>
                        <td style="width:7%;">满分</td>
                       </tr>
                       <tr>
                        <td rowspan="5">
                            工作态度</td>
                        <td colspan="4">
                            <span>很少迟到、早退、缺席，工作态度认真</span></td>
                        <td><input type="text" name="Selfas1" class="Input1" value="<%= Selfas1 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                严格要求自己遵守公司各项规章制度，纪律性强，无随意违纪、违规现象。</span></td>
                        <td><input type="text" name="Selfas2" class="Input1" value="<%= Selfas2 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    积极完成公司领导的临时任务，并能够高质量的完成。</span></td>
                            <td><input type="text" name="Selfas3" class="Input1" value="<%= Selfas3 %>"/></td>
                            <td></td>
                            <td></td>
                            <td>
                                5</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 能够帮助同事完成各类工作，协调跨部门的各类事务。</span></td>
                            <td><input type="text" name="Selfas4" class="Input1"  value="<%= Selfas4 %>"/></td>
                            <td></td>
                            <td></td>
                            <td>
                                5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>对工作出现的问题能够及时补救并勇于承担责任。</span></td>
                            <td><input type="text" name="Selfas5" class="Input1" value="<%= Selfas5 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="8">
                            业务能力</td>
                        <td colspan="4">监督各部门对公司相关制度的执行，对出现的问题能够及时上报。</td>
                        <td><input type="text" name="Selfas6" class="Input1" value="<%= Selfas6 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">配合其他部门进行绩效考核并能及时将相关文件上报、归档。</td>
                        <td><input type="text" name="Selfas7" class="Input1" value="<%= Selfas7 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       
                        <tr>
                        <td colspan="4">定时、高效率的完成员工的各类保险的缴纳和工资的计算。</td>
                        <td><input type="text" name="Selfas8" class="Input1" value="<%= Selfas8 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       
                        <tr>
                        <td colspan="4">协助举办各类活动，丰富员工的业余生活，提高公司凝聚力。</td>
                        <td><input type="text" name="Selfas9" class="Input1"  value="<%= Selfas9 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">按时缴纳公司水、电、煤（因行政助理没有备用金，故我先代理缴纳）</td>
                        <td><input type="text" name="Selfas10" class="Input1" value="<%= Selfas10 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">做好行政相关交接工作。</td>
                        <td><input type="text" name="Selfas11" class="Input1" value="<%= Selfas11 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督行政助理做好行政相关工作，有违规现象及时指出。</td>
                         <td ><input type="text" name="Selfas12" class="Input1"  value="<%= Selfas12 %>"/></td>
                        <td ></td>
                        <td ></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">做好行政备用金支出、保管工作。</td>
                        <td><input type="text" name="Selfas13" class="Input1" value="<%= Selfas13 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       
                      
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">积极保守公司商业秘密，并能制定相应策略或制度监督其他部门员工执行。</td>
                         <td ><input type="text" name="Selfas14" class="Input1" value="<%= Selfas14 %>" /></td>
                        <td ></td>
                        <td ></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督公司各类财务支出的有效性、及时性。防止因误缴、缓缴造成公司的各类损失。</td>
                        <td><input type="text" name="Selfas15" class="Input1" value="<%= Selfas15 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                      
                       <tr>
                        <td colspan="4">勇于面对和承担新任务。</td>
                        <td><input type="text" name="Selfas16" class="Input1" value="<%= Selfas16 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                   <tr>
                        <td rowspan="3">学习培养</td>
                        <td colspan="4">认真学好会计，尽早取得会计证书。</td>
                         <td ><input type="text" name="Selfas17" class="Input1" value="<%= Selfas17 %>"/></td>
                        <td ></td>
                        <td ></td>
                        <td >
                            10</td>
                       </tr>
                       <tr>
                        <td colspan="4">钻研自身业务技能，提高业务水平。</td>
                        <td><input type="text" name="Selfas18" class="Input1" value="<%= Selfas18 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                        <tr>
                        <td colspan="4">正确看待自己与公司的未来。</td>
                        <td><input type="text" name="Selfas19" class="Input1" value="<%= Selfas19 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                        <td>总分</td>
                        <td colspan="7"></td>
                        <td>100</td>
                       </tr>
                       <tr>
                        <td>评价等级</td>
                        <td colspan="8">
                        </td>
                       </tr>
                       <tr>
                        <td>评价者综合意见</td>
                        <td colspan="8"></td>
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
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"  /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>
