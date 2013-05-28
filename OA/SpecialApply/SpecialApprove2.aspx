<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpecialApprove2.aspx.cs" Inherits="OA.SpecialApply.SpecialApprove2" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
     <script language=javascript type="text/javascript">
    function expandcollapse(obj,row)
    {
        var div = document.getElementById(obj);
        var img = document.getElementById('img' + obj);
        
        if (div.style.display == "none")
        {
            div.style.display = "block";
            if (row == 'alt')
            {
                img.src = "../images/minus.gif";
            }
            else
            {
                img.src = "../images/minus.gif";
            }
            img.alt = "Close to view other Customers";
        }
        else
        {
            div.style.display = "none";
            if (row == 'alt')
            {
                img.src = "../images/plus.gif";
            }
            else
            {
                img.src = "../images/plus.gif";
            }
            img.alt = "Expand to show Orders";
        }
    } 
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table class="Tb_Blank">
        <tr>
            <td><asp:Label ID="lblSheetNum" Text="表单编号:" runat="server"></asp:Label></td>
            <td><asp:TextBox ID="txtWorkSheetNum" runat="server" ></asp:TextBox></td>
            <td> <asp:Label ID="lblSheetName" runat="server" Text="项目名称"></asp:Label></td>
            <td><asp:DropDownList ID="ddlProject" runat="server"></asp:DropDownList></td>
            <td><asp:Button ID="btnSearch" runat="server" Text="查询" OnClick="btnSearch_Click" /></td>
            <td><asp:Button ID="btnCancel" runat="server" Text="取消" OnClick="btnCancel_Click" /></td>
            
        </tr>
      </table>
   <asp:GridView ID="gvSpecial" runat="server" AllowSorting="true"  AutoGenerateColumns="false" DataKeyNames="SpecialExpId" CellPadding="1" Width="100%" OnRowDataBound="gvSpecial_RowDataBound" OnSorting="gvSpecial_Sorting">
            <Columns>
                 <asp:TemplateField >
                    <ItemTemplate>
                        <a href="javascript:expandcollapse('div<%# Eval("SpecialExpId") %>','one')">
                            <img id="imgdiv<%# Eval("SpecialExpID") %>" alt="Click to show/hide Orders for Customer <%# Eval("SpecialExpId") %>"   border="0" src="../images/plus.gif" />
                        </a>
                    </ItemTemplate>
                    <ItemStyle Width="5%" />
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="序号">
                    <ItemTemplate>
                        <%#Container.DataItemIndex+1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="表单编号" SortExpression="SheetNum">
                     <ItemTemplate>
                        <asp:LinkButton ID="lbtnDetail" runat="server" style="text-decoration:none;" Text='<%#Eval("SheetNum") %>' CommandArgument='<%#Eval("SpecialExpId") %>' CausesValidation="false" OnClick="btnDetail_Click"  ></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="项目名称" SortExpression="ProjectName">
                    <ItemTemplate>
                        <asp:Label ID="ProjectName" runat="server" Text='<%#Eval("ProjectName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="申请人">
                    <ItemTemplate>
                        <asp:Label ID="lblApplyName" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="申请时间">
                    <ItemTemplate>
                        <asp:Label ID="lblApplyTime" runat="server"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="审批状态">
                    <ItemTemplate>
                        <asp:Label ID="lblState" runat="server" Text=""></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="审批时间">
                    <ItemTemplate>
                        <asp:Label ID="lblApproveTime" runat="server" Text='<%#Eval("Apply2Time") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnSubmit" Text="审批" runat="server"  CommandArgument='<%#Eval("SpecialExpId") %>' CausesValidation="false" OnClick="btnSubmit_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField >
                    <ItemTemplate>
                         <tr>
                            <td colspan="100%">
                                 <div id="div<%# Eval("SpecialExpID") %>" style="display:none;position:relative;left:4.3%;OVERFLOW: auto;WIDTH:96%" >
                                    <asp:GridView ID="GridView2" Width=100%  AutoGenerateColumns=false  runat="server" ShowHeader="false" DataKeyNames="SpecialExpId"  OnRowDataBound = "GridView2_RowDataBound">
                                        <Columns>
                                             <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                    <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                           <asp:TemplateField HeaderText="表单编号" SortExpression="SheetNum">
                                                 <ItemTemplate>
                                                    <asp:LinkButton ID="lbtnDetail" runat="server" style="text-decoration:none;" Text='<%#Eval("SheetNum") %>' CommandArgument='<%#Eval("SpecialExpId") %>' CausesValidation="false" OnClick="btnDetail_Click"  ></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="项目名称" SortExpression="ProjectName">
                                                <ItemTemplate>
                                                    <asp:Label ID="ProjectName" runat="server" Text='<%#Eval("ProjectName") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="申请人">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblApplyName" runat="server"></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="申请时间">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblApplyTime" runat="server"></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="审批状态">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblState" runat="server" Text=""></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="审批时间">
                                                <ItemTemplate>
                                                    <asp:Label ID="lblApproveTime" runat="server" Text='<%#Eval("Apply2Time") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                        <AlternatingRowStyle BackColor="#F2F0F0" />
                                        <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White" />
                                         <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                   </asp:GridView>
                                   </div>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <AlternatingRowStyle BackColor="#F2F0F0" />
           <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
           <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
        </asp:GridView>
         <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged">
       </webdiyer:AspNetPager>
        <webdiyer:AspNetPager ID="AspNetPager2" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" NumericButtonCount="30" PageSize="30" Visible="false" >
        </webdiyer:AspNetPager>
    </div>
    </form>
</body>
</html>
