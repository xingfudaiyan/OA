<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="Asset.aspx.cs" Inherits="OA.Asset" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ContentPlaceHolderID="Content1" runat="server">
      <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>办公用品列表</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1" style="width:100%">
                                <tr>
                                        <td  style="width:10%; text-align:right;">  <asp:FileUpload ID="myFile" runat="server" /></td>
                                        <td  style="width:10%; text-align:left;"> <asp:Button ID="btnInExecel" runat="server" Text="Excel导入" OnClick="btnInExecel_Click" /></td>
                                        <td  style="width:10%; text-align:left;"> <asp:Button ID="btnOutExecel" runat="server" Text="Excel导出" OnClick="btnOutExecel_Click" /></td>
                                        <td  style="width:70%; text-align:right;"><asp:Button id="btnAdd" runat="server" Text="新增"   OnClick="btnAdd_Click" /></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                <asp:GridView ID="gvAsset" runat="server" AutoGenerateColumns="False" AllowSorting="true" DataKeyNames="AssetId" CellPadding="3" Width="100%" EmptyDataText="没有数据" OnRowCancelingEdit="gvAsset_RowCancelingEdit" OnRowDeleting="gvAsset_RowDeleting" OnRowUpdating="gvAsset_RowUpdating" OnRowDataBound="gvAsset_RowDataBound" OnRowEditing="gvAsset_RowEditing" PageSize="20" OnSorting="gvAsset_Sorting">
                                    <Columns>
                                       <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="品名" SortExpression="AssetName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblAssetName" runat="server" Text='<%#Eval("AssetName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="txtAssetName" runat="server" Text='<%#Eval("AssetName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="数量" SortExpression="Amount">
                                            <ItemTemplate>
                                                <asp:Label ID="lblAmount" runat="server" Text='<%#Eval("Amount") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtAmount" runat="server" Text='<%#Eval("Amount") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="计量单位" SortExpression="UnitName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblUnitId" runat="server" Text='<%#Eval("UnitName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtUnit" runat="server" Text='<%#Eval("UnitName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="使用部门" SortExpression="DepartName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblDepart" runat="server" Text='<%#Eval("DepartName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                              <asp:TextBox ID="txtDepart" runat="server" Text='<%#Eval("DepartName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="存放地点" SortExpression="SiteName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblSite" runat="server" Text='<%#Eval("SiteName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                              <asp:TextBox ID="txtSite" runat="server" Text='<%#Eval("SiteName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="价格" SortExpression="Price">
                                           <ItemTemplate>
                                                <asp:Label ID="lblPrice" runat="server" Text='<%#Eval("Price") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtPrice" runat="server" Text='<%#Eval("Price") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="规格" SortExpression="Type">
                                           <ItemTemplate>
                                                <asp:Label ID="lblType" runat="server" Text='<%#Eval("Type") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtType" runat="server" Text='<%#Eval("Type") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="备注">
                                           <ItemTemplate>
                                                <asp:Label ID="lblMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:TextBox>
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
                </td>
            </tr>
        </table>
</asp:Content>
     