<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddContract.aspx.cs" Inherits="OA.ClientManage.AddContract" %>


   <asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
    <tr>
        <td colspan="2">
            <h2>添加合同</h2>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
           <tr>
                <td>合同类型<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="true" SkinID="ddl1" OnSelectedIndexChanged="ddlContractType_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
             <tr>
                <td>签约方<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlAuto" runat="server" AutoPostBack="true" SkinID="ddl1" OnSelectedIndexChanged="ddlAuto_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
            <tr>
                <td>合同编号</td>
                <td style=" text-align:left;"><asp:TextBox ID="txtContractNum" runat="server" SkinID="skinid3"></asp:TextBox></td>
            </tr>
            <tr>
                <td>合同名称<span style="color:Red;">*</span></td>
                <td style=" text-align:left;">
                <asp:TextBox ID="txtContractName" runat="server" SkinID="skinid3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="var" runat="server" ErrorMessage="必填" ControlToValidate="txtContractName"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>金额(元)<span style="color:Red;">*</span></td>
                <td style=" text-align:left;">
                <asp:TextBox ID="txtMoney" runat="server" SkinID="skinid3"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtMoney"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="r1" runat="server" ErrorMessage="数字格式" ControlToValidate="txtMoney" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                </td>
             </tr>
              <tr>
                <td>生效日期<span style="color:Red;">*</span></td>
                <td style=" text-align:left;">
                <asp:TextBox ID="txtBeginDate" runat="server" onclick="WdatePicker()" SkinID="skinid3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valrDate" runat="server" ErrorMessage="必填" ControlToValidate="txtBeginDate"></asp:RequiredFieldValidator>
                </td>
                
              </tr>
              <tr>
                <td>附件</td>
                <td style=" text-align:left;">
                <asp:FileUpload ID="UpFile" runat="server" SkinID="fu70" />
                
                </td>
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

            