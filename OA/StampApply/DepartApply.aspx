<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master" CodeBehind="DepartApply.aspx.cs" Inherits="OA.StampApply.DepartApply" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>部门经理用章申请</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;"><asp:Button ID="btnAdd" runat="server" Text="新增记录" OnClick="btnAdd_Click" /></td>
                                        <td style="width:10%; text-align:left;"></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  
                                <asp:GridView ID="gvStamp" runat="server" AutoGenerateColumns="False" DataKeyNames="StampId" AllowSorting="True" CellPadding="1" Width="100%" OnRowCancelingEdit="gvStamp_RowCancelingEdit" OnRowDataBound="gvStamp_RowDataBound" OnRowEditing="gvStamp_RowEditing" OnRowUpdating="gvStamp_RowUpdating" OnSorting="gvStamp_Sorting" OnRowDeleting="gvStamp_RowDeleting">
                                    <Columns>
                                         <asp:TemplateField HeaderText="序号">
                                            <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:TemplateField HeaderText="申请时间" SortExpression="ApplyTime"> 
                                            <ItemTemplate>
                                                <asp:Label ID="lblApplyTime" runat="server" Text='<%#Eval("ApplyTime") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        
                                        <asp:TemplateField HeaderText="使用日期" SortExpression="UseDate"> 
                                            <ItemTemplate>
                                                <asp:Label ID="lblApplyDate" runat="server" Text='<%#Eval("UseDate") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtApplyDate" runat="server" Text='<%#Eval("UseDate") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        
                                         <asp:TemplateField HeaderText="文件类型" SortExpression="StampFileType"> 
                                            <ItemTemplate>
                                                <asp:Label ID="lblFileType" runat="server" Text='<%#Eval("StampFileTypeName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                 <asp:DropDownList ID="ddlFileType" runat="server"></asp:DropDownList>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        
                                         <asp:TemplateField HeaderText="用章类型" SortExpression="StampType"> 
                                            <ItemTemplate>
                                                <asp:Label ID="lblStampType" runat="server" Text='<%#Eval("StampName") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                     <asp:DropDownList ID="ddlStampType" runat="server"></asp:DropDownList>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        
                                         <asp:TemplateField HeaderText="用途"> 
                                            <ItemTemplate>
                                                <asp:Label ID="lblUse" runat="server" Text='<%#Eval("StampUse") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="txtUse" runat="server" Text='<%#Eval("StampUse") %>'></asp:TextBox>
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
                                        
                                        <asp:TemplateField HeaderText="状态">
                                            <ItemTemplate>
                                                <asp:Label ID="lblState" runat="server"></asp:Label>
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
                                                <asp:Button ID="btnSubmit" Text="提交" runat="server" CommandArgument='<%#Eval("StampId") %>' CausesValidation="false" OnClientClick="return confirm('确认要提交吗？');" OnClick="btnSubmit_Click" />
                                            </ItemTemplate>
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
      
