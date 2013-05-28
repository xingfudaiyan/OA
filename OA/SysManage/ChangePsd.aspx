<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="ChangePsd.aspx.cs" Inherits="OA.ChangePsd" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
  
  <table class="Tb_Blank1" style="width:80%; margin-left:10%;">
    <tr>
        <td colspan="2"><h2>修改密码</h2></td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
           <tr>
            <td>
                <asp:Label ID="lblUserName1" runat="server" Text="用户名"></asp:Label><span style="color:Red;">*</span>
            </td>
            <td>
                <asp:Label ID="lblUserName" runat="server" Text=""></asp:Label>
            </td>
           </tr>
           <tr>
            <td>
               <asp:Label ID="lblUserPsd" runat="server" Text="原密码"></asp:Label> <span style="color:Red;">*</span>
            </td>
            <td style="text-align:left;">
                <asp:TextBox ID="txtOldUserPsd" runat="server" TextMode="password" SkinID="skinid3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="re" runat="server" ErrorMessage="必填" ControlToValidate="txtOldUserPsd"></asp:RequiredFieldValidator>
            </td>
           </tr>
           <tr>
            <td>
               <asp:Label ID="lblNewPsd" runat="server" Text="新密码"></asp:Label><span style="color:Red;">*</span> 
            </td>
            <td style="text-align:left;">
                <asp:TextBox ID="txtNewPsd" runat="server" TextMode="Password" SkinID="skinid3"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtNewPsd"></asp:RequiredFieldValidator>
            </td>
           </tr>
           <tr>
            <td>
               <asp:Label ID="lblCkPsd" runat="server" Text="确认密码"></asp:Label> <span style="color:Red;">*</span>
            </td>
            <td style="text-align:left;">
                <asp:TextBox ID="txtCkPsd" runat="server" TextMode="Password" SkinID="skinid3"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtCkPsd"></asp:RequiredFieldValidator>
            </td>
           </tr>
        </table>
        </td>
    </tr>
    <tr>
            <td>
                 <asp:Button ID="btnOk" runat="server" Text="保存" OnClick="btnOk_Click"  />
            </td>
            <td>
                <asp:Button ID="btnBack" runat="server" Text="返回" OnClick="btnBack_Click" ValidationGroup="btn1" />
            </td>
  </tr>
  </table>
</asp:Content>

     