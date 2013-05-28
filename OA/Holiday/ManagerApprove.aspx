<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="ManagerApprove.aspx.cs" Inherits="OA.Holiday.ManagerApprove" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%">
        <tr>
            <td><h1>请假审批</h1></td>
        </tr>
        <tr>
            <td style="text-align:right;">填单日期：<asp:Label ID="lblApplyDate" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>
                <table class="Tb_Common">
                    <tr>
                        <td colspan="6" style="width:60%;">请假人</td>
                         <td colspan="4" style="width:40%;">职务代理人</td>
                    </tr>
                    <tr>
                        <td style="width:10%;">单位</td>
                        <td style="width:10%;"><asp:Label ID="lblCompany" runat="server" Text="上海君众"></asp:Label></td>
                        <td style="width:10%;">职称</td>
                        <td style="width:10%;"><asp:Label ID="lblPosition" runat="server"></asp:Label></td>
                        <td style="width:10%;">姓名</td>
                        <td style="width:10%;"><asp:Label ID="lblEmployeeName" runat="server"></asp:Label></td>
                        <td style="width:10%;">单位</td>
                        <td style="width:10%;"><asp:Label ID="lblApplyCompany" runat="server"></asp:Label></td>
                        <td style="width:10%;">姓名</td>
                        <td style="width:10%;"><asp:Label ID="lblApplyName" runat="server"></asp:Label></td>
                    </tr>
                     <tr>
                        <td>种类</td>
                        <td colspan="9" style="text-align:left;"><asp:RadioButtonList ID="rblHoliydayType" runat="server" Enabled="false"  RepeatDirection="Horizontal"></asp:RadioButtonList></td>
                    </tr>
                    <tr>
                        <td rowspan="2">请假时间</td>
                        <td colspan="6" style="text-align:left;"><asp:Label ID="lblBeginTime" runat="server"></asp:Label>起</td>
                        <td rowspan="2">合计</td>
                        <td colspan="2" rowspan="2" ><asp:Label ID="lblTimeSum" runat="server" Text=""></asp:Label></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="text-align:left;"><asp:Label ID="lblEndTime" runat="server"></asp:Label>止</td>
                    </tr>
                    <tr>
                        <td>事由</td>
                        <td colspan="9">
                            <asp:Label ID="lblReason" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                          <td>批示</td>
                          <td>直属主管</td>
                          <td><asp:TextBox ID="txtUperView"   runat="server" TextMode="MultiLine"></asp:TextBox></td>
                          <td>总经理</td>
                          <td><asp:TextBox ID="txtManagerView"  runat="server" ReadOnly="true" TextMode="MultiLine"></asp:TextBox></td>
                          <td>综合部</td>
                          <td><asp:TextBox ID="txtHrView" runat="server" ReadOnly="true" TextMode="MultiLine"></asp:TextBox></td>
                          <td>备注</td>
                          <td colspan="2"><asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine"></asp:TextBox></td>
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
            <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"  />
        </td>
         <td>
            <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  />
        </td>
    </tr>
</table>
</asp:Content>


