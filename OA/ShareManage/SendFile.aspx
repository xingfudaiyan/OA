<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="SendFile.aspx.cs" Inherits="OA.Document.SendFile" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:80%; margin-left:10%;">
        <tr>
            <td colspan="2"><h1>发送文件</h1></td>
        </tr>
        <tr>
            <td colspan="2">
                    <table class="Tb_Common">
                <tr>
                    <td style="width:30%;"><asp:Label ID="lblRecvDepart" runat="server" Text="部门"></asp:Label><span style="color:Red;">*</span></td>
                    <td style="text-align:left; width:70%;" >
                    <asp:DropDownList ID="ddlDepart" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDepart_SelectedIndexChanged" SkinID="ddl1">
                    </asp:DropDownList></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEm" runat="server" Text="员工"></asp:Label><span style="color:Red;">*</span>
                    </td>
                    <td style="text-align:left;">
                    <asp:DropDownList ID="ddlRecvEmployee" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlRecvEmployee_SelectedIndexChanged" SkinID="ddl1"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblRecv" runat="server" Text="接收人"></asp:Label><span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                        <asp:ListBox ID="lbxRecv" runat="server" OnSelectedIndexChanged="lbxRecv_SelectedIndexChanged" SkinID="lb50" ></asp:ListBox>
                        <asp:Button ID="btnRemove" runat="server" Text="删除"  OnClick="btnRemove_Click" />
                        <asp:Label ID="lblMsg1" runat="server" Text="" ForeColor="red"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblFile" runat="server" Text="文件"></asp:Label><span style="color:Red;">*</span></td>
                    <td style="text-align:left;"><asp:FileUpload ID="UpFile" runat="server"  SkinID="fu70" /></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblFileType" runat="server" Text="文件类型"></asp:Label><span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                    <asp:DropDownList ID="ddlFileType" runat="server" SkinID="ddl1">
                    </asp:DropDownList>
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
            <td><asp:Button ID="btnSendFile" runat="server" Text="发送"  OnClick="btnSendFile_Click" /></td>
            <td style="width: 253px"><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
      
</asp:Content>
    
    

      
