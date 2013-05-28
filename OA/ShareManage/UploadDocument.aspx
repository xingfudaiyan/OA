<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="UploadDocument.aspx.cs" Inherits="OA.ShareManage.UploadDocument" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:80%; margin-left:10%;">
        <tr>
            <td colspan="2"><h1>上传文档</h1></td>
        </tr>
        <tr>
            <td colspan="2">
                    <table class="Tb_Common">
                <tr>
                   <td><asp:Label ID="lblDocument" runat="server" Text="文档"></asp:Label><span style="color:Red;">*</span></td>
                   <td style="text-align:left;"><asp:FileUpload ID="UpFile" runat="server" SkinID="fu70" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblFileType" runat="server" Text="文档类型"></asp:Label><span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                        <asp:DropDownList ID="ddlFileType" runat="server" SkinID="skinid2" >
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblPermit" runat="server" Text="文档权限"></asp:Label><span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                    <asp:DropDownList ID="ddlFilePermit" runat="server" SkinID="skinid2"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                   <td><asp:Label ID="lblMemo" runat="server" Text="备注"></asp:Label></td>
                   <td style="text-align:left;"><asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine" SkinID="skinid3"></asp:TextBox></td>
                </tr>
              </table>
          </td>
        </tr>
         <tr>
            <td> <asp:Button ID="btnSendFile" runat="server" Text="上传" OnClick="btnSendFile_Click" ValidationGroup="btn1"  /></td>
            <td>  <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
</asp:Content>
    
    

