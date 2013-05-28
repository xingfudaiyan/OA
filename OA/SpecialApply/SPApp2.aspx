<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SPApp2.aspx.cs" Inherits="OA.SpecialApply.SPApp2" %>
<%@ Register Assembly="KingControls" Namespace="KingControls" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script language="javascript" defer="defer" type="text/javascript" src="/My97DatePicker/WdatePicker.js"> 
<LINK rel="stylesheet" type="text/css" href="My97DatePicker/skin/default/datepicker.css" />
</script> 

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
     <style type="text/css">
        .button
        { 
            BORDER-RIGHT: #7EBF4F 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7EBF4F 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 12px; FILTER: 
            progid:DXImageTransform.Microsoft.Gradient(GradientType=0, StartColorStr=#ffffff, EndColorStr=#B3D997); BORDER-LEFT: #7EBF4F 1px solid; CURSOR: hand; 
            COLOR: black; PADDING-TOP: 2px; BORDER-BOTTOM: #7EBF4F 1px solid;
        } 
        .table
        {
            background-color:#EFF2E9;                     
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="Tb_Blank" style="margin-left:15%;">
        <tr>
            <td colspan="2"><h3>特殊费用申请表</h3></td>
        </tr>
         <tr>
            <td colspan="2" style="text-align:right;">表单编号:<span style="color:Red;">*</span><asp:Label ID="lblSheetNum" runat="server" ></asp:Label></td>
        </tr>
         <tr>
            <td colspan="2"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="20%">申请人</td>
                <td width="20%"><asp:Label ID="lblApplyPeople" runat="server"></asp:Label></td>
                <td width="20%">申请时间</td>
                <td width="40%"><asp:Label ID="lblApplyDate" runat="server" ></asp:Label></td>
            </tr>
            <tr>
                <td rowspan="4">项目</td>
                <td>项目名称</td>
                <td colspan="2"><asp:Label ID="lblProject" runat="server"></asp:Label></td>
                
            </tr>
            <tr>
                <td>项目阶段</td>
                <td colspan="2"><asp:Label ID="lblStep" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目金额</td>
                <td colspan="2"><asp:Label ID="lblMoneyNum" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>申请费用</td>
                <td colspan="2"><asp:Label ID="lblApplyMoney" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="4" style="text-align:left;">申请项目特殊费用的原因:</td>
            </tr>
            <tr>
                <td colspan="4">
                 <asp:Label ID="lblReason" runat="server" ></asp:Label>
                </td>
            </tr>
            <tr>
                <td>市场部经理</td>
                <td colspan="3"><img src="ShowImage1.aspx" width="100" height="50" /></td>
            </tr>
            <tr>
                <td>总经理</td>
                <td colspan="3"> <img src="ShowImage2.aspx" width="100" height="50" /></td>
            </tr>
            <tr>
            <td>财务部经理</td>
            <td colspan="3"><cc1:SignNameControl id="SignNameControl1" SignatureWidth="400" ClientPath=".\" SignatureHeight="80" runat="server" PenSize="Normal" OnClearClick="SignNameControl1_ClearClick" OnSaveClick="SignNameControl1_SaveClick" ButtonClass="button" CssClass="table"></cc1:SignNameControl> </td>
            </tr>
        </table>
        </td>
        </tr>
        <tr>
            <td>
               是否通过
            </td>
             <td> <asp:RadioButtonList ID="rblOver" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="0">修正</asp:ListItem>
                    <asp:ListItem Value="1">通过</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
        <tr>
            <td>
               <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click" />
            </td> 
            <td><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" /></td> 
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
