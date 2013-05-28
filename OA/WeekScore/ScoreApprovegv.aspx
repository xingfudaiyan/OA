<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreApprovegv.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.WeekScore.ScoreApprovegv" %>


<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ContentPlaceHolderID="Content1" ID="con1" runat="server">
    <table class="Tb_Blank1" style="width:100%;text-decoration:none;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center; ">
                        <tr>
                            <td colspan="2"><h2>技术部周报</h2></td>
                        </tr>
                         <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;"><asp:Button ID="btnAll" runat="server" Text="周报统计" OnClick="btnAll_Click" /></td>
                                        <td style="width:10%;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                 <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="false" DataKeyNames="WeekScoreId" AllowSorting="true" CellPadding="1" Width="100%" OnRowDataBound="gvScore_RowDataBound" OnSorting="gvScore_Sorting"  >
                                    <Columns>
                                     <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="周报ID" SortExpression="WeekScoreNum"> 
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lblDetail" runat="server" style="text-decoration:none;" Text='<%#Eval("WeekScoreNum") %>' CommandArgument='<%#Eval("WeekScoreId") %>' CausesValidation="false" OnClick="lblDetail_Click" ></asp:LinkButton>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                              <asp:TemplateField HeaderText="申请人" SortExpression="EmployeeName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUpEmployee" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="总分" SortExpression="TotalScore"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSumScore" runat="server" Text='<%#Eval("TotalScore") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="评分" runat="server" CommandArgument='<%#Eval("WeekScoreId") %>' CausesValidation="false"  OnClick="btnSubmit_Click"  />
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                 </asp:GridView>
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" PageSize="20" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" >
                                   </webdiyer:AspNetPager>
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>

</asp:Content>
