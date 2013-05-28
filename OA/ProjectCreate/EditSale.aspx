<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="EditSale.aspx.cs" Inherits="OA.ProjectCreate.EditSale" %>

   <asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style=" width:100%;">
        <tr>
            <td colspan="2"><h1>
                销售立项申请表</h1></td>
        </tr>
        <tr>
            <td style="text-align:right;" colspan="2">表单编号：<span style="color:Red;">*</span><asp:TextBox ID="txtSheetNum" runat="server" SkinID="skinid4" ReadOnly="true"></asp:TextBox>  
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <table class="Tb_Common" style="text-align:center;">
                    <tr>
                            <td width="16%">申请人</td>
                            <td width="17%"><asp:Label ID="lblApplyName" runat="server" Text=""></asp:Label></td>
                            <td width="16%">申请部门</td>
                            <td width="17%"><asp:Label ID="lblApplyDepart" runat="server"></asp:Label></td>
                            <td width="16%">申请日期<span style="color:Red;">*</span> </td>
                            <td width="17%">
                            <asp:TextBox ID="txtApplyDate" runat="server" onclick="WdatePicker()" SkinID="skinid5"  ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="valrDate" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>客户名称<span style="color:Red;">*</span></td>
                            <td><asp:DropDownList ID="ddlClient" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlClient_SelectedIndexChanged"></asp:DropDownList></td>
                            <td>项目编号</td>
                            <td><asp:Label ID="lblProjectNum" runat="server"></asp:Label></td>
                            <td>项目名称<span style="color:Red;">*</span></td>
                            <td>
                                <asp:TextBox ID="txtProjectName" runat="server" SkinID="skinid5"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="valR" runat="server" ErrorMessage="必填" ControlToValidate="txtProjectName"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td>项目级别<span style="color:Red;">*</span></td>
                             <td colspan="2"><asp:DropDownList ID="ddlProjectLevel" runat="server" SkinID="ddl1"></asp:DropDownList></td>
                             <td>项目类别<span style="color:Red;">*</span></td>
                             <td colspan="2"><asp:DropDownList ID="ddlProjectType" runat="server" SkinID="ddl1"></asp:DropDownList></td>
                        </tr>
                         <tr>
                            <td>业务类型</td>
                            <td colspan="5"><asp:DropDownList ID="ddlYewu" runat="server"></asp:DropDownList></td>
                        </tr>
                        <tr>
                           <td>预计金额</td>
                            <td colspan="2"><asp:TextBox ID="txtPreMoney" runat="server" SkinID="skinid1"></asp:TextBox></td>
                            <td>预计毛利</td>
                            <td colspan="2"><asp:TextBox ID="txtPreProfit" runat="server" SkinID="skinid1"></asp:TextBox></td>
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
                           <td><asp:TextBox ID="txtCratePhaseExp" runat="server" SkinID="skinid1"></asp:TextBox></td>
                            <td><asp:TextBox ID="txtProposePhaseExp" runat="server" SkinID="skinid1"></asp:TextBox></td>
                            <td><asp:TextBox ID="txtCallBidPhaseExp" runat="server" SkinID="skinid1"></asp:TextBox></td>
                            <td><asp:TextBox ID="txtTalkPhaseExp" runat="server" SkinID="skinid1"></asp:TextBox></td>
                            <td><asp:TextBox ID="txtCarryPhaseExp" runat="server" SkinID="skinid1"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td colspan="6">项目描述</td>
                        </tr>
                         <tr>
                            <td>需求方面</td>
                            <td colspan="5"><asp:TextBox ID="txtNeedDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>竞争方面</td>
                            <td colspan="5"><asp:TextBox ID="txtCompitDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>客户关系方面</td>
                            <td colspan="5"><asp:TextBox ID="txtClientDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>技术方面</td>
                            <td colspan="5"><asp:TextBox ID="txtTechDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>商务方面</td>
                            <td colspan="5"><asp:TextBox ID="txtBusinessDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>风险方面</td>
                            <td colspan="5"><asp:TextBox ID="txtRiskDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>战略价值</td>
                            <td colspan="5"><asp:TextBox ID="txtStrategyDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                        </tr>
                         <tr>
                            <td>备注</td>
                            <td colspan="5"><asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine"></asp:TextBox></td>
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
                                        <td><asp:TextBox ID="txtTechView" runat="server" TextMode="MultiLine"></asp:TextBox></td>
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
<asp:Content ID="Content2"  ContentPlaceHolderID="Content2" runat="server">
<table class="Tb_Blank" style="width:100%;">
            
             <tr>
                <td>
                     <asp:Button ID="Button1" runat="server" Text="保存"  OnClick="btnSave_Click" />
                </td>
               <td>
                   <asp:Button ID="Button2" runat="server" Text="返回"  OnClick="btnCancel_Click" ValidationGroup="btn1"/>
               </td> 
           </tr>
        </table>
</asp:Content>
    