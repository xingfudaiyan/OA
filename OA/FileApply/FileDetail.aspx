<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="FileDetail.aspx.cs" Inherits="OA.FileApply.FileDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>文件审批详情</h1></td>
        </tr>
    
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="25%">申请人</td>
                <td width="25%"><asp:Label ID="lblEm" runat="server"></asp:Label></td>
                <td width="25%">
                    申请时间</td>
                <td width="25%"><asp:Label ID="lblTime" runat="server"></asp:Label></td>
            </tr>
            <tr>
            
             <td>
                 文件名</td>
             <td><asp:Label ID="lblName" runat="server"></asp:Label></td>
             <td>
                 文件类型</td>
             <td><asp:Label ID="lblType" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>文件内容</td>
                <td colspan="3"> <asp:Button ID="btnDownLoad" runat="server" Text="下载" OnClick="btnDownLoad_Click" /></td>
            </tr>
             <tr>
                <td>文件说明</td>
                 <td colspan="3">
                     <asp:Label ID="lblDes" runat="server"></asp:Label></td>
            </tr>
           <tr>
                <td>部门经理意见</td>
                <td><asp:Label ID="departView" runat="server"></asp:Label></td>
                 <td>总经理意见</td>
                <td><asp:Label ID="lblManagerView" runat="server"></asp:Label></td>
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
                   <asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" />
               </td> 
           </tr>
</table>
</asp:Content>
        
