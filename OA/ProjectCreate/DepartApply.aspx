<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="DepartApply.aspx.cs" Inherits="OA.ProjectCreate.DepartApply" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>销售立项申请</h2></td>
                        </tr>
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td  style="width:8%; text-align:right;"> <asp:Label ID="lblClientName" runat="server" Text="客户名称"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:DropDownList ID="ddlClient" runat="server"></asp:DropDownList></td>
                                        <td  style="width:5%; text-align:left;"><asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click"  /></td>
                                        <td  style="width:10%; text-align:left;"><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
                                        <td  style="width:40%; text-align:right;"><asp:Button ID="btnAddSale" runat="server" Text="新增" OnClick="btnAddSale_Click"/> </td>
                                        <td style="width:6%;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                   <asp:GridView ID="gvSale" runat="server" AllowSorting="true" AutoGenerateColumns="false" CellPadding="1" DataKeyNames="ProjectCreateId" Width="100%" OnRowDataBound="gvSale_RowDataBound" OnRowDeleting="gvSale_RowDeleting" OnSorting="gvSale_Sorting" >
                                        <Columns>
                                              <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                    <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                 <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="表单编号" SortExpression="SheetNum"> 
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbtnDetail" runat="server" style="text-decoration:none;" Text='<%#Eval("SheetNum") %>' CommandArgument='<%#Eval("ProjectCreateId") %>' CausesValidation="false" OnClick="lbtnDetail_Click" ></asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="项目名称" SortExpression="ProjectName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblProjectName" runat="server"  Text='<%#Eval("ProjectName") %>'></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="客户名称" SortExpression="ClientName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblClientName" runat="server" Text='<%#Eval("ClientName") %>'></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                           <asp:TemplateField HeaderText="状态" SortExpression="State">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblState" runat="server" ></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                        <asp:TemplateField HeaderText="申请时间" SortExpression="ApplyTime">
                                            <ItemTemplate>
                                                <asp:Label ID="lblApplyTime" runat="server" Text='<%#Eval("ApplyTime") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                      <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="申请" runat="server" CommandArgument='<%#Eval("ProjectCreateId") %>' CausesValidation="false" OnClientClick="return confirm('确认要申请吗？');" OnClick="btnSubmit_Click"  />
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:Button ID="btnEdit" Text="编辑" runat="server"  CommandArgument='<%#Eval("ProjectCreateId") %>' CausesValidation="false" OnClick="btnEdit_Click"    />
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnDelete" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('确认要删除吗？');"
                                                        Text="删除" CommandArgument='<%#Eval("ProjectCreateId") %>'></asp:Button>
                                                </ItemTemplate>
                                                 <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                        </Columns>
                                        <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                    </asp:GridView>
                                       <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
                                       </webdiyer:AspNetPager> 
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>

       
      
         
          