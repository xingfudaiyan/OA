<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="PreApp.aspx.cs" Inherits="OA.TreatApply.PreApp" %>
<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="2"><h1>业务费用申请表</h1></td>
        </tr>
         <tr>
            <td colspan="2" style="text-align:right;">表单编号:<span style="color:Red;">*</span><asp:Label ID="lblSheetNum" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">
            <table class="Tb_Common" style="text-align:center;">
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
                 <td colspan="3">被招待人单位</td>
                 <td colspan="3">我司陪同人员</td>
            </tr>
            <tr>
                <td colspan="3" style=" vertical-align:top;">
                    <asp:GridView ID="gvBRelate" runat="server" EmptyDataText="没有被招待人员" AutoGenerateColumns="False" DataKeyNames="RelateBExpId" Width="100%" >
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
                <td colspan="3" style=" vertical-align:top;">
                    <asp:GridView ID="gvBEmployee" runat="server" EmptyDataText="没有陪同人员" AutoGenerateColumns="false" DataKeyNames="EmployeeBExpId" Width="100%" >
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
                 <td colspan="2">
                  <asp:Label ID="lblMemo" runat="server"></asp:Label>
                 </td>
                 <td>人数总计</td>
                 <td colspan="2"><asp:Label ID="lblPeopleNum" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td>接待事由</td>
                <td colspan="5">
                <asp:TextBox ID="txtReason" runat="server" ReadOnly="true" TextMode="MultiLine"></asp:TextBox>
                </td>
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
        </table>
        <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;"> <asp:Image ID="imgMarket" runat="server" ImageUrl="~/images/hechun.jpg" Visible="false" /></td>
                <td style="width:15%;">总经理：</td>
                <td style="width:35%;"></td>
            </tr>
        </table>
        
        </td>
        </tr>
      
    </table>
</asp:Content>
<asp:Content ContentPlaceHolderID="Content2" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
             <td style="padding-left:65%;">
                  <asp:RadioButtonList ID="rblOver" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="0">修正</asp:ListItem>
                        <asp:ListItem Value="1">通过</asp:ListItem>
                  </asp:RadioButtonList>
             </td>
             <td style="padding-left:5%;">
                <asp:Button  ID="btnSign" runat="server" Text="签名" OnClick="btnSign_Click" />
             </td>
        </tr>
</table>
<table class="Tb_Blank" style="width:100%;">
    <tr>
            <td>
               <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click"  />
            </td> 
            <td><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" /></td> 
        </tr>  
</table>
</asp:Content>
         