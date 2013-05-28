<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TApp2.aspx.cs" Inherits="OA.TreatApply.TApp2" %>
<script language="javascript" defer="defer" type="text/javascript" src="/My97DatePicker/WdatePicker.js"> 
<LINK rel="stylesheet" type="text/css" href="My97DatePicker/skin/default/datepicker.css" />
</script> 

<%@ Register Assembly="KingControls" Namespace="KingControls" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
     <style type="text/css">
        .button
        { 
            BORDER-RIGHT: #7EBF4F 1px solid; PADDING-RIGHT: 2px; BORDER-TOP: #7EBF4F 1px solid; PADDING-LEFT: 2px; FONT-SIZE: 12px; FILTER: 
            progid:DXImageTransform.Microsoft.Gradient(GradientType=0, StartColorStr=#ffffff, EndColorStr=#B3D997); BORDER-LEFT: #7EBF4F 1px solid; CURSOR: hand; 
            COLOR: black; PADDING-TOP: 2px; BORDER-BOTTOM: #7EBF4F 1px solid;
        } 
        .table
        {
            background-color:#EFF2E9;                     
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table class="Tb_Blank" style="margin-left:10%;">
        <tr>
            <td colspan="2"><h3>业务费用申请表</h3></td>
        </tr>
        <tr>
            
            <td colspan="2" style="text-align:right;">表单编号:<span style="color:Red;">*</span><asp:Label ID="lblSheetNum" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="16%">申请人</td>
                <td width="17%"><asp:Label ID="lblApplyPeople" runat="server"></asp:Label></td>
                <td width="16%">部门</td>
                <td width="17%"><asp:Label ID="lblDepart" runat="server"></asp:Label></td>
                <td width="16%">申请日期<span style="color:Red;">*</span></td>
                <td width="17%">
                <asp:Label ID="lblApplyDate" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">招待人员<span style="color:Red;">*</span>
                </td>
                <td colspan="3">
                 陪同人员<span style="color:Red;">*</span>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="gvBRelate" runat="server" AutoGenerateColumns="False" DataKeyNames="RelateBExpId" Width="100%" >
                    <Columns>
                         <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="招待人员">
                            <ItemTemplate>
                             <asp:Label ID="lblName" runat="server" Text='<%#Eval("RelateName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="职务">
                        <ItemTemplate>
                            <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("Position") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                </td>
                <td colspan="3">
                    <asp:GridView ID="gvBEmployee" runat="server" AutoGenerateColumns="false" DataKeyNames="EmployeeBExpId" Width="100%" >
                    <Columns>
                         <asp:TemplateField HeaderText="序号">
                            <ItemTemplate>
                                <%#Container.DataItemIndex+1 %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="陪同人员">
                            <ItemTemplate>
                             <asp:Label ID="lblName" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="职务">
                        <ItemTemplate>
                            <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("PositionName") %>'></asp:Label>
                        </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    </asp:GridView>
                </td>
            </tr>
            
            <tr>
                <td>备注</td>
                <td colspan="5">
                 <asp:Label ID="lblMemo" runat="server"></asp:Label>
                </td>
                
            </tr>
            <tr>
                <td colspan="6" style="text-align:left">接待事由说明:</td>
            </tr>
            <tr>
                <td colspan="6"><asp:Label ID="lblReason" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>费用项目</td>
                 <td><asp:Label ID="lblItem1" runat="server"></asp:Label></td>
                  <td><asp:Label ID="lblItem2" runat="server" ></asp:Label></td>
                   <td><asp:Label ID="lblItem3" runat="server" ></asp:Label></td>
                    <td><asp:Label ID="lblItem4" runat="server" ></asp:Label></td>
                     <td>小计</td>
            </tr>
            <tr>
                <td>金额(元)</td>
                  <td style="text-align:left;">
                  <asp:Label ID="lblMoney1" runat="server" ></asp:Label></td>
                    <td style="text-align:left;"><asp:Label ID="lblMoney2" runat="server" ></asp:Label></td>
                    <td style="text-align:left;"><asp:Label ID="lblMoney3" runat="server" ></asp:Label> </td>
                    <td style="text-align:left;"><asp:Label ID="lblMoney4" runat="server" ></asp:Label></td>
                    <td style="text-align:left;"><asp:Label ID="lblMoneySum" runat="server" ></asp:Label></td>
            </tr>
             <tr>
                <td>市场部经理</td>
                <td colspan="5"></td>
            </tr>
            <tr>
                <td>总经理</td>
                <td colspan="5"> </td>
            </tr>
            
        </table>
        </td>
        </tr>
        <tr>
            <td>
               是否通过
            </td>
             <td> <asp:RadioButtonList ID="rblOver" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="0">修正</asp:ListItem>
                    <asp:ListItem Value="1">通过</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td>
               <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click" />
            </td> 
            <td><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" /></td> 
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
