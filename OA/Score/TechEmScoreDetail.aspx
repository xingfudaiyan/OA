<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechEmScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.TechEmScoreDetail" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>技术部员工考核表</h3></td></tr>
            <tr>
                <td>
                    <table class="Tb_Common" style="width:100%;">
                        <tr>
                            <td style="width:11%;">姓名</td><td colspan="2" style="width:22%;"><asp:Label ID="lblName" runat="server"></asp:Label></td>
                            <td style="width:11%;">岗位</td><td colspan="2" style="width:22%;"><asp:Label ID="lblPosition" runat="server"></asp:Label></td>
                            <td style="width:11%;">考核人</td><td colspan="2" style="width:22%;">马斌</td>
                        </tr>
                        <tr>
                            <td>部门</td><td colspan="2">技术部</td>
                            <td>评价时间</td><td colspan="5">
                                <asp:Label ID="lblDate" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                             <td colspan="2" style=" width:22%;">考核维度及项目类型</td>
                             <td colspan="3"  style="width:33%;">优秀（10分） 好（8-9分） 良好（6-7）<br />较差（4-5分）极差（1-2分）</td>
                             <td style="width:11%;">自评</td> <td style="width:11%;">上司评</td> <td style="width:11%;">本栏得分</td> <td style="width:11%;">满分</td>
                        </tr>
                        <tr>
                            <td rowspan="2">目标</td><td style="width:11%;" rowspan="2"></td>
                            <td>计划完成</td> <td>实际完成</td> <td>完成率</td>
                            <td rowspan="2"></td>
                            <td rowspan="2"><asp:Label ID="lblUp" runat="server"></asp:Label></td>
                            <td rowspan="2"><asp:Label ID="lblUp1" runat="server"></asp:Label></td>
                            <td rowspan="2">40</td>
                        </tr>
                        <tr>
                           <td><asp:Label ID="lblPlan" runat="server"></asp:Label></td>
                           <td><asp:Label ID="lblActual" runat="server"></asp:Label></td> 
                           <td><asp:Label ID="lblPercent" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td rowspan="9">内部运营<br />（月评）</td>
                            <td>5.计划性</td>
                            <td colspan="3">及时制订综合计划，完成率高，工作成果良好，<br />并及时形成书面总结。（在会议记录及备忘录进行记录）</td>
                            <td><asp:Label ID="lblSelfPlan" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpPlan" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecPlan" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td>6.工作量</td>
                            <td colspan="3">月职责内工作及公司整体配合<br />工作总量基本饱和,无长时间空闲现象。</td>
                            <td><asp:Label ID="lblSelfWorkTotal" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpWorkTotal" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecWorkTotal" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>7.工作速度</td>
                            <td colspan="3">完成工作迅速、及时，无浪费时间或拖拉现象。</td>
                            <td><asp:Label ID="lblSelfWorkSpeed" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpWorkSpeed" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecWorkSpeed" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>8.合作性及沟通性</td>
                            <td colspan="3">在人际关系及与其他部门配合方面顺畅和谐，<br />能及时与其他同事进行科学的工作沟通。团队合作性强。</td>
                            <td><asp:Label ID="lblSelfCommunicate" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpCommunicate" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecCommunicate" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td>9.纪律性</td>
                            <td colspan="3">严格要求自己遵守公司各项规章制度，纪律性强，<br />无随意违纪、违规现象。（参考日常考勤及规范记录）</td>
                            <td><asp:Label ID="lblSelfDescipline" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpDescipline" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecDescipline" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>10.执行性</td>
                            <td colspan="3">对上级指示、决议、计划坚决执行并督促跟进下级工作。</td>
                            <td><asp:Label ID="lblSelfExecute" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpExecute" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecExecute" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td>11.流程缜密</td>
                            <td colspan="3">工作认真细致，<br />考虑问题的全面，流程遗漏率低，出错率低。</td>
                            <td><asp:Label ID="lblSelfRoute" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpRoute" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecRoute" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>14.职业素质</td>
                            <td colspan="3">职业意识强，有职业道德，言谈举止符合职业特点。</td>
                            <td><asp:Label ID="lblSelfProfession" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpProfession" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecProfession" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>15.工作态度</td>
                            <td colspan="3">乐观、积极的工作心态，<br />对工作充满热情，有进取精神、勤奋、责任感强。</td>
                            <td><asp:Label ID="lblSelfAttitude" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpAttitude" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecAttitude" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                        <tr>
                            <td rowspan="2">学习成长<br />（季度评）</td>
                            <td>12.综合素质</td>
                            <td colspan="3">主动学习各种学科知识，<br />积极参加各类培训，拓宽知识面，提高综合素质。</td>
                            <td><asp:Label ID="lblSelfComplex" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpComplex" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecComplex" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td>13.专业技能</td>
                            <td colspan="3">对所任职务所需的专业知识和业务技能掌握熟练，<br />积极组织培训与自我学习，并能运用自如。</td>
                            <td><asp:Label ID="lblSelfSpeciality" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpSpeciality" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecSpeciality" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                        <tr>
                            <td colspan="2">奖惩加/减分</td>
                            <td colspan="7"><span style=" float:left;">事由：<asp:Label ID="lblReason" runat="server"></asp:Label></span><span>分值：加/减分<asp:Label ID="lblAddMinusScore" runat="server"></asp:Label> </span> <span style="float:right;">总计本月得分<asp:Label ID="lblSumScore" runat="server"></asp:Label></span>   </td>
                        </tr>
                         <tr>
                            <td colspan="2">评价等级</td>
                            <td colspan="7">
                              <asp:Label ID="lblLevels" runat="server"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="2">评价者<br />综合意见</td>
                            <td colspan="7"><asp:Label ID="lblViews" runat="server"></asp:Label></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content2" runat="server">
    <table class="Tb_Blank" style="width:100%;">
        <tr>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>


