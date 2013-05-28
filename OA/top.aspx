<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="top.aspx.cs" Inherits="OA.top" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<title>无标题文档</title>
<style type="text/css">
<!--
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
.STYLE1 {
	font-size: 12px;
	color: #FFFFFF;
}
.STYLE2 {font-size: 9px}
.STYLE3 {
	color: #033d61;
	font-size: 12px;
}
-->
</style></head>

<body>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td height="70" background="images/main_05.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td height="24"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="270" height="24" background="images/main_03.gif">&nbsp;</td>
            <td width="505" background="images/main_04.gif">&nbsp;</td>
            <td>&nbsp;</td>
            <td width="21"><img src="images/main_07.gif" width="21" height="24"></td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td height="38"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="270" height="38" background="images/main_09.gif">&nbsp;</td>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="77%" height="25" valign="bottom"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td width="50" height="19"><div align="center"><a href="tab.aspx" target="I2"><img src="images/main_12.gif" width="49" height="19" border="0"></a></div></td>
                    <td width="50"><div align="center"><input type="button" onclick="history.go(-1)" style="background-image:url(images/main_14.gif); width:45px; height:19px; border:0" /></div></td>
                    <td width="50"><div align="center"><a target="_top"><input type="button" onclick="history.go(1)" style="background-image:url(images/main_16.gif); width:45px; height:19px; border:0" /></a></div></td>
                    <td width="50"><div align="center"><input type="button" onclick="window.parent.frames[1][2].location.reload()" style="background-image:url(images/main_18.gif); width:45px; height:19px; border:0" /> </div></td>
                    <td width="50"><div align="center"><a href="Index_top/LoginOut.aspx" target="_top"><img src="images/main_20.gif" width="48" height="19" border="0"></a></div></td>
                    <td width="26"><div align="center"><img src="images/main_21.gif" width="26" height="19"></div></td>
                    <td width="100"><div align="center"><a href="SysManage/ChangePsd.aspx" target="I2"><img src="images/main_22.gif" width="98" height="19" border="0"></a></div></td>
                    <td width="50"><div align="center"><a href="OpenFile.aspx" target="I2"><img src="images/help.gif" width="48" height="19" border="0"></a></div></td>
                    <td>&nbsp;</td>
                  </tr>
                </table></td>
                <td width="220" valign="bottom"  nowrap="nowrap"><div align="right"><span class="STYLE1"><span class="STYLE2">■</span> 今天是：<asp:Label ID="lblDate" runat="server" Text="日期"></asp:Label></span></div></td>
              </tr>
            </table></td>
            <td width="21"><img src="images/main_11.gif" width="21" height="38"></td>
          </tr>
        </table></td>
      </tr>
      <tr>
        <td height="8" style=" line-height:8px;"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="270" background="images/main_29.gif" style=" line-height:8px;">&nbsp;</td>
            <td width="505" background="images/main_30.gif" style=" line-height:8px;">&nbsp;</td>
            <td style=" line-height:8px;">&nbsp;</td>
            <td width="21" style=" line-height:8px;"><img src="images/main_31.gif" width="21" height="8"></td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="28" background="images/main_36.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="177" height="28" background="images/main_32.gif"><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="18%"  height="22">&nbsp;</td>
            <td width="77%" valign="bottom"><div align="left" class="STYLE1">当前用户：<asp:Label ID="lblMaster" runat="server" Text=""></asp:Label></div></td>
            <td width="5%">&nbsp;</td>
          </tr>
        </table></td>
        <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td width="1%;" height="28">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="23" valign="bottom"><table width="58" border="0" align="center" cellpadding="0" cellspacing="0">
                  <tr> 
                    <td height="20" style="cursor:hand" onMouseOver="this.style.backgroundImage='url(images/bg.gif)';this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#a6d0e7'; "onmouseout="this.style.backgroundImage='url()';this.style.borderStyle='none'"> <div align="center" class="STYLE3"></div></td>
                  </tr>
                </table>
                </td>
              </tr>
            </table>
            </td>
            <td style="width:10%;"><span>君众公告：</span></td>
            <td style="width:89%;">
                   <marquee direction="up" scrollamount="1" scrolldelay="1" behavior="scroll" onmousemove="stop()" onmouseout="start()" height="20px" >
                      <a href="Notice/PerNotice.aspx?NoticeId=<%= getNoticeId() %>" target="I2" id="hb" name="hs"  style="text-decoration:none;"><asp:Label ID="lblNotice"  runat="server"></asp:Label></a>
                   </marquee>
            </td>
          </tr>
        </table></td>
        <td width="21"><img src="images/main_37.gif" width="21" height="28"></td>
      </tr>
    </table></td>
  </tr>
</table>
</body>
</html>
