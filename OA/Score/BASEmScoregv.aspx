<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BASEmScoregv.aspx.cs" MasterPageFile="~/Manage.Master"  Inherits="OA.Score.BASEmScoregv" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>商务助理绩效考核</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;"><asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click"/></td>
                                        <td style="width:10%;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="False" DataKeyNames="BasEmScoreId" AllowSorting="True" CellPadding="1" Width="100%" OnRowDataBound="gvScore_RowDataBound" OnRowDeleting="gvScore_RowDeleting" OnSorting="gvScore_Sorting"  >
                                        <Columns>
                                             <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="时间" SortExpression="DateSpan"> 
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lblDateSpan" runat="server" style="text-decoration:none;" Text='<%#Eval("DateSpan") %>' CommandArgument='<%#Eval("BasEmScoreId") %>' CausesValidation="false" OnClick="btnDetail_Click" ></asp:LinkButton>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="总分" SortExpression="TotalScore"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSumScore" runat="server" Text='<%#Eval("TotalScore") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="等级" SortExpression="EvaluateName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLevels" runat="server" Text='<%#Eval("EvaluateName") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="考核人"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUpEmployee" runat="server" Text='何春'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="提交" runat="server" CommandArgument='<%#Eval("BasEmScoreId") %>' CausesValidation="false" OnClientClick="return confirm('提交后不能再编辑和删除，确认要提交吗？');" OnClick="btnSubmit_Click"  />
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnEdit" runat="server" CausesValidation="False" CommandName="Edit"
                                                        Text="编辑" CommandArgument='<%#Eval("BasEmScoreId") %>' OnClick="btnEdit_Click"></asp:Button>
                                                </ItemTemplate>
                                                 <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnDelete" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('确认要删除吗？');"
                                                        Text="删除"></asp:Button>
                                                </ItemTemplate>
                                                 <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
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
      

