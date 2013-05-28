<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="RecvRights.aspx.cs" Inherits="OA.SysManage.RecvRights" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
  
  <table class="Tb_Blank1" style="width:80%; margin-left:10%;">
    <tr>
        <td colspan="2"><h2>分配用户权限</h2></td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
           <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
            </td>
           </tr>
           <tr>
            <td>
               <asp:Label ID="lblEmployeeName" runat="server" Text="姓名"></asp:Label>
            </td>
            <td>
               <asp:Label ID="lblEmployee" runat="server" Text=""></asp:Label>
            </td>
           </tr>
           <tr>
            <td>
              <asp:Label ID="lblRole" runat="server" Text="分配角色"></asp:Label> <span style="color:Red;">*</span>
            </td>
            <td>
                 <asp:RadioButtonList ID="rblRole" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" >
                 </asp:RadioButtonList>
            </td>
           </tr>
           <tr>
            <td>
                <asp:Label ID="lblRight" runat="server" Text="分配权限"></asp:Label><span style="color:Red;">*</span>
            </td>
            <td>
                <asp:CheckBoxList ID="ckblRight" runat="server" RepeatDirection="Horizontal" RepeatColumns="4">
                </asp:CheckBoxList>
            </td>
           </tr>
        </table>
        </td>
    </tr>
    <tr>
        <td colspan="2">
        <table class="Tb_Blank">
            <tr>
                <td style=" padding-left:55%;">
                    <asp:RadioButtonList ID="rblIsOver" runat="server" RepeatDirection="horizontal">
                        <asp:ListItem Value="0">通过</asp:ListItem>
                        <asp:ListItem Value="1">修正</asp:ListItem>
                    </asp:RadioButtonList>
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
                <asp:Button ID="btnBack" runat="server" Text="返回" OnClick="btnBack_Click" />
            </td>
  </tr>
  </table>
</asp:Content>

          
 
