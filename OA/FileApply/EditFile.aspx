<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="EditFile.aspx.cs" Inherits="OA.FileApply.EditFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>编辑文件申请</h1></td>
        </tr>
    
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="25%">申请人</td>
                <td width="25%"><asp:Label ID="lblEm" runat="server"></asp:Label></td>
                <td width="25%">
                    申请时间</td>
                <td width="25%"><asp:TextBox ID="txtTime" runat="server" onclick="WdatePicker()"></asp:TextBox></td>
            </tr>
            <tr>
             <td>
                 文件名</td>
             <td><asp:TextBox ID="txtFileName" runat="server"></asp:TextBox></td>
             <td>
                 文件类型</td>
             <td><asp:TextBox ID="txtFileType" runat="server" ></asp:TextBox></td>
            </tr>
             <tr>
                <td>本地上传</td>
                <td colspan="3"><asp:FileUpload ID="UpFile" runat="server" /></td>
            </tr>
             <tr>
                <td>文件说明</td>
                 <td colspan="3">
                 <asp:TextBox ID="txtFileDes" runat="server"  TextMode="MultiLine" ></asp:TextBox>
                 </td>
            </tr>
           <tr>
                <td>部门经理意见</td>
                <td><asp:TextBox ID="txtSectionView" runat="server"></asp:TextBox></td>
                 <td>总经理意见</td>
                <td><asp:TextBox ID="txtManagerView" runat="server"  ReadOnly="true"></asp:TextBox></td>
            </tr>
        </table>
        
        </td>
        </tr>
    </table>
    
</asp:Content>
<asp:Content ID="Content2"  ContentPlaceHolderID="Content2" runat="server">
 <table class="Tb_Blank" style="width:100%;">
             <tr>
                <td>
                     <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"  />
                </td>
               <td>
                   <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  />
               </td> 
           </tr>
</table>
</asp:Content>
        
