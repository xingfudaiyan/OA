<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddClient.aspx.cs" Inherits="OA.MarketManage.AddClient" %>


<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
    <tr>
        <td colspan="2">
            <h2>添加客户</h2>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
            <tr>
               <td>客户类别<span style="color:Red;">*</span></td>
               <td><asp:DropDownList ID="ddlClientType" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlClientType_SelectedIndexChanged"></asp:DropDownList></td>
               <td>客户等级<span style="color:Red;">*</span></td>
               <td><asp:DropDownList ID="ddlClientLevel" runat="server"></asp:DropDownList></td>
            </tr>
              <tr>
                <td>客户编号<span style="color:Red;">*</span></td>
                <td><asp:TextBox ID="txtClientNum" runat="server" ReadOnly="true"></asp:TextBox></td>
                <td>客户名称<span style="color:Red;">*</span></td>
                <td>
                <asp:TextBox ID="txtClientName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valrName" runat="server" ErrorMessage="必填" ControlToValidate="txtClientName"></asp:RequiredFieldValidator>
                </td>
                
            </tr>
              
              <tr>
                <td>传真</td>
                <td><asp:TextBox ID="txtFax" runat="server"></asp:TextBox></td>
                <td>电话
                <td>
                <asp:TextBox ID="txtTelephone" runat="server"></asp:TextBox>
                </td>
                
             </tr>  
              <tr>
              <td>邮编</td>
                <td><asp:TextBox ID="txtMailNo" runat="server"></asp:TextBox></td>
                <td>地址</td>
                <td><asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
             </tr>
             <tr>
                <td>联系人姓名<span style="color:Red;">*</span></td>
                <td>
                <asp:TextBox ID="txtRelateName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtRelateName"></asp:RequiredFieldValidator>
                </td>
                <td>手机</td>
                <td><asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
             </tr>
              <tr>
                <td>邮箱</td>
                <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
               <td>职务</td>
                <td>
                <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
                </td>
                
             </tr>
             <tr>
               <td>备注</td>
                <td colspan="3"><asp:TextBox ID="txtMemo" runat="server"></asp:TextBox></td>
             </tr>
        </table>
        </td>
        
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" />
        </td>
        <td>
            <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" ValidationGroup="btn1" />
        </td>
    </tr>
</table>
</asp:Content>

        