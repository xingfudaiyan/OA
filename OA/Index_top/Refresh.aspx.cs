using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace OA.Index_top
{
    public partial class Refresh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         Response.Write( "<script language=javascript>window.location.href=document.URL;</script>" );
        }
    }
}
