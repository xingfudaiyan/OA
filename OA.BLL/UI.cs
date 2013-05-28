using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Wuqi.Webdiyer;

namespace CanYou.OA.BLL
{
    public class UI
    {
        /// <summary>

        /// 全部数据用AspNetPager分页绑定，Repeater,GridView,DataList

        /// </summary>

        /// <param name="ie">实现IEnumerable的数据源</param>

        /// <param name="ctl_Listctl">列表控件</param>

        /// <param name="AspNetPager1"></param>

        public static void BindCtrl(IEnumerable ie, Control ctl_Listctl, AspNetPager AspNetPager1)
        {

            PagedDataSource PDS = new PagedDataSource();

            PDS.DataSource = ie;

            if (ie is DataTable)

                AspNetPager1.RecordCount = ((DataTable)ie).Rows.Count;

            if (ie is IList)

                AspNetPager1.RecordCount = ((IList)ie).Count;

            int cPageIndex = AspNetPager1.CurrentPageIndex;

            if (cPageIndex > 1)

                PDS.CurrentPageIndex = cPageIndex - 1;

            PDS.AllowPaging = true;

            PDS.PageSize = AspNetPager1.PageSize;

            if (ctl_Listctl is Repeater)
            {

                ((Repeater)ctl_Listctl).DataSource = PDS;

                ((Repeater)ctl_Listctl).DataBind();

            }

            if (ctl_Listctl is DataList)
            {

                ((DataList)ctl_Listctl).DataSource = PDS;

                ((DataList)ctl_Listctl).DataBind();

            }

            if (ctl_Listctl is GridView)
            {

                ((GridView)ctl_Listctl).DataSource = PDS;

                ((GridView)ctl_Listctl).DataBind();

            }

        }


    }
}
