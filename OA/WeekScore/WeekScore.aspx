<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeekScore.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.WeekScore.WeekScore" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ContentPlaceHolderID="Content1" ID="con1" runat="server">
    <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>我的周报</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;"><asp:Button ID="btnAll" runat="server" Text="技术部周报" OnClick="btnAll_Click" /></td>
                                        <td style="width:10%;"><asp:Button ID="btnAdd" runat="server" Text="新增周报" OnClick="btnAdd_Click" /></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                 <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="false" DataKeyNames="WeekScoreId" AllowSorting="true" CellPadding="1" Width="100%" OnRowDataBound="gvScore_RowDataBound" OnRowDeleting="gvScore_RowDeleting" OnSorting="gvScore_Sorting" >
                                    <Columns>
                                     <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="周报ID" SortExpression="WeekScoreNum"> 
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lblDetail" runat="server" style="text-decoration:none;" Text='<%#Eval("WeekScoreNum") %>' CommandArgument='<%#Eval("WeekScoreId") %>' CausesValidation="false" OnClick="lblDetail_Click"></asp:LinkButton>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="总分" SortExpression="TotalScore"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSumScore" runat="server" Text='<%#Eval("TotalScore") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="考核人"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUpEmployee" runat="server" Text='马斌'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="提交" runat="server" CommandArgument='<%#Eval("WeekScoreId") %>' CausesValidation="false" OnClientClick="return confirm('提交后不能再编辑和删除，确认要提交吗？');" OnClick="btnSubmit_Click" />
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnEdit" runat="server" CausesValidation="False" CommandName="Edit"
                                                        Text="编辑" CommandArgument='<%#Eval("WeekScoreId") %>' OnClick="btnEdit_Click"></asp:Button>
                                                </ItemTemplate>
                                                 <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnDelete" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('确认要删除吗？');"
                                                        Text="删除" CommandArgument='<%#Eval("WeekScoreId") %>'></asp:Button>
                                                </ItemTemplate>
                                                 <ItemStyle Width="5%" />
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
