<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeekApply.aspx.cs" Inherits="OA.ApplyManage.WeekApply" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>周计划审批</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
          <table  class="Tb_Blank" style="margin-left:15%; width:70%;">
            <tr>
            <td><h4>审批周总结</h4> </td>
            </tr>
            <tr>
                <td style=" text-align:left;"> <asp:Button ID="btnAddWeek" runat="server"  Text="新增" OnClick="btnAddWeek_Click" /> 
                     <asp:Label ID="lblRecv" runat="server" Text="审批人："></asp:Label>
                     <asp:Label ID="lblRecvEmployee" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
             <td style="text-align:center;">
           <asp:GridView ID="gvwWeekSum" runat="server" AutoGenerateColumns="false" DataKeyNames="WeekSumId" CellPadding="3" Width="100%" OnRowDeleting="gvwWeekSum_RowDeleting" OnRowDataBound="gvwWeekSum_RowDataBound">
            <Columns>
               <asp:TemplateField HeaderText="序号">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="周总结">
                    <ItemTemplate>
                        <asp:Label ID="lblWeekSunName" runat="server" Text='<%#Eval("WeekSumName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="发送">
                    <ItemTemplate>
                        <asp:Label ID="lblIsSend" runat="server" Text='<%#Eval("IsSend").ToString()=="0"?"未发送":"已发送" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="发送时间">
                    <ItemTemplate>
                        <asp:Label ID="lblSendTime" runat="server" Text='<%#Eval("ApplyTime") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="审批时间">
                    <ItemTemplate>
                        <asp:Label ID="lblReplyTime" runat="server" Text='<%#Eval("RepplyTime") %>'></asp:Label>
                    </ItemTemplate>  
                </asp:TemplateField>
                <asp:TemplateField HeaderText="审批">
                    <ItemTemplate>
                        <asp:Label ID="lblIsApply" runat="server" Text='<%#Eval("IsApply").ToString()=="0"?"未审批":"已审批" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="通过">
                    <ItemTemplate>
                        <asp:Label ID="lblIsApprove" runat="server" Text='<%#Eval("IsApprove").ToString()=="0"?"未通过":"已通过" %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="审批意见">
                    <ItemTemplate>
                        <asp:Label ID="lblApplyView" runat="server" Text='<%#Eval("ApplyView") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnSubmit" Text="发送" runat="server"  CommandArgument='<%#Eval("WeekSumId") %>' CausesValidation="false" OnClick="btnSubmit_Click" OnClientClick="return confirm('确认要发送吗？');" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnEdit" Text="编辑" runat="server"  CommandArgument='<%#Eval("WeekSumId") %>' CausesValidation="false" OnClick="btnEdit_Click"/>
                    </ItemTemplate>
                </asp:TemplateField>
               
          
            </Columns>
             <AlternatingRowStyle BackColor="#F2F0F0" />
           <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
           <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
        </asp:GridView>
        
       
        </td>
       </tr>
       <tr><td><webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
               </webdiyer:AspNetPager></td></tr>
        </table>
    </div>
    </form>
</body>
</html>
