<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAsset.aspx.cs" Inherits="OA.AddAsset" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>添加固定资产</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblAssetName" runat="server" Text="品名"></asp:Label>
                    <span style="color:Red;">*</span>
                </td>
                <td>
                    <asp:TextBox ID="txtAssetName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="valName" runat="server" ErrorMessage="必填" ControlToValidate="txtAssetName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAmount" runat="server" Text="数量"></asp:Label>
                    <span style="color:Red;">*</span>
                </td>
                <td>
                    <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="必填" ControlToValidate="txtAmount"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUnit" runat="server" Text="计量单位"></asp:Label>
                    <span style="color:Red;">*</span>
                </td>
                <td>
                   <asp:DropDownList ID="ddlUnit" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td><asp:Label ID="lblDepart" runat="server" Text="使用部门"></asp:Label><span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlDepart" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblSite" runat="server" Text="存放地点"></asp:Label><span style="color:Red;">*</span></td>
                <td><asp:DropDownList ID="ddlSite" runat="server"></asp:DropDownList></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblPrice" runat="server" Text="价格"></asp:Label></td>
                <td> <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblType" runat="server" Text="规格"></asp:Label></td>
                <td> <asp:TextBox ID="txtType" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td><asp:Label ID="lblMemo" runat="server" Text="备注"></asp:Label></td>
                <td> <asp:TextBox ID="txtMemo" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
        </table>
        <asp:Button ID="btnAddAsset" runat="server" Text="新增"  OnClick="btnAddAsset_Click"></asp:Button>
        <asp:Button ID="btnBack" runat="server" Text="返回"  OnClick="btnBack_Click" ValidationGroup="btn1"></asp:Button>
       </div>
    </form>
</body>
</html>
