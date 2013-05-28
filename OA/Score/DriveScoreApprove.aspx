<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriveScoreApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.DriveScoreApprove" %>
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
           if(document.getElementById("<%=lblSecds1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds1.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecds2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds2.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds3.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds4.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds5.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds6.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds7.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds8.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds8.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds9.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds10.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds11.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds12.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds13.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds14.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds14.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds15.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds15.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds16.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds16.ClientID %>").innerText="0";
           }
            
           if(document.getElementById("<%=lblSecds17.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds17.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds18.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds18.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds19.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds19.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds20.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds20.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds21.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds21.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecds22.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds22.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecds23.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecds23.ClientID %>").innerText="0";
           }
           var x1=parseFloat(document.getElementById("<%=lblSecds1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecds2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecds3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecds4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecds5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecds6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecds7.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSecds8.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSecds9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSecds10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSecds11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSecds12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSecds13.ClientID %>").innerText);
           var x14=parseFloat(document.getElementById("<%=lblSecds14.ClientID %>").innerText);
           var x15=parseFloat(document.getElementById("<%=lblSecds15.ClientID %>").innerText);
           var x16=parseFloat(document.getElementById("<%=lblSecds16.ClientID %>").innerText);
           var x17=parseFloat(document.getElementById("<%=lblSecds17.ClientID %>").innerText);
           var x18=parseFloat(document.getElementById("<%=lblSecds18.ClientID %>").innerText);
           var x19=parseFloat(document.getElementById("<%=lblSecds19.ClientID %>").innerText);
           var x20=parseFloat(document.getElementById("<%=lblSecds20.ClientID %>").innerText);
           var x21=parseFloat(document.getElementById("<%=lblSecds21.ClientID %>").innerText);
           var x22=parseFloat(document.getElementById("<%=lblSecds22.ClientID %>").innerText);
           var x23=parseFloat(document.getElementById("<%=lblSecds23.ClientID %>").innerText);
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
            <tr><td><h3>司机绩效考核表</h3></td></tr>
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
                        <td><asp:Label ID="lblSelfds1" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds1" name="Upds1" class="Input1" onblur="Score('Upds1','<%=lblSelfds1.ClientID %>','<%=lblSecds1.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                工作不偷懒、不倦怠</span></td>
                        <td><asp:Label ID="lblSelfds2" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds2" name="Upds2" class="Input1" onblur="Score('Upds2','<%=lblSelfds2.ClientID %>','<%=lblSecds2.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds2" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    做事敏捷、效率高</span></td>
                            <td><asp:Label ID="lblSelfds3" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upds3" name="Upds3" class="Input1" onblur="Score('Upds3','<%=lblSelfds3.ClientID %>','<%=lblSecds3.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecds3" runat="server"></asp:Label></td>
                            <td>8</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 遵守上司的指示</span></td>
                            <td><asp:Label ID="lblSelfds4" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upds4" name="Upds4" class="Input1" onblur="Score('Upds4','<%=lblSelfds4.ClientID %>','<%=lblSecds4.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecds4" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>不倦怠，且正确地向上司报告</span></td>
                            <td><asp:Label ID="lblSelfds5" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upds5" name="Upds5" class="Input1" onblur="Score('Upds5','<%=lblSelfds5.ClientID %>','<%=lblSecds5.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSecds5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="4">基础能力</td>
                        <td colspan="4">精通职务内容，具备处理份内工作的能力</td>
                        <td><asp:Label ID="lblSelfds6" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds6" name="Upds6" class="Input1" onblur="Score('Upds6','<%=lblSelfds6.ClientID %>','<%=lblSecds6.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds6" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">工作习惯和方法</td>
                        <td><asp:Label ID="lblSelfds7" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds7" name="Upds7" class="Input1" onblur="Score('Upds7','<%=lblSelfds7.ClientID %>','<%=lblSecds7.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds7" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">工作效率</td>
                        <td><asp:Label ID="lblSelfds8" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds8" name="Upds8" class="Input1" onblur="Score('Upds8','<%=lblSelfds8.ClientID %>','<%=lblSecds8.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds8" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">严守公司纪律，纪律性、保密性</td>
                        <td><asp:Label ID="lblSelfds9" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds9" name="Upds9" class="Input1" onblur="Score('Upds9','<%=lblSelfds9.ClientID %>','<%=lblSecds9.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds9" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">业务磨练程度</td>
                        <td colspan="4">完成每天领导及员工的出车任务</td>
                         <td><asp:Label ID="lblSelfds10" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds10" name="Upds10" class="Input1" onblur="Score('Upds10','<%=lblSelfds10.ClientID %>','<%=lblSecds10.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds10" runat="server"></asp:Label></td>
                        <td >8</td>
                       </tr>
                       <tr>
                        <td colspan="4">对出车前做好前期准备。如：查看好路线</td>
                        <td><asp:Label ID="lblSelfds11" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds11" name="Upds11" class="Input1" onblur="Score('Upds11','<%=lblSelfds11.ClientID %>','<%=lblSecds11.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds11" runat="server"></asp:Label></td>
                        <td>8</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">做好公司车辆清洁工作</td>
                        <td><asp:Label ID="lblSelfds12" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds12" name="Upds12" class="Input1" onblur="Score('Upds12','<%=lblSelfds12.ClientID %>','<%=lblSecds12.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds12" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">做好领导交办的临时工作</td>
                        <td><asp:Label ID="lblSelfds13" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds13" name="Upds13" class="Input1" onblur="Score('Upds13','<%=lblSelfds13.ClientID %>','<%=lblSecds13.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds13" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">责任感强</td>
                         <td><asp:Label ID="lblSelfds14" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds14" name="Upds14" class="Input1" onblur="Score('Upds14','<%=lblSelfds14.ClientID %>','<%=lblSecds14.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds14" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">勇于面对和承担新任务</td>
                        <td><asp:Label ID="lblSelfds15" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds15" name="Upds15" class="Input1" onblur="Score('Upds15','<%=lblSelfds15.ClientID %>','<%=lblSecds15.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds15" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">严谨细致</td>
                        <td><asp:Label ID="lblSelfds16" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds16" name="Upds16" class="Input1" onblur="Score('Upds16','<%=lblSelfds16.ClientID %>','<%=lblSecds16.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds16" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                  
                   <tr>
                        <td rowspan="3">协调性</td>
                        <td colspan="4">能与其他同事和睦相处</td>
                         <td><asp:Label ID="lblSelfds17" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds17" name="Upds17" class="Input1" onblur="Score('Upds17','<%=lblSelfds17.ClientID %>','<%=lblSecds17.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds17" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">乐于帮助同事，积极参与并协助其他部门完成相关任务</td>
                        <td><asp:Label ID="lblSelfds18" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds18" name="Upds18" class="Input1" onblur="Score('Upds18','<%=lblSelfds18.ClientID %>','<%=lblSecds18.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds18" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">沟通能力</td>
                        <td><asp:Label ID="lblSelfds19" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds19" name="Upds19" class="Input1" onblur="Score('Upds19','<%=lblSelfds19.ClientID %>','<%=lblSecds19.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds19" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td rowspan="4">自我启发</td>
                        <td colspan="4">审查自己的能力，并时常查阅地图熟悉江浙沪地带路线</td>
                         <td><asp:Label ID="lblSelfds20" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds20" name="Upds20" class="Input1" onblur="Score('Upds20','<%=lblSelfds20.ClientID %>','<%=lblSecds20.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds20" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">正确看待看自己与公司的未来</td>
                        <td><asp:Label ID="lblSelfds21" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds21" name="Upds21" class="Input1" onblur="Score('Upds21','<%=lblSelfds21.ClientID %>','<%=lblSecds21.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds21" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">自我调整情绪</td>
                        <td><asp:Label ID="lblSelfds22" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds22" name="Upds22" class="Input1" onblur="Score('Upds22','<%=lblSelfds22.ClientID %>','<%=lblSecds22.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds22" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                        <td colspan="4">即使是自己份外的事，也能主动承担</td>
                        <td><asp:Label ID="lblSelfds23" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upds23" name="Upds23" class="Input1" onblur="Score('Upds23','<%=lblSelfds23.ClientID %>','<%=lblSecds23.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecds23" runat="server"></asp:Label></td>
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
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"  /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>
