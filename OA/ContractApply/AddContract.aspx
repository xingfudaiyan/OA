<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddContract.aspx.cs" Inherits="OA.ContractApply.AddContract" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>合同\协议申请</h1></td>
        </tr>
        <tr>
            <td colspan="2" style=" text-align:right;">
                表单编号：<span style="color:Red;">*</span>
                <asp:TextBox ID="txtSheetNum" runat="server" SkinID="skinid6" ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td>申请部门</td>
                <td><asp:Label ID="lblDepart" runat="server"></asp:Label></td>
                <td>申请人</td>
                <td><asp:Label ID="lblEmployee" runat="server"></asp:Label></td>
            </tr>
            <tr>
             <td>类型<span style="color:Red;">*</span></td>
             <td><asp:DropDownList ID="ddlContractType" runat="server" AutoPostBack="true" SkinID="ddl90" OnSelectedIndexChanged="ddlContractType_SelectedIndexChanged"></asp:DropDownList></td>
             <td>签约方<span style="color:Red;">*</span></td>
             <td><asp:DropDownList ID="ddlAuto" runat="server" AutoPostBack="true" SkinID="ddl90" OnSelectedIndexChanged="ddlAuto_SelectedIndexChanged"></asp:DropDownList></td>
            </tr>
             <tr>
                <td>编号</td>
                 <td style="text-align:left;">
                 <asp:TextBox ID="txtContractNum" runat="server" SkinID="skinid3" ></asp:TextBox>
                 </td>
                <td>名称<span style="color:Red;">*</span></td>
                <td> 
                <asp:TextBox ID="txtContractName" runat="server" SkinID="skinid3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="var" runat="server" ErrorMessage="必填" ControlToValidate="txtContractName"></asp:RequiredFieldValidator></td>
                 
               
            </tr>
            <tr>
               <td>生效日期</td>
                <td style=" text-align:left;">
                <asp:TextBox ID="txtBeginDate" runat="server" SkinID="skinid3" onclick="WdatePicker()" ></asp:TextBox>
                </td>
               <td>申请日期<span style="color:Red;">*</span></td>
                <td>
                <asp:TextBox ID="txtApplyDate" runat="server" SkinID="skinid3" onclick="WdatePicker()"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate"></asp:RequiredFieldValidator>
               
                </td>
            </tr>
            <tr>
                 <td>用章类型<span style="color:Red;">*</span></td>
                <td>
                    <asp:RadioButtonList ID="rblSignType" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0">合同章</asp:ListItem>
                        <asp:ListItem Value="1">公章</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>附件</td>
                <td>
                <asp:FileUpload ID="UpFile" runat="server" SkinID="fu90" />
                </td>
            </tr>
            <tr>
                <td>概述</td>
                <td colspan="3"><asp:TextBox ID="txtContractDes" runat="server" TextMode="MultiLine" SkinID="skinid1"></asp:TextBox></td>
                
            </tr>
            <tr>
                 <td rowspan="3">金额</td>
                 <td>大写(元)</td>
                 <td colspan="2" style="text-align:left;"><asp:TextBox ID="txtBigMoney" runat="server" SkinID="skinid3" ></asp:TextBox>
                 </td> 
            </tr>
            <tr>
                 <td>小写(元)￥</td>
                 <td colspan="2" style="text-align:left;">
                 <asp:TextBox ID="txtSmallMoney" runat="server" SkinID="skinid3"></asp:TextBox>
                 </td>
            </tr>
            <tr>
                <td>其他</td>
                <td colspan="2" style="text-align:left;"><asp:CheckBox ID="ckbIsMoney" runat="server" Text="不涉及金额" /></td>
            </tr>
           <tr>
                <td>部门经理意见</td>
                <td><asp:TextBox ID="txtSectionView" runat="server" TextMode="MultiLine"></asp:TextBox></td>
                 <td>总经理意见</td>
                <td><asp:TextBox ID="txtManagerView" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox></td>
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
                   <asp:Button ID="btnCancel" runat="server" Text="返回"  ValidationGroup="btn1" OnClick="btnCancel_Click"/>
               </td> 
           </tr>
</table>
</asp:Content>
        
