<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master"  CodeBehind="ManagerApprove.aspx.cs" Inherits="OA.ProjectCreate.ManagerApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank"  style=" width:100%;">
        <tr>
            <td colspan="2"><h1>
                销售立项申请表</h1></td>
        </tr>
         <tr>
            <td style="text-align:right;" colspan="2">表单编号: <asp:Label ID="lblSheetNums" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="16%">申请人</td>
                <td width="17%"><asp:Label ID="lblApplyName" runat="server" Text=""></asp:Label></td>
                <td width="16%">申请部门</td>
                <td width="17%"><asp:Label ID="lblApplyDepart" runat="server" ></asp:Label></td>
                <td width="16%">申请日期</td>
                <td width="17%"><asp:Label ID="lblApplyDate" runat="server" ></asp:Label></td>
            </tr>
            
             <tr>
               <td>客户名称<span style="color:Red;">*</span></td>
               <td><asp:Label ID="lblClientName" runat="server"></asp:Label></td>
               <td>项目编号</td>
               <td><asp:Label ID="lblProjectNum" runat="server"></asp:Label></td>
               <td>项目名称<span style="color:Red;">*</span></td>
               <td><asp:Label ID="lblProjectFullName" runat="server"></asp:Label></td>
             </tr>
             <tr>
               <td>项目级别<span style="color:Red;">*</span></td>
               <td colspan="2"><asp:Label ID="lblProjectLevel" runat="server"></asp:Label></td>
               <td>项目类别<span style="color:Red;">*</span></td>
               <td colspan="2"><asp:Label ID="lblProjectType" runat="server"></asp:Label></td>
             </tr>
              <tr>
                <td>业务类型</td>
                <td colspan="5">
                    <asp:Label ID="lblYewu" runat="server"></asp:Label>
                </td>
             </tr>
            <tr>
               <td>预计金额</td>
                <td colspan="2"><asp:Label ID="lblPredictMoney" runat="server"></asp:Label></td>
                <td>预计毛利</td>
                <td colspan="2"><asp:Label ID="lblPredictProfit" runat="server"></asp:Label></td>
            </tr>
            
            <tr>
                <td rowspan="2">预计销售费用</td>
                 <td>立项阶段</td>
                 <td>提案阶段</td>
                 <td>招投标阶段</td>
                 <td>谈判阶段</td>
                 <td>实施阶段</td>
            </tr>
            <tr>
               <td><asp:Label ID="lblCratePhaseExp" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblProposePhaseExp" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblCallBidPhaseExp" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblTalkPhaseExp" runat="server"></asp:Label></td>
                <td><asp:Label ID="lblCarryPhaseExp" runat="server"></asp:Label></td>
            </tr>
             <tr>
                <td colspan="6">项目描述</td>
            </tr>
             <tr>
                            <td>需求方面</td>
                            <td colspan="5"><asp:Label ID="txtNeedDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>竞争方面</td>
                            <td colspan="5"><asp:Label ID="txtCompitDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>客户关系方面</td>
                            <td colspan="5"><asp:Label ID="txtClientDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>技术方面</td>
                            <td colspan="5"><asp:Label ID="txtTechDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>商务方面</td>
                            <td colspan="5"><asp:Label ID="txtBusinessDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>风险方面</td>
                            <td colspan="5"><asp:Label ID="txtRiskDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>战略价值</td>
                            <td colspan="5"><asp:Label ID="txtStrategyDes" runat="server"></asp:Label></td>
                        </tr>
                         <tr>
                            <td>备注</td>
                            <td colspan="5"><asp:Label ID="txtMemo" runat="server"></asp:Label></td>
                        </tr>
            <tr>
                <td rowspan="2">审批</td>
                <td colspan="5">
                    <table class="Tb_Common" style="text-align:center;">
                        <tr>
                             <td>市场部意见</td>
                             <td>技术部意见</td>
                             <td>总经理意见</td>
                        </tr>
                        <tr>
                           <td><asp:TextBox ID="txtMarketView" runat="server" TextMode="MultiLine" ></asp:TextBox></td>
                            <td><asp:TextBox ID="txtTechView" runat="server" TextMode="MultiLine" ></asp:TextBox></td>
                            <td><asp:TextBox ID="txtManagerView" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                    </table>
                    
                </td>
            </tr>
        </table>
        
        </td>
        </tr>
    </table>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
             <td style="padding-left:65%;">
                  <asp:RadioButtonList ID="rblOver" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0">修正</asp:ListItem>
                        <asp:ListItem Value="1">通过</asp:ListItem>
                  </asp:RadioButtonList>
             </td>
             
        </tr>
</table>
<table class="Tb_Blank" style="width:100%;">
    <tr>
            <td>
               <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"    />
            </td> 
            <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td> 
        </tr>  
</table>
</asp:Content>
        
      


