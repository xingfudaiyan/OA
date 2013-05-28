<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="Employee.aspx.cs" Inherits="OA.Employee" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td><h2>君众成员列表</h2></td>
                        </tr>
                        
                        <tr>
                        <td>
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="text-align:right;"> <asp:Button ID="btnAddEmployee" runat="server"  Text="新增" OnClick="btnAddEmployee_Click" /></td> 
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td style="height:300px; vertical-align:top;">
                                   <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False"  DataKeyNames="EmployeeId" CellPadding="3" Width="100%" EmptyDataText="没有数据" OnRowDeleting="gvEmployee_RowDeleting" OnRowDataBound="gvEmployee_RowDataBound" >
                                        <Columns>
                                            <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                    <%#(this.AspNetPager1.CurrentPageIndex-1)*this.AspNetPager1.PageSize+Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="姓名" SortExpression="EmployeeName">
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="hplEmployeeName" runat="server" Text='<%#Eval("EmployeeName") %>' Target="I2" ></asp:HyperLink>
                                                </ItemTemplate>
                                                <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="性别" SortExpression="Sex">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSex" runat="server" Text='<%#Eval("Sex").ToString() == "0" ? "男" : "女"%>'>
                                                    </asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="职位" SortExpression="PositionName">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("PositionName") %>'>
                                                    </asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="部门" SortExpression="DepartName">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDepart" runat="server" Text='<%#Eval("DepartName") %>'>
                                                    </asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            
                                            <asp:TemplateField HeaderText="状态">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblState" runat="server" Text='<%#Eval("State").ToString() == "0" ? "在职" : "离职"%>'>
                                                    </asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField>
                                                <ItemTemplate>
                                                
                                                    <asp:Button ID="btnEdit" Text="编辑" runat="server"  CommandArgument='<%#Eval("EmployeeId") %>' CausesValidation="false" OnClick="btnEdit_Click"/>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                 <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                           </asp:TemplateField>
                                        </Columns>
                                        <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
                                     </asp:GridView>
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
                                    </webdiyer:AspNetPager>
                                  
                                     <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                             
 
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
