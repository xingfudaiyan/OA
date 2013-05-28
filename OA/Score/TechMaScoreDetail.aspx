<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechMaScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.TechMaScoreDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
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
                            <td><asp:Label ID="lblSelfScore1" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpScore1" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectScore1" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                       <tr>
                            <td colspan="4">项目质量满足合同需求</td>
                            <td>
                                <asp:Label ID="lblSelfScore2" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore2" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore2" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                       <tr>
                            <td colspan="4">项目进行中技术的成本节约</td>
                            <td>
                                <asp:Label ID="lblSelfScore3" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore3" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore3" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">实施过程中符合相关技术流程</td>
                            <td>
                                <asp:Label ID="lblSelfScore4" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore4" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore4" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td rowspan="4">团队管理及协作</td>
                            <td colspan="4">相关工程师工作的合理分配</td>
                            <td>
                                <asp:Label ID="lblSelfScore5" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore5" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore5" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td colspan="4">内部培训</td>
                            <td>
                                <asp:Label ID="lblSelfScore6" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore6" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore6" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">技术部相关流程的制订及监督执行	</td>
                            <td>
                                <asp:Label ID="lblSelfScore7" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore7" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore7" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="4">相关部门的团队协作</td>
                            <td>
                                <asp:Label ID="lblSelfScore8" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore8" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore8" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                       <tr>
                            <td rowspan="3">客户服务</td>
                            <td colspan="4">客户服务流程的修订和完善</td>
                            <td>
                                <asp:Label ID="lblSelfScore9" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore9" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore9" runat="server"></asp:Label></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td colspan="4">故障管理</td>
                            <td>
                                <asp:Label ID="lblSelfScore10" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore10" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore10" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="4">客户服务流程的监督执行</td>
                            <td>
                                <asp:Label ID="lblSelfScore11" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore11" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore11" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                         <tr>
                            <td rowspan="2">产品调研<br />及技术开发</td>
                            <td colspan="4">新产品市场调研</td>
                            <td>
                                <asp:Label ID="lblSelfScore12" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore12" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore12" runat="server"></asp:Label></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td colspan="4">现有产品的提供商的维护</td>
                            <td>
                                <asp:Label ID="lblSelfScore13" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblUpScore13" runat="server"></asp:Label></td>
                            <td>
                                <asp:Label ID="lblSectScore13" runat="server"></asp:Label></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="2">总分</td>
                            <td colspan="7"><asp:Label ID="lblSumScore" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td colspan="2">评价等级</td>
                            <td colspan="7">
                                <asp:Label ID="lblLevel" runat="server"></asp:Label>
                            </td>
                        </tr>
                         <tr>
                            <td colspan="2">评价者<br />综合意见</td>
                            <td colspan="7"><asp:Label ID="lblViews" runat="server"></asp:Label></td>
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
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
        </tr>
    </table> 
</asp:Content>
