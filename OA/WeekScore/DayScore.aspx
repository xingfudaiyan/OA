<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DayScore.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.WeekScore.DayScore" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ContentPlaceHolderID="Content1" ID="con1" runat="server">
    <table class="Tb_Blank1" style="width:100%;text-decoration:none;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center; ">
                        <tr>
                            <td colspan="2"><h2>新增周报</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;"><asp:Button ID="btnAdd" runat="server" Text="新增记录" OnClick="btnAdd_Click"  /></td>
                                        <td style="width:10%;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="False" DataKeyNames="DayScoreId" AllowSorting="True" CellPadding="1" Width="100%" OnRowCancelingEdit="gvScore_RowCancelingEdit" OnRowDataBound="gvScore_RowDataBound" OnRowDeleting="gvScore_RowDeleting" OnRowEditing="gvScore_RowEditing" OnRowUpdating="gvScore_RowUpdating" OnSorting="gvScore_Sorting"  >
                                        <Columns>
                                            <asp:TemplateField HeaderText="日期" SortExpression="Today" ControlStyle-Font-Underline="false"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblToday" runat="server" Text='<%#Eval("Today") %>' ></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtToday" onclick="WdatePicker()" runat="server" Text='<%#Eval("Today") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                               
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="事项" SortExpression="Item"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblItem" runat="server" Text='<%#Eval("Item").ToString().Length>150?Eval("Item").ToString().Substring(0,150)+"...":Eval("Item") %>' ToolTip='<%#Eval("Item") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtItem" runat="server" Text='<%#Eval("Item") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                 
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="完成时间（精确到分）" SortExpression="FinishTime"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblFinishTime" runat="server" Text='<%#Eval("FinishTime") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtFinishTime"  runat="server" Text='<%#Eval("FinishTime") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                               
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="角色" SortExpression="DayRoleName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDayRoleName" runat="server" Text='<%#Eval("DayRoleName") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:DropDownList ID="ddlRole" runat="server"></asp:DropDownList>
                                                </EditItemTemplate>
                                                 
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="历时" SortExpression="TimeSpan"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTimeSpan" runat="server" Text='<%#Eval("TimeSpan") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtTimeSpan" runat="server" Text='<%#Eval("TimeSpan") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="备注" SortExpression="Memo"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMemo" runat="server" Text='<%#Eval("Memo").ToString().Length>50?Eval("Memo").ToString().Substring(0,50)+"...":Eval("Memo") %>' ToolTip='<%#Eval("Memo") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtMemo" runat="server" Text='<%#Eval("Memo")%>'></asp:TextBox>
                                                </EditItemTemplate>
                                                 
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="评分" SortExpression="Score"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblScore" runat="server" Text='<%#Eval("Score") %>'></asp:Label>
                                                </ItemTemplate>
                                              
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <EditItemTemplate>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update"
                                                        Text="更新"></asp:LinkButton>
                                                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                                                        Text="取消"></asp:LinkButton>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton3" runat="server" CausesValidation="False" CommandName="Edit"
                                                        Text="编辑"></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="LinkButton4" runat="server" CausesValidation="False" CommandName="Delete"
                                                        Text="删除"></asp:LinkButton>
                                                </ItemTemplate>
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
                         <tr>
                           <td colspan="2">
                            <table class="Tb_Blank1" style="width:50%; margin-left:25%;">
                                <tr>
                                        <td style="width:50%;"><asp:Button ID="btnSave" runat="server" OnClientClick="return confirm('确认要提交吗？');" Text="提交" OnClick="btnSave_Click"  /></td>
                                        <td style="width:50%;"><asp:Button ID="btnBack" runat="server" Text="返回" OnClick="btnBack_Click" /></td>
                                </tr>
                            </table>
                        </td>
                         </tr>
                      </table>
                </td>
            </tr>
        </table>

</asp:Content>
