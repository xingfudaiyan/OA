<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Apply1.Master" CodeBehind="ManagerApprove.aspx.cs" Inherits="OA.OfficeApply.ManagerApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:100%;">
            <tr>
                <td colspan="2"><h1>借/付款审批表</h1></td>
            </tr>
             <tr>
                <td colspan="2" style="text-align:right;">时间<asp:Label ID="lblApplyTime" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <table class="Tb_Common">
                        <tr>
                             <td style="width:20%;">借款部门</td>
                             <td style="width:30%;">
                                 <asp:Label ID="lblJieDepart" runat="server" Text=""></asp:Label></td>
                             <td style="width:20%;">经办人</td>
                             <td style="width:30%;">
                                 <asp:Label ID="lblJinEmployee" runat="server" Text=""></asp:Label></td>
                        </tr>
                         <tr>
                             <td>办款部门</td>
                             <td>
                                 <asp:Label ID="lblBanDepart" runat="server" Text=""></asp:Label></td>
                             <td>出纳人</td>
                             <td></td>
                             
                        </tr>
                         <tr>
                             <td>使用部门</td>
                             <td colspan="3">
                                 <asp:Label ID="lblUseDepart" runat="server" Text=""></asp:Label></td>
                            
                        </tr>
                         <tr>
                             <td>借款用途及理由</td>
                             <td colspan="3">
                                 <asp:Label ID="lblReason" runat="server"></asp:Label></td>
                             
                        </tr>
                         <tr>
                             <td rowspan="2">借款金额</td>
                             <td colspan="3" style="text-align:left;">
                             (大写)￥    <asp:Label ID="lblBigMoney" runat="server" Text=""></asp:Label>
                             </td>
                             
                        </tr>
                       <tr>
                         <td colspan="3" style="text-align:left;">
                              (小写)￥
                              <asp:Label ID="lblSmallMoney" runat="server" Text=""></asp:Label></td>
 
                       </tr>
                         <tr>
                             <td>付款方式</td>
                             <td>
                                 <asp:Label ID="lblMoneyStyle" runat="server" Text=""></asp:Label></td>
                             <td>付款时间</td>
                             <td><asp:Label ID="lblFuTime" runat="server"></asp:Label></td>
                        </tr>
                          <tr>
                              <td >部门经理意见</td>
                               <td>
                               <asp:Label ID="lblDepartView" runat="server"></asp:Label>
                              </td>
                               <td>总经理意见</td>
                               <td>
                                    <asp:TextBox ID="txtManagerView" runat="server"></asp:TextBox>
                               </td>
                            </tr>
                    </table>
                </td>
            </tr>
             
        </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
    <table class="Tb_Blank" style=" width:100%; ">
             <tr>
                 <td colspan="2"> 
                    <div style="text-align:center; padding-left:42%;">
                        <asp:RadioButtonList ID="rblOver" runat="server" RepeatDirection="Horizontal" SkinID="rbl1" >
                        <asp:ListItem Value="0">修正</asp:ListItem>
                        <asp:ListItem Value="1">通过</asp:ListItem>
                    </asp:RadioButtonList>
                    </div>
                    
                 </td>
            </tr>
        <tr>
            <td>
               <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"   />
            </td> 
            <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"   /></td> 
        </tr>
  </table>
</asp:Content>

    

