using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// GetRedirect 的摘要说明
/// </summary>
public class GetRedirect
{
    public GetRedirect()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }

    public const string TIMERWINALERT = "<script>AjaxCallHelper.WriteAlert('{0}');</script>";

    public const string WINALERT = "<script>alert('{0}');</script>";
    public const string REDIRECT = "<script>document.location.href='{0}';</script>";
    public const string ALLREDIRECT = "<script>parent.document.location.href='{0}';</script>";
}
