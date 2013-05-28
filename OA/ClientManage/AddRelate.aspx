<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRelate.aspx.cs" Inherits="OA.ClientManage.AddRelate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table class="Tb_Common" style="width:80%; margin-left:10%;">
            <tr>
                <td>客户编号</td>
                <td><asp:Label ID="lblClientNum" runat="server"></asp:Label></td>
                <td>客户名称</td>
                <td>
                <asp:Label ID="lblClientName" runat="server"></asp:Label>
                </td>
            </tr>
              <tr>
                <td>客户等级<span style="color:Red;">*</span></td>
                <td><asp:Label ID="lblClientLevel" runat="server"></asp:Label></td>
                <td>传真</td>
                <td><asp:Label ID="lblFax" runat="server"></asp:Label></td>
            </tr>
              
              <tr>
                <td>电话</td>
                <td><asp:Label ID="lblTelephone" runat="server"></asp:Label></td>
                <td>邮编</td>
                <td><asp:Label ID="lblMailNo" runat="server"></asp:Label></td>
             </tr>  
              <tr>
                <td>地址</td>
                <td colspan="3"><asp:Label ID="lblAddress" runat="server"></asp:Label></td>
             </tr>
             <tr>
                <td>联系人姓名<span style="color:Red;">*</span></td>
                <td>
                <asp:TextBox ID="txtRelateName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valrRelate" runat="server" ErrorMessage="必填" ControlToValidate="txtRelateName"></asp:RequiredFieldValidator>
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
              <tr>
                <td colspan="2"><asp:Button ID="btnAdd" runat="server" Text="添加" OnClick="btnAdd_Click" /></td>
                <td colspan="2"><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" ValidationGroup="btn1" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
