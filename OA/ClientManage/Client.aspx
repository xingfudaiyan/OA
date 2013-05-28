<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="Client.aspx.cs" Inherits="OA.ClientManage.Client" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>客户信息列表</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td  style="width:10%; text-align:right;"><asp:Label ID="lblclname" Text="客户名称:" runat="server"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:TextBox ID="txtClientName" runat="server" ></asp:TextBox></td>
                                        <td  style="width:8%; text-align:right;"><asp:Label ID="lblClientLevel" runat="server" Text="客户等级"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:DropDownList ID="ddlClientLevel" runat="server"></asp:DropDownList></td>
                                        <td  style="width:5%; text-align:left;"><asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" /></td>
                                        <td style=" width:10%; text-align:left;"><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
                                        <td style="width:40%; text-align:right;"><asp:Button id="btnAddClient" runat="server" Text="新增"  OnClick="btnAddClient_Click"/></td>
                                        <td style="width:6%;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                              <asp:GridView ID="gvClient" runat="server"  AutoGenerateSelectButton="True" AutoGenerateColumns="False" AllowSorting="True"  DataKeyNames="ClientId" CellPadding="1" Width="100%"
 EmptyDataText="没有数据" OnRowCancelingEdit="gvClient_RowCancelingEdit" OnRowDeleting="gvClient_RowDeleting" OnRowEditing="gvClient_RowEditing" OnRowUpdating="gvClient_RowUpdating" OnRowDataBound="gvClient_RowDataBound" OnSelectedIndexChanging="gvClient_SelectedIndexChanging" OnSorting="gvClient_Sorting" >
                                    <Columns>
                                         <asp:TemplateField Visible="False">
                                            <ItemTemplate >
                                                <asp:Label ID="lblClientId" runat="server" Text='<%#Eval("ClientId") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                             <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="客户编号" SortExpression="SheetNum">
                                            <ItemTemplate>
                                                <asp:Label ID="lblClientNum" runat="server" Text='<%#Eval("SheetNum") %>'></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="客户名称" SortExpression="ClientName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblClientName" runat="server" Text='<%#Eval("ClientName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="txtClientName" runat="server" Text='<%#Eval("ClientName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="客户等级" SortExpression="ClientLevelName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblClientLevel" runat="server" Text='<%#Eval("ClientLevelName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:DropDownList ID="ddlClientLevel" runat="server"></asp:DropDownList> 
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="电话" >
                                            <ItemTemplate>
                                                <asp:Label ID="lblTelephone" runat="server" Text='<%#Eval("Telephone") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:TextBox ID="txtTelephone" runat="server" Text='<%#Eval("Telephone") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="邮编">
                                            <ItemTemplate>
                                                <asp:Label ID="lblMailNo" runat="server" Text='<%#Eval("MailNo") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtMailNo" runat="server" Text='<%#Eval("MailNo") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="传真">
                                            <ItemTemplate>
                                                <asp:Label ID="lblFax" runat="server" Text='<%#Eval("Fax") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtFax" runat="server" Text='<%#Eval("Fax") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="地址">
                                            <ItemTemplate>
                                                <asp:Label ID="lblAddress" runat="server" Text='<%#Eval("Address") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtAddress" runat="server" Text='<%#Eval("Address") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update"
                                                    Text="更新"></asp:LinkButton>
                                                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                                                    Text="取消"></asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                 <asp:Button ID="btnEdit" runat="server" CausesValidation="false" CommandName="Edit" Text="编辑" />
                                            </ItemTemplate>
                                             <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                    
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                 <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
                                            </ItemTemplate>
                                             <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:Button ID="btnRelate" Text="添加联系人" runat="server" CommandName="Select" CommandArgument='<%#Eval("ClientId") %>' OnClick="btnRelate_Click" />
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                    </Columns>
                                    <AlternatingRowStyle BackColor="#F2F0F0" />
                                   <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                   <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                </asp:GridView> 
                              <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
                                </webdiyer:AspNetPager>
                             
                             
                                <asp:GridView ID="gvRelate" runat="server" AutoGenerateColumns="False" DataKeyNames="RelateId" OnRowCancelingEdit="gvRelate_RowCancelingEdit" OnRowDeleting="gvRelate_RowDeleting" Width="100%" OnRowEditing="gvRelate_RowEditing" OnRowUpdating="gvRelate_RowUpdating" OnRowDataBound="gvRelate_RowDataBound">
                                    <Columns>
                                         <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                             <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField Visible="False">
                                        <ItemTemplate >
                                                <asp:Label ID="lblClientId" runat="server" Text='<%#Eval("ClientId") %>'></asp:Label>
                                        </ItemTemplate>
                                         
                                       </asp:TemplateField>
                                        <asp:TemplateField HeaderText="联系人">
                                        <ItemTemplate>
                                            <asp:Label ID="lblRelateName" runat="server" Text='<%#Eval("RelateName") %>' ></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtRelateName" runat="server" Text='<%#Eval("RelateName") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                         <ItemStyle Width="15%" />
                                       </asp:TemplateField>
                                    <asp:TemplateField HeaderText="手机">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("Mobile") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtMobile" runat="server" Text='<%#Eval("Mobile") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                         <ItemStyle Width="15%" />
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="邮箱">
                                        <ItemTemplate>
                                            <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <asp:TextBox ID="txtEmail" runat="server" Text='<%#Eval("Email") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                         <ItemStyle Width="15%" />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="职务">
                                        <ItemTemplate>
                                            <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("Position") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                          <asp:TextBox ID="txtPosition" runat="server"  Text='<%#Eval("Position") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                         <ItemStyle Width="15%" />
                                    </asp:TemplateField>
                                    
                                    <asp:TemplateField HeaderText="备注">
                                        <ItemTemplate>
                                            <asp:Label ID="lblMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:Label>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                           <asp:TextBox ID="txtMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                         <ItemStyle Width="15%" />
                                    </asp:TemplateField>
                                        <asp:TemplateField ShowHeader="False">
                                            <EditItemTemplate>
                                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update"
                                                    Text="更新"></asp:LinkButton>
                                                <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                                                    Text="取消"></asp:LinkButton>
                                            </EditItemTemplate>
                                            <ItemTemplate>
                                                <asp:Button ID="btnEdit" runat="server" CausesValidation="false" CommandName="Edit" Text="编辑" />
                                                
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                       
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                 <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        
                                    </Columns>
                                    <AlternatingRowStyle BackColor="#F2F0F0" />
                                   <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                   <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                </asp:GridView>
                                <webdiyer:AspNetPager ID="AspNetPager2" runat="server" Visible="false" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager2_PageChanged">
                                </webdiyer:AspNetPager>
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
      