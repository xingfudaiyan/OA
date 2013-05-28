<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUserRole.aspx.cs" MasterPageFile="~/Apply.Master" Inherits="OA.SysManage.AddUserRole" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:80%; margin-left:10%;">
    <tr>
        <td colspan="2"><h2>分配角色</h2></td>
    </tr>
    <tr>
        <td colspan="2">
        <table class="Tb_Common">
            <tr>
                <td style="width:20%;">用户名：</td>
                <td><asp:DropDownList ID="ddlMaster" runat="server" OnSelectedIndexChanged="ddlMaster_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList></td>
            </tr>
          <tr>
            <td>角色</td>
            <td><asp:CheckBoxList ID="ckblRole" runat="server" RepeatDirection="Horizontal" RepeatColumns="5"></asp:CheckBoxList></td>
          </tr>
        </table>
        </td>
    </tr>
    <tr>
        <td>   <asp:Button ID="btnAddUser" runat="server" Text="保存" OnClick="btnAddUser_Click"   /></td>
         <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
    </tr>
</table>

     
        

</asp:Content>
       