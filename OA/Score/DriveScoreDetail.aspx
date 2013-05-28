<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriveScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.DriveScoreDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
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
                        <td><asp:Label ID="lblUpds1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                工作不偷懒、不倦怠</span></td>
                        <td><asp:Label ID="lblSelfds2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds2" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    做事敏捷、效率高</span></td>
                            <td><asp:Label ID="lblSelfds3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpds3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectds3" runat="server"></asp:Label></td>
                            <td>8</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 遵守上司的指示</span></td>
                            <td><asp:Label ID="lblSelfds4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpds4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectds4" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>不倦怠，且正确地向上司报告</span></td>
                            <td><asp:Label ID="lblSelfds5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpds5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectds5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="4">基础能力</td>
                        <td colspan="4">精通职务内容，具备处理份内工作的能力</td>
                        <td><asp:Label ID="lblSelfds6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds6" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">工作习惯和方法</td>
                        <td><asp:Label ID="lblSelfds7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds7" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">工作效率</td>
                        <td><asp:Label ID="lblSelfds8" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds8" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds8" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">严守公司纪律，纪律性、保密性</td>
                        <td><asp:Label ID="lblSelfds9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds9" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">业务磨练程度</td>
                        <td colspan="4">完成每天领导及员工的出车任务</td>
                         <td ><asp:Label ID="lblSelfds10" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpds10" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectds10" runat="server"></asp:Label></td>
                        <td >8</td>
                       </tr>
                       <tr>
                        <td colspan="4">对出车前做好前期准备。如：查看好路线</td>
                        <td><asp:Label ID="lblSelfds11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds11" runat="server"></asp:Label></td>
                        <td>8</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">做好公司车辆清洁工作</td>
                        <td><asp:Label ID="lblSelfds12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds12" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds12" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">做好领导交办的临时工作</td>
                        <td><asp:Label ID="lblSelfds13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds13" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">责任感强</td>
                         <td ><asp:Label ID="lblSelfds14" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpds14" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectds14" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">勇于面对和承担新任务</td>
                        <td><asp:Label ID="lblSelfds15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds15" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">严谨细致</td>
                        <td><asp:Label ID="lblSelfds16" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds16" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds16" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                  
                   <tr>
                        <td rowspan="3">协调性</td>
                        <td colspan="4">能与其他同事和睦相处</td>
                         <td ><asp:Label ID="lblSelfds17" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpds17" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectds17" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">乐于帮助同事，积极参与并协助其他部门完成相关任务</td>
                        <td><asp:Label ID="lblSelfds18" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds18" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds18" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">沟通能力</td>
                        <td><asp:Label ID="lblSelfds19" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds19" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds19" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td rowspan="4">自我启发</td>
                        <td colspan="4">审查自己的能力，并时常查阅地图熟悉江浙沪地带路线</td>
                         <td ><asp:Label ID="lblSelfds20" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpds20" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectds20" runat="server"></asp:Label></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">正确看待看自己与公司的未来</td>
                        <td><asp:Label ID="lblSelfds21" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds21" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds21" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">自我调整情绪</td>
                        <td><asp:Label ID="lblSelfds22" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds22" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds22" runat="server"></asp:Label></td>
                        <td>3</td>
                       </tr>
                        <tr>
                        <td colspan="4">即使是自己份外的事，也能主动承担</td>
                        <td><asp:Label ID="lblSelfds23" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpds23" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectds23" runat="server"></asp:Label></td>
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

