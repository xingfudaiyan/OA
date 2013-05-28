<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BASEmScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.BASEmScoreDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>商务助理绩效考核表</h3></td></tr>
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
                        <td>考核指标</td>
                        <td colspan="3">评价标准</td>
                        <td style="width:7%;">自评</td>
                        <td style="width:7%;">领导评</td>
                        <td style="width:7%;">本栏得分</td>
                        <td style="width:7%;">满分</td>
                       </tr>
                       <tr>
                        <td rowspan="9">工作绩效</td>
                        <td rowspan="2">商务文件制作及管理（HP等）</td>
                        <td colspan="3">在规定时间内完成商务文件制作</td>
                        <td><asp:Label ID="lblSelfbas1" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpbas1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas1" runat="server"></asp:Label></td>
                        <td>10</td>
                       </tr>
                       <tr>
                        <td colspan="3">商务文件存档及保管准确、有序</td>
                        <td>
                            <asp:Label ID="lblSelfbas2" runat="server"></asp:Label></td>
                        <td>
                            <asp:Label ID="lblUpbas2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas2" runat="server"></asp:Label></td>
                        <td>10</td>
                       </tr>
                       <tr>
                            <td rowspan="2">销售报表提交</td>
                            <td colspan="3">在规定的时间之内将相关报表交到指定处</td>
                            <td>
                                <asp:Label ID="lblSelfbas3" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpbas3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas3" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                         <td colspan="3">销售报表提交的准确性</td>
                            <td>
                                <asp:Label ID="lblSelfbas4" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpbas4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas4" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td rowspan="2">进销存管理</td>
                            <td colspan="3">进销存系统及时录入系统</td>
                            <td>
                                <asp:Label ID="lblSelfbas5" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpbas5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas5" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                         <td colspan="3">进销存数据的准确性</td>
                            <td>
                                <asp:Label ID="lblSelfbas6" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpbas6" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas6" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                            <td>部门行政事务</td>
                            <td colspan="3">市场部行政事务的执行及协助</td>
                            <td>
                                <asp:Label ID="lblSelfbas7" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpbas7" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas7" runat="server"></asp:Label></td>
                            <td>4</td>
                       </tr>
                        <tr>
                            <td>各类报告提交</td>
                            <td colspan="3">在规定的时间之内将相关报告交到指定处（1分）报告的质量（2分）</td>
                            <td>
                                <asp:Label ID="lblSelfbas8" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpbas8" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas8" runat="server"></asp:Label></td>
                            <td>3</td>
                       </tr>
                       <tr>
                            <td>团队协作</td>
                            <td colspan="3">因个人原因而影响团队（包括市场部，技术部）工作的情况出现一次，扣除该项3分</td>
                            <td>
                                <asp:Label ID="lblSelfbas9" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpbas9" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSecbas9" runat="server"></asp:Label></td>
                            <td>3</td>
                       </tr>
                       <tr>
                        <td rowspan="4">工作能力</td>
                        <td>专业知识</td>
                        <td colspan="3">①了解公司产品基本知识②熟悉本行业及本公司的产品<br />③熟练掌握本岗位所具备的专业知识，但对其他相关知识了解不多<br />④熟练掌握业务知识及其他相关知识</td>
                        <td>
                            <asp:Label ID="lblSelfbas10" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas10" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas10" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td>分析判断能力</td>
                        <td colspan="3">①较弱，不能及时地做出正确的分析与判断<br />②一般，能对问题进行简单的分析和判断<br />③较强，能对复杂的问题进行分析和判断，但不能灵活运用到实际工作④非常强，能迅速地对客观环境做出较正确的判断，并能灵活运用到实际工作中，取得较好的销售业绩</td>
                        <td>
                            <asp:Label ID="lblSelfbas11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas11" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td>沟通能力</td>
                        <td colspan="3">①能较清晰地表达自己的想法②有一定的说服能力③能有效地化解矛盾④能灵活运用多种谈话技巧和他人进行沟通</td>
                        <td>
                            <asp:Label ID="lblSelfbas12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas12" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td>灵活应变能力</td>
                        <td colspan="3">①思想比较保守，应变能力较弱②有一定的灵活应变能力<br />③应变能力较强，能根据客观环境的变化灵活地采取相应的措施</td>
                        <td>
                            <asp:Label ID="lblSelfbas13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas13" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">工作态度</td>
                        <td>员工出勤率</td>
                        <td colspan="3">迟到或早退一次扣0.5分</td>
                         <td>
                             <asp:Label ID="lblSelfbas14" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpbas14" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSecbas14" runat="server"></asp:Label></td>
                        <td >2</td>
                       </tr>
                       <tr>
                        <td>日常行为规范</td>
                        <td colspan="3">违反一次，扣2分</td>
                        <td>
                            <asp:Label ID="lblSelfbas15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas15" runat="server"></asp:Label></td>
                        <td>2</td>
                       </tr>
                       <tr>
                        <td>责任感</td>
                        <td colspan="3">①工作马虎，不能保质保量地完成工作任务且工作态度极不认真<br />②自觉地完成工作任务，但对工作中的失误有时推卸责任<br />③自觉地完成工作任务且对自己的行为负责<br />④除了做好自己的本职工作外，还主动承担公司内部额外的工作</td>
                        <td>
                            <asp:Label ID="lblSelfbas16" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas16" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas16" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td>服务意识</td>
                        <td colspan="3">出现一次客户投诉，扣3分</td>
                        <td>
                            <asp:Label ID="lblSelfbas17" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpbas17" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSecbas17" runat="server"></asp:Label></td>
                        <td>3</td>
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
