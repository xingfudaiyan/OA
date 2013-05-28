<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="Detail.aspx.cs" Inherits="OA.SpecialApply.Detail" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>特殊费用申请表</h1></td>
        </tr>
          <tr>
            <td colspan="2" style="text-align:right;">表单编号:<span style="color:Red;">*</span><asp:Label ID="lblSheetNum" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="25%">申请人</td>
                <td width="25%"><asp:Label ID="lblApplyPeople" runat="server"></asp:Label></td>
                <td width="25%">申请时间</td>
                <td width="25%"><asp:Label ID="lblApplyDate" runat="server" ></asp:Label></td>
            </tr>
            <tr>
                <td rowspan="3">项目</td>
                <td>项目名称</td>
                <td colspan="2"><asp:Label ID="lblProject" runat="server"></asp:Label></td>
                
            </tr>
            <tr>
                <td>项目阶段</td>
                <td colspan="2"><asp:Label ID="lblStep" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目金额(元)</td>
                <td colspan="2"><asp:Label ID="lblMoneyNum" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>申请费用(元)</td>
                <td colspan="3" style="text-align:left;"><asp:Label ID="lblApplyMoney" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>申请特殊费用原因</td>
                <td colspan="3">
                 <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
        </table>
         <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;">  <asp:Image ID="imgMarket" runat="server" ImageUrl="~/images/hechun.jpg"  Visible="false" /></td>
                <td style="width:15%;">总经理：</td>
                <td style="width:35%;"><asp:Image ID="imgManager" runat="server" ImageUrl="~/images/qidawei.jpg" Height="80px"  Visible="false" /></td>
            </tr>
        </table>
        </td>
        </tr>
       
    </table>
</asp:Content>
<asp:Content ContentPlaceHolderID="Content2" runat="server">
 <table class="Tb_Blank" style="width:100%;">
         <tr>
            <td colspan="2"><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" /></td> 
        </tr>
        </table>
</asp:Content>
        
