<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ScoreDetail.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.WeekScore.ScoreDetail" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ContentPlaceHolderID="Content1" ID="con1" runat="server">
    <table class="Tb_Blank1" style="width:100%;text-decoration:none;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center; ">
                        <tr>
                            <td colspan="2"><h2><asp:Label ID="lblEm" runat="server"></asp:Label><asp:Label ID="lblNum" runat="server"></asp:Label>_周报详情</h2></td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="False" DataKeyNames="DayScoreId" AllowSorting="True" CellPadding="1" Width="100%"  OnRowDataBound="gvScore_RowDataBound" OnSorting="gvScore_Sorting"  >
                                        <Columns>
                                            <asp:TemplateField HeaderText="日期" SortExpression="Today" ControlStyle-Font-Underline="false"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblToday" runat="server" Text='<%#Eval("Today") %>' ></asp:Label>
                                                </ItemTemplate>
                                             
                                               <ItemStyle Width="8%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="事项" SortExpression="Item"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblItem" runat="server" Text='<%#Eval("Item").ToString().Length>150?Eval("Item").ToString().Substring(0,150)+"...":Eval("Item") %>' ToolTip='<%#Eval("Item") %>'></asp:Label>
                                                </ItemTemplate>
                                               
                                                
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="完成时间" SortExpression="FinishTime"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFinishTime" runat="server" Text='<%#Eval("FinishTime") %>'></asp:Label>
                                                </ItemTemplate>
                                              
                                                 <ItemStyle Width="8%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="角色" SortExpression="DayRoleName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDayRoleName" runat="server" Text='<%#Eval("DayRoleName") %>'></asp:Label>
                                                </ItemTemplate>
                                               
                                                 <ItemStyle Width="8%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="历时（精确到分）" SortExpression="TimeSpan"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTimeSpan" runat="server" Text='<%#Eval("TimeSpan") %>'></asp:Label>
                                                </ItemTemplate>
                                              
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="备注" SortExpression="Memo"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMemo" runat="server" Text='<%#Eval("Memo").ToString().Length>50?Eval("Memo").ToString().Substring(0,50)+"...":Eval("Memo") %>' ToolTip='<%#Eval("Memo") %>'></asp:Label>
                                                </ItemTemplate>
                                               
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="评分" SortExpression="Score"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblScore" runat="server" Text='<%#Eval("Score") %>'></asp:Label>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                         
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" PageSize="30" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
                                   </webdiyer:AspNetPager>
                            </td>
                        </tr>
                        
                      </table>
                </td>
            </tr>
        </table>

</asp:Content>
