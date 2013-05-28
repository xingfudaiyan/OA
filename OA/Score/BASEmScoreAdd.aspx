<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BASEmScoreAdd.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.BASEmScoreAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>商务助理绩效考核表</h3></td></tr>
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
                        <td><input type="text" name="iSelfbas1" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>10</td>
                       </tr>
                       <tr>
                        <td colspan="3">商务文件存档及保管准确、有序</td>
                        <td><input type="text" name="iSelfbas2" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>10</td>
                       </tr>
                       <tr>
                            <td rowspan="2">销售报表提交</td>
                            <td colspan="3">在规定的时间之内将相关报表交到指定处</td>
                            <td><input type="text" name="iSelfbas3" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                       <tr>
                         <td colspan="3">销售报表提交的准确性</td>
                            <td><input type="text" name="iSelfbas4" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td rowspan="2">进销存管理</td>
                            <td colspan="3">进销存系统及时录入系统</td>
                            <td><input type="text" name="iSelfbas5" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                       <tr>
                         <td colspan="3">进销存数据的准确性</td>
                            <td><input type="text" name="iSelfbas6" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                       <tr>
                            <td>部门行政事务</td>
                            <td colspan="3">市场部行政事务的执行及协助</td>
                            <td><input type="text" name="iSelfbas7" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>4</td>
                       </tr>
                        <tr>
                            <td>各类报告提交</td>
                            <td colspan="3">在规定的时间之内将相关报告交到指定处（1分）报告的质量（2分）</td>
                            <td><input type="text" name="iSelfbas8" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>3</td>
                       </tr>
                       <tr>
                            <td>团队协作</td>
                            <td colspan="3">因个人原因而影响团队（包括市场部，技术部）工作的情况出现一次，扣除该项3分</td>
                            <td><input type="text" name="iSelfbas9" class="Input1" /></td>
                            <td></td>
                            <td></td>
                            <td>3</td>
                       </tr>
                       <tr>
                        <td rowspan="4">工作能力</td>
                        <td>专业知识</td>
                        <td colspan="3">①了解公司产品基本知识②熟悉本行业及本公司的产品<br />③熟练掌握本岗位所具备的专业知识，但对其他相关知识了解不多<br />④熟练掌握业务知识及其他相关知识</td>
                        <td><input type="text" name="iSelfbas10" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td>分析判断能力</td>
                        <td colspan="3">①较弱，不能及时地做出正确的分析与判断<br />②一般，能对问题进行简单的分析和判断<br />③较强，能对复杂的问题进行分析和判断，但不能灵活运用到实际工作④非常强，能迅速地对客观环境做出较正确的判断，并能灵活运用到实际工作中，取得较好的销售业绩</td>
                        <td><input type="text" name="iSelfbas11" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td>沟通能力</td>
                        <td colspan="3">①能较清晰地表达自己的想法②有一定的说服能力③能有效地化解矛盾④能灵活运用多种谈话技巧和他人进行沟通</td>
                        <td><input type="text" name="iSelfbas12" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td>灵活应变能力</td>
                        <td colspan="3">①思想比较保守，应变能力较弱②有一定的灵活应变能力<br />③应变能力较强，能根据客观环境的变化灵活地采取相应的措施</td>
                        <td><input type="text" name="iSelfbas13" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">工作态度</td>
                        <td style="height: 25px">员工出勤率</td>
                        <td colspan="3" style="height: 25px">迟到或早退一次扣0.5分</td>
                         <td style="height: 25px"><input type="text" name="iSelfbas14" class="Input1" /></td>
                        <td style="height: 25px"></td>
                        <td style="height: 25px"></td>
                        <td style="height: 25px">2</td>
                       </tr>
                       <tr>
                        <td>日常行为规范</td>
                        <td colspan="3">违反一次，扣2分</td>
                        <td><input type="text" name="iSelfbas15" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>2</td>
                       </tr>
                       <tr>
                        <td>责任感</td>
                        <td colspan="3">①工作马虎，不能保质保量地完成工作任务且工作态度极不认真<br />②自觉地完成工作任务，但对工作中的失误有时推卸责任<br />③自觉地完成工作任务且对自己的行为负责<br />④除了做好自己的本职工作外，还主动承担公司内部额外的工作</td>
                        <td><input type="text" name="iSelfbas16" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td>服务意识</td>
                        <td colspan="3">出现一次客户投诉，扣3分</td>
                        <td><input type="text" name="iSelfbas17" class="Input1" /></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
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
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" />
               </td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
        </tr>
    </table> 
</asp:Content>
