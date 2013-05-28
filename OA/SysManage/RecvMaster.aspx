<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master"  CodeBehind="RecvMaster.aspx.cs" Inherits="OA.SysManage.RecvMaster" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:99%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>用户信息列表</h2></td>
                        </tr>
                        
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                 <asp:GridView ID="gvMaster" runat="server" AutoGenerateColumns="False" DataKeyNames="MasterId" CellPadding="3" Width="100%" EmptyDataText="没有数据" OnRowDataBound="gvMaster_RowDataBound">
                                    <Columns>
                                        <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                            <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="用户名">
                                            <ItemTemplate>
                                                <asp:Label ID="lblMasterName" runat="server" Text='<%#Eval("MasterName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtMasterName" runat="server" Text='<%#Eval("MasterName") %>' ></asp:TextBox>
                                            </EditItemTemplate>
                                             <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="姓名">
                                            <ItemTemplate>
                                                <asp:Label ID="lblEmployeeName" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                         <asp:TemplateField HeaderText="所属部门">
                                            <ItemTemplate>
                                                <asp:Label ID="lblDepartName" runat="server" Text='<%#Eval("DepartName") %>'></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="15%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="创建日期">
                                            <ItemTemplate>
                                                <asp:Label ID="lblCreateDate" runat="server" Text='<%#Eval("CreateDate") %>'>
                                                </asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="20%" />
                                        </asp:TemplateField>      
                                         <asp:TemplateField HeaderText="状态">
                                            <ItemTemplate>
                                                <asp:Label ID="lblState" runat="server"></asp:Label>
                                            </ItemTemplate>
                                             <ItemStyle Width="15%" />
                                        </asp:TemplateField>              
                                        <asp:TemplateField HeaderText="角色/权限">
                                            <ItemTemplate>
                                               <asp:Button ID="btnApply" Text="审批" runat="server" CommandArgument='<%#Eval("MasterId") %>' CausesValidation="false" OnClick="btnApply_Click" />
                                            </ItemTemplate>
                                             <ItemStyle Width="10%" />
                                        </asp:TemplateField>
                                       
                                    </Columns>
                                    <AlternatingRowStyle BackColor="#F2F0F0" />
                                   <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                   <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
                                 </asp:GridView>
                                 <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:AspNetPager>
                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
         
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
        

             
                                 