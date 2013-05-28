<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="Project.aspx.cs" Inherits="OA.ClientManage.Project" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>君众项目列表</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td  style="width:10%; text-align:right;"><asp:Label ID="lblProjectName" Text="项目名称:" runat="server"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:TextBox ID="txtProjectName" runat="server" ></asp:TextBox></td>
                                        <td  style="width:8%; text-align:right;"><asp:Label ID="lblProjectLevel" runat="server" Text="项目级别:"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:DropDownList ID="ddlProjectLevel" runat="server"></asp:DropDownList></td>
                                        <td  style="width:5%; text-align:left;"><asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" /></td>
                                        <td style=" width:10%; text-align:left;"><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
                                        <td style="width:40%; text-align:right;"><asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click" /></td>
                                            <td style=" width:1%;"></td>            
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                               <asp:GridView ID="gvProject" runat="server" DataKeyNames="MainProjectCreateId" AllowSorting="true" CellPadding="1" AutoGenerateColumns="false" Width="100%" EmptyDataText="没有数据" OnRowCancelingEdit="gvProject_RowCancelingEdit" OnRowDataBound="gvProject_RowDataBound" OnRowDeleting="gvProject_RowDeleting" OnRowEditing="gvProject_RowEditing" OnRowUpdating="gvProject_RowUpdating" OnSorting="gvProject_Sorting">
                                  <Columns>
                                         <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="项目编号" SortExpression="SheetNum">
                                            <ItemTemplate>
                                                <asp:Label ID="lblSheetNum" runat="server" Text='<%#Eval("SheetNum") %>'></asp:Label>
                                            </ItemTemplate>
                                            <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="客户名称" SortExpression="ClientName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblClientName" runat="server" Text='<%#Eval("ClientName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="ddlClient" runat="server"></asp:TextBox>
                                            </EditItemTemplate>
                                              <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="项目名称" SortExpression="ProjectName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblProjectName" runat="server" Text='<%#Eval("ProjectName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtProjectName" runat="server" Text='<%#Eval("ProjectName") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                              <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="项目级别" SortExpression="ProjectLevelName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblProjectLevelName" runat="server" Text='<%#Eval("ProjectLevelName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:DropDownList ID="ddlProjectLevel" runat="server"></asp:DropDownList>
                                            </EditItemTemplate>
                                              <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="项目类别" SortExpression="ProjectTypeName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblProjectType" runat="server" Text='<%#Eval("ProjectTypeName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:DropDownList ID="ddlProjectType" runat="server"></asp:DropDownList>
                                            </EditItemTemplate>
                                              <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="预计金额" SortExpression="PreMoney">
                                            <ItemTemplate>
                                                <asp:Label ID="lblPreMoney" runat="server" Text='<%#Eval("PreMoney") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtPreMoney" runat="server" Text='<%#Eval("PreMoney") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                              <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="预计毛利" SortExpression="PreProfit">
                                            <ItemTemplate>
                                                <asp:Label ID="lblPreProfit" runat="server" Text='<%#Eval("PreProfit") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtPreProfit" runat="server" Text='<%#Eval("PreProfit") %>'></asp:TextBox>
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
                                                <asp:Button ID="btnEdit" runat="server" CausesValidation="False" Text="编辑" CommandName="Edit"/>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                 <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
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
      