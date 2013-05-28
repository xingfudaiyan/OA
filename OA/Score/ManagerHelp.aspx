<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManagerHelp.aspx.cs" MasterPageFile="~/Manage.Master" Inherits="OA.Score.ManagerHelp" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<table class="Tb_Blank1" style="width:100%;">
            <tr>
                <td>
                     <table style="width:100%; text-align:center;">
                        <tr>
                            <td colspan="2"><h2>我的审批</h2></td>
                        </tr>
                        
                        <tr>
                        <td colspan="2">
                            <table class="Tb_Blank1">
                                <tr>
                                        <td style="width:90%; text-align:right;"></td>
                                        <td style="width:10%;"><asp:Button ID="btnApprove" runat="server" Text="我的绩效" OnClick="btnApprove_Click"/></td>
                                </tr>
                            </table>
                        </td>
                        </tr>
                        <tr>
                            <td colspan="2" style="height:300px; vertical-align:top;">
                                  <asp:GridView ID="gvScore" runat="server" AutoGenerateColumns="False" DataKeyNames="BasEmScoreId,FrontScoreId,AssistantScoreId" AllowSorting="True" CellPadding="1" Width="100%" OnRowDataBound="gvScore_RowDataBound" OnSorting="gvScore_Sorting">
                                        <Columns>
                                             <asp:TemplateField HeaderText="序号">
                                                <ItemTemplate>
                                                <%#Container.DataItemIndex+1 %>
                                                </ItemTemplate>
                                                <ItemStyle Width="5%" />
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="姓名" SortExpression="EmployeeName"> 
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="lbtnEmployeeName" runat="server" style="text-decoration:none;" Text='<%#Eval("EmployeeName") %>'  CommandArgument='<%#Eval("BasEmScoreId")+","+Eval("FrontScoreId")+","+Eval("AssistantScoreId")  %>'  CausesValidation="false" OnClick="lbtnEmployeeName_Click" ></asp:LinkButton>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="时间" SortExpression="DateSpan"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblDataSpan" runat="server" Text='<%#Eval("DateSpan") %>'></asp:Label>
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
                                             <asp:TemplateField HeaderText="考核人"> 
                                                <ItemTemplate>
                                                    <asp:Label ID="lblUpEmployee" runat="server" Text='何春'></asp:Label>
                                                </ItemTemplate>
                                                 <ItemStyle Width="10%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:Button ID="btnSubmit" Text="评分" runat="server"  CausesValidation="false" CommandArgument='<%#Eval("BasEmScoreId")+","+Eval("FrontScoreId")+","+Eval("AssistantScoreId")  %>' OnClick="btnSubmit_Click"    />
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
      


