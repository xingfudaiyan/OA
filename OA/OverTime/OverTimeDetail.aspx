<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OverTimeDetail.aspx.cs" MasterPageFile="~/Apply.Master" Inherits="OA.OverTime.OverTimeDetail" %>


<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
    <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td><h4><asp:Label ID="lblEmName" runat="server"></asp:Label>加班申请单详情</h4></td>
        </tr>
         <tr>
            <td>
                <table class="Tb_Common">
                    <tr>
                        <td style="width:12%;">
                        申请日期：
                        </td>
                          <td style="width:21%;">
                            <asp:Label ID="lblApplyDate" runat="server"></asp:Label>
                           
                        </td>
                          <td style="width:12%;">
                          申请时间：
                        </td>
                          <td style="width:21%;">
                            <asp:Label ID="lblTimeFrom" runat="server"></asp:Label>时
                        </td>
                          <td style="width:12%;">
                          ------
                        </td>
                          <td style="width:21%;">
                           <asp:Label ID="lblTimeTo" runat="server"></asp:Label>时
                        </td>
                    </tr>
                   <tr>
                        <td>
                        申请部门：
                        </td>
                          <td>
                           技术部
                        </td>
                          <td>
                          申请人：
                        </td>
                          <td>
                           <asp:Label ID="lblApplyEmName" runat="server"></asp:Label>
                        </td>
                          <td>
                          主管经理：
                        </td>
                        <td>
                            马斌
                        </td>
                    </tr>
                    <tr>
                        <td>加班原因简述：</td>
                        <td colspan="3"><asp:Label ID="lblReason" runat="server"></asp:Label></td>
                        <td>历时（分钟）</td>
                        <td><asp:Label ID="lblTimeSpan" runat="server"></asp:Label></td>
                    </tr>
                </table>
            </td>
         </tr>
        <tr>
            <td><h4>加班组（组员）名单</h4></td>
        </tr>
         <tr>
            <td> 
                <asp:GridView ID="gvOtGroup" runat="server" AutoGenerateColumns="False" DataKeyNames="OtGroupId" CellPadding="1" Width="100%" OnRowDataBound="gvOtGroup_RowDataBound">
                    <Columns>
                            <asp:TemplateField HeaderText="序号">
                                <ItemTemplate>
                                   <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                             </asp:TemplateField>
                            <asp:TemplateField HeaderText="组别" >
                                <ItemTemplate>
                                    <asp:Label ID="lblGroupName" runat="server" Text='<%#Eval("GroupName") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtGroupName" runat="server" Text='<%#Eval("GroupName") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="姓名" >
                                <ItemTemplate>
                                    <asp:Label ID="lblGroupName" runat="server" Text='<%#Eval("ApplyName") %>'></asp:Label>
                                </ItemTemplate>
                                <EditItemTemplate>
                                    <asp:TextBox ID="txtGroupName" runat="server" Text='<%#Eval("ApplyName") %>'></asp:TextBox>
                                </EditItemTemplate>
                            </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" PageSize="20" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" >
                </webdiyer:AspNetPager>
            </td>
        </tr>
      
    </table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
      <table class="Tb_Blank" style="width:100%;">
             <tr>
               <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click" /></td> 
            </tr>
        </table>
</asp:Content>