<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Apply1.Master"  CodeBehind="AddOffice.aspx.cs" Inherits="OA.OfficeApply.AddOffice" %>


         <asp:Content ContentPlaceHolderID="Content1" runat="server">
            <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td colspan="2"><h1>借（付）款申请表</h1></td>
            </tr>
             <tr>
                <td colspan="2">
                    <table class="Tb_Common" >
                        <tr>
                             <td style="width:20%;">借款部门</td>
                             <td style="width:30%;">
                                 <asp:Label ID="lblJieDepart" runat="server" ></asp:Label></td>
                             <td style="width:20%;">经办人</td>
                             <td style="width:30%;">
                                 <asp:Label ID="lblJinEmployee" runat="server" ></asp:Label></td>
                        </tr>
                         <tr>
                             <td>办款部门</td>
                             <td>
                                 <asp:Label ID="lblBanDepart" runat="server" ></asp:Label></td>
                             <td>出纳人</td>
                             <td></td>
                             
                        </tr>
                         <tr>
                             <td >使用部门<span style="color:Red;">*</span></td>
                             <td colspan="3" style="text-align:center; ">
                              <asp:TextBox ID="txtUseDepart" runat="server"></asp:TextBox></td>
                            
                        </tr>
                         <tr>
                             <td style="height:120px;">借款用途及理由<span style="color:Red;">*</span></td>
                             <td colspan="3" style="text-align:left;"  >
                                 <asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" SkinID="txtHeight120" ></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="re" runat="server" ErrorMessage="必填" ControlToValidate="txtReason"></asp:RequiredFieldValidator>
                             </td>
                                
                        </tr>
                         <tr>
                             <td rowspan="2" >借款金额<span style="color:Red;">*</span></td>
                             <td colspan="3" style="text-align:left;">
                              (大写)￥
                                 <asp:TextBox ID="txtBigMoney" runat="server" SkinID="skinid3"></asp:TextBox>
                                   <asp:RequiredFieldValidator ID="re1" runat="server" ErrorMessage="必填" ControlToValidate="txtBigMoney"></asp:RequiredFieldValidator>
                                 </td>
                               
                        </tr>
                       <tr>
                          <td colspan="3" style="text-align:left;">
                          (小写)￥
                              <asp:TextBox ID="txtSmallMoney" runat="server" SkinID="skinid3"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtSmallMoney"></asp:RequiredFieldValidator>
                              </td>
                              
                       </tr>
                         <tr>
                             <td>付款方式</td>
                             <td >
                                 <asp:TextBox ID="txtFuMoney" runat="server" SkinID="skinid3"></asp:TextBox></td>
                             <td >付款时间</td>
                             <td>
                             <asp:TextBox ID="txtFuTime" runat="server"  SkinID="skinid3"></asp:TextBox>
                            
                             </td>
                        </tr>
                           <tr>
                              <td >部门经理意见</td>
                               <td>
                               <asp:TextBox ID="txtDepartView" runat="server"></asp:TextBox>
                              </td>
                               <td>总经理意见</td>
                               <td >
                               </td>
                            </tr>
                    </table>
                </td>
            </tr>
        </table>
         </asp:Content>
         
         <asp:Content ContentPlaceHolderID="Content2" runat="server">
             <table class="Tb_Blank1">
             <tr>
                <td >
                    <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click" /></td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" ValidationGroup="btn1" /></td>
            </tr>
          </table>
         </asp:Content>
         
        
        
        
        
      


