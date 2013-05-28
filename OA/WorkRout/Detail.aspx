<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="Detail.aspx.cs" Inherits="OA.WorkRout.Detail" %>
<asp:Content ContentPlaceHolderID="Content1" runat="server">
  <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="4"><h1>技术支持工单</h1></td>
        </tr>
        <tr>
            <td style="width:10%">工单种类:</td>
            <td style="width:60%; text-align:left;">
                 <asp:RadioButtonList ID="rblWorkSheetType" runat="server" RepeatDirection="Horizontal"></asp:RadioButtonList>
             </td>
           
            <td style="width:30%" colspan="2">工单编号:<asp:Label ID="lblSheetNum" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="10%">提交人</td>
                <td width="15%"><asp:Label ID="lblApplyName" runat="server"></asp:Label></td>
                <td width="10%">申请时间</td>
                <td width="20%"><asp:Label ID="lblApplyDate" runat="server"></asp:Label></td>
            </tr>
            <tr>
               <td>客户名称</td>
                <td>
                 <asp:Label ID="lblClientName" runat="server"></asp:Label>
                </td> 
                <td>客户联系人</td>
                <td><asp:Label ID="lblRelate" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>电话</td>
                <td><asp:Label ID="lblTelephone" runat="server"></asp:Label></td>
                <td>地址</td>
                <td><asp:Label ID="lblAddress" runat="server"></asp:Label></td>
            </tr>
            <tr>
               <td>传真</td>
                <td><asp:Label ID="lblFax" runat="server"></asp:Label></td>
                <td>邮编</td>
                <td><asp:Label ID="lblMailNum" runat="server"></asp:Label></td>
            </tr>
             <tr>
               <td>手机</td>
                <td><asp:Label ID="lblMobile" runat="server"></asp:Label></td>
                <td>Email</td>
                <td><asp:Label ID="lblEmail" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td rowspan="3">业务描述</td>
                <td>合同名称</td>
                <td colspan="2"><asp:Label ID="lblContractName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目名称</td>
                <td colspan="2"><asp:Label ID="lblProjectName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>其他描述</td>
                <td colspan="2"><asp:Label ID="lblOther" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>技术要求</td>
                <td colspan="3"><asp:Label ID="lblTechR" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>其他要求</td>
                <td colspan="3"><asp:Label ID="lblElseR" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>完成时限</td>
                <td colspan="3"><asp:Label ID="lblShiXian" runat="server"></asp:Label></td>
            </tr>
             <tr>
                <td>
                    备注</td>
                <td colspan="3" style="text-align:left;"><asp:TextBox ID="txtElse" runat="server" TextMode="MultiLine"  ReadOnly="true"  SkinID="skinid1"></asp:TextBox></td>
            </tr>
             <tr>
                <td>市场部意见</td>
                <td><asp:TextBox ID="txtMarketView" runat="server"  SkinID="skinid1" TextMode="MultiLine" ReadOnly="true" ></asp:TextBox></td>
                <td>
                    技术部意见</td>
                <td><asp:TextBox ID="txtTechView" runat="server" SkinID="skinid1" TextMode="MultiLine" ReadOnly="true" ></asp:TextBox></td>
            </tr>
        </table>
           <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;"><asp:Image ID="imgMarket" runat="server" ImageUrl="~/images/hechun.jpg" Visible="false" /></td>
                <td style="width:15%;">技术部经理：</td>
                <td style="width:35%;"><asp:Image ID="imgTech" runat="server"  Visible="false" /></td>
            </tr>
        </table>
        </td>
        </tr>
         
       
    </table>

</asp:Content>
<asp:Content ContentPlaceHolderID="Content2" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td><asp:Button ID="btnBack" runat="server" Text="返回" OnClick="btnBack_Click" /></td> 
        </tr>
</table>
</asp:Content>
       