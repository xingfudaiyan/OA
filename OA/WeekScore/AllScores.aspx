<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllScores.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.WeekScore.AllScores" %>

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
                                        <td  style="width:10%; text-align:right;"><asp:Label ID="lblSheetNum" Text="姓名:" runat="server"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:DropDownList ID="ddlEmployee" runat="server"></asp:DropDownList></td>
                                        <td  style="width:8%; text-align:right;"><asp:Label ID="lblDate1" runat="server"  Text="开始时间"></asp:Label></td>
                                        <td  style="width:10%; text-align:left;"><asp:TextBox ID="txtDate1" runat="server" onclick="WdatePicker()"></asp:TextBox></td>
                                        <td style="width:8%; text-align:right;"><asp:Label ID="Label1" runat="server"  Text="结束时间"></asp:Label></td>
                                        <td style="width:10%; text-align:left;"><asp:TextBox ID="txtDate2" runat="server" onclick="WdatePicker()"></asp:TextBox></td>
                                        <td  style="width:5%; text-align:left;"><asp:Button ID="btnSearch" runat="server" Text="统计" OnClick="btnSearch_Click"/></td>
                                        <td  style="width:10%; text-align:left;"></td>
                                        <td><asp:Label ID="lblS" runat="server" Text="分数:"></asp:Label></td>
                                        <td><asp:Label ID="lblScore" runat="server" Text="" ></asp:Label></td>
                 
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
                                              <asp:TemplateField HeaderText="所属人" SortExpression="EmployeeName"> 
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
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                 </asp:GridView>
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" PageSize="40" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" >
                                   </webdiyer:AspNetPager>
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>

</asp:Content>
