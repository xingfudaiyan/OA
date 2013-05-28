<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddSupply.aspx.cs" Inherits="OA.Supply.AddSupply" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="width:100%;">
    <tr>
        <td colspan="2">
            <h2>添加供应商</h2>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
              <tr>
            <td style="width:20%">供应商编号<span style="color:Red;">*</span></td>
            <td style="text-align:left;"><asp:TextBox ID="txtSheetNum" runat="server" SkinID="skinid3"></asp:TextBox>
            <asp:RequiredFieldValidator ID="valr" runat="server" ErrorMessage="非空" ControlToValidate="txtSheetNum"></asp:RequiredFieldValidator>
            
            </td>
        </tr>
        <tr>
            <td>供应商名称<span style="color:Red;">*</span></td>
            <td style="text-align:left;"><asp:TextBox ID="txtName" runat="server" SkinID="skinid3"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="非空" ControlToValidate="txtName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        </table>
        </td>
        
    </tr>
    <tr>
        <td>
           <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" />
        </td>
        <td>
           <asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" />
        </td>
    </tr>
</table>
</asp:Content>
