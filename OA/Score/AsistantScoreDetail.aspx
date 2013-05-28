<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsistantScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.AsistantScoreDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>综合部经理绩效考核表</h3></td></tr>
            <tr>
                <td style="text-align:right;">时间：<asp:Label ID="lblDate" runat="server"></asp:Label></td>
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
                        <td><asp:Label ID="lblSelfas1" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas1" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                严格要求自己遵守公司各项规章制度，纪律性强，无随意违纪、违规现象。</span></td>
                        <td>
                            <asp:Label ID="lblSelfas2" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas2" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas2" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    积极完成公司领导的临时任务，并能够高质量的完成。</span></td>
                            <td>
                                <asp:Label ID="lblSelfas3" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpas3" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSecas3" runat="server"></asp:Label></td>
                            <td>
                                5</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 能够帮助同事完成各类工作，协调跨部门的各类事务。</span></td>
                            <td>
                                <asp:Label ID="lblSelfas4" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpas4" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSecas4" runat="server"></asp:Label></td>
                            <td>
                                5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>对工作出现的问题能够及时补救并勇于承担责任。</span></td>
                            <td>
                                <asp:Label ID="lblSelfas5" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpas5" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSecas5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="8">
                            业务能力</td>
                        <td colspan="4">监督各部门对公司相关制度的执行，对出现的问题能够及时上报。</td>
                        <td>
                            <asp:Label ID="lblSelfas6" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas6" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas6" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4" >配合其他部门进行绩效考核并能及时将相关文件上报、归档。</td>
                        <td >
                            <asp:Label ID="lblSelfas7" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblUpas7" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblSecas7" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       
                        <tr>
                        <td colspan="4">定时、高效率的完成员工的各类保险的缴纳和工资的计算。</td>
                        <td>
                            <asp:Label ID="lblSelfas8" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas8" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas8" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       
                        <tr>
                        <td colspan="4">协助举办各类活动，丰富员工的业余生活，提高公司凝聚力。</td>
                        <td>
                            <asp:Label ID="lblSelfas9" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas9" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas9" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">按时缴纳公司水、电、煤（因行政助理没有备用金，故我先代理缴纳）</td>
                        <td>
                            <asp:Label ID="lblSelfas10" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas10" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas10" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">做好行政相关交接工作。</td>
                        <td>
                            <asp:Label ID="lblSelfas11" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas11" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas11" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督行政助理做好行政相关工作，有违规现象及时指出。</td>
                         <td >
                             <asp:Label ID="lblSelfas12" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblUpas12" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblSecas12" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4" >做好行政备用金支出、保管工作。</td>
                        <td >
                            <asp:Label ID="lblSelfas13" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblUpas13" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblSecas13" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       
                      
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">积极保守公司商业秘密，并能制定相应策略或制度监督其他部门员工执行。</td>
                         <td >
                             <asp:Label ID="lblSelfas14" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblUpas14" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblSecas14" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督公司各类财务支出的有效性、及时性。防止因误缴、缓缴造成公司的各类损失。</td>
                        <td>
                            <asp:Label ID="lblSelfas15" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas15" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas15" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                      
                       <tr>
                        <td colspan="4">勇于面对和承担新任务。</td>
                        <td>
                            <asp:Label ID="lblSelfas16" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas16" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas16" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                   <tr>
                        <td rowspan="3">学习培养</td>
                        <td colspan="4">认真学好会计，尽早取得会计证书。</td>
                         <td >
                             <asp:Label ID="lblSelfas17" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblUpas17" runat="server"></asp:Label></td>
                        <td >
                            <asp:Label ID="lblSecas17" runat="server"></asp:Label></td>
                        <td >
                            10</td>
                       </tr>
                       <tr>
                        <td colspan="4">钻研自身业务技能，提高业务水平。</td>
                        <td>
                            <asp:Label ID="lblSelfas18" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas18" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas18" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                        <tr>
                        <td colspan="4">正确看待自己与公司的未来。</td>
                        <td>
                            <asp:Label ID="lblSelfas19" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpas19" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblSecas19" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                        <td>总分</td>
                        <td colspan="7"><asp:Label ID="lblTotalScore" runat="server"></asp:Label></td>
                        <td>100</td>
                       </tr>
                       <tr>
                        <td>评价等级</td>
                        <td colspan="8">
                            <asp:Label ID="lblLevel" runat="server"></asp:Label>
                        </td>
                       </tr>
                       <tr>
                        <td>评价者综合意见</td>
                        <td colspan="8"><asp:Label ID="lblViews" runat="server"></asp:Label></td>
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
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
        </tr>
    </table> 
</asp:Content>
