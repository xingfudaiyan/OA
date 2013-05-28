<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="PriceAp1.aspx.cs" Inherits="OA.OfferPrice.PriceAp1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="4"><h1>报价(投标)审批表</h1></td>
        </tr>
        <tr>
            <td style="text-align:right; width:15%;"> 表单类型:<span style="color:Red;">*</span></td>
            <td style="text-align:left;"><asp:RadioButtonList ID="rblType" runat="server" RepeatDirection="Horizontal" Enabled="false"></asp:RadioButtonList></td>
           <td style="width:15%; text-align:right;">
             表单编号:<span style="color:Red;">*</span>
            </td>
            <td style="width:20%;"><asp:Label ID="lblSheetNum" runat="server" ></asp:Label></td>
        </tr>
        <tr>
            <td colspan="4">
            <table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="10%">填表时间</td>
                <td width="40%"><asp:Label ID="lblFillTableDate" runat="server" ></asp:Label></td>
                <td width="12%">项目负责人</td>
                <td width="38%"><asp:Label ID="lblEmployee" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>项目名称</td>
                <td><asp:Label ID="lblProject" runat="server"></asp:Label></td>
                <td >项目编号</td>
                <td ><asp:Label ID="lblProjectNum" runat="server"></asp:Label></td>
            </tr>
             <tr>
                <td rowspan="2">系统报价</td>
                <td style="text-align:left;"> 大写：￥<asp:Label ID="lblBigMoney" runat="server"></asp:Label></td>
                <td rowspan="2">附件</td>
                <td rowspan="2"><asp:Button ID="btnDownLoad" runat="server" Text="下载" OnClick="btnDownLoad_Click" /></td>
            </tr>
            <tr>
               <td  style="text-align:left;">小写：￥<asp:Label ID="lblMoneySum" runat="server"></asp:Label></td>
            </tr>
              <tr>
                <td>产品报价</td>
                <td colspan="3" style="text-align:left;">
                 产品总报价：￥<asp:Label ID="Label1" runat="server" Text="0元"></asp:Label>
                    <asp:GridView ID="gvProductType" runat="server" Width="100%" AutoGenerateColumns="false" DataKeyNames="ProductTypeId">
                        <Columns>
                             <asp:TemplateField HeaderText="序号">
                                <ItemTemplate>
                                    <%#Container.DataItemIndex+1 %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="产品名称">
                                <ItemTemplate>
                                    <asp:Label ID="lblName" runat="server" Text='<%#Eval("ProductName") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="型号/规格">
                                <ItemTemplate>
                                    <asp:Label ID="lblM" runat="server"  Text='<%#Eval("Model") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="单位" >
                                <ItemTemplate>
                                    <asp:Label ID="lblU" runat="server"  Text='<%#Eval("Unit") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="数量" >
                                <ItemTemplate>
                                    <asp:Label ID="lblN" runat="server"  Text='<%#Eval("Num") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="单价" >
                                <ItemTemplate>
                                    <asp:Label ID="lblP" runat="server"  Text='<%#Eval("Price") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="合计" >
                                <ItemTemplate>
                                    <asp:Label ID="lblS" runat="server"  Text='<%#Eval("Sums") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                          
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            
            <tr>
                <td>项目概述</td>
                <td colspan="3"><asp:TextBox ID="txtProjectDes" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox></td>

            </tr>
            <tr>
                <td>市场部意见</td>
                <td><asp:TextBox ID="txtSectionView" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox></td>
                <td>总经理意见</td>
                <td><asp:TextBox ID="txtManagerView" runat="server" TextMode="MultiLine" ReadOnly="true"></asp:TextBox></td>
            </tr>
        </table>
         <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;"><asp:Image ID="imgMarket" runat="server" ImageUrl="~/images/hechun.jpg" /></td>
                <td style="width:15%;">总经理：</td>
                <td style="width:35%;"><asp:Image ID="imgManager" runat="server" Visible="false" ImageUrl="~/images/qidawei.jpg" /></td>
            </tr>
        </table>
        </td>
    </table>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
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
        