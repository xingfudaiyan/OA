<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="DepartApprove.aspx.cs" Inherits="OA.ContractApply.DepartApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>合同\协议审批</h1></td>
        </tr>
        <tr>
            <td colspan="2" style=" text-align:right;">
                表单编号：
               <asp:Label ID="lblSheetNum" runat="server"  Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td>申请部门</td>
                <td><asp:Label ID="lblDepart" runat="server"></asp:Label></td>
                <td>申请人</td>
                <td><asp:Label ID="lblEmployee" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>附件</td>
                <td>
                <asp:Button ID="btnDownLoad" runat="server" Text="查看" OnClick="btnDownLoad_Click" />
                </td>
             <td>签约方</td>
             <td><asp:Label ID="lblSignName" runat="server"></asp:Label></td>
            </tr>
             <tr>
                <td>编号</td>
                 <td >
                 <asp:Label ID="lblContractNum" runat="server"></asp:Label>
                 </td>
                <td>名称</td>
                <td> 
                <asp:Label ID="lblContract" runat="server" Text=""></asp:Label>
                </td>
                 
               
            </tr>
            <tr>
               <td>生效日期</td>
                <td >
                <asp:Label ID="lblBeginDate" runat="server"></asp:Label>
                </td>
               <td>申请日期</td>
                <td>
                <asp:Label ID="lblApplyDate" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>概述</td>
                <td colspan="3">
                <asp:Label ID="lblContractDes" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                 <td rowspan="2">金额</td>
                 <td>大写(元)</td>
                 <td colspan="2" ><asp:Label ID="lblBigMoney" runat="server" ></asp:Label>
                 </td> 
            </tr>
            <tr>
                 <td>小写(元)￥</td>
                 <td colspan="2" >
                <asp:Label ID="lblSmallMoney" runat="server"></asp:Label>
                 </td>
            </tr>
           
           <tr>
                <td>部门意见</td>
                <td><asp:TextBox ID="txtSectionView" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                 <td>总经理意见</td>
                <td></td>
            </tr>
        </table>
        </td>
        </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="Content2" runat="server">
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
               <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click"  />
            </td> 
            <td><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" /></td> 
        </tr>  
</table>
</asp:Content>
        
         
               