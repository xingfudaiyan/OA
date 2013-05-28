<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TechMaScoreEdit.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.TechMaScoreEdit" %>


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
                            <td colspan="5">  <span style="color:red">*</span>
                                <asp:DropDownList ID="ddlYear" runat="server"> 
                                </asp:DropDownList>年
                                 <asp:DropDownList ID="ddlMonth" runat="server">
                                </asp:DropDownList>月
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
                            <td><input id="input1" type="text" name="Project1" class="Input1" value="<%=strbind1 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                        </tr>
                       <tr>
                            <td colspan="4">项目质量满足合同需求</td>
                            <td><input id="Text1" type="text" name="Project2" class="Input1" value="<%=strbind2 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                       <tr>
                            <td colspan="4">项目进行中技术的成本节约</td>
                            <td><input id="Text2" type="text" name="Project3" class="Input1" value="<%=strbind3 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">实施过程中符合相关技术流程</td>
                            <td><input id="Text3" type="text" name="Project4" class="Input1" value="<%=strbind4 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td rowspan="4">团队管理及协作</td>
                            <td colspan="4">相关工程师工作的合理分配</td>
                            <td><input id="Text4" type="text" name="Project5" class="Input1" value="<%=strbind5 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td colspan="4">内部培训</td>
                            <td><input id="Text5" type="text" name="Project6" class="Input1" value="<%=strbind6 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">技术部相关流程的制订及监督执行	</td>
                            <td><input id="Text6" type="text" name="Project7" class="Input1" value="<%=strbind7 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="4">相关部门的团队协作</td>
                            <td><input id="Text7" type="text" name="Project8" class="Input1" value="<%=strbind8 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                       <tr>
                            <td rowspan="3">客户服务</td>
                            <td colspan="4">客户服务流程的修订和完善</td>
                            <td><input id="Text8" type="text" name="Project9" class="Input1" value="<%=strbind9 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                        </tr>
                        <tr>
                            <td colspan="4">故障管理</td>
                            <td><input id="Text9" type="text" name="Project10" class="Input1" value="<%=strbind10 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="4">客户服务流程的监督执行</td>
                            <td><input id="Text10" type="text" name="Project11" class="Input1" value="<%=strbind11 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                         <tr>
                            <td rowspan="2">产品调研<br />及技术开发</td>
                            <td colspan="4">新产品市场调研</td>
                            <td><input id="Text11" type="text" name="Project12" class="Input1" value="<%=strbind12 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                        </tr>
                         <tr>
                            <td colspan="4">现有产品的提供商的维护</td>
                            <td><input id="Text12" type="text" name="Project13" class="Input1" value="<%=strbind13 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>10</td>
                       </tr>
                        <tr>
                            <td colspan="2">奖惩加/减分</td>
                            <td colspan="7"><span style=" float:left;">事由：<asp:Label ID="lblReason" runat="server"></asp:Label></span><span>分值：加/减分<asp:Label ID="lblAddMinusScore" runat="server"></asp:Label> </span> <span style="float:right;">总计本月得分<asp:Label ID="lblSumScore" runat="server"></asp:Label></span>  </td>
                        </tr>
                        <tr>
                            <td colspan="2">评价等级</td>
                            <td colspan="7">
                           
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
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>