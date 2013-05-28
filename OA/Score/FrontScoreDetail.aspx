<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrontScoreDetail.aspx.cs" MasterPageFile="~/Apply1.Master" Inherits="OA.Score.FrontScoreDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>前台绩效考核表</h3></td></tr>
            <tr>
                <td style="text-align:right;">时间：<asp:Label ID="lblDate" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>
                    <table class="Tb_Common" style="width:100%;">
                       <tr>
                        <td style="width:11%;">部门</td>
                        <td style="width:20%;"><asp:Label ID="lblDepart" runat="server"></asp:Label></td>
                        <td style="width:11%;">姓名</td>
                        <td style="width:20%;"><asp:Label ID="lblName" runat="server"></asp:Label></td>
                        <td style="width:10%;">职务</td>
                        <td colspan="4" style="width:28%;"><asp:Label ID="lblPosition" runat="server"></asp:Label></td>
                       </tr>
                       <tr>
                        <td>考核项目</td>
                        <td colspan="4">
                            评价内容</td>
                        <td style="width:7%;">自评</td>
                        <td style="width:7%;">领导评</td>
                        <td style="width:7%;">本栏得分</td>
                        <td style="width:7%;">满分</td>
                       </tr>
                       <tr>
                        <td rowspan="5">
                            工作态度</td>
                        <td colspan="4">
                            <span>严格要求自己遵守公司各项规章制度，纪律性强，无随意违纪、违规现象。</span></td>
                        <td><asp:Label ID="lblSelffs1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs1" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs1" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                形象符合公司要求，衣着打扮大方得体。</span></td>
                        <td><asp:Label ID="lblSelffs2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs2" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs2" runat="server"></asp:Label></td>
                        <td>
                            3</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    积极完成公司领导的临时任务，并能够高质量的完成。</span></td>
                            <td><asp:Label ID="lblSelffs3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpfs3" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectfs3" runat="server"></asp:Label></td>
                            <td>
                                5</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 能够帮助同事完成各类工作，协调跨部门的各类事务。</span></td>
                            <td><asp:Label ID="lblSelffs4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpfs4" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectfs4" runat="server"></asp:Label></td>
                            <td>
                                8</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>对工作出现的问题能够及时补救并勇于承担责任。</span></td>
                            <td><asp:Label ID="lblSelffs5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblUpfs5" runat="server"></asp:Label></td>
                            <td><asp:Label ID="lblSectfs5" runat="server"></asp:Label></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="9">
                            业务能力</td>
                        <td colspan="4">监督各部门对公司相关制度的执行，对出现的问题能够及时上报。</td>
                        <td><asp:Label ID="lblSelffs6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs6" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs6" runat="server"></asp:Label></td>
                        <td>
                            3</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">配合其他部门进行绩效考核并能及时将相关文件上报、归档。</td>
                        <td><asp:Label ID="lblSelffs7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs7" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs7" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       
                        <tr>
                        <td colspan="4">有建设性举办各类活动，丰富员工的业余生活，提高公司凝聚力。</td>
                        <td><asp:Label ID="lblSelffs9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs9" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs9" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">有条理，有营养的制订每周菜谱。</td>
                        <td><asp:Label ID="lblSelffs10" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs10" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs10" runat="server"></asp:Label></td>
                        <td>
                            4</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">公司重要精神、文件的及时传达</td>
                        <td><asp:Label ID="lblSelffs11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs11" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs11" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">公司重要文件资料的管理及合理的归档，在需要时能够迅速的找到。</td>
                         <td ><asp:Label ID="lblSelffs12" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpfs12" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectfs12" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">会议的准备及协助工作</td>
                        <td><asp:Label ID="lblSelffs13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs13" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs13" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">配合公司相关部门的人员招聘工作，并能起到人事监督的作用。</td>
                        <td><asp:Label ID="lblSelffs14" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs14" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs14" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">定期的进行资产盘点，能够有效地保证固定资产的完整及无流失。</td>
                        <td><asp:Label ID="lblSelffs15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs15" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs15" runat="server"></asp:Label></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td rowspan="4">责任感</td>
                        <td colspan="4">积极保守公司商业秘密，并能制定相应策略或制度监督其他部门员工执行。</td>
                         <td ><asp:Label ID="lblSelffs16" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpfs16" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectfs16" runat="server"></asp:Label></td>
                        <td >
                            5</td>
                       </tr>
                       <tr>
                        <td colspan="4">监督公司各类财务支出的有效性、及时性。防止因误缴、缓缴造成公司的各类损失。</td>
                        <td><asp:Label ID="lblSelffs17" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs17" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs17" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                      
                       <tr>
                        <td colspan="4">及时收发公司各类邮件，并对重要邮件或快递能够跟踪收件人是否及时收到。</td>
                        <td><asp:Label ID="lblSelffs18" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs18" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs18" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                  
                        <tr>
                        <td colspan="4">合理的保管和使用公司各类印章，对印章的使用能够有详细的清单记录。</td>
                        <td><asp:Label ID="lblSelffs19" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs19" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs19" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       
                   <tr>
                        <td rowspan="2">学习培养</td>
                        <td colspan="4">对国家行政人事法律法规能够及时理解，并为公司提供良好的指导方向。</td>
                         <td ><asp:Label ID="lblSelffs20" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblUpfs20" runat="server"></asp:Label></td>
                        <td ><asp:Label ID="lblSectfs20" runat="server"></asp:Label></td>
                        <td >
                            7</td>
                       </tr>
                       <tr>
                        <td colspan="4">钻研自身业务技能，提高业务水平。</td>
                        <td><asp:Label ID="lblSelffs21" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblUpfs21" runat="server"></asp:Label></td>
                        <td><asp:Label ID="lblSectfs21" runat="server"></asp:Label></td>
                        <td>
                            5</td>
                       </tr>
                       <tr>
                        <td>总分</td>
                        <td colspan="7"><asp:Label ID="lblTotalScore" runat="server"></asp:Label></td>
                        <td>100</td>
                       </tr>
                       <tr>
                        <td>评价等级</td>
                        <td colspan="8">
                            <asp:Label ID="lblLevel" runat="server"></asp:Label>
                        </td>
                       </tr>
                       <tr>
                        <td>评价者综合意见</td>
                        <td colspan="8">
                            <asp:Label ID="lblViews" runat="server"></asp:Label>
                        </td>
                       </tr>
                    </table>
                </td>
            </tr>
        </tbody>
    </table>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content2" runat="server">
  <table class="Tb_Blank" style="width:100%;">
        <tr>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"   /></td>
        </tr>
    </table> 
</asp:Content>
