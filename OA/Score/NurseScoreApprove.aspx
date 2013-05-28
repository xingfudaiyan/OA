<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NurseScoreApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.NurseScoreApprove" %>

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
           if(document.getElementById("<%=lblSecns1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns1.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecns2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns2.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns3.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns4.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns5.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns6.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns7.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns8.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns8.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns9.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns10.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns11.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns12.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns13.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns14.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns14.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns15.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns15.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns16.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns16.ClientID %>").innerText="0";
           }
            
           if(document.getElementById("<%=lblSecns17.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns17.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns18.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns18.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns19.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns19.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns20.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns20.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns21.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns21.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecns22.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns22.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecns23.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecns23.ClientID %>").innerText="0";
           }
           var x1=parseFloat(document.getElementById("<%=lblSecns1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecns2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecns3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecns4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecns5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecns6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecns7.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSecns8.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSecns9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSecns10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSecns11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSecns12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSecns13.ClientID %>").innerText);
           var x14=parseFloat(document.getElementById("<%=lblSecns14.ClientID %>").innerText);
           var x15=parseFloat(document.getElementById("<%=lblSecns15.ClientID %>").innerText);
           var x16=parseFloat(document.getElementById("<%=lblSecns16.ClientID %>").innerText);
           var x17=parseFloat(document.getElementById("<%=lblSecns17.ClientID %>").innerText);
           var x18=parseFloat(document.getElementById("<%=lblSecns18.ClientID %>").innerText);
           var x19=parseFloat(document.getElementById("<%=lblSecns19.ClientID %>").innerText);
           var x20=parseFloat(document.getElementById("<%=lblSecns20.ClientID %>").innerText);
           var x21=parseFloat(document.getElementById("<%=lblSecns21.ClientID %>").innerText);
           var x22=parseFloat(document.getElementById("<%=lblSecns22.ClientID %>").innerText);
           var x23=parseFloat(document.getElementById("<%=lblSecns23.ClientID %>").innerText);
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x8+x9+x10+x11+x12+x13+x14+x15+x16+x17+x18+x19+x20+x21+x22+x23).toFixed(2);
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
            <tr><td><h3>后勤绩效考核表</h3></td></tr>
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
                        <td><asp:Label ID="lblSelfns1" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns1" name="Upns1" class="Input1" onblur="Score('Upns1','<%=lblSelfns1.ClientID %>','<%=lblSecns1.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                工作不偷懒、不倦怠</span></td>
                        <td><asp:Label ID="lblSelfns2" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns2" name="Upns2" class="Input1" onblur="Score('Upns2','<%=lblSelfns2.ClientID %>','<%=lblSecns2.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns2" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    做事敏捷、效率高</span></td>
                            <td><asp:Label ID="lblSelfns3" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upns3" name="Upns3" class="Input1" onblur="Score('Upns3','<%=lblSelfns3.ClientID %>','<%=lblSecns3.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecns3" runat="server"></asp:Label></td>
                            <td>8</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 遵守上司的指示</span></td>
                            <td><asp:Label ID="lblSelfns4" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upns4" name="Upns4" class="Input1" onblur="Score('Upns4','<%=lblSelfns4.ClientID %>','<%=lblSecns4.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecns4" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>不倦怠，且正确地向上司报告</span></td>
                            <td><asp:Label ID="lblSelfns5" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upns5" name="Upns5" class="Input1" onblur="Score('Upns5','<%=lblSelfns5.ClientID %>','<%=lblSecns5.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecns5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="4">基础能力</td>
                        <td colspan="4">精通职务内容，具备处理份内工作的能力</td>
                        <td><asp:Label ID="lblSelfns6" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns6" name="Upns6" class="Input1" onblur="Score('Upns6','<%=lblSelfns6.ClientID %>','<%=lblSecns6.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns6" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">工作习惯和方法</td>
                        <td><asp:Label ID="lblSelfns7" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns7" name="Upns7" class="Input1" onblur="Score('Upns7','<%=lblSelfns7.ClientID %>','<%=lblSecns7.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns7" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">工作效率</td>
                        <td><asp:Label ID="lblSelfns8" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns8" name="Upns8" class="Input1" onblur="Score('Upns8','<%=lblSelfns8.ClientID %>','<%=lblSecns8.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns8" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">严守公司纪律，纪律性、保密性</td>
                        <td><asp:Label ID="lblSelfns9" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns9" name="Upns9" class="Input1" onblur="Score('Upns9','<%=lblSelfns9.ClientID %>','<%=lblSecns9.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns9" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">业务磨练程度</td>
                        <td colspan="4">完成每天中午员工用餐，及计划每日菜单</td>
                         <td><asp:Label ID="lblSelfns10" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns10" name="Upns10" class="Input1" onblur="Score('Upns10','<%=lblSelfns10.ClientID %>','<%=lblSecns10.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns10" runat="server"></asp:Label></td>
                        <td >8</td>
                       </tr>
                       <tr>
                        <td colspan="4">做好环境卫生工作</td>
                        <td><asp:Label ID="lblSelfns11" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns11" name="Upns11" class="Input1" onblur="Score('Upns11','<%=lblSelfns11.ClientID %>','<%=lblSecns11.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns11" runat="server"></asp:Label></td>
                        <td>8</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">做好公司绿化环境及鱼缸维护清洁工作</td>
                        <td><asp:Label ID="lblSelfns12" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns12" name="Upns12" class="Input1" onblur="Score('Upns12','<%=lblSelfns12.ClientID %>','<%=lblSecns12.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns12" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">做好领导交办的临时工作</td>
                        <td><asp:Label ID="lblSelfns13" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns13" name="Upns13" class="Input1" onblur="Score('Upns13','<%=lblSelfns13.ClientID %>','<%=lblSecns13.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns13" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">责任感强</td>
                         <td><asp:Label ID="lblSelfns14" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns14" name="Upns14" class="Input1" onblur="Score('Upns14','<%=lblSelfns14.ClientID %>','<%=lblSecns14.ClientID %>')"/></td>
                        <td><asp:Label ID="lblSecns14" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">勇于面对和承担新任务</td>
                        <td><asp:Label ID="lblSelfns15" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns15" name="Upns15" class="Input1" onblur="Score('Upns15','<%=lblSelfns15.ClientID %>','<%=lblSecns15.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns15" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">严谨细致</td>
                        <td><asp:Label ID="lblSelfns16" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns16" name="Upns16" class="Input1" onblur="Score('Upns16','<%=lblSelfns16.ClientID %>','<%=lblSecns16.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns16" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                  
                   <tr>
                        <td rowspan="3">协调性</td>
                        <td colspan="4">能与其他同事和睦相处</td>
                         <td><asp:Label ID="lblSelfns17" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns17" name="Upns17" class="Input1" onblur="Score('Upns17','<%=lblSelfns17.ClientID %>','<%=lblSecns17.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns17" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">乐于帮助同事，积极参与并协助其他部门完成相关任务</td>
                        <td><asp:Label ID="lblSelfns18" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns18" name="Upns18" class="Input1" onblur="Score('Upns18','<%=lblSelfns18.ClientID %>','<%=lblSecns18.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns18" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">沟通能力</td>
                        <td><asp:Label ID="lblSelfns19" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns19" name="Upns19" class="Input1" onblur="Score('Upns19','<%=lblSelfns19.ClientID %>','<%=lblSecns19.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns19" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td rowspan="4">自我启发</td>
                        <td colspan="4">
                            <span style="font-size: 9pt; layout-grid-mode: line; font-family: 汉仪中黑简; mso-hansi-font-family: 'Times New Roman';
                                mso-bidi-font-family: 'Times New Roman'; mso-ansi-language: EN-GB; mso-fareast-language: ZH-CN;
                                mso-bidi-language: AR-SA">审查自己的能力，并学习新的菜谱，更好的营养搭配，满足员工的各种口味需求</span></td>
                         <td><asp:Label ID="lblSelfns20" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns20" name="Upns20" class="Input1" onblur="Score('Upns20','<%=lblSelfns20.ClientID %>','<%=lblSecns20.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns20" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">正确看待看自己与公司的未来</td>
                        <td><asp:Label ID="lblSelfns21" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns21" name="Upns21" class="Input1" onblur="Score('Upns21','<%=lblSelfns21.ClientID %>','<%=lblSecns21.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns21" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">自我调整情绪</td>
                        <td><asp:Label ID="lblSelfns22" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns22" name="Upns22" class="Input1" onblur="Score('Upns22','<%=lblSelfns22.ClientID %>','<%=lblSecns22.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns22" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                        <td colspan="4">即使是自己份外的事，也能主动承担</td>
                        <td><asp:Label ID="lblSelfns23" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upns23" name="Upns23" class="Input1" onblur="Score('Upns23','<%=lblSelfns23.ClientID %>','<%=lblSecns23.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecns23" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td>总分</td>
                        <td colspan="7"><input type="hidden" id="hid" name="hid" ><asp:Label ID="lblTotalScore" runat="server"></asp:Label></td>
                        <td>100</td>
                       </tr>
                       <tr>
                        <td>评价等级</td>
                        <td colspan="8"><asp:Label ID="lblLevel" runat="server"></asp:Label>
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
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"   /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"   /></td>
        </tr>
    </table> 
</asp:Content>