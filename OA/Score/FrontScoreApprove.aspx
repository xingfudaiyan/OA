<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontScoreApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.FrontScoreApprove" %>

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
           if(document.getElementById("<%=lblSecfs1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs1.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSecfs2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs2.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs3.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs4.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs5.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs6.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs7.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs9.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs10.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs11.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs12.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs13.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs14.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs14.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs15.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs15.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs16.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs16.ClientID %>").innerText="0";
           }
            
           if(document.getElementById("<%=lblSecfs17.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs17.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs18.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs18.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs19.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs19.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs20.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs20.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSecfs21.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSecfs21.ClientID %>").innerText="0";
           }
            
           var x1=parseFloat(document.getElementById("<%=lblSecfs1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSecfs2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSecfs3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSecfs4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSecfs5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSecfs6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSecfs7.ClientID %>").innerText);
         
           var x9=parseFloat(document.getElementById("<%=lblSecfs9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSecfs10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSecfs11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSecfs12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSecfs13.ClientID %>").innerText);
           var x14=parseFloat(document.getElementById("<%=lblSecfs14.ClientID %>").innerText);
           var x15=parseFloat(document.getElementById("<%=lblSecfs15.ClientID %>").innerText);
           var x16=parseFloat(document.getElementById("<%=lblSecfs16.ClientID %>").innerText);
           var x17=parseFloat(document.getElementById("<%=lblSecfs17.ClientID %>").innerText);
           var x18=parseFloat(document.getElementById("<%=lblSecfs18.ClientID %>").innerText);
           var x19=parseFloat(document.getElementById("<%=lblSecfs19.ClientID %>").innerText);
           var x20=parseFloat(document.getElementById("<%=lblSecfs20.ClientID %>").innerText);
           var x21=parseFloat(document.getElementById("<%=lblSecfs21.ClientID %>").innerText);
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x9+x10+x11+x12+x13+x14+x15+x16+x17+x18+x19+x20+x21).toFixed(2);
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
            <tr><td><h3>前台绩效考核表</h3></td></tr>
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
                            <span>严格要求自己遵守公司各项规章制度，纪律性强，无随意违纪、违规现象。</span></td>
                        <td><asp:Label ID="lblSelffs1" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs1" name="Upfs1"  class="Input1"  onblur="Score('Upfs1','<%=lblSelffs1.ClientID %>','<%=lblSecfs1.ClientID %>')" /></td>
                        <td><asp:Label ID="lblSecfs1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                形象符合公司要求，衣着打扮大方得体。</span></td>
                        <td><asp:Label ID="lblSelffs2" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs2" name="Upfs2" class="Input1" onblur="Score('Upfs2','<%=lblSelffs2.ClientID %>','<%=lblSecfs2.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs2" runat="server"></asp:Label></td>
                        <td>
                            3</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    积极完成公司领导的临时任务，并能够高质量的完成。</span></td>
                            <td>
                                <asp:Label ID="lblSelffs3" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upfs3" name="Upfs3" class="Input1" onblur="Score('Upfs3','<%=lblSelffs3.ClientID %>','<%=lblSecfs3.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecfs3" runat="server"></asp:Label></td>
                            <td>
                                5</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 能够帮助同事完成各类工作，协调跨部门的各类事务。</span></td>
                            <td>
                                <asp:Label ID="lblSelffs4" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upfs4" name="Upfs4" class="Input1" onblur="Score('Upfs4','<%=lblSelffs4.ClientID %>','<%=lblSecfs4.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecfs4" runat="server"></asp:Label></td>
                            <td>
                                8</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>对工作出现的问题能够及时补救并勇于承担责任。</span></td>
                            <td>
                                <asp:Label ID="lblSelffs5" runat="server"></asp:Label></td>
                            <td><input type="text" id="Upfs5" name="Upfs5" class="Input1" onblur="Score('Upfs5','<%=lblSelffs5.ClientID %>','<%=lblSecfs5.ClientID %>')" /></td>
                            <td>
                                <asp:Label ID="lblSecfs5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="9">
                            业务能力</td>
                        <td colspan="4">监督各部门对公司相关制度的执行，对出现的问题能够及时上报。</td>
                        <td>
                            <asp:Label ID="lblSelffs6" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs6" name="Upfs6" class="Input1" onblur="Score('Upfs6','<%=lblSelffs6.ClientID %>','<%=lblSecfs6.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs6" runat="server"></asp:Label></td>
                        <td>
                            3</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">配合其他部门进行绩效考核并能及时将相关文件上报、归档。</td>
                        <td>
                            <asp:Label ID="lblSelffs7" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs7" name="Upfs7" class="Input1" onblur="Score('Upfs7','<%=lblSelffs7.ClientID %>','<%=lblSecfs7.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs7" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       
                        <tr>
                        <td colspan="4">有建设性举办各类活动，丰富员工的业余生活，提高公司凝聚力。</td>
                        <td>
                            <asp:Label ID="lblSelffs9" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs9" name="Upfs9" class="Input1" onblur="Score('Upfs9','<%=lblSelffs9.ClientID %>','<%=lblSecfs9.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs9" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">有条理，有营养的制订每周菜谱。</td>
                        <td>
                            <asp:Label ID="lblSelffs10" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs10" name="Upfs10" class="Input1" onblur="Score('Upfs10','<%=lblSelffs10.ClientID %>','<%=lblSecfs10.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs10" runat="server"></asp:Label></td>
                        <td>
                            4</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">公司重要精神、文件的及时传达</td>
                        <td>
                            <asp:Label ID="lblSelffs11" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs11" name="Upfs11" class="Input1" onblur="Score('Upfs11','<%=lblSelffs11.ClientID %>','<%=lblSecfs11.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs11" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">公司重要文件资料的管理及合理的归档，在需要时能够迅速的找到。</td>
                         <td >
                             <asp:Label ID="lblSelffs12" runat="server"></asp:Label></td>
                        <td ><input type="text" id="Upfs12" name="Upfs12" class="Input1" onblur="Score('Upfs12','<%=lblSelffs12.ClientID %>','<%=lblSecfs12.ClientID %>')" /></td>
                        <td >
                            <asp:Label ID="lblSecfs12" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">会议的准备及协助工作</td>
                        <td>
                            <asp:Label ID="lblSelffs13" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs13" name="Upfs13" class="Input1" onblur="Score('Upfs13','<%=lblSelffs13.ClientID %>','<%=lblSecfs13.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs13" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">配合公司相关部门的人员招聘工作，并能起到人事监督的作用。</td>
                        <td>
                            <asp:Label ID="lblSelffs14" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs14" name="Upfs14" class="Input1" onblur="Score('Upfs14','<%=lblSelffs14.ClientID %>','<%=lblSecfs14.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs14" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">定期的进行资产盘点，能够有效地保证固定资产的完整及无流失。</td>
                        <td>
                            <asp:Label ID="lblSelffs15" runat="server"></asp:Label></td>
                        <td ><input type="text" id="Upfs15" name="Upfs15" class="Input1" onblur="Score('Upfs15','<%=lblSelffs15.ClientID %>','<%=lblSecfs15.ClientID %>')" /></td>
                        <td >
                            <asp:Label ID="lblSecfs15" runat="server"></asp:Label></td>
                        <td >5</td>
                       </tr>
                        <tr>
                        <td rowspan="4">责任感</td>
                        <td colspan="4">积极保守公司商业秘密，并能制定相应策略或制度监督其他部门员工执行。</td>
                         <td >
                             <asp:Label ID="lblSelffs16" runat="server"></asp:Label></td>
                        <td ><input type="text" id="Upfs16" name="Upfs16" class="Input1" onblur="Score('Upfs16','<%=lblSelffs16.ClientID %>','<%=lblSecfs16.ClientID %>')" /></td>
                        <td >
                            <asp:Label ID="lblSecfs16" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督公司各类财务支出的有效性、及时性。防止因误缴、缓缴造成公司的各类损失。</td>
                        <td>
                            <asp:Label ID="lblSelffs17" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs17" name="Upfs17" class="Input1" onblur="Score('Upfs17','<%=lblSelffs17.ClientID %>','<%=lblSecfs17.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs17" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                      
                       <tr>
                        <td colspan="4">及时收发公司各类邮件，并对重要邮件或快递能够跟踪收件人是否及时收到。</td>
                        <td>
                            <asp:Label ID="lblSelffs18" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs18" name="Upfs18" class="Input1" onblur="Score('Upfs18','<%=lblSelffs18.ClientID %>','<%=lblSecfs18.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs18" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                  
                        <tr>
                        <td colspan="4">合理的保管和使用公司各类印章，对印章的使用能够有详细的清单记录。</td>
                        <td>
                            <asp:Label ID="lblSelffs19" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs19" name="Upfs19" class="Input1" onblur="Score('Upfs19','<%=lblSelffs19.ClientID %>','<%=lblSecfs19.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs19" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       
                   <tr>
                        <td rowspan="2">学习培养</td>
                        <td colspan="4">对国家行政人事法律法规能够及时理解，并为公司提供良好的指导方向。</td>
                         <td >
                             <asp:Label ID="lblSelffs20" runat="server"></asp:Label></td>
                        <td ><input type="text" id="Upfs20" name="Upfs20" class="Input1" onblur="Score('Upfs20','<%=lblSelffs20.ClientID %>','<%=lblSecfs20.ClientID %>')" /></td>
                        <td >
                            <asp:Label ID="lblSecfs20" runat="server"></asp:Label></td>
                        <td >
                            7</td>
                       </tr>
                       <tr>
                        <td colspan="4">钻研自身业务技能，提高业务水平。</td>
                        <td>
                            <asp:Label ID="lblSelffs21" runat="server"></asp:Label></td>
                        <td><input type="text" id="Upfs21" name="Upfs21" class="Input1" onblur="Score('Upfs21','<%=lblSelffs21.ClientID %>','<%=lblSecfs21.ClientID %>')" /></td>
                        <td>
                            <asp:Label ID="lblSecfs21" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                        <td>总分</td>
                        <td colspan="7">
                            <input type="hidden" id="hid" name="hid" >
                            <asp:Label ID="lblTotalScore" runat="server"></asp:Label></td>
                        <td>100</td>
                       </tr>
                       <tr>
                        <td>评价等级</td>
                        <td colspan="8">
                            <asp:Label ID="lblLevel" runat="server"></asp:Label></td>
                       </tr>
                       <tr>
                        <td>评价者综合意见</td>
                        <td colspan="8">
                            <textarea id="UpViews" name="UpViews" style="width:95%;"></textarea></td>
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
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"   /></td>
        </tr>
    </table> 
</asp:Content>
