<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DriveScoreEdit.aspx.cs" MasterPageFile="~/Apply1.Master"  Inherits="OA.Score.DriveScoreEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
 <table class="Tb_Blank" style="width:100%;">
        <tbody>
            <tr><td><h3>司机绩效考核表</h3></td></tr>
            <tr>
                <td style="text-align:right;"><span style="color:red">*</span>时间：<asp:DropDownList ID="ddlYear" runat="server"></asp:DropDownList>年<asp:DropDownList ID="ddlMonth" runat="server"></asp:DropDownList>月</td>
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
                            <span>很少迟到、早退、缺席，工作态度认真</span></td>
                        <td><input type="text" name="Selfds1" class="Input1" value="<%=Selfds1 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td colspan="4">
                            <span >
                                工作不偷懒、不倦怠</span></td>
                        <td><input type="text" name="Selfds2" class="Input1" value="<%=Selfds2 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                            <td colspan="4">
                                <span>
                                    做事敏捷、效率高</span></td>
                            <td><input type="text" name="Selfds3" class="Input1" value="<%=Selfds3 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>8</td>
                       </tr>
                       <tr>
                         <td colspan="4">
                             <span>
                                 遵守上司的指示</span></td>
                            <td><input type="text" name="Selfds4" class="Input1" value="<%=Selfds4 %>" /></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                        <tr>
                            <td colspan="4">
                                <span>不倦怠，且正确地向上司报告</span></td>
                            <td><input type="text" name="Selfds5" class="Input1" value="<%=Selfds5 %>"/></td>
                            <td></td>
                            <td></td>
                            <td>5</td>
                       </tr>
                     
                       <tr>
                        <td rowspan="4">基础能力</td>
                        <td colspan="4">精通职务内容，具备处理份内工作的能力</td>
                        <td><input type="text" name="Selfds6" class="Input1" value="<%=Selfds6 %>" /></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                       
                        <td colspan="4">工作习惯和方法</td>
                        <td><input type="text" name="Selfds7" class="Input1" value="<%=Selfds7 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                        <tr>
                       
                        <td colspan="4">工作效率</td>
                        <td><input type="text" name="Selfds8" class="Input1" value="<%=Selfds8 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        
                        <td colspan="4">严守公司纪律，纪律性、保密性</td>
                        <td><input type="text" name="Selfds9" class="Input1" value="<%=Selfds9 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                        <td rowspan="4">业务磨练程度</td>
                        <td colspan="4">完成每天领导及员工的出车任务</td>
                         <td ><input type="text" name="Selfds10" class="Input1" value="<%=Selfds10 %>"/></td>
                        <td ></td>
                        <td ></td>
                        <td >8</td>
                       </tr>
                       <tr>
                        <td colspan="4">对出车前做好前期准备。如：查看好路线</td>
                        <td><input type="text" name="Selfds11" class="Input1" value="<%=Selfds11 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>8</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">做好公司车辆清洁工作</td>
                        <td><input type="text" name="Selfds12" class="Input1" value="<%=Selfds12 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                       <tr>
                      
                        <td colspan="4">做好领导交办的临时工作</td>
                        <td><input type="text" name="Selfds13" class="Input1" value="<%=Selfds13 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>5</td>
                       </tr>
                        <tr>
                        <td rowspan="3">责任感</td>
                        <td colspan="4">责任感强</td>
                         <td ><input type="text" name="Selfds14" class="Input1" value="<%=Selfds14 %>"/></td>
                        <td ></td>
                        <td ></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">勇于面对和承担新任务</td>
                        <td><input type="text" name="Selfds15" class="Input1" value="<%=Selfds15 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">严谨细致</td>
                        <td><input type="text" name="Selfds16" class="Input1" value="<%=Selfds16 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                  
                   <tr>
                        <td rowspan="3">协调性</td>
                        <td colspan="4">能与其他同事和睦相处</td>
                         <td ><input type="text" name="Selfds17" class="Input1" value="<%=Selfds17 %>"/></td>
                        <td ></td>
                        <td ></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">乐于帮助同事，积极参与并协助其他部门完成相关任务</td>
                        <td><input type="text" name="Selfds18" class="Input1" value="<%=Selfds18 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       <tr>
                     
                        <td colspan="4">沟通能力</td>
                        <td><input type="text" name="Selfds19" class="Input1" value="<%=Selfds19 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td rowspan="4">自我启发</td>
                        <td colspan="4">审查自己的能力，并时常查阅地图熟悉江浙沪地带路线</td>
                         <td ><input type="text" name="Selfds20" class="Input1" value="<%=Selfds20 %>"/></td>
                        <td ></td>
                        <td ></td>
                        <td >3</td>
                       </tr>
                       <tr>
                        <td colspan="4">正确看待看自己与公司的未来</td>
                        <td><input type="text" name="Selfds21" class="Input1" value="<%=Selfds21 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       <tr>
                        <td colspan="4">自我调整情绪</td>
                        <td><input type="text" name="Selfds22" class="Input1" value="<%=Selfds22 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                        <tr>
                        <td colspan="4">即使是自己份外的事，也能主动承担</td>
                        <td><input type="text" name="Selfds23" class="Input1" value="<%=Selfds23 %>"/></td>
                        <td></td>
                        <td></td>
                        <td>3</td>
                       </tr>
                       
                       <tr>
                        <td>总分</td>
                        <td colspan="7"></td>
                        <td>100</td>
                       </tr>
                       <tr>
                        <td>评价等级</td>
                        <td colspan="8">
                        </td>
                       </tr>
                       <tr>
                        <td>评价者综合意见</td>
                        <td colspan="8"></td>
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
           <td><asp:Button ID="btnSave" runat="server" Text="保存" OnClick="btnSave_Click"   /></td>
           <td><asp:Button ID="btnCancel" runat="server" Text="返回" OnClick="btnCancel_Click"  /></td>
        </tr>
    </table> 
</asp:Content>
