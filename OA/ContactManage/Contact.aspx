<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="Contact.aspx.cs" Inherits="OA.Contact" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>君众通讯录</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td  style="width:10%; text-align:right;"><asp:Label ID="lblName" Text="姓名:" runat="server"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:TextBox ID="txtName" runat="server" ></asp:TextBox></td>
                                        <td  style="width:8%; text-align:right;"> <asp:Label ID="lblDepart" runat="server" Text="部门"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:DropDownList ID="ddlDepart" runat="server"></asp:DropDownList></td>
                                        <td  style="width:5%; text-align:left;"><asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" /></td>
                                        <td style="width:55%;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                 
                               <asp:GridView ID="gvContact" runat="server" AutoGenerateColumns="False" AllowSorting="true"  DataKeyNames="ContactId" CellPadding="3" Width="100%" EmptyDataText="没有数据" OnRowDataBound="gvContact_RowDataBound" OnSorting="gvContact_Sorting" PageSize="20">
                                    <Columns>
                                        <asp:TemplateField HeaderText="序号" SortExpression="ContactId">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="姓名" SortExpression="EmployeeName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmployeeName" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="职位" SortExpression="PositionName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblPositionName" runat="server" Text='<%#Eval("PositionName") %>'></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="部门" SortExpression="DepartName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblDepart" runat="server" Text='<%#Eval("DepartName") %>'></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                       
                                        <asp:TemplateField HeaderText="办公电话">
                                           <ItemTemplate>
                                                <asp:Label ID="lblOfficephone" runat="server" Text='<%#Eval("Officephone") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtOfficephone" runat="server" Text='<%#Eval("Officephone") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="分机">
                                            <ItemTemplate>
                                                <asp:Label ID="lblPhoneExt" runat="server" Text='<%#Eval("PhoneExt") %>'></asp:Label>
                                            </ItemTemplate>
                                            
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtPhoneExt" runat="server" Text='<%#Eval("PhoneExt") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="邮箱">
                                           <ItemTemplate>
                                                <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtEmail" runat="server" Text='<%#Eval("Email") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="10%" />
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
                                        <asp:TemplateField HeaderText="家庭电话">
                                           <ItemTemplate>
                                                <asp:Label ID="lblHomephone" runat="server" Text='<%#Eval("Homephone") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtHomephone" runat="server" Text='<%#Eval("Homephone") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                    </Columns>
                                   <AlternatingRowStyle BackColor="#F2F0F0" />
                                   <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                   <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
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

    