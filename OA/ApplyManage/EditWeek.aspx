<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditWeek.aspx.cs" Inherits="OA.ApplyManage.EditWeek" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script language="javascript" defer="defer" type="text/javascript" src="/My97DatePicker/WdatePicker.js"> 
<LINK rel="stylesheet" type="text/css" href="My97DatePicker/skin/default/datepicker.css" />
</script>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>编辑周总结</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
        <tr><td><asp:Label ID="lblTitle" runat="server" Text="周总结标题:"></asp:Label>
            <asp:TextBox ID="txtSumName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:GridView ID="gvwDay" runat="server" AutoGenerateColumns="False" DataKeyNames="DayId" CellPadding="3" Width="100%"
 EmptyDataText="没有数据" OnRowCancelingEdit="gvwDay_RowCancelingEdit" OnRowDeleting="gvwDay_RowDeleting" OnRowEditing="gvwDay_RowEditing" OnRowUpdating="gvwDay_RowUpdating"   >
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
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlWeek" runat="server"></asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="日期">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("WorkDate") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDate" runat="server" Text='<%#Eval("WorkDate") %>' onclick="WdatePicker()"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="工作内容">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkContent" runat="server" Text='<%#Eval("WorkContent") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                         <asp:TextBox ID="txtWorkContent" runat="server" Text='<%#Eval("WorkContent") %>' TextMode="MultiLine"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="完成情况">
                    <ItemTemplate>
                        <asp:Label ID="lblResult" runat="server" Text='<%#Eval("Result") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtResult" runat="server" Text='<%#Eval("Result") %>' TextMode="MultiLine"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">
                    <EditItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="True" CommandName="Update"
                            Text="更新"></asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Cancel"
                            Text="取消"></asp:LinkButton>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtn" runat="server" ImageUrl="~/images/edit.gif" CausesValidation="False" CommandName="Edit" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                         <asp:Button ID="btnDelete" runat="server"  CausesValidation="false" CommandName="Delete" Text="删除" OnClientClick="return confirm('确认要删除吗？');" />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            <AlternatingRowStyle BackColor="#F2F0F0" />
           <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
           <RowStyle BackColor="#ECF5FF" ForeColor="Black" />
        </asp:GridView> 
        <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
        </webdiyer:AspNetPager></td>
        </tr>
        </table>
        
         
        <asp:Button ID="btnSaveWkSum" runat="server" Text="保存编辑"  OnClick="btnSaveWkSum_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" />
    </div>
    </form>
</body>
</html>
