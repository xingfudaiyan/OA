<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Assistantgv.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.Score.Assistantgv" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2" style="height: 48px"><h2>综合部绩效考核</h2></td>
                        </tr>
                        <tr>
                             <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:80%; text-align:right;"></td>
                                        <td style="width:20%;"><asp:Button ID="btnMyScore" runat="server" Text="我的绩效" OnClick="btnMyScore_Click" /></td>
                                       
                                </tr>
                            </table>
                        </td>
                        </tr>
                        
                        <tr>
                            <td colspan="3" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="False" DataKeyNames="DriverScoreId,NurseScoreId" AllowSorting="True" CellPadding="1" Width="100%" OnRowDataBound="gvScore_RowDataBound" OnSorting="gvScore_Sorting" >
                                        <Columns>
                                             <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="姓名" SortExpression="EmployeeName" > 
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbtnName" runat="server" style="text-decoration:none;" Text='<%#Eval("EmployeeName") %>'  CommandArgument='<%#Eval("DriverScoreId")+","+Eval("NurseScoreId")  %>' CausesValidation="false" OnClick="lbtnName_Click"  ></asp:LinkButton>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="时间" SortExpression="DateSpan"> 
                                                <ItemTemplate>
                                                     <asp:Label ID="lblDateSpan" runat="server" Text='<%#Eval("DateSpan") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="15%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="总分" SortExpression="TotalScore"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSumScore" runat="server" Text='<%#Eval("TotalScore") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="等级" SortExpression="EvaluateName"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblLevels" runat="server" Text='<%#Eval("EvaluateName") %>'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="评分" runat="server" CommandArgument='<%#Eval("DriverScoreId")+","+Eval("NurseScoreId")  %>' CausesValidation="false" OnClick="btnSubmit_Click"  />
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                        </Columns>
                                         <AlternatingRowStyle BackColor="#F2F0F0" />
                                       <HeaderStyle BackColor="#507CB2" Font-Bold="True" ForeColor="White"/>
                                       <RowStyle BackColor="#ECF5FF" ForeColor="Black" HorizontalAlign="Center" />
                                    </asp:GridView>
                                    <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="第一页" LastPageText="最后一页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" >
                                   </webdiyer:AspNetPager>
                            </td>
                        </tr>
                      </table>
                </td>
            </tr>
        </table>
</asp:Content>
      



