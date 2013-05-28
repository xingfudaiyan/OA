<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechEmApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.TechMaApprove" %>

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
        
        function Score1()
        {
            
            var x=parseFloat(document.getElementById("iPlanFinish").value);
            var y=parseFloat(document.getElementById("iActualFinish").value);
            document.getElementById("<%=lblPercent.ClientID %>").innerText=(y/x)*100+"%";
            
        }
        
        function Score2()
        {
             var x=parseFloat(document.getElementById("iUp").value);
             document.getElementById("<%=lblUp.ClientID %>").innerText=x;
             SumScore();
        }
        
        function SumScore()
        {
           if(document.getElementById("<%=lblSecPlan.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecPlan.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecWorkTotal.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecWorkTotal.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecWorkSpeed.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecWorkSpeed.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecCommunicate.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecCommunicate.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecDescipline.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecDescipline.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecExecute.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecExecute.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecRoute.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecRoute.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecProfession.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecProfession.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecAttitude.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecAttitude.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblUp.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblUp.ClientID %>").innerText="0";
           }
           var x1=parseFloat(document.getElementById("<%=lblSecPlan.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecWorkTotal.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecWorkSpeed.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecCommunicate.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecDescipline.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecExecute.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecRoute.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSecProfession.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSecAttitude.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblUp.ClientID %>").innerText);
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x8+x9+x10).toFixed(2);
           document.getElementById("<%=lblSumScore.ClientID %>").innerText=sum;
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
                            <td rowspan="2"><input type="text" id="iUp" name="iUp" class="Input1" onblur="Score2()" /></td>
                            <td rowspan="2"><asp:Label ID="lblUp" runat="server"></asp:Label></td>
                            <td rowspan="2">40</td>
                        </tr>
                        <tr>
                           <td><input type="text" id="iPlanFinish" name="iPlanFinish" class="Input1" /></td>
                           <td><input type="text" id="iActualFinish" name="iActualFinish" class="Input1" onblur="Score1()" /></td>
                           <td><asp:Label ID="lblPercent" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td rowspan="9">内部运营<br />（月评）</td>
                            <td>5.计划性</td>
                            <td colspan="3">及时制订综合计划，完成率高，工作成果良好，<br />并及时形成书面总结。（在会议记录及备忘录进行记录）</td>
                            <td><asp:Label ID="lblSelfPlan" runat="server"></asp:Label></td>
                            <td>
                                &nbsp;<input type="text" id="Upplan" name="Upplan" class="Input1" onblur="Score('Upplan','<%=lblSelfPlan.ClientID %>','<%=lblSecPlan.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecPlan" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td>6.工作量</td>
                            <td colspan="3">月职责内工作及公司整体配合<br />工作总量基本饱和,无长时间空闲现象。</td>
                            <td><asp:Label ID="lblSelfWorkTotal" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpWorkTotal" name="UpWorkTotal" class="Input1" onblur="Score('UpWorkTotal','<%=lblSelfWorkTotal.ClientID %>','<%=lblSecWorkTotal.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecWorkTotal" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>7.工作速度</td>
                            <td colspan="3">完成工作迅速、及时，无浪费时间或拖拉现象。</td>
                            <td><asp:Label ID="lblSelfWorkSpeed" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpWorkSpeed" name="UpWorkSpeed" class="Input1" onblur="Score('UpWorkSpeed','<%=lblSelfWorkSpeed.ClientID %>','<%=lblSecWorkSpeed.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecWorkSpeed" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>8.合作性及沟通性</td>
                            <td colspan="3">在人际关系及与其他部门配合方面顺畅和谐，<br />能及时与其他同事进行科学的工作沟通。团队合作性强。</td>
                            <td><asp:Label ID="lblSelfCommunicate" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpCommunicate" name="upCommunicate" class="Input1" onblur="Score('UpCommunicate','<%=lblSelfCommunicate.ClientID %>','<%=lblSecCommunicate.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecCommunicate" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td>9.纪律性</td>
                            <td colspan="3">严格要求自己遵守公司各项规章制度，纪律性强，<br />无随意违纪、违规现象。（参考日常考勤及规范记录）</td>
                            <td><asp:Label ID="lblSelfDescipline" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpDescipline" name="UpDescipline" class="Input1" onblur="Score('UpDescipline','<%=lblSelfDescipline.ClientID %>','<%=lblSecDescipline.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecDescipline" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>10.执行性</td>
                            <td colspan="3">对上级指示、决议、计划坚决执行并督促跟进下级工作。</td>
                            <td><asp:Label ID="lblSelfExecute" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpExecute" name="UpExecute" class="Input1" onblur="Score('UpExecute','<%=lblSelfExecute.ClientID %>','<%=lblSecExecute.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecExecute" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td>11.流程缜密</td>
                            <td colspan="3">工作认真细致，<br />考虑问题的全面，流程遗漏率低，出错率低。</td>
                            <td><asp:Label ID="lblSelfRoute" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpRoute" name="UpRoute" class="Input1" onblur="Score('UpRoute','<%=lblSelfRoute.ClientID %>','<%=lblSecRoute.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecRoute" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>14.职业素质</td>
                            <td colspan="3">职业意识强，有职业道德，言谈举止符合职业特点。</td>
                            <td><asp:Label ID="lblSelfProfession" runat="server"></asp:Label></td>
                            <td>
                                &nbsp;<input id="UpProfession" class="Input1" name="UpProfession" type="text" onblur="Score('UpProfession','<%=lblSelfProfession.ClientID %>','<%=lblSecProfession.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecProfession" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                         <tr>
                            <td>15.工作态度</td>
                            <td colspan="3">乐观、积极的工作心态，<br />对工作充满热情，有进取精神、勤奋、责任感强。</td>
                            <td><asp:Label ID="lblSelfAttitude" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpAttitude" name="UpAttitude" class="Input1" onblur="Score('UpAttitude','<%=lblSelfAttitude.ClientID %>','<%=lblSecAttitude.ClientID %>')"/></td>
                            <td><asp:Label ID="lblSecAttitude" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                        <tr>
                            <td rowspan="2">学习成长<br />（季度评）</td>
                            <td>12.综合素质</td>
                            <td colspan="3">主动学习各种学科知识，<br />积极参加各类培训，拓宽知识面，提高综合素质。</td>
                            <td><asp:Label ID="lblSelfComplex" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpComplex" name="UpComplex" class="Input1" onblur="Score('UpComplex','<%=lblSelfComplex.ClientID %>','<%=lblSecComplex.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecComplex" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td>13.专业技能</td>
                            <td colspan="3">对所任职务所需的专业知识和业务技能掌握熟练，<br />积极组织培训与自我学习，并能运用自如。</td>
                            <td><asp:Label ID="lblSelfSpeciality" runat="server"></asp:Label></td>
                            <td><input type="text" id="UpSpeciality" name="UpSpeciality" class="Input1" onblur="Score('UpSpeciality','<%=lblSelfSpeciality.ClientID %>','<%=lblSecSpeciality.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecSpeciality" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                        <tr>
                            <td colspan="2">奖惩加/减分</td>
                            <td colspan="7"><span style=" float:left;">事由：<input type="text" id="iReason" name="iReason" /></span>
                            <input type="hidden" id="hid" name="hid" >
                            <span>分值：&nbsp;
                            <asp:RadioButtonList ID="rblAddScore" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                <asp:ListItem Value="0" Text="加分"></asp:ListItem>
                                <asp:ListItem Value="1" Text="减分"></asp:ListItem>
                            </asp:RadioButtonList>
                            <input type="text" id="iAddMinusScore" name="iAddMinusScore" style="width:10%;" value="0" onblur="addScore()" /> </span> 
                            <span>总计本月得分:<asp:Label ID="lblSumScore" runat="server"   ></asp:Label></span>  
                             </td>
                           
                        </tr>
                         <tr>
                            <td colspan="2">评价等级</td>
                            <td colspan="7">
                              <asp:Label ID="lblLevel" runat="server"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="2">评价者<br />综合意见</td>
                            <td colspan="7"><textarea id="tViews" name="tViews" style="width:95%;"></textarea></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
    <script type="text/javascript">
      function addScore()
        {
            var sum=document.getElementById("<%=lblSumScore.ClientID %>").innerText;
            var add=document.getElementById("iAddMinusScore").value;
            var radio=document.getElementById("<%=lblLevel.ClientID %>");
            if(radio.checked)
            {
                 sum=sum-add;
                 document.getElementById("<%=lblSumScore.ClientID %>").innerText=sum;
            }
        }
</script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
    <table class="Tb_Blank" style="width:100%;">
        <tr>
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" /> </td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>

