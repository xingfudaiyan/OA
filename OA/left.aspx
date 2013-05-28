<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="left.aspx.cs" Inherits="OA.left" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
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
.STYLE3 {
	font-size: 12px;
	color: #033d61;
}
-->
</style>
<style type="text/css">
.menu_title SPAN {
	FONT-WEIGHT: bold; LEFT: 3px; COLOR: #ffffff; POSITION: relative; TOP: 2px 
}
.menu_title2 SPAN {
	FONT-WEIGHT: bold; LEFT: 3px; COLOR: #FFCC00; POSITION: relative; TOP: 2px
}

</style>
<!-- 
<script>
    var he=document.body.clientHeight-105;
    document.write("<div id=tt style=height:"+he+";overflow:hidden>");
</script> 
-->

</head>
<body>
  <table width="165" height="100%" border="0" cellpadding="0" cellspacing="0">
  <tbody>
     <tr>
        <td height="28" background="images/main_40.gif">
            <table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td width="19%">&nbsp;</td>
                <td width="81%" height="20"><span class="STYLE1">管理菜单</span></td>
              </tr>
            </table>
        </td>
      </tr>
  <tr>
        <td valign="top"><table width="151" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td>
                <table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td height="23" background="images/main_47.gif" id="imgmenu1" class="menu_title" onMouseOver="this.className='menu_title2';" onClick="showsubmenu(1)" onMouseOut="this.className='menu_title';" style="cursor:hand"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="18%">&nbsp;</td>
                        <td width="82%" class="STYLE1">文档管理</td>
                      </tr>
                 </table>
               </td>
              </tr>
              <tr>
                <td background="images/main_51.gif" id="submenu1" style="DISPLAY: none">
			     <div class="sec_menu" >  
			    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                  <tr>
                    <td><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                      <tr>
                        <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                        <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ShareManage/Send.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">发送文件</span></a></td>
                            </tr>
                        </table></td>
                      </tr>
                      <tr>
                        <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                        <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ShareManage/RecvFile.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">接收文件</span></a></td>
                            </tr>
                        </table></td>
                      </tr>
                     
                      <tr>
                        <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                        <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ShareManage/Upload.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">上传文档</span></a></td>
                            </tr>
                        </table></td>
                      </tr>
                      <tr>
                        <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                        <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                            <tr>
                              <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ShareManage/DownloadDocument.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">下载文档</span></a></td>
                            </tr>
                        </table></td>
                      </tr>
                    </table></td>
                  </tr>
                  <tr>
                    <td height="5"><img src="images/main_52.gif" width="151" height="5" /></td>
                  </tr>
                </table></div></td>
              </tr>
              
            </table></td>
          </tr>
          
          
            <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="23" background="images/main_47.gif" id="imgmenu2" class="menu_title" onmouseover="this.className='menu_title2';" onclick="showsubmenu(2)" onmouseout="this.className='menu_title';" style="cursor:hand"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="18%">&nbsp;</td>
                      <td width="82%" class="STYLE1">日程安排</td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td background="images/main_51.gif" id="submenu2" style="DISPLAY: none"><div class="sec_menu" >
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ContactManage/Contact.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">通讯录</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                        </table></td>
                      </tr>
                      <tr>
                        <td height="5"><img src="images/main_52.gif" width="151" height="5" /></td>
                      </tr>
                    </table>
                </div></td>
              </tr>
            </table></td>
            
          </tr>
          
          
          
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="23" background="images/main_47.gif" id="imgmenu3" class="menu_title" onmouseover="this.className='menu_title2';" onclick="showsubmenu(3)" onmouseout="this.className='menu_title';" style="cursor:hand"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="18%">&nbsp;</td>
                      <td width="82%" class="STYLE1">行政管理</td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td background="images/main_51.gif" id="submenu3" style="DISPLAY: none"><div class="sec_menu" >
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="AffairManage/Employee.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">人力资源管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="AffairManage/Asset.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">固定资产管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                          
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="Notice/NoticeManage.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">公告管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                        </table></td>
                      </tr>
                      <tr>
                        <td height="5"><img src="images/main_52.gif" width="151" height="5" /></td>
                      </tr>
                    </table>
                </div></td>
              </tr>
            </table>          </td>
          </tr>
          
          
            <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="23" background="images/main_47.gif" id="imgmenu4" class="menu_title" onmouseover="this.className='menu_title2';" onclick="showsubmenu(4)" onmouseout="this.className='menu_title';" style="cursor:hand"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="18%">&nbsp;</td>
                      <td width="82%" class="STYLE1">市场管理</td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td background="images/main_51.gif" id="submenu4" style="DISPLAY: none"><div class="sec_menu" >
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                             <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ClientManage/Client.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">客户管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="Supply/SupplyManage.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">供应商管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                            <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ClientManage/ContractIndex.aspx"target="I2" style=" text-decoration:none;"><span class="STYLE3">合同管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ClientManage/Project.aspx"target="I2" style=" text-decoration:none;"><span class="STYLE3">项目管理</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                        </table></td>
                      </tr>
                      <tr>
                        <td height="5"><img src="images/main_52.gif" width="151" height="5" /></td>
                      </tr>
                    </table>
                </div></td>
              </tr>
            </table>          </td>
          </tr>
          
          
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="23" background="images/main_47.gif" id="imgmenu5" class="menu_title" onmouseover="this.className='menu_title2';" onclick="showsubmenu(5)" onmouseout="this.className='menu_title';" style="cursor:hand"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="18%">&nbsp;</td>
                      <td width="82%" class="STYLE1">系统管理</td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td background="images/main_51.gif" id="submenu5" style="DISPLAY: none"><div class="sec_menu" >
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                            <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="SysManage/MasterIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">编辑用户</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                          
                            
                             <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="Message/MsgGv.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">消息提醒</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>  
                        </table></td>
                      </tr>
                      <tr>
                        <td height="5"><img src="images/main_52.gif" width="151" height="5" /></td>
                      </tr>
                    </table>
                </div></td>
              </tr>
            </table></td>
            
          </tr>
          
        
          
          <tr>
            <td><table width="100%" border="0" cellspacing="0" cellpadding="0">
              <tr>
                <td height="23" background="images/main_47.gif" id="imgmenu6" class="menu_title" onmouseover="this.className='menu_title2';" onclick="showsubmenu(6)" onmouseout="this.className='menu_title';" style="cursor:hand"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                    <tr>
                      <td width="18%">&nbsp;</td>
                      <td width="82%" class="STYLE1">审批管理</td>
                    </tr>
                </table></td>
              </tr>
              <tr>
                <td background="images/main_51.gif" id="submenu6"><div class="sec_menu" >
                    <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td><table width="90%" border="0" align="center" cellpadding="0" cellspacing="0">
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="OutRegist/OutRegistIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">外出审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="StampApply/StampApplyIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">用章申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                              <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="StampApply/StampApproveIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">用章审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                              <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="StampApply/StampList.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">用章记录</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                               <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="Holiday/HolidayApplyIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">请假申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                            
                             <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="Holiday/HolidayApproveIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">请假审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="Holiday/HolidayList.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">请假记录</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                                <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="OfficeApply/OfficeApplyIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">借款申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                                <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="OfficeApply/OfficeApproveIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">借款审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="OfficeApply/List.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">借款记录</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ToolApply/ToolApplyIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">用品申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ToolApply/ToolApproveIndex.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">用品审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td width="16%" height="25"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td width="84%" height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ToolApply/ToolList.aspx" target="I2" style="text-decoration:none;"><span class="STYLE3">用品记录</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ProjectCreate/ProjectApplyIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">立项申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ProjectCreate/ProjectApproveIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">立项审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                           
                            <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="OfferPrice/PriceIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">报价审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ContractApply/ContractApplyIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">合同申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                             <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="ContractApply/ContractApproveIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">合同审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>

                           
                            
                         
                            
                              <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="OverTime/OverTimeIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">加班申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                              <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="FileApply/FileApplyIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">文件申请</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                              <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="FileApply/FileApproveIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">文件审批</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                            
                                <tr>
                              <td height="23"><div align="center"><img src="images/left.gif" width="10" height="10" /></div></td>
                              <td height="23"><table width="95%" border="0" cellspacing="0" cellpadding="0">
                                  <tr>
                                    <td height="20" style="cursor:hand" onmouseover="this.style.borderStyle='solid';this.style.borderWidth='1';borderColor='#7bc4d3'; "onmouseout="this.style.borderStyle='none'"><a href="WeekScore/WeekScoreIndex.aspx" target="I2" style=" text-decoration:none;"><span class="STYLE3">技术部周报</span></a></td>
                                  </tr>
                              </table></td>
                            </tr>
                        </table></td>
                      </tr>
                      
                      <tr>
                        <td height="5"><img src="images/main_52.gif" width="151" height="5" /></td>
                      </tr>
                    </table>
                </div></td>
              </tr>
            </table>        
              </td>
          </tr>
          
          
        </table>
        </td>
  </tr>
  <tr>
    <td height="18" background="images/main_58.gif">
        <table width="100%" border="0" cellspacing="0" cellpadding="0">
          <tr>
            <td height="18" valign="bottom"><div align="center" class="STYLE3">版本：2011V1.0</div></td>
          </tr>
        </table>
    </td>
  </tr>
  </tbody>
     
</table>

<script>

function showsubmenu(sid)
{
whichEl = eval("submenu" + sid);
imgmenu = eval("imgmenu" + sid);
if (whichEl.style.display == "none")
{
eval("submenu" + sid + ".style.display=\"\";");
imgmenu.background="images/main_47.gif";
}
else
{
eval("submenu" + sid + ".style.display=\"none\";");
imgmenu.background="images/main_48.gif";
}
}

</script>
</body>
</html>
