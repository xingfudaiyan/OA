<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RoleGv.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.SysManage.RoleGv" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:99%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>角色管理</h2></td>
                        </tr>
                        <tr>
                            <td style=" text-align:right;"> 
                                  <asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click" />  
                            </td>
                            <td style="width:3%;"></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                 <asp:GridView ID="gvRole" runat="server" AutoGenerateColumns="False" DataKeyNames="RoleId" CellPadding="3" Width="100%" EmptyDataText="没有数据" OnRowCancelingEdit="gvRole_RowCancelingEdit" OnRowDeleting="gvRole_RowDeleting" OnRowEditing="gvRole_RowEditing" OnRowUpdating="gvRole_RowUpdating" >
                                    <Columns>
                                        <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="角色名称">
                                            <ItemTemplate>
                                                <asp:Label ID="lblMasterName" runat="server" Text='<%#Eval("RoleName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtRoleName" runat="server" Text='<%#Eval("RoleName") %>' ></asp:TextBox>
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
                                        <asp:TemplateField ShowHeader="False">
                                            <ItemTemplate>
                                                <asp:Button ID="btnDelete" runat="server" CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <AlternatingRowStyle BackColor="#F2F0F0" />
                                   <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                   <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
                                 </asp:GridView>
                             
                                        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="20" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
                                        </webdiyer:AspNetPager>
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
        

             
                           