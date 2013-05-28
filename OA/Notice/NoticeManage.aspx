<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NoticeManage.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.Notice.NoticeManage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ContentPlaceHolderID="Content1" runat="server">
     <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>公告列表</h2></td>
                        </tr>
                        <tr>
                            <td style=" text-align:left;">
                            <asp:CheckBox ID="ckbAll" runat="server" AutoPostBack="true"  Text="全选" OnCheckedChanged="ckbAll_CheckedChanged" />
                            <asp:Button ID="btnDelete" runat="server" Text="删除"  OnClientClick="return confirm('确认要删除吗？');" OnClick="btnDelete_Click" />
                            </td>
                            <td>
                                <asp:Button ID="btnAddNotice" runat="server" Text="发布公告" OnClick="btnAddNotice_Click" />
                            </td>
           
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                <asp:GridView ID="gvNotice" runat="server" AutoGenerateColumns="false" AllowSorting="true" DataKeyNames="NoticeId" Width="100%" CellPadding="3" EmptyDataText="没有数据" OnSorting="gvNotice_Sorting" >
                                    <Columns>
                                        <asp:TemplateField>
                                           <ItemTemplate>
                                               <asp:CheckBox ID="ckbChoose" runat="server" AutoPostBack="true" />
                                           </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                            <ItemStyle Width="5%" />
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="标题" SortExpression="NoticeTitle">
                                            <ItemTemplate>
                                               <asp:Label ID="lblTitle" runat="server" Text='<%#Eval("NoticeTitle") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="内容" SortExpression="NoticeContent">
                                           <ItemTemplate>
                                             <asp:Label ID="lblContent" runat="server" Text='<%# Eval("NoticeContent").ToString().Length>20?Eval("NoticeContent").ToString().Substring(0,20) + "....": Eval("NoticeContent") %>' ToolTip='<%#Eval("NoticeContent") %>'  ></asp:Label>
                                           </ItemTemplate>
                                           <ItemStyle Wrap="False" /> 
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="落款" SortExpression="SignName">
                                            <ItemTemplate>
                                                <asp:Label ID="lblSignName" runat="server" Text='<%#Eval("SignName") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="发布人"  SortExpression="EmployeeName">
                                              <ItemTemplate>
                                                <asp:Label ID="lblEmName" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                                              </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="发布时间" SortExpression="NoticeTime">
                                            <ItemTemplate>
                                                <asp:Label ID="lblTime" runat="server" Text='<%#Eval("NoticeTime") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                         <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White" />
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