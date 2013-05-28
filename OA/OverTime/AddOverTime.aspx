<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddOverTime.aspx.cs" MasterPageFile="~/Apply.Master" Inherits="OA.OverTime.AddOverTime" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td><h4>加班申请单</h4></td>
        </tr>
         <tr>
            <td>
                <table class="Tb_Common">
                    <tr>
                        <td style="width:10%;">
                        申请日期：
                        </td>
                          <td style="width:23%;">
                            <asp:TextBox ID="txtApplyDate" runat="server" SkinID="skinid3"  onclick="WdatePicker()"></asp:TextBox>
                        </td>
                          <td style="width:10%;">
                          申请时间：
                        </td>
                          <td style="width:23%;">
                            <asp:TextBox ID="txtTimeFrom" runat="server" SkinID="skinid3"></asp:TextBox>时
                        </td>
                          <td style="width:10%;">
                          ------
                        </td>
                          <td style="width:23%; ">
                            <asp:TextBox ID="txtTimeTo" runat="server" SkinID="skinid3"></asp:TextBox>时
                        </td>
                    </tr>
                   <tr>
                        <td>
                        申请部门：
                        </td>
                          <td>
                           技术部
                        </td>
                          <td>
                          申请人：
                        </td>
                          <td>
                           <asp:Label ID="lblApplyEmName" runat="server"></asp:Label>
                        </td>
                          <td>
                          主管经理：
                        </td>
                        <td>
                            马斌
                        </td>
                    </tr>
                    <tr>
                        <td>加班原因：</td>
                        <td colspan="3" style="text-align:left;"><asp:TextBox ID="txtReason" runat="server" TextMode="MultiLine" SkinID="skinid1"></asp:TextBox></td>
                        <td>历时（数字)</td>
                        <td><asp:TextBox ID="txtTimeSpan" runat="server" SkinID="skinid3"></asp:TextBox>分</td>
                    </tr>
                </table>
            </td>
         </tr>
        <tr>
           <td>
             <table class="Tb_Blank" style="width:100%;"> 
                <tr>
                 <td style="text-align:right; width:58%;"><h4>加班组（组员）名单</h4></td>
                  <td style="text-align:right;  width:42%;">
                      <asp:Button ID="btnAdd" runat="server" Text="新增记录" OnClick="btnAdd_Click" /> 
                 </td>
                </tr>
             </table>
           </td>
           
        </tr>
        <tr>
           
        </tr>
         <tr>
            <td> 
                <asp:GridView ID="gvOtGroup" runat="server" AutoGenerateColumns="False" DataKeyNames="OtGroupId" CellPadding="1" Width="100%" OnRowDataBound="gvOverTime_RowDataBound" OnRowDeleting="gvOverTime_RowDeleting" OnRowEditing="gvOverTime_RowEditing" OnRowUpdating="gvOverTime_RowUpdating" OnRowCancelingEdit="gvOverTime_RowCancelingEdit"  >
                    <Columns>
                            <asp:TemplateField HeaderText="序号">
                                <ItemTemplate>
                                   <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                             </asp:TemplateField>
                            <asp:TemplateField HeaderText="组别" >
                                <ItemTemplate>
                                    <asp:Label ID="lblGroupName" runat="server" Text='<%#Eval("GroupName") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtGroupName" runat="server" Text='<%#Eval("GroupName") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="姓名" >
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("ApplyName") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtApplyName" runat="server" Text='<%#Eval("ApplyName") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <EditItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update"
                                    Text="更新"></asp:LinkButton>
                                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                                    Text="取消"></asp:LinkButton>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Edit"
                                    Text="编辑"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" CommandName="Delete"
                                    Text="删除" OnClientClick="return confirm('确认要删除吗？');" CommandArgument='<%#Eval("OtGroupId") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="20" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged"  >
                </webdiyer:AspNetPager>
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ContentPlaceHolderID="Content2" runat="server">
      <table class="Tb_Blank" style="width:100%;">
             <tr>
               <td>
                  <asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"   />
               </td> 
               <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td> 
            </tr>
        </table>
</asp:Content>