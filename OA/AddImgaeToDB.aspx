<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddImgaeToDB.aspx.cs" Inherits="OA.AddImgaeToDB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="上传图片到数据库" OnClick="btnAdd_Click" /></div>
        <asp:Button ID="btnShow" runat="server" Text="显示图片" OnClick="btnShow_Click1" />
        
    </form>
</body>
</html>
