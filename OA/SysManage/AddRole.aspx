<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRole.aspx.cs" MasterPageFile="~/Apply.Master" Inherits="OA.SysManage.AddRole" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:80%; margin-left:10%;">
    <tr>
        <td colspan="2"><h2>新增角色</h2></td>
    </tr>
    <tr>
        <td colspan="2">
        <table class="Tb_Common">
            <tr>
                <td style="width:20%;">角色名称：</td>
                <td><asp:TextBox ID="txtRoleName" runat="server"></asp:TextBox> </td>
            </tr>
          
        </table>
        </td>
    </tr>
    <tr>
        <td>   <asp:Button ID="btnAddUser" runat="server" Text="新增" OnClick="btnAddUser_Click"  /></td>
         <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
    </tr>
</table>

     
        

</asp:Content>
       