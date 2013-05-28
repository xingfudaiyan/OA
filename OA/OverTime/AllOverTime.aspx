<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllOverTime.aspx.cs" MasterPageFile="~/Manage.Master"  Inherits="OA.OverTime.AllOverTime" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>技术部加班申请单</h2></td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                 <asp:GridView ID="gvOverTime" runat="server" AutoGenerateColumns="false" DataKeyNames="OverTimeId" AllowSorting="true" CellPadding="1" Width="100%" OnRowDataBound="gvOverTime_RowDataBound" OnSorting="gvOverTime_Sorting" >
                                    <Columns>
                                     <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="申请日期" SortExpression="ApplyDate"> 
                                                <ItemTemplate>
                                                     <asp:Label ID="lblApplyDate" runat="server" Text='<%#Eval("ApplyDate") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                               <asp:TemplateField HeaderText="申请人" SortExpression="ApplyEmName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmName" runat="server" Text='<%#Eval("ApplyEmName") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="审批状态"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUpEmployee" runat="server" Text="通过"></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="审批人"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUp" runat="server" Text="马斌"></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                              <asp:TemplateField HeaderText="详情"> 
                                                <ItemTemplate>
                                                     <asp:LinkButton ID="lblDetail" runat="server" style="text-decoration:none;"  Text="详情" CommandArgument='<%#Eval("OverTimeId") %>' CausesValidation="false" OnClick="lblDetail_Click"></asp:LinkButton>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                 </asp:GridView>
                                   <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="20" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" >
                                   </webdiyer:AspNetPager>
                            </td>
                        </tr>
                        
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
