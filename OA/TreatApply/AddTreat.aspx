<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddTreat.aspx.cs" Inherits="OA.TreatApply.AddTreat" %>


<asp:Content  ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>业务费用申请表</h1></td>
        </tr>
         <tr>
            <td colspan="2" style="text-align:right;">表单编号:<span style="color:Red;">*</span><asp:TextBox ID="txtSheetNum" runat="server" SkinID="skinid4" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="16%">申请人</td>
                <td width="17%"><asp:Label ID="lblApplyPeople" runat="server"></asp:Label></td>
                <td width="16%">部门</td>
                <td width="17%"><asp:Label ID="lblDepart" runat="server"></asp:Label></td>
                <td width="16%">申请日期<span style="color:Red;">*</span></td>
                <td width="17%">
                <asp:TextBox ID="txtApplyDate" runat="server" onclick="WdatePicker()" SkinID="skinid5"></asp:TextBox>
                <asp:RequiredFieldValidator ID="valrDate" runat="server" ErrorMessage="必填" ControlToValidate="txtApplyDate"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="3">被招待人单位</td>
                <td colspan="3">我司陪同人员<span style="color:Red;">*</span></td>
            </tr>
            <tr>
                <td colspan="3" style=" vertical-align:top;">
                    <asp:GridView ID="gvBRelate" runat="server" EmptyDataText="没有被招待人员" AutoGenerateColumns="False" DataKeyNames="RelateBExpId" Width="100%" OnRowDeleting="gvBRelate_RowDeleting">
                    <Columns>
                         <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="姓名">
                            <ItemTemplate>
                             <asp:Label ID="lblName" runat="server" Text='<%#Eval("RelateName") %>'></asp:Label>
                            </ItemTemplate>
                            
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="职务">
                        <ItemTemplate>
                            <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("Position") %>'></asp:Label>
                        </ItemTemplate>
                        
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                    Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                </td>
                <td colspan="3" style=" vertical-align:top;">
                    <asp:GridView ID="gvBEmployee" runat="server" EmptyDataText="没有陪同人员" AutoGenerateColumns="False" DataKeyNames="EmployeeBExpId" Width="100%" OnRowDeleting="gvBEmployee_RowDeleting" >
                    <Columns>
                         <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="姓名">
                            <ItemTemplate>
                             <asp:Label ID="lblName" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                            </ItemTemplate>
                           
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="职务">
                        <ItemTemplate>
                            <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("PositionName") %>'></asp:Label>
                        </ItemTemplate>
                      
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                    Text="删除"></asp:LinkButton>
                            </ItemTemplate>
                          
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>备注</td>
                <td colspan="2">
                 <asp:TextBox ID="txtMemo" runat="server" SkinID="skinid1"></asp:TextBox>
                </td>
                <td>人数总计</td>
                <td colspan="2"><asp:Label ID="lblPeopleNum" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>接待事由</td>
                <td colspan="5"><asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td>费用项目</td>
                 <td style="text-align:left;"><asp:TextBox ID="txtItem1" runat="server" SkinID="skinid5"></asp:TextBox></td>
                  <td style="text-align:left;"><asp:TextBox ID="txtItem2" runat="server" SkinID="skinid5"></asp:TextBox></td>
                   <td style="text-align:left;"><asp:TextBox ID="txtItem3" runat="server" SkinID="skinid5"></asp:TextBox></td>
                    <td style="text-align:left;"><asp:TextBox ID="txtItem4" runat="server" SkinID="skinid5"></asp:TextBox></td>
                     <td><asp:Button ID="btnSum" runat="server" Text="小计" OnClick="btnSum_Click" /></td>
            </tr>
            <tr>
                <td>金额(元)</td>
                  <td style="text-align:left;">
                  <asp:TextBox ID="txtMoney1" runat="server" SkinID="skinid5"></asp:TextBox><asp:RegularExpressionValidator ID="valE1" runat="server" ErrorMessage="数字" ControlToValidate="txtMoney1" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator></td>
                    <td style="text-align:left;"><asp:TextBox ID="txtMoney2" runat="server" SkinID="skinid5"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="数字" ControlToValidate="txtMoney2" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator></td>
                    <td style="text-align:left;"><asp:TextBox ID="txtMoney3" runat="server" SkinID="skinid5"></asp:TextBox> <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="数字" ControlToValidate="txtMoney3" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator></td>
                    <td style="text-align:left;"><asp:TextBox ID="txtMoney4" runat="server" SkinID="skinid5"></asp:TextBox><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="数字" ControlToValidate="txtMoney4" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator></td>
                    <td style="text-align:left;"><asp:TextBox ID="txtMoneySum" runat="server" SkinID="skinid5"></asp:TextBox></td>
            </tr>
        </table>
       
        </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content2" runat="server">
       <table class="Tb_Blank" style="width:100%;">
             <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click" />
                </td>
               <td>
                    <asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" ValidationGroup="btn1" />
               </td> 
           </tr>
        </table>
        <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:60%;">
                     <table class="Tb_Common">
                        <tr>
                            <td style="width:35%;">被招待人单位</td>
                            <td style="width:35%;">姓名</td>
                            <td style="width:30%;"></td>
                        </tr>
                        <tr>
                            <td><asp:DropDownList ID="ddlClient" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlClient_SelectedIndexChanged"></asp:DropDownList></td>
                            <td><asp:DropDownList ID="ddlRelate" runat="server" Width="93%"></asp:DropDownList></td>
                            <td><asp:Button ID="btnAddRelate" runat="server" Text="新增" OnClick="btnAddRelate_Click" /></td>
                        </tr>
                     </table>
                </td>
                <td style="width:40%;">
                        <table class="Tb_Common">
                            <tr>
                                <td style="width:60%;">我司陪同人员</td>
                                <td style="width:40%;"></td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlEmployee" runat="server" SkinID="skinid2"></asp:DropDownList></td>
                                <td><asp:Button ID="btnAddEmployee" runat="server" Text="新增" OnClick="btnAddEmployee_Click" /></td>
                            </tr>
                        </table> 
                </td>
            </tr>
        </table>
</asp:Content>
       
   

