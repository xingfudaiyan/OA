<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="SupplyManage.aspx.cs" Inherits="OA.Supply.SupplyManage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ContentPlaceHolderID="Content1" runat="server">

<table class="Tb_Blank" style="width:100%;">
    <tr>
        <td><h1>供应商管理</h1></td>
    </tr>
    <tr>
        <td style="text-align:right;">
            <asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gvSupply" runat="server" AutoGenerateColumns="False" DataKeyNames="SupplyId" Width="100%" AllowSorting="True" CellPadding="3" EmptyDataText="没有数据" OnRowCancelingEdit="gvSupply_RowCancelingEdit" OnRowDataBound="gvSupply_RowDataBound" OnRowDeleting="gvSupply_RowDeleting" OnRowEditing="gvSupply_RowEditing" OnRowUpdating="gvSupply_RowUpdating" OnSorting="gvSupply_Sorting">
                <Columns>
                       <asp:TemplateField HeaderText="序号">
                          <ItemTemplate>
                            <asp:Label ID="lblNum" runat="server" Text=' <%#Container.DataItemIndex+1 %>' ></asp:Label>
                          </ItemTemplate>
                      </asp:TemplateField>
                    <asp:TemplateField HeaderText="供应商编号" SortExpression="SheetNum">
                        <ItemTemplate>
                            <asp:Label ID="lblSheetNum" runat="server" Text='<%#Eval("SheetNum") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSheetNum" runat="server" Text='<%#Eval("SheetNum") %>'></asp:TextBox>
                        </EditItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="供应商名称" SortExpression="SupplyName">
                        <ItemTemplate>
                            <asp:Label ID="lblSpName" runat="server" Text='<%#Eval("SupplyName") %>'></asp:Label>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <asp:TextBox ID="txtSpName" runat="server" Text='<%#Eval("SupplyName") %>'></asp:TextBox>
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
                                                <asp:Button ID="btnEdit" runat="server" Text="编辑" CausesValidation="False" CommandName="Edit" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                    <asp:TemplateField>
                         <ItemTemplate>
                           <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
                         </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                 <AlternatingRowStyle BackColor="#F2F0F0" />
                 <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                 <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
            </asp:GridView>
             <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="40" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
           </webdiyer:AspNetPager>
        </td>
    </tr>
</table>
</asp:Content>