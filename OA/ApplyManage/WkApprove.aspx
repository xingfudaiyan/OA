<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WkApprove.aspx.cs" Inherits="OA.ApplyManage.WkApprove" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script language="javascript" defer="defer" type="text/javascript" src="/My97DatePicker/WdatePicker.js"> 
<LINK rel="stylesheet" type="text/css" href="My97DatePicker/skin/default/datepicker.css" />
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>审批周总结</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblTitle" runat="server" Text="周总结标题:"></asp:Label>
        <asp:TextBox ID="txtSumName" runat="server"></asp:TextBox>
         <asp:GridView ID="gvwDay" runat="server" AutoGenerateColumns="False" DataKeyNames="DayId" CellPadding="3" Width="100%"
                EmptyDataText="没有数据" OnRowDataBound="gvwDay_RowDataBound">
            <Columns> 
                <asp:TemplateField HeaderText="序号">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="星期">
                    <ItemTemplate>
                        <asp:Label ID="lblDayName" runat="server" Text='<%#Eval("WeekName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="日期">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("WorkDate") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="工作内容">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkContent" runat="server" Text='<%#Eval("WorkContent") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="完成情况">
                    <ItemTemplate>
                        <asp:Label ID="lblResult" runat="server" Text='<%#Eval("Result") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <AlternatingRowStyle BackColor="#F2F0F0" />
           <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
           <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
        </asp:GridView> 
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
        </webdiyer:AspNetPager>
        <asp:Label ID="lblApprove" runat="server" Text="是否通过："></asp:Label>
        <asp:RadioButtonList ID="rblApprove" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="0">修正</asp:ListItem>
            <asp:ListItem Value="1">通过</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="lblView" runat="server" Text="审批意见："></asp:Label>
        <asp:TextBox ID="txtView" runat="server"></asp:TextBox> 
        <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" />
    </div>
    </form>
</body>
</html>
