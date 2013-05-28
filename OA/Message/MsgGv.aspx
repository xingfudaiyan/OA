<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MsgGv.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.Message.MsgGv" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>OA消息提醒</h2></td>
                        </tr>
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;">  <asp:CheckBox ID="ckbAll" runat="server" AutoPostBack="true" Text="全选" OnCheckedChanged="ckbAll_CheckedChanged" /> </td>
                                        <td style="width:10%;"><asp:Button ID="btnAll" runat="server" Text="提醒" OnClick="btnAll_Click" /></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvMsg" runat="server" AutoGenerateColumns="False" DataKeyNames="MessageId" AllowSorting="True" CellPadding="1" Width="100%" OnRowDataBound="gvMsg_RowDataBound" OnSorting="gvMsg_Sorting" >
                                        <Columns>
                                             <asp:TemplateField>
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="ckbChoose" runat="server" />
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="时间" SortExpression="MsgTime"> 
                                                <ItemTemplate>
                                                   <asp:Label ID="lblTime" runat="server" Text='<%#Eval("MsgTime") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="发起人" SortExpression="EmployeeName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSumScore" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="接收人" SortExpression="RecvName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLevels" runat="server" Text='<%#Eval("RecvName") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="消息内容" SortExpression="Msg"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUpEmployee" runat="server" Text='<%#Eval("Msg") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%"  />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="提醒" runat="server" CommandArgument='<%#Eval("MessageId") %>' CausesValidation="false"  OnClick="btnSubmit_Click"  />
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
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
      



