﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddExecute.aspx.cs" Inherits="OA.ProjectExecute.AddExecute" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script language="javascript" defer="defer" type="text/javascript" src="/My97DatePicker/WdatePicker.js"> 
<LINK rel="stylesheet" type="text/css" href="My97DatePicker/skin/default/datepicker.css" />
</script> 
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table class="Tb_Blank" style="margin-left:10%;">
        <tr>
            <td colspan="4"><h3>项目实施工单</h3></td>
        </tr>
        <tr>
            <td style="width:10%">工单种类:<span style="color:Red;">*</span></td>
            <td style="width:65%; text-align:left;">
                 <asp:RadioButtonList ID="rblWorkSheetType" runat="server" RepeatDirection="Horizontal"></asp:RadioButtonList>
             </td>
            <td style="width:15%">工单编号:<span style="color:Red;">*</span></td>
            <td style="width:15%">
            <asp:TextBox ID="txtSheetNum" runat="server" ReadOnly="true"></asp:TextBox>
           
            </td>
        </tr>
        <tr>
            <td colspan="4"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="10%">申请人</td>
                <td width="15%"><asp:Label ID="lblApplyName" runat="server"></asp:Label></td>
                <td width="10%">申请时间<span style="color:Red;">*</span></td>
                <td width="20%">
                <asp:TextBox ID="txtApplyDate" runat="server" onclick="WdatePicker()"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
               <td>客户名称<span style="color:Red;">*</span></td>
                <td>
                <asp:DropDownList ID="ddlClient" runat="server" AutoPostBack="true" ></asp:DropDownList>
                </td> 
                <td>客户联系人<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlRelate" runat="server" AutoPostBack="true"  ></asp:DropDownList></td>
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
                <td><asp:Label ID="lblMailNo" runat="server"></asp:Label></td>
            </tr>
            <tr>
               <td>手机</td>
                <td><asp:Label ID="lblMobile" runat="server"></asp:Label></td>
                <td>Email</td>
                <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td rowspan="3">业务描述<span style="color:Red;">*</span></td>
                <td>合同名称</td>
                <td><asp:DropDownList ID="ddlContract" runat="server" AutoPostBack="true"  ></asp:DropDownList></td>
                <td><asp:Label ID="lblContract" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目名称</td>
                <td><asp:DropDownList ID="ddlProject" runat="server" AutoPostBack="true" ></asp:DropDownList></td>
                <td><asp:Label ID="lblProject" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>其他描述</td>
                <td colspan="2"><asp:TextBox ID="txtOtherMiaoshu" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>技术要求</td>
                <td colspan="3"><asp:TextBox ID="txtTecR" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>其他要求</td>
                <td colspan="3"><asp:TextBox ID="txtElseR" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>完成时限</td>
                <td colspan="3"><asp:TextBox ID="txtShiXian" runat="server" onclick="WdatePicker()"></asp:TextBox></td>
            </tr>
            <tr>
                <td>市场部意见</td>
                <td colspan="3"><asp:TextBox ID="txtMarketView" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>技术部意见</td>
                <td colspan="3"><asp:TextBox ID="txtTechView" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>备注</td>
                <td colspan="3"><asp:TextBox ID="txtElse" runat="server"></asp:TextBox></td>
            </tr>
           
        </table>
        </td>
        </tr>
        <tr>
            <td colspan="2">
               <asp:Button ID="btnSave" runat="server" Text="保存"   />
            </td> 
            <td colspan="2"><asp:Button ID="btnCancel" runat="server"  Text="返回" /></td> 
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
