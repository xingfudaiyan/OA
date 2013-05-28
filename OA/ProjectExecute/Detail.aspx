<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detail.aspx.cs" Inherits="OA.ProjectExecute.Detail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table class="Tb_Blank" style="margin-left:10%;">
        <tr>
            <td colspan="4"><h3>技术支持工单</h3></td>
        </tr>
        <tr>
            <td style="width:10%">工单种类:</td>
            <td style="width:65%; text-align:left;">
                 <asp:RadioButtonList ID="rblWorkSheetType" runat="server" RepeatDirection="Horizontal"></asp:RadioButtonList>
             </td>
            <td style="width:10%">工单编号:</td>
            <td style="width:15%"><asp:Label ID="lblSheetNum" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="10%">提交人</td>
                <td width="15%"><asp:Label ID="lblApplyName" runat="server"></asp:Label></td>
                <td width="10%">下单时间</td>
                <td width="20%"><asp:Label ID="lblApplyDate" runat="server"></asp:Label></td>
            </tr>
            <tr>
               <td>客户名称</td>
                <td>
                 <asp:Label ID="lblClientName" runat="server"></asp:Label>
                </td> 
                <td>客户联系人</td>
                <td><asp:Label ID="lblRelate" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>电话</td>
                <td><asp:Label ID="lblTelephone" runat="server"></asp:Label></td>
                <td>地址</td>
                <td><asp:Label ID="lblAddress" runat="server"></asp:Label></td>
            </tr>
            <tr>
               <td>传真</td>
                <td><asp:Label ID="lblFax" runat="server"></asp:Label></td>
                <td>邮编</td>
                <td><asp:Label ID="lblMailNum" runat="server"></asp:Label></td>
            </tr>
             <tr>
               <td>手机</td>
                <td><asp:Label ID="lblMobile" runat="server"></asp:Label></td>
                <td>Email</td>
                <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td rowspan="3">业务描述</td>
                <td>合同名称</td>
                <td colspan="2"><asp:Label ID="lblContractName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目名称</td>
                <td colspan="2"><asp:Label ID="lblProjectName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>其他描述</td>
                <td colspan="2"><asp:Label ID="lblOther" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>技术要求</td>
                <td colspan="3"><asp:Label ID="lblTechR" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>其他要求</td>
                <td colspan="3"><asp:Label ID="lblElseR" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>完成时限</td>
                <td colspan="3"><asp:Label ID="lblShiXian" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>市场部意见</td>
                <td colspan="3"><asp:Label ID="txtMarketView" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>技术部意见</td>
                <td colspan="3"><asp:Label ID="txtTechView" runat="server"></asp:Label></td>
            </tr>
             <tr>
                <td>其他</td>
                <td colspan="3"><asp:Label ID="lblElse" runat="server"></asp:Label></td>
            </tr>
           
        </table>
        </td>
        </tr>
         
        <tr>

            <td colspan="4"><asp:Button ID="btnBack" runat="server" Text="返回" /></td> 
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
