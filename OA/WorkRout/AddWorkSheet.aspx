<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="AddWorkSheet.aspx.cs" Inherits="OA.jszhichi" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="4"><h1>技术支持工单</h1></td>
        </tr>
        <tr>
            <td style="width:12%">工单种类:<span style="color:Red;">*</span></td>
            <td style="width:50%; text-align:left;">
                 <asp:RadioButtonList ID="rblWorkSheetType" runat="server" AutoPostBack="true" RepeatDirection="Horizontal"></asp:RadioButtonList>
             </td>
          
            <td style="width:30%" colspan="2">工单编号:<span style="color:Red;">*</span>
            <asp:TextBox ID="txtSheetNum" runat="server" SkinID="skinid5" ReadOnly="true"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="20%">申请人</td>
                <td width="30%"><asp:Label ID="lblApplyName" runat="server"></asp:Label></td>
                <td width="20%">申请时间<span style="color:Red;">*</span></td>
                <td width="30%">
                <asp:TextBox ID="txtApplyDate" runat="server" onclick="WdatePicker()" SkinID="skinid1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="vDate" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
               <td>客户名称<span style="color:Red;">*</span></td>
                <td>
                <asp:DropDownList ID="ddlClient" runat="server" AutoPostBack="true" SkinID="skinid2" ></asp:DropDownList>
                </td> 
                <td>客户联系人<span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlRelate" runat="server" AutoPostBack="true" SkinID="skinid2" ></asp:DropDownList></td>
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
                <td><asp:Label ID="lblMailNo" runat="server"></asp:Label></td>
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
                <td><asp:DropDownList ID="ddlContract" runat="server" AutoPostBack="true" ></asp:DropDownList></td>
                <td><asp:Label ID="lblContract" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目名称</td>
                <td><asp:DropDownList ID="ddlProject" runat="server" AutoPostBack="true" ></asp:DropDownList></td>
                <td><asp:Label ID="lblProject" runat="server"></asp:Label></td>
              
            </tr>
            <tr>
                <td>其他描述</td>
                <td colspan="2"><asp:TextBox ID="txtOtherMiaoshu" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>技术要求</td>
                <td colspan="3" style="text-align:left;"><asp:TextBox ID="txtTecR" runat="server" SkinID="skinid1"></asp:TextBox></td>
            </tr>
            <tr>
                <td>其他要求</td>
                <td colspan="3" style="text-align:left;"><asp:TextBox ID="txtElseR" runat="server" SkinID="skinid1"></asp:TextBox></td>
            </tr>
            <tr>
                <td>完成时限<span style="color:Red;">*</span></td>
                <td colspan="3" style="text-align:left;">
                <asp:TextBox ID="txtShiXian" runat="server" onclick="WdatePicker()" SkinID="skinid1"></asp:TextBox>
                <asp:RequiredFieldValidator ID="vShiXian" runat="server" ErrorMessage="必填" ControlToValidate="txtShiXian"></asp:RequiredFieldValidator>
                </td>
            </tr>
             <tr>
                <td>
                    备注</td>
                <td colspan="3" style="text-align:left;"><asp:TextBox ID="txtElse" runat="server" TextMode="MultiLine"  SkinID="skinid1"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    市场部意见</td>
                <td><asp:TextBox ID="txtMarketView" runat="server"  SkinID="skinid1" TextMode="MultiLine"></asp:TextBox></td>
                <td>
                    技术部意见</td>
                <td><asp:TextBox ID="txtTechView" runat="server" SkinID="skinid1" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        </table>
         <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;"><asp:Image ID="imgMarket" runat="server" ImageUrl="~/images/hechun.jpg" Visible="false" /></td>
                <td style="width:15%;">技术部经理：</td>
                <td style="width:35%;"></td>
            </tr>
        </table>
        </td>
        </tr>
    </table>
        

</asp:Content>
<asp:Content  ContentPlaceHolderID="Content2" runat="server">
 <table class="Tb_Blank" style="width:100%;">
           
             <tr>
                <td>
                     <asp:Button ID="Button1" runat="server" Text="保存"   />
                </td>
               <td>
                   <asp:Button ID="Button2" runat="server" Text="返回"   ValidationGroup="btn1"/>
               </td> 
           </tr>
</table>
</asp:Content>


   