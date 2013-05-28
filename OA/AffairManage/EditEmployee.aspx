<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Apply1.Master" CodeBehind="EditEmployee.aspx.cs" Inherits="OA.EditEmployee" %>


      <asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank" style="width:100%;">
    <tr>
        <td colspan="2"><h2>编辑员工信息</h2></td>
    </tr>
    <tr>
        <td colspan="2">
            <table class="Tb_Common">
                <tr>
                    <td style="width:12%;">姓名<span style="color:Red;">*</span></td>
                    <td style="text-align:left; width:21%;">
                        <asp:TextBox ID="txtEmployeeName" runat="server" SkinID="skinid3"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valrName" runat="server" ErrorMessage="必填" ControlToValidate="txtEmployeeName"></asp:RequiredFieldValidator>
                    </td>
                    <td style="width:12%;">性别<span style="color:Red;">*</span></td>
                    <td style="width:21%;">
                            <asp:RadioButtonList ID="rblSex" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="0" Selected="True">男</asp:ListItem>
                                <asp:ListItem Value="1">女</asp:ListItem>
                            </asp:RadioButtonList>
                    </td>
                    <td rowspan="4" colspan="2" style="width:34%;">
                     <asp:Image ID="Image1" runat="server" ImageUrl="~/Photo/NewImage.jpg"  />
                    </td>
                </tr>
                 <tr>
                     <td>政治面貌<span style="color:Red;">*</span></td>
                    <td style="text-align:left;"><asp:DropDownList ID="ddlPolitics" runat="server" SkinID="skinid2"></asp:DropDownList></td>
                    <td>婚姻<span style="color:Red;">*</span></td>
                    <td>
                        <asp:RadioButtonList ID="rbtnMarrage" runat="server" RepeatDirection="Horizontal">
                                <asp:ListItem Value="0" Selected="True">未婚</asp:ListItem>
                                <asp:ListItem Value="1">已婚</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                  <td>所在部门<span style="color:Red;">*</span></td>
                  <td style="text-align:left;"><asp:DropDownList ID="ddlDepart" runat="server" SkinID="skinid2"></asp:DropDownList></td>
                  <td>职位<span style="color:Red;">*</span></td>
                  <td style="text-align:left;"><asp:DropDownList ID="ddlPosition" runat="server" SkinID="skinid2"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td>学历<span style="color:Red;">*</span></td>
                    <td style="text-align:left;"><asp:DropDownList ID="ddlEducation" runat="server" SkinID="skinid2"></asp:DropDownList></td>
                    <td>外语水平<span style="color:Red;">*</span></td>
                    <td style="text-align:left;"><asp:DropDownList ID="ddlLanguage" runat="server" SkinID="skinid2"></asp:DropDownList></td>
                </tr>
                <tr>
                    <td><asp:Label ID="lblState" runat="server" Text="状态"></asp:Label><span style="color:Red;">*</span></td>
                    <td>
                        <asp:RadioButtonList ID="rblState" runat="server" AutoPostBack="true" RepeatDirection="Horizontal" OnSelectedIndexChanged="rblState_SelectedIndexChanged">
                            <asp:ListItem Value="0" Selected="True">在职</asp:ListItem>
                            <asp:ListItem Value="1">离职</asp:ListItem>
                        </asp:RadioButtonList>
                        
                    </td>
                    <td><asp:Label ID="lblLeave" runat="server" Text="离职时间"></asp:Label></td>
                    <td style="text-align:left;">
                        <asp:TextBox ID="txtLeaveDate" runat="server" onclick="WdatePicker()" Enabled="false" Visible="false" SkinID="skinid3" ></asp:TextBox>
                    </td>
                     <td>
                        转正时间：
                    </td>
                    <td>
                        <asp:TextBox ID="txtTurntime" runat="server" onclick="WdatePicker()" SkinID="skinid2" ></asp:TextBox>
                    </td>
                    
                </tr>
                 <tr>
                    <td>身份证号</td>
                    <td style="text-align:left;">
                        <asp:TextBox ID="txtIdentyNum" runat="server"  SkinID="skinid3"></asp:TextBox>
                    </td>
                      <td>生日<span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                        <asp:TextBox ID="txtBirthday" runat="server" onclick="WdatePicker()" SkinID="skinid3"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="valr" runat="server" ErrorMessage="必填" ControlToValidate="txtBirthday"></asp:RequiredFieldValidator>
                    </td>    
                     <td>
                        QQ邮箱<span style="color:Red;">*</span>
                    </td> 
                    <td style="text-align:left;">
                        <asp:TextBox ID="txtQq" runat="server" SkinID="skinid3"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="必填" ControlToValidate="txtQq"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                   <td>毕业院校</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtSchool" runat="server" SkinID="skinid3"></asp:TextBox></td>
                     <td>专业</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtMajor" runat="server" SkinID="skinid3"></asp:TextBox></td>
                    <td style="width:12%;">获得证书</td>
                    <td style="width:22%; text-align:left" ><asp:TextBox ID="txtCertificate" runat="server"  SkinID="skinid3"></asp:TextBox></td>
                </tr>
                
                  <tr>
                   
                     <td>家庭电话</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtHomephone" runat="server"  SkinID="skinid3"></asp:TextBox></td> 
                     <td>
                        户口所在地</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtNativePlace" runat="server" SkinID="skinid3"></asp:TextBox></td>
                        <td>
                        常住地址</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtAddress" runat="server"  SkinID="skinid3"></asp:TextBox></td>
                </tr>
                

                <tr>
                    <td>参加工作时间<span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                    <asp:TextBox ID="txtJobTime" runat="server" onclick="WdatePicker()"  SkinID="skinid3"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtJobTime"></asp:RequiredFieldValidator>
                    </td>
                    <td>加入公司时间<span style="color:Red;">*</span></td>
                    <td style="text-align:left;">
                    <asp:TextBox ID="txtJoinTime" runat="server" onclick="WdatePicker()"  SkinID="skinid3"></asp:TextBox>
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="必填" ControlToValidate="txtJoinTime"></asp:RequiredFieldValidator>
                    </td>
                     <td>办公电话</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtOfficephone" runat="server" Text="02168543120"  SkinID="skinid3"></asp:TextBox></td>
                   
                     
                </tr>
               
                
                <tr> 
                 <td>手机</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtMobile" runat="server"  SkinID="skinid3"></asp:TextBox></td>
                     <td>Email</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtEmail" runat="server"  SkinID="skinid3"></asp:TextBox></td>
                <td>分机</td>
                    <td style="text-align:left;"><asp:TextBox ID="txtPhoneExt" runat="server"  SkinID="skinid3"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>级别<span style="color:Red;">*</span></td>
                    <td><asp:DropDownList ID="ddlLevel" runat="server"></asp:DropDownList></td>
                    <td>档次<span style="color:Red;">*</span></td>
                    <td><asp:DropDownList ID="ddlDang" runat="server"></asp:DropDownList></td>
                    <td>
                       上传头像
                    </td>
                    <td>
                          <asp:FileUpload ID="UpImage" runat="server" SkinID="fu70" />
                          <asp:Button ID="btnImgUp" runat="server" Text="上传"  CausesValidation="false" OnClick="btnImgUp_Click" ValidationGroup="btn2" />
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
       <td><asp:Button ID="btnSave" runat="server"  Text="保存" OnClick="btnSave_Click"  /></td>
       <td><asp:Button ID="btnBack" runat="server" Text="返回"  OnClick="btnBack_Click" ValidationGroup="btn1" /></td>
    </tr>
</table>
</asp:Content>
         