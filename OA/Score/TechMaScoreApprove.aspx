<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechMaScoreApprove.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.ManagerTechAdd" %>

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
            var y=parseFloat(document.getElementById(str2).innerText);
            document.getElementById(str3).innerText=parseFloat(0.4*y+0.6*x).toFixed(2);
            SumScore();

        }    
        function SumScore()
        {
           if(document.getElementById("<%=lblSectProject1.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject1.ClientID %>").innerText="0";
           }
            if(document.getElementById("<%=lblSectProject2.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject2.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject3.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject3.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject4.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject4.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject5.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject5.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject6.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject6.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject7.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject7.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject8.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject8.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject9.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject9.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject10.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject10.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject11.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject11.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject12.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject12.ClientID %>").innerText="0";
           }
           if(document.getElementById("<%=lblSectProject13.ClientID %>").innerText=="")
           {
            document.getElementById("<%=lblSectProject13.ClientID %>").innerText="0";
           } 
                             
           var x1=parseFloat(document.getElementById("<%=lblSectProject1.ClientID %>").innerText);
           var x2=parseFloat(document.getElementById("<%=lblSectProject2.ClientID %>").innerText);
           var x3=parseFloat(document.getElementById("<%=lblSectProject3.ClientID %>").innerText);
           var x4=parseFloat(document.getElementById("<%=lblSectProject4.ClientID %>").innerText);
           var x5=parseFloat(document.getElementById("<%=lblSectProject5.ClientID %>").innerText);
           var x6=parseFloat(document.getElementById("<%=lblSectProject6.ClientID %>").innerText);
           var x7=parseFloat(document.getElementById("<%=lblSectProject7.ClientID %>").innerText);
           var x8=parseFloat(document.getElementById("<%=lblSectProject8.ClientID %>").innerText);
           var x9=parseFloat(document.getElementById("<%=lblSectProject9.ClientID %>").innerText);
           var x10=parseFloat(document.getElementById("<%=lblSectProject10.ClientID %>").innerText);
           var x11=parseFloat(document.getElementById("<%=lblSectProject11.ClientID %>").innerText);
           var x12=parseFloat(document.getElementById("<%=lblSectProject12.ClientID %>").innerText);
           var x13=parseFloat(document.getElementById("<%=lblSectProject13.ClientID %>").innerText);
           var sum=parseFloat(x1+x2+x3+x4+x5+x6+x7+x8+x9+x10+x11+x12+x13).toFixed(2);
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
            <tr><td><h3>技术部经理考核表</h3></td></tr>
            <tr>
                <td>
                    <table class="Tb_Common" style="width:100%;">
                        <tr>
                            <td style="width:11%;">姓名</td>
                            <td colspan="2" style="width:22%;"><asp:Label ID="lblName" runat="server"></asp:Label></td>
                            <td style="width:11%;">岗位</td>
                            <td colspan="2" style="width:22%;"><asp:Label ID="lblPosition" runat="server"></asp:Label></td>
                            <td style="width:11%;">考核人</td>
                            <td colspan="2" style="width:22%;"><asp:Label ID="lblZmanager" runat="server" Text="祁大为"></asp:Label></td>
                        </tr>
                        <tr>
                            <td>部门</td>
                            <td colspan="2">技术部</td>
                            <td>评价时间</td>
                            <td colspan="5">  
                               <asp:Label ID="lblDate" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>考核纬度<br />及项目类型</td>
                            <td colspan="4" style="width:44%;">优秀（10分） 好（8-9分） 良好（6-7）较差（4-5分）极差（1-2分）</td>
                            <td style="width:11%;">本人评</td>
                            <td style="width:11%;">上司评</td>
                            <td style="width:11%;">本栏得分</td>
                            <td style="width:11%;">满分</td>
                        </tr>
                        <tr>
                            <td rowspan="4">项目管理</td>
                            <td colspan="4">有序的进行项目管理，项目进度期内完成</td>
                            <td><asp:Label ID="lblSelfProject1" runat="server"></asp:Label></td>
                            <td><input id="project1" type="text" name="project1" class="Input1" onblur="Score('project1','<%=lblSelfProject1.ClientID %>','<%=lblSectProject1.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject1" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                       <tr>
                            <td colspan="4">项目质量满足合同需求</td>
                            <td><asp:Label ID="lblSelfProject2" runat="server"></asp:Label></td>
                            <td><input id="project2" type="text" name="project2" class="Input1" onblur="Score('project2','<%=lblSelfProject2.ClientID %>','<%=lblSectProject2.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject2" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                            <td colspan="4">项目进行中技术的成本节约</td>
                            <td><asp:Label ID="lblSelfProject3" runat="server"></asp:Label></td>
                            <td><input id="project3" type="text" name="project3" class="Input1" onblur="Score('project3','<%=lblSelfProject3.ClientID %>','<%=lblSectProject3.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject3" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">实施过程中符合相关技术流程</td>
                            <td><asp:Label ID="lblSelfProject4" runat="server"></asp:Label></td>
                            <td><input id="project4" type="text" name="project4" class="Input1" onblur="Score('project4','<%=lblSelfProject4.ClientID %>','<%=lblSectProject4.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject4" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td rowspan="4">团队管理及协作</td>
                            <td colspan="4">相关工程师工作的合理分配</td>
                            <td><asp:Label ID="lblSelfProject5" runat="server"></asp:Label></td>
                            <td><input id="project5" type="text" name="project5" class="Input1" onblur="Score('project5','<%=lblSelfProject5.ClientID %>','<%=lblSectProject5.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject5" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td colspan="4">内部培训</td>
                            <td><asp:Label ID="lblSelfProject6" runat="server"></asp:Label></td>
                            <td><input id="project6" type="text" name="project6" class="Input1" onblur="Score('project6','<%=lblSelfProject6.ClientID %>','<%=lblSectProject6.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject6" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">技术部相关流程的制订及监督执行	</td>
                            <td><asp:Label ID="lblSelfProject7" runat="server"></asp:Label></td>
                            <td><input id="project7" type="text" name="project7" class="Input1" onblur="Score('project7','<%=lblSelfProject7.ClientID %>','<%=lblSectProject7.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject7" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="4">相关部门的团队协作</td>
                            <td><asp:Label ID="lblSelfProject8" runat="server"></asp:Label></td>
                            <td><input id="project8" type="text" name="project8" class="Input1" onblur="Score('project8','<%=lblSelfProject8.ClientID %>','<%=lblSectProject8.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject8" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                       <tr>
                            <td rowspan="3">客户服务</td>
                            <td colspan="4">客户服务流程的修订和完善</td>
                            <td><asp:Label ID="lblSelfProject9" runat="server"></asp:Label></td>
                            <td><input id="project9" type="text" name="project9" class="Input1" onblur="Score('project9','<%=lblSelfProject9.ClientID %>','<%=lblSectProject9.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject9" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td colspan="4">故障管理</td>
                            <td><asp:Label ID="lblSelfProject10" runat="server"></asp:Label></td>
                            <td><input id="project10" type="text" name="project10" class="Input1" onblur="Score('project10','<%=lblSelfProject10.ClientID %>','<%=lblSectProject10.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject10" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="4">客户服务流程的监督执行</td>
                            <td><asp:Label ID="lblSelfProject11" runat="server"></asp:Label></td>
                            <td><input id="project11" type="text" name="project11" class="Input1" onblur="Score('project11','<%=lblSelfProject11.ClientID %>','<%=lblSectProject11.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject11" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                         <tr>
                            <td rowspan="2">产品调研<br />及技术开发</td>
                            <td colspan="4">新产品市场调研</td>
                            <td><asp:Label ID="lblSelfProject12" runat="server"></asp:Label></td>
                            <td><input id="project12" type="text" name="project12" class="Input1" onblur="Score('project12','<%=lblSelfProject12.ClientID %>','<%=lblSectProject12.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject12" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td colspan="4">现有产品的提供商的维护</td>
                            <td><asp:Label ID="lblSelfProject13" runat="server"></asp:Label></td>
                            <td><input id="project13" type="text" name="project13" class="Input1" onblur="Score('project13','<%=lblSelfProject13.ClientID %>','<%=lblSectProject13.ClientID %>')" /></td>
                            <td><asp:Label ID="lblSectProject13" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="2">总分</td>
                            <td colspan="7">
                            <input type="hidden" id="hid" name="hid" >
                            <asp:Label ID="lblSumScore" runat="server"></asp:Label>  
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
                            <td colspan="7"><textarea id="tViews" name="tViews" style="width:97%;"></textarea></td>
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
           <td><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>