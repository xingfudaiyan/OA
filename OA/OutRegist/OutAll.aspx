<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="OutAll.aspx.cs" Inherits="OA.OutRegist.OutAll" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>外出登记记录表</h2></td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvOutRegist" runat="server" AutoGenerateColumns="False" DataKeyNames="OutRegistId" AllowSorting="True" CellPadding="1" Width="100%" OnRowDataBound="gvOutRegist_RowDataBound" OnSorting="gvOutRegist_Sorting" >
                                        <Columns>
                                             <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="日期" SortExpression="OutDate"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblOutDate" runat="server" Text='<%#Eval("OutDate") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="部门"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDepartName" runat="server" Text='<%#Eval("DepartName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="外出事由"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblOutContent" runat="server" Text='<%#Eval("OutContent") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="外出人"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmployeeName" runat="server" Text='<%#Eval("ApplyName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="外出时间" > 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblOutTime" runat="server" Text='<%#Eval("OutTime") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="回司时间"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblBackTime" runat="server" Text='<%#Eval("BackTime") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="交通工具" > 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblOutTool" runat="server" Text='<%#Eval("OutTool") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="备注"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" >
                                   </webdiyer:AspNetPager>
                                 
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
      

