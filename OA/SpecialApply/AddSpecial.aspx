<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddSpecial.aspx.cs" Inherits="OA.SpecialApply.AddSpecial" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>特殊费用申请表</h1></td>
        </tr>
         <tr>
            <td colspan="2" style="text-align:right;">表单编号:<span style="color:Red;">*</span><asp:TextBox ID="txtSheetNum" runat="server"  SkinID="skinid4" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
            
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="25%">申请人</td>
                <td width="25%"><asp:Label ID="lblApplyPeople" runat="server"></asp:Label></td>
                <td width="25%">申请时间<span style="color:Red;">*</span></td>
                <td width="25%">
                <asp:TextBox ID="txtApplyDate" runat="server" onclick="WdatePicker()" SkinID="skinid3" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="valRDate" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate"></asp:RequiredFieldValidator>
               
                </td>
            </tr>
            <tr>
                <td rowspan="3">项目</td>
                <td style="height: 25px">项目名称<span style="color:Red;">*</span></td>
                <td colspan="2" style="text-align:left; height: 25px;">
                <asp:DropDownList ID="ddlProject" runat="server"  OnSelectedIndexChanged="ddlProject_SelectedIndexChanged" SkinID="ddl1"></asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td>项目阶段</td>
                <td colspan="2" style="text-align:left;"><asp:DropDownList ID="ddlProjectStep" runat="server" AutoPostBack="true" SkinID="ddl1"></asp:DropDownList></td>
            </tr>
             <tr>
                <td>项目金额(元)</td>
                <td colspan="2"><asp:Label ID="lblMoneyNum" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>申请费用(元)</td>
                <td colspan="3" style="text-align:left;"><asp:TextBox ID="txtApplyMoney" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td >申请特殊费用原因</td>
                <td colspan="3">
                 <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine"></asp:TextBox>
                </td>
            </tr>
        </table>
         <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;"><asp:Image ID="imgMarket" runat="server" ImageUrl="~/images/hechun.jpg" Visible="false" /></td>
                <td style="width:15%;">总经理：</td>
                <td style="width:35%;"></td>
            </tr>
        </table>
        </td>
        </tr>
    </table>

</asp:Content>
 <asp:Content ContentPlaceHolderID="Content2" runat="server">
  <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td colspan="2" style="text-align:right;">
                   <asp:Button ID="btnSign" runat="server" Text="签名" OnClick="btnSign_Click" />
                </td>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click" />
                </td>
               <td>
                  <asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" ValidationGroup="btn1" />
               </td> 
           </tr>
        </table>
 </asp:Content>   

        