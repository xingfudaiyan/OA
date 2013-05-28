<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddProject.aspx.cs" Inherits="OA.ClientManage.AddProject" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
    <tr>
        <td colspan="2">
            <h2>添加项目</h2>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
          <tr>
                <td>客户名称<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlClient" runat="server" AutoPostBack="true" SkinID="ddl1" OnSelectedIndexChanged="ddlClient_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>项目编号<span style="color:Red;">*</span></td>
                <td style="text-align:left;"><asp:TextBox ID="txtSheetNum" runat="server" SkinID="skinid3"></asp:TextBox></td>
            </tr>
            
            <tr>
                <td>项目名称<span style="color:Red;">*</span></td>
                <td style="text-align:left;">
                <asp:TextBox ID="txtProjectName" runat="server" SkinID="skinid3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valR" runat="server" ErrorMessage="必填" ControlToValidate="txtProjectName"></asp:RequiredFieldValidator>
                </td>
            </tr>
              <tr>
                <td>项目级别<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlProjectLevel" runat="server" SkinID="ddl1"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>项目类别<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlProjectType" runat="server" SkinID="ddl1"></asp:DropDownList></td>
            </tr>
              <tr>
                <td>预计金额</td>
                <td style="text-align:left;"><asp:TextBox ID="txtPreMoney" runat="server" SkinID="skinid3"></asp:TextBox></td>
            </tr>
              <tr>
                <td>预计毛利</td>
                <td style="text-align:left;"><asp:TextBox ID="txtPreProfit" runat="server" SkinID="skinid3"></asp:TextBox></td>
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

            
       
