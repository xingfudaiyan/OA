<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerNotice.aspx.cs" Inherits="OA.Notice.PerNotice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <table  style="width:30%; margin-left:35%;">
            <tr>
                <td colspan="2">
                <h2 runat="server" id="hTitle"></h2>
                </td>
            </tr>
            <tr>
                <td colspan="2" style=" border-top:solid 1px Gray; height:10px;">
                </td>
            </tr>
            <tr>
                <td colspan="2">
                   <asp:Label ID="lblContent" runat="server"  ></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="border-bottom:solid 1px Gray; height:10px;">
                </td>
            </tr>
            <tr>
                <td style="width:80%;"></td>
                <td>
                     <span runat="server" id="sName"></span>
                </td>
            </tr>
            <tr>
                <td style="width:80%; height:10px;"></td>
                <td style="height:10px;"><span runat="server" id="sTime"></span></td>
            </tr>
        </table>


    </form>
</body>
</html>
