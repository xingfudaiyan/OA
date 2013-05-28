<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply.Master" CodeBehind="AddPrice.aspx.cs" Inherits="OA.OfferPrice.AddPrice" %>


<asp:Content ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:100%;">
        <tr>
            <td colspan="4"><h1> 报价(投标)审批表</h1></td>
        </tr>
        <tr>
            <td style="text-align:right; width:15%;">表单类型:<span style="color:Red;">*</span></td>
            <td style="text-align:left;"><asp:RadioButtonList ID="rblType" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="rblType_SelectedIndexChanged" ></asp:RadioButtonList></td>
            <td style="width:15%; text-align:right;">表单编号:<span style="color:Red;">*</span></td>
            <td style="width:20%;">
               <asp:TextBox ID="txtSheetNum" runat="server"  ReadOnly="true" SkinID="skinid3"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4"><table class="Tb_Common" style="text-align:center;">
            <tr>
                <td width="10%">填表时间<span style="color:Red;">*</span></td>
                <td width="40%" style="text-align:left;">
                <asp:TextBox ID="txtFillTableDate" runat="server" onclick="WdatePicker()" SkinID="skinid3" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="valRDate" runat="server" ErrorMessage="必填" ControlToValidate="txtFillTableDate"></asp:RequiredFieldValidator>
                </td>
                <td width="12%">项目负责人<span style="color:Red;">*</span></td>
                <td width="38%"><asp:DropDownList ID="ddlEmployee" runat="server" SkinID="ddl1"></asp:DropDownList></td>
            </tr>
            <tr>
                <td >项目名称<span style="color:Red;">*</span></td>
                <td style=" text-align:left;"><asp:DropDownList ID="ddlProject" runat="server" AutoPostBack="true" SkinID="Skinid2" OnSelectedIndexChanged="ddlProject_SelectedIndexChanged"></asp:DropDownList></td>
                <td >项目编号<span style="color:Red;">*</span></td>
                <td ><asp:Label ID="lblProjectNum" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td rowspan="2">系统报价</td>
                <td style="text-align:left;">
                大写：￥<asp:TextBox ID="txtBigMoney" runat="server" SkinID="skinid3"></asp:TextBox>
                </td>
                <td rowspan="2">附件</td>
                <td  rowspan="2" ><asp:FileUpload ID="UpFile" runat="server" /></td>
                
            </tr>
            <tr>
                <td style="text-align:left;"> 小写：￥<asp:TextBox ID="txtMoneySum" runat="server" SkinID="skinid3"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td>产品报价</td>
                <td colspan="3" style="text-align:left;"> 
                产品总报价：￥<asp:Label ID="lblMoneySum" runat="server" Text="0元"></asp:Label>
                 <asp:GridView ID="gvProductType" runat="server" Width="100%" AutoGenerateColumns="false" DataKeyNames="ProductTypeId" OnRowDeleting="gvProductType_RowDeleting">
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
                             <asp:TemplateField HeaderText="单价(元)" >
                                <ItemTemplate>
                                    <asp:Label ID="lblP" runat="server"  Text='<%#Eval("Price") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="合计(元)" >
                                <ItemTemplate>
                                    <asp:Label ID="lblS" runat="server"  Text='<%#Eval("Sums") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:CommandField ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
                
            </tr>
       
            <tr>
                <td>项目概述</td>
                <td colspan="3"><asp:TextBox ID="txtProjectDes" runat="server" TextMode="MultiLine"></asp:TextBox></td>

            </tr>
            <tr>
                <td>市场部意见</td>
                <td><asp:TextBox ID="txtSectionView" runat="server" TextMode="MultiLine"></asp:TextBox></td>
               <td>总经理意见</td>
                <td><asp:TextBox ID="txtManagerView" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        </table>
        <table class="Tb_Blank" style="width:100%;">
            <tr>
                <td style="width:15%; height:80px;">市场部经理：</td>
                <td style="width:35%;"></td>
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
               <td>
                  <asp:Button ID="btnSave" runat="server" Text="保存"  OnClick="btnSave_Click" />
               </td> 
               <td><asp:Button ID="btnCancel" runat="server" Text="返回"  OnClick="btnCancel_Click" ValidationGroup="btn1" /></td> 
            </tr>
        </table>
        
       <table class="Tb_Common" style="width:100%;">
            <tr>
                <td style="width:20%;">
                产品名称<span style="color:Red;">*</span>  <asp:RequiredFieldValidator ID="re1" runat="server" ErrorMessage="必填" ControlToValidate="txtName" ValidationGroup="btn2"></asp:RequiredFieldValidator>
                </td>
                <td style="width:20%;">
                型号/规格<span style="color:Red;">*</span>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtModel" ValidationGroup="btn2" ></asp:RequiredFieldValidator>
                </td>
                <td style="width:10%;">单位<span style="color:Red;">*</span></td>
                <td style="width:20%;">
                数量<span style="color:Red;">*</span>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtNum"  ValidationGroup="btn2"></asp:RequiredFieldValidator>
                </td>
                <td style="width:20%;">
                单价(元)<span style="color:Red;">*</span>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="必填" ControlToValidate="txtPrice" ValidationGroup="btn2"></asp:RequiredFieldValidator>
                </td>
                <td style="width:10%;"></td>
            </tr>
            <tr>
                 <td>
                 <asp:TextBox ID="txtName" runat="server" SkinID="skinid1"></asp:TextBox>
               
                 </td>
                 <td>
                 <asp:TextBox ID="txtModel" runat="server" SkinID="skinid1"></asp:TextBox>
                
                 </td>
                 <td>
                     <asp:DropDownList ID="ddlPUnit" runat="server"></asp:DropDownList>
                 </td>
                 <td>
                 <asp:TextBox ID="txtNum" runat="server" SkinID="skinid1"></asp:TextBox>
                 
                 </td>
                 <td>
                 <asp:TextBox ID="txtPrice" runat="server" SkinID="skinid1"></asp:TextBox>
                  
                 </td>
                 
                 <td><asp:Button ID="btnAdd" runat="server" Text="新增" OnClick="btnAdd_Click"  ValidationGroup="btn2" /></td>
            </tr>
         </table>
</asp:Content>
    
      