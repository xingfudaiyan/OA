<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperationList.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.SysManage.OperationList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:99%; text-align:center;">
                        <tr>
                            <td colspan="2" style="height: 48px"><h2>权限分配</h2></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                 <asp:GridView ID="gvProcess" runat="server" AutoGenerateColumns="False" DataKeyNames="ProcessId,RoleId" CellPadding="3" Width="100%" EmptyDataText="没有数据" OnRowCancelingEdit="gvProcess_RowCancelingEdit" OnRowDataBound="gvProcess_RowDataBound" OnRowEditing="gvProcess_RowEditing" OnRowUpdating="gvProcess_RowUpdating" OnSorting="gvProcess_Sorting">
                                    <Columns>
                                        <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="流程" SortExpression="ProcessName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblName1" runat="server" Text='<%#Eval("ProcessName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="角色" SortExpression="RoleName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblName2" runat="server" Text='<%#Eval("RoleName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                          <asp:TemplateField HeaderText="操作">
                                            <ItemTemplate>
                                                <asp:CheckBoxList ID="ckblOperation" runat="server" RepeatDirection="Horizontal" Enabled="false"></asp:CheckBoxList>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:CheckBoxList ID="ckblOperation" runat="server" RepeatDirection="Horizontal"></asp:CheckBoxList>
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
                                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Edit"
                                                    Text="编辑"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <AlternatingRowStyle BackColor="#F2F0F0" />
                                   <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                   <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
                                 </asp:GridView>
                             
                                        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="19" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
                                        </webdiyer:AspNetPager>
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
        

             
                           