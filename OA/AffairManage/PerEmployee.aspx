<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerEmployee.aspx.cs" Inherits="OA.PerEmployee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>员工基本信息</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>姓名</td>
                <td><asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></td>
                <td>性别</td>
                <td><asp:Label id="lblSex" runat="server" Text="Label"></asp:Label></td>
            </tr>
             <tr>
                <td>籍贯</td>
                <td><asp:Label ID="lblNative" runat="server" Text="Label"></asp:Label></td>
                <td>生日</td>
               <td><asp:Label id="lblBirthday" runat="server" Text="Label"></asp:Label></td>        
            </tr>
             <tr>
                <td>专业</td>
                <td> <asp:Label ID="lblMajor" runat="server" Text="Label"></asp:Label></td>
                <td>毕业院校</td>
                <td><asp:Label id="lblSchool" runat="server" Text="Label"></asp:Label></td>
                           
            </tr>
             <tr>
                <td>学历</td>
                <td><asp:Label ID="lblEducation" runat="server" Text="Label"></asp:Label></td>
                <td>外语水平</td>
                <td><asp:Label id="lblLanguage" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>身份证号</td>
                <td> <asp:Label ID="lblIdentyNum" runat="server" Text="Label"></asp:Label></td>
                <td>获得证书</td>
                <td><asp:Label id="lblCertificate" runat="server" Text="Label"></asp:Label></td>
            </tr>
           
            <tr>
                <td>职位</td>
                <td><asp:Label ID="lblPosition" runat="server" Text="Label"></asp:Label></td>
                <td>政治面貌</td>
                <td><asp:Label id="lblPolitics" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>婚姻</td>
                <td><asp:Label ID="lblMarrage" runat="server" Text="Label"></asp:Label></td>
                <td>所在部门</td>
                <td><asp:Label id="lblDepart" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td>常住地址</td>
                <td colspan="3"><asp:Label id="lblAddress" runat="server" Text="Label"></asp:Label></td>
                
            </tr>
            <tr>
                <td>参加工作时间</td>
                <td><asp:Label ID="lblJobtime" runat="server" Text="Label"></asp:Label></td>
                <td>加入公司时间</td>
                <td><asp:Label id="lblJointime" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
        </div>
        
        
    </form>
</body>
</html>
