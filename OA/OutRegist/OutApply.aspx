<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutApply.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.OutRegist.OutApply" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>外出登记申请</h2></td>
                        </tr>
                        <tr>
                            <td><asp:Button ID="btnAdd" runat="server" Text="新增记录" OnClick="btnAdd_Click" /></td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvOutRegist" runat="server" AutoGenerateColumns="False" DataKeyNames="OutRegistId" AllowSorting="True" CellPadding="1" Width="100%" OnRowCancelingEdit="gvOutRegist_RowCancelingEdit" OnRowDeleting="gvOutRegist_RowDeleting" OnRowEditing="gvOutRegist_RowEditing" OnSorting="gvOutRegist_Sorting" OnRowUpdating="gvOutRegist_RowUpdating" OnRowDataBound="gvOutRegist_RowDataBound">
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
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtOutDate" runat="server" Text='<%#Eval("OutDate") %>' onclick="WdatePicker()"></asp:TextBox>
                                                </EditItemTemplate>
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
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtOutContent" runat="server" Text='<%#Eval("OutContent") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                
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
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtOutTime" runat="server" Text='<%#Eval("OutTime") %>' onclick="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="回司时间"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblBackTime" runat="server" Text='<%#Eval("BackTime") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtBackTime" runat="server" Text='<%#Eval("BackTime") %>' onclick="WdatePicker({dateFmt:'yyyy-MM-dd HH:mm:ss'})"></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="交通工具" > 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblOutTool" runat="server" Text='<%#Eval("OutTool") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtOutTool" runat="server" Text='<%#Eval("OutTool") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="备注"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:Label>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtMemo" runat="server" Text='<%#Eval("Memo") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                            </asp:TemplateField>
                                              <asp:TemplateField HeaderText="状态" SortExpression="State">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblState" runat="server" ></asp:Label>
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
                                                    <asp:Button ID="btnEdit" runat="server" CausesValidation="False" CommandName="Edit"
                                                        Text="编辑"></asp:Button>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnDelete" runat="server" CausesValidation="False" CommandName="Delete" OnClientClick="return confirm('确认要删除吗？');"
                                                        Text="删除"></asp:Button>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="提交" runat="server" CommandArgument='<%#Eval("OutRegistId") %>' CausesValidation="false" OnClientClick="return confirm('确认要提交吗？');" OnClick="btnSubmit_Click"/>
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
      
