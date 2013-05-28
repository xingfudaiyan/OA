<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Manage.Master"  CodeBehind="Contract.aspx.cs" Inherits="OA.ClientManage.Contract" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ContentPlaceHolderID="Content1" runat="server">
       <table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td><h1>合同信息列表</h1></td>
            </tr>
            <tr>
                <td>
                         <table class="Tb_Blank1">
                            <tr>
                                <td style="width:30%; text-align:right;"><asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click" /></td>
                            </tr>
                         </table>
                        <asp:GridView ID="gvContract" runat="server" DataKeyNames="ContractId" AllowSorting="true" CellPadding="1" AutoGenerateColumns="false" Width="100%" EmptyDataText="没有数据"  OnRowDataBound="gvContract_RowDataBound" OnRowDeleting="gvContract_RowDeleting"  OnSorting="gvContract_Sorting">
                          <Columns>
                             <asp:TemplateField HeaderText="序号">
                                    <ItemTemplate>
                                        <%#Container.DataItemIndex+1 %>
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="合同编号" SortExpression="ContractNum">
                                    <ItemTemplate>
                                        <asp:Label ID="lblContractNum" runat="server" Text='<%#Eval("ContractNum") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" />
                                </asp:TemplateField>
                               
                                
                                 <asp:TemplateField HeaderText="合同名称" SortExpression="ContractName">
                                    <ItemTemplate>
                                        <asp:Label ID="lblContractName" runat="server" Text='<%#Eval("ContractName") %>'></asp:Label>
                                    </ItemTemplate>
                                   
                                    <ItemStyle Width="15%" />
                                </asp:TemplateField>
                                
                                <asp:TemplateField HeaderText="签约方" SortExpression="SignName">
                                    <ItemTemplate>
                                        <asp:Label ID="lblSignName" runat="server" Text='<%#Eval("SignName") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" />
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="生效日期" SortExpression="BeginDate">
                                    <ItemTemplate>
                                        <asp:Label ID="lblBeginDate" runat="server" Text='<%#Eval("BeginDate") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="15%" />
                                </asp:TemplateField>
                                  <asp:TemplateField HeaderText="金额(元)" SortExpression="MoneySum">
                                    <ItemTemplate>
                                        <asp:Label ID="lblMoney" runat="server" Text='<%#Eval("MoneySum") %>'></asp:Label>
                                    </ItemTemplate>
                                    <ItemStyle Width="10%" />
                                </asp:TemplateField>
                                 <asp:TemplateField HeaderText="下载">
                                    <ItemTemplate>
                                        <a href="DownLoadFile.aspx?fileid=<%#Eval("ContractFileId") %>" target="I2" style="text-decoration:none;">下载</a>
                                    </ItemTemplate>
                                    <ItemStyle Width="5%" />
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                         <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
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
      

</asp:Content>
        