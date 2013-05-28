<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tab.aspx.cs" Inherits="OA.tab.tab" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        a:link { color: green; }
        a:visited { color: green; }
        a:hover { color: blue; }
    </style>
</head>
<body  runat="server" style="filter:progid:dximagetransform.microsoft.alphaimageloader(src='../images/bk.gif',sizingmethod='scale'); margin-left:0; margin-right:0; margin-bottom:0; margin-top:0; height:900px;"  >
    <form id="form1" runat="server" >
        <table style="position:relative; background-image:url(../images/test1.png); overflow:hidden; width:1000px; margin:auto auto;  height:500px; margin-top:100px; background-repeat:no-repeat; background-position:center; color:Gray;" >
          <tr>
            <td colspan="6" style="height:20px;"></td>
          </tr>
          <tr>
            <td style="width:21%; height:200px; vertical-align:top; ">   
                <ul id="uApply" runat="server" style="list-style-image:url(../images/l1.png); line-height:25px;">
                </ul>
            </td>
            <td style="width:12%; vertical-align:top;">
                <ul id="uTime1" runat="server" style="line-height:27px; list-style:none; padding-left:1px;">
                </ul>
            </td>
            <td  style="width:21%;vertical-align:top; ">
                 <ul id="uFile" runat="server" style="list-style-image:url(../images/l1.png); line-height:25px;">
                </ul>
            </td>
             <td style="width:12%;vertical-align:top;">
                <ul id="uTime2" runat="server" style="line-height:27px; list-style:none;padding-left:1px;">
                </ul>
             </td>
            <td  style="width:21%;vertical-align:top;">
               <ul id="uMine" runat="server" style="list-style-image:url(../images/l1.png); line-height:25px;">
                </ul>
            </td>
             <td style="width:12%;vertical-align:top;">
                  <ul id="uTime3" runat="server" style="line-height:27px; list-style:none;padding-left:1px;">
                  </ul>
             </td>
          </tr>
           <tr>
            <td colspan="6" style="height:40px;"></td>
          </tr>
          <tr>
            <td style="height:200px;vertical-align:top;">
                <ul id="uNews" runat="server" style=" line-height:25px; padding-left:130px;">
                </ul>
            </td>
             <td style="vertical-align:top;">
              <ul id="uTime4" runat="server" style="line-height:27px; list-style:none;padding-left:15px;">
                  </ul>
             </td>
            <td style="vertical-align:top;">
                 <ul id="uNotice" runat="server" style="list-style-image:url(../images/notice.png); line-height:25px;">
                </ul>
            </td>
             <td style="vertical-align:top;">
                  <ul id="uTime5" runat="server" style="line-height:27px; list-style:none;padding-left:1px;">
                  </ul>
             </td>
            <td style="vertical-align:top;">
                <ul id="uDay" runat="server" style="list-style-image:url(../images/day.png); line-height:25px;padding-left:45px;">
                </ul>
            </td>
             <td style="vertical-align:top;">
                <ul id="uTime6" runat="server" style="line-height:27px; list-style:none;padding-left:1px;">
                </ul>
             </td>
          </tr>
        </table>
    </form>
</body>
</html>
