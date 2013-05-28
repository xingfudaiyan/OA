<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="EditHoliday.aspx.cs" Inherits="OA.Holiday.EditHoliday" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%">
        <tr>
            <td><h1>请假单</h1></td>
        </tr>
        <tr>
            <td style="text-align:right;">填单日期：<span style="color:Red;">*</span>
            <asp:TextBox ID="txtApplyDate" runat="server" onclick="WdatePicker()" SkinID="skinid4"></asp:TextBox>
            <asp:RequiredFieldValidator ID="re" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate"></asp:RequiredFieldValidator>
            </td>
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
                        <td style="width:10%;"><asp:TextBox ID="txtApplyCompany" runat="server" SkinID="skinid1"></asp:TextBox></td>
                        <td style="width:10%;">姓名</td>
                        <td style="width:10%;"><asp:TextBox ID="txtApplyName" runat="server" SkinID="skinid1"></asp:TextBox></td>
                    </tr>
                     <tr>
                        <td>种类<span style="color:Red;">*</span></td>
                        <td colspan="9" style="text-align:left;"><asp:RadioButtonList ID="rblHoliydayType" runat="server" RepeatDirection="Horizontal"></asp:RadioButtonList></td>
                    </tr>
                    <tr>
                        <td rowspan="2">请假时间<span style="color:Red;">*</span></td>
                        <td colspan="6" style="text-align:left;">
                        <asp:TextBox ID="txtBeginTime" runat="server" onclick="WdatePicker()" SkinID="skinid3"></asp:TextBox>起
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtBeginTime"></asp:RequiredFieldValidator>
                        </td>
                        <td rowspan="2">合计</td>
                        <td colspan="2" rowspan="2" style="text-align:left;" ><asp:TextBox ID="txtTimeSum" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td colspan="6" style="text-align:left;">
                        <asp:TextBox ID="txtEndTime" runat="server" onclick="WdatePicker()" SkinID="skinid3"></asp:TextBox>止
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtEndTime"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>事由</td>
                        <td colspan="9">
                            <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                          <td>批示</td>
                          <td>直属主管</td>
                          <td><asp:TextBox ID="txtUperView" runat="server" TextMode="MultiLine" SkinID="skinid1"></asp:TextBox></td>
                          <td>综合部</td>
                          <td><asp:TextBox ID="txtHrView" runat="server" TextMode="MultiLine" SkinID="skinid1" ReadOnly="true"></asp:TextBox></td>
                          <td>总经理</td>
                          <td><asp:TextBox ID="txtManagerView" runat="server" TextMode="MultiLine" SkinID="skinid1" ReadOnly="true"></asp:TextBox></td>
                          <td>备注</td>
                          <td colspan="2"><asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine" SkinID="skinid1"></asp:TextBox></td>
                    </tr>
                </table>
            </td>
        </tr>
</table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
<table class="Tb_Blank" style="width:100%;">
    <tr>
        <td>
            <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnAdd_Click" />
        </td>
         <td>
            <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" />
        </td>
    </tr>
</table>
</asp:Content>
