<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BASEmApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.BASEmApprove" %>

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
           if(document.getElementById("<%=lblSecbas1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas1.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecbas2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas2.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas3.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas4.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas5.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas6.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas7.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas8.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas8.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas9.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas10.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas11.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas12.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas13.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas14.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas14.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas15.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas15.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas16.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas16.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecbas17.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecbas17.ClientID %>").innerText="0";
           }
           
           var x1=parseFloat(document.getElementById("<%=lblSecbas1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecbas2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecbas3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecbas4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecbas5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecbas6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecbas7.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSecbas8.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSecbas9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSecbas10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSecbas11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSecbas12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSecbas13.ClientID %>").innerText);
           var x14=parseFloat(document.getElementById("<%=lblSecbas14.ClientID %>").innerText);
           var x15=parseFloat(document.getElementById("<%=lblSecbas15.ClientID %>").innerText);
           var x16=parseFloat(document.getElementById("<%=lblSecbas16.ClientID %>").innerText);
           var x17=parseFloat(document.getElementById("<%=lblSecbas17.ClientID %>").innerText);
           
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x8+x9+x10+x11+x12+x13+x14+x15+x16+x17).toFixed(2);
           document.getElementById("<%=lblTotalScore.ClientID %>").innerText=sum;
           document.getElementById('hid').value=sum;
           
           if(sum>91)
           {
            document.getElementById("<%=lblLevel.ClientID %>").innerText="优秀91分以上";
           }
           else if(sum<90&&sum >76)
           {
            document.getElementById("<%=lblLevel.ClientID %>").innerText="良好76~90分";
           }
           else if(sum>60&&sum<75)
           {
            document.getElementById("<%=lblLevel.ClientID %>").innerText="一般60~75分";
           }
           else if(sum<60)
           {
             document.getElementById("<%=lblLevel.ClientID %>").innerText="不合格60分以下";
           }
        }
        
      
    </script>
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
                        <td><input type="text" id="Upbas1" name="Upbas1" class="Input1" onblur="Score('Upbas1','<%=lblSelfbas1.ClientID %>','<%=lblSecbas1.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecbas1" runat="server"></asp:Label></td>
                        <td>10</td>
                       </tr>
                       <tr>
                        <td colspan="3">商务文件存档及保管准确、有序</td>
                        <td>
                            <asp:Label ID="lblSelfbas2" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas2" name="Upbas2" class="Input1" onblur="Score('Upbas2','<%=lblSelfbas2.ClientID %>','<%=lblSecbas2.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas2" runat="server"></asp:Label></td>
                        <td>10</td>
                       </tr>
                       <tr>
                            <td rowspan="2">销售报表提交</td>
                            <td colspan="3">在规定的时间之内将相关报表交到指定处</td>
                            <td>
                                <asp:Label ID="lblSelfbas3" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas3" name="Upbas3" class="Input1" onblur="Score('Upbas3','<%=lblSelfbas3.ClientID %>','<%=lblSecbas3.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas3" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                         <td colspan="3">销售报表提交的准确性</td>
                            <td>
                                <asp:Label ID="lblSelfbas4" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas4" name="Upbas4" class="Input1" onblur="Score('Upbas4','<%=lblSelfbas4.ClientID %>','<%=lblSecbas4.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas4" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td rowspan="2">进销存管理</td>
                            <td colspan="3">进销存系统及时录入系统</td>
                            <td>
                                <asp:Label ID="lblSelfbas5" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas5" name="Upbas5" class="Input1" onblur="Score('Upbas5','<%=lblSelfbas5.ClientID %>','<%=lblSecbas5.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas5" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                         <td colspan="3">进销存数据的准确性</td>
                            <td>
                                <asp:Label ID="lblSelfbas6" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas6" name="Upbas6" class="Input1" onblur="Score('Upbas6','<%=lblSelfbas6.ClientID %>','<%=lblSecbas6.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas6" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                            <td>部门行政事务</td>
                            <td colspan="3">市场部行政事务的执行及协助</td>
                            <td>
                                <asp:Label ID="lblSelfbas7" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas7" name="Upbas7" class="Input1" onblur="Score('Upbas7','<%=lblSelfbas7.ClientID %>','<%=lblSecbas7.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas7" runat="server"></asp:Label></td>
                            <td>4</td>
                       </tr>
                        <tr>
                            <td>各类报告提交</td>
                            <td colspan="3">在规定的时间之内将相关报告交到指定处（1分）报告的质量（2分）</td>
                            <td>
                                <asp:Label ID="lblSelfbas8" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas8" name="Upbas8" class="Input1" onblur="Score('Upbas8','<%=lblSelfbas8.ClientID %>','<%=lblSecbas8.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas8" runat="server"></asp:Label></td>
                            <td>3</td>
                       </tr>
                       <tr>
                            <td>团队协作</td>
                            <td colspan="3">因个人原因而影响团队（包括市场部，技术部）工作的情况出现一次，扣除该项3分</td>
                            <td>
                                <asp:Label ID="lblSelfbas9" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upbas9" name="Upbas9" class="Input1" onblur="Score('Upbas9','<%=lblSelfbas9.ClientID %>','<%=lblSecbas9.ClientID %>')"/></td>
                            <td>
                                <asp:Label ID="lblSecbas9" runat="server"></asp:Label></td>
                            <td>3</td>
                       </tr>
                       <tr>
                        <td rowspan="4">工作能力</td>
                        <td>专业知识</td>
                        <td colspan="3">①了解公司产品基本知识②熟悉本行业及本公司的产品<br />③熟练掌握本岗位所具备的专业知识，但对其他相关知识了解不多<br />④熟练掌握业务知识及其他相关知识</td>
                        <td>
                            <asp:Label ID="lblSelfbas10" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas10" name="Upbas10" class="Input1" onblur="Score('Upbas10','<%=lblSelfbas10.ClientID %>','<%=lblSecbas10.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas10" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td>分析判断能力</td>
                        <td colspan="3">①较弱，不能及时地做出正确的分析与判断<br />②一般，能对问题进行简单的分析和判断<br />③较强，能对复杂的问题进行分析和判断，但不能灵活运用到实际工作④非常强，能迅速地对客观环境做出较正确的判断，并能灵活运用到实际工作中，取得较好的销售业绩</td>
                        <td>
                            <asp:Label ID="lblSelfbas11" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas11" name="Upbas11" class="Input1" onblur="Score('Upbas11','<%=lblSelfbas11.ClientID %>','<%=lblSecbas11.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas11" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td>沟通能力</td>
                        <td colspan="3">①能较清晰地表达自己的想法②有一定的说服能力③能有效地化解矛盾④能灵活运用多种谈话技巧和他人进行沟通</td>
                        <td>
                            <asp:Label ID="lblSelfbas12" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas12" name="Upbas12" class="Input1" onblur="Score('Upbas12','<%=lblSelfbas12.ClientID %>','<%=lblSecbas12.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas12" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td>灵活应变能力</td>
                        <td colspan="3">①思想比较保守，应变能力较弱②有一定的灵活应变能力<br />③应变能力较强，能根据客观环境的变化灵活地采取相应的措施</td>
                        <td>
                            <asp:Label ID="lblSelfbas13" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas13" name="Upbas13" class="Input1" onblur="Score('Upbas13','<%=lblSelfbas13.ClientID %>','<%=lblSecbas13.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas13" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">工作态度</td>
                        <td >员工出勤率</td>
                        <td colspan="3" >迟到或早退一次扣0.5分</td>
                         <td >
                             <asp:Label ID="lblSelfbas14" runat="server"></asp:Label></td>
                        <td ><input type="text" id="Upbas14" name="Upbas14" class="Input1" onblur="Score('Upbas14','<%=lblSelfbas14.ClientID %>','<%=lblSecbas14.ClientID %>')"/></td>
                        <td >
                            <asp:Label ID="lblSecbas14" runat="server"></asp:Label></td>
                        <td >2</td>
                       </tr>
                       <tr>
                        <td>日常行为规范</td>
                        <td colspan="3">违反一次，扣2分</td>
                        <td>
                            <asp:Label ID="lblSelfbas15" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas15" name="Upbas15" class="Input1" onblur="Score('Upbas15','<%=lblSelfbas15.ClientID %>','<%=lblSecbas15.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas15" runat="server"></asp:Label></td>
                        <td>2</td>
                       </tr>
                       <tr>
                        <td>责任感</td>
                        <td colspan="3">①工作马虎，不能保质保量地完成工作任务且工作态度极不认真<br />②自觉地完成工作任务，但对工作中的失误有时推卸责任<br />③自觉地完成工作任务且对自己的行为负责<br />④除了做好自己的本职工作外，还主动承担公司内部额外的工作</td>
                        <td>
                            <asp:Label ID="lblSelfbas16" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas16" name="Upbas16" class="Input1" onblur="Score('Upbas16','<%=lblSelfbas16.ClientID %>','<%=lblSecbas16.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas16" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td>服务意识</td>
                        <td colspan="3">出现一次客户投诉，扣3分</td>
                        <td>
                            <asp:Label ID="lblSelfbas17" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upbas17" name="Upbas17" class="Input1" onblur="Score('Upbas17','<%=lblSelfbas17.ClientID %>','<%=lblSecbas17.ClientID %>')"/></td>
                        <td>
                            <asp:Label ID="lblSecbas17" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td>总分</td>
                        <td colspan="7"><input type="hidden" id="hid" name="hid" ><asp:Label ID="lblTotalScore" runat="server"></asp:Label></td>
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
                        <td colspan="8"><textarea id="UpViews" name="UpViews" style="width:95%;"></textarea></td>
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
