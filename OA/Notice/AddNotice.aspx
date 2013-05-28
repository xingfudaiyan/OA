<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddNotice.aspx.cs" Inherits="OA.Notice.AddNotice" %>


<asp:Content ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="text-align:center;">
        <tr>
            <td colspan="3">
                <input  name="txtTitle" type="text" />(标题)
                
            </td>
        </tr>
        <tr>
            <td colspan="3">
               <textarea name="txtContent" style="width:80%; height:200px;"></textarea>
                
            </td>
        </tr>
        <tr>
            <td style="width:70%;">
            </td>
            <td colspan="2" style="text-align:left;">
                落款:<input type="text" name="txtSignName" style="width:40%;" />
                 
            </td>
        </tr>
         <tr>
            <td style="width:70%;" >
            </td>
            <td colspan="2" style="text-align:left;">
                时间:<input type="text" name="txtNoticeTime" style="width:40%;" onclick="WdatePicker()"/>
                 
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ContentPlaceHolderID="Content2" runat="server">
    <table class="Tb_Blank1">
        <tr>
            <td><asp:Button ID="btnSave" Text="保存" runat="server" OnClientClick="return PageValid();" OnClick="btnSave_Click" /></td>
            <td><asp:Button ID="btnCancel" Text="取消" runat="server" OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
</asp:Content>