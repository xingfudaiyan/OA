<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NurseScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master"  Inherits="OA.Score.NurseScoreDetail" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
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
                        <td><asp:Label ID="lblUpns1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                工作不偷懒、不倦怠</span></td>
                        <td><asp:Label ID="lblSelfns2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns2" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    做事敏捷、效率高</span></td>
                            <td><asp:Label ID="lblSelfns3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpns3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectns3" runat="server"></asp:Label></td>
                            <td>8</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 遵守上司的指示</span></td>
                            <td><asp:Label ID="lblSelfns4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpns4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectns4" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>不倦怠，且正确地向上司报告</span></td>
                            <td><asp:Label ID="lblSelfns5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpns5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectns5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="4">基础能力</td>
                        <td colspan="4">精通职务内容，具备处理份内工作的能力</td>
                        <td><asp:Label ID="lblSelfns6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns6" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">工作习惯和方法</td>
                        <td><asp:Label ID="lblSelfns7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns7" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">工作效率</td>
                        <td><asp:Label ID="lblSelfns8" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns8" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns8" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">严守公司纪律，纪律性、保密性</td>
                        <td><asp:Label ID="lblSelfns9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns9" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">业务磨练程度</td>
                        <td colspan="4">完成每天中午员工用餐，及计划每日菜单</td>
                         <td ><asp:Label ID="lblSelfns10" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpns10" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectns10" runat="server"></asp:Label></td>
                        <td >8</td>
                       </tr>
                       <tr>
                        <td colspan="4">好环境卫生工作</td>
                        <td><asp:Label ID="lblSelfns11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns11" runat="server"></asp:Label></td>
                        <td>8</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">做好公司绿化环境及鱼缸维护清洁工作作</td>
                        <td><asp:Label ID="lblSelfns12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns12" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">做好领导交办的临时工作</td>
                        <td><asp:Label ID="lblSelfns13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns13" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">责任感强</td>
                         <td ><asp:Label ID="lblSelfns14" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpns14" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectns14" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">勇于面对和承担新任务</td>
                        <td><asp:Label ID="lblSelfns15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns15" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">严谨细致</td>
                        <td><asp:Label ID="lblSelfns16" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns16" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns16" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                  
                   <tr>
                        <td rowspan="3">协调性</td>
                        <td colspan="4">能与其他同事和睦相处</td>
                         <td ><asp:Label ID="lblSelfns17" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpns17" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectns17" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">乐于帮助同事，积极参与并协助其他部门完成相关任务</td>
                        <td><asp:Label ID="lblSelfns18" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns18" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns18" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">沟通能力</td>
                        <td><asp:Label ID="lblSelfns19" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns19" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns19" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td rowspan="4">自我启发</td>
                        <td colspan="4">
                            <span style="font-size: 9pt; layout-grid-mode: line; font-family: 汉仪中黑简; mso-hansi-font-family: 'Times New Roman';
                                mso-bidi-font-family: 'Times New Roman'; mso-ansi-language: EN-GB; mso-fareast-language: ZH-CN;
                                mso-bidi-language: AR-SA">审查自己的能力，并学习新的菜谱，更好的营养搭配，满足员工的各种口味需求</span></td>
                         <td ><asp:Label ID="lblSelfns20" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpns20" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectns20" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">正确看待看自己与公司的未来</td>
                        <td><asp:Label ID="lblSelfns21" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns21" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns21" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">自我调整情绪</td>
                        <td><asp:Label ID="lblSelfns22" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns22" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns22" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                        <td colspan="4">即使是自己份外的事，也能主动承担</td>
                        <td><asp:Label ID="lblSelfns23" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpns23" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectns23" runat="server"></asp:Label></td>
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
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"   /></td>
        </tr>
    </table> 
</asp:Content>

