<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsistantScoreApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.AsistantScoreApprove" %>

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
           if(document.getElementById("<%=lblSecas1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas1.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecas2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas2.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas3.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas4.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas5.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas6.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas7.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas8.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas8.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas9.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas10.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas11.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas12.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas13.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas14.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas14.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas15.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas15.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas16.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas16.ClientID %>").innerText="0";
           }
            
           if(document.getElementById("<%=lblSecas17.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas17.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas18.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas18.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecas19.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecas19.ClientID %>").innerText="0";
           }
           
           var x1=parseFloat(document.getElementById("<%=lblSecas1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecas2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecas3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecas4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecas5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecas6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecas7.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSecas8.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSecas9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSecas10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSecas11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSecas12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSecas13.ClientID %>").innerText);
           var x14=parseFloat(document.getElementById("<%=lblSecas14.ClientID %>").innerText);
           var x15=parseFloat(document.getElementById("<%=lblSecas15.ClientID %>").innerText);
           var x16=parseFloat(document.getElementById("<%=lblSecas16.ClientID %>").innerText);
           var x17=parseFloat(document.getElementById("<%=lblSecas17.ClientID %>").innerText);
           var x18=parseFloat(document.getElementById("<%=lblSecas18.ClientID %>").innerText);
           var x19=parseFloat(document.getElementById("<%=lblSecas19.ClientID %>").innerText);
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x8+x9+x10+x11+x12+x13+x14+x15+x16+x17+x18+x19).toFixed(2);
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
                        <td><input type="text" id="Upas1" name="Upas1" class="Input1" onblur="Score('Upas1','<%=lblSelfas1.ClientID %>','<%=lblSecas1.ClientID %>')" /></td>
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
                        <td><input type="text" id="Upas2" name="Upas2" class="Input1" onblur="Score('Upas2','<%=lblSelfas2.ClientID %>','<%=lblSecas2.ClientID %>')" /></td>
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
                            <td><input type="text" id="Upas3" name="Upas3" class="Input1" onblur="Score('Upas3','<%=lblSelfas3.ClientID %>','<%=lblSecas3.ClientID %>')" /></td>
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
                               <input type="text" id="Upas4" name="Upas4" class="Input1" onblur="Score('Upas4','<%=lblSelfas4.ClientID %>','<%=lblSecas4.ClientID %>')" /> </td>
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
                               <input type="text" id="Upas5" name="Upas5" class="Input1" onblur="Score('Upas5','<%=lblSelfas5.ClientID %>','<%=lblSecas5.ClientID %>')"/> </td>
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
                            <input type="text" id="Upas6" name="Upas6" class="Input1" onblur="Score('Upas6','<%=lblSelfas6.ClientID %>','<%=lblSecas6.ClientID %>')" /></td>
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
                            <input type="text" id="Upas7" name="Upas7" class="Input1" onblur="Score('Upas7','<%=lblSelfas7.ClientID %>','<%=lblSecas7.ClientID %>')" /></td>
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
                           <input type="text" id="Upas8" name="Upas8" class="Input1" onblur="Score('Upas8','<%=lblSelfas8.ClientID %>','<%=lblSecas8.ClientID %>')"/> </td>
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
                            <input type="text" id="Upas9" name="Upas9" class="Input1" onblur="Score('Upas9','<%=lblSelfas9.ClientID %>','<%=lblSecas9.ClientID %>')"/></td>
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
                          <input type="text" id="Upas10" name="Upas10" class="Input1" onblur="Score('Upas10','<%=lblSelfas10.ClientID %>','<%=lblSecas10.ClientID %>')"/>  </td>
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
                           <input type="text" id="Upas11" name="Upas11" class="Input1" onblur="Score('Upas11','<%=lblSelfas11.ClientID %>','<%=lblSecas11.ClientID %>')"/> </td>
                        <td>
                            <asp:Label ID="lblSecas11" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督行政助理做好行政相关工作，有违规现象及时指出。</td>
                         <td >
                             <asp:Label ID="lblSelfas12" runat="server"></asp:Label></td>
                        <td >
                           <input type="text" id="Upas12" name="Upas12" class="Input1" onblur="Score('Upas12','<%=lblSelfas12.ClientID %>','<%=lblSecas12.ClientID %>')"/> </td>
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
                           <input type="text" id="Upas13" name="Upas13" class="Input1" onblur="Score('Upas13','<%=lblSelfas13.ClientID %>','<%=lblSecas13.ClientID %>')"/> </td>
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
                          <input type="text" id="Upas14" name="Upas14" class="Input1" onblur="Score('Upas14','<%=lblSelfas14.ClientID %>','<%=lblSecas14.ClientID %>')" />  </td>
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
                           <input type="text" id="Upas15" name="Upas15" class="Input1" onblur="Score('Upas15','<%=lblSelfas15.ClientID %>','<%=lblSecas15.ClientID %>')" /> </td>
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
                           <input type="text" id="Upas16" name="Upas16" class="Input1" onblur="Score('Upas16','<%=lblSelfas16.ClientID %>','<%=lblSecas16.ClientID %>')" /> </td>
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
                          <input type="text" id="Upas17" name="Upas17" class="Input1" onblur="Score('Upas17','<%=lblSelfas17.ClientID %>','<%=lblSecas17.ClientID %>')" />  </td>
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
                           <input type="text" id="Upas18" name="Upas18" class="Input1" onblur="Score('Upas18','<%=lblSelfas18.ClientID %>','<%=lblSecas18.ClientID %>')" /> </td>
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
                           <input type="text" id="Upas19" name="Upas19" class="Input1" onblur="Score('Upas19','<%=lblSelfas19.ClientID %>','<%=lblSecas19.ClientID %>')" /> </td>
                        <td>
                            <asp:Label ID="lblSecas19" runat="server"></asp:Label></td>
                        <td>
                            5</td>
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
            <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
        </tr>
    </table> 
</asp:Content>
