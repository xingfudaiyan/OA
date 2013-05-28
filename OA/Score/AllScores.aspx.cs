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
using CanYou.OA.BLL;

namespace OA.Score
{
    public partial class AllScores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "DateSpan";
                ViewState["SortDir"] = "ASC";
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            DataSet ds = BasEmScoreInfo.getBasM();//市场助理
            DataSet ds1 = BasEmScoreInfo.getFrontM();//前台
            DataSet ds2 = BasEmScoreInfo.getAssisM();//行政助理
            DataSet ds3 = BasEmScoreInfo.getNurseds();//后勤
            DataSet ds4 = BasEmScoreInfo.getDriveds();//司机
            DataSet ds5 = TechMaScoreInfo.getMarketds();//市场部经理
            DataSet ds6 = TechMaScoreInfo.getTechds();//技术部经理
            DataSet ds7 = TechMaScoreInfo.getTechEmds();//技术部员工


            ds.Merge(ds1);
            ds.Merge(ds2);
            ds.Merge(ds3);
            ds.Merge(ds4);
            ds.Merge(ds5);
            ds.Merge(ds6);
            ds.Merge(ds7);

            DataView view = ds.Tables[0].DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;

            DataTable dt = ds.Tables[0];
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvScore, AspNetPager1);
                gvScore.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvScore, AspNetPager1);
            }
        }

        protected void btnMyScore_Click(object sender, EventArgs e)
        {
            Response.Redirect("AsistantScoregv.aspx");
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

      

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] str = ((Button)sender).CommandArgument.Split(',');
            if (str[0] != "")
            {
                Response.Redirect("BasEmScoreDetail.aspx?BasEmScoreId=" + str[0]);
            }
            else if (str[1] != "")
            {
                Response.Redirect("FrontScoreDetail.aspx?FrontScoreId=" + str[1]);
            }
            else if (str[2] != "")
            {
                Response.Redirect("AsistantScoreDetail.aspx?AssistantScoreId=" + str[2]);
            }
            else if (str[3] != "")
            {
                Response.Redirect("TechEmScoreDetail.aspx?TechEmScoreId=" + str[3]);
            }
            else if (str[4] != "")
            {
                Response.Redirect("TechMaScoreDetail.aspx?TechMaScoreId=" + str[4]);
            }
            else if (str[5] != "")
            {
                Response.Redirect("DriveScoreDetail.aspx?DriveScoreId=" + str[5]);
            }
            else if (str[6] != "")
            {
                Response.Redirect("NurseScoreDetail?NurseScoreId=" + str[6]);
            }
            else if (str[7] != "")
            {
                Response.Redirect("MarketScoreDetail?MarketScoreId=" + str[7]);
            }
        }

        protected void gvScore_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");
                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";
            }
        }

        protected void gvScore_Sorting(object sender, GridViewSortEventArgs e)
        {
            //首先判断当前的排序表达式（字段），是否为当前当前的表达式。。。
            if (ViewState["SortExpression"].ToString() == e.SortExpression.ToString())
            {
                //判断当前的排序方式是否为倒序（DESC），如果是则将排序方式设为升序（ASC），原因是：因为我们要做双向排序！
                if (ViewState["SortDir"].ToString() == "DESC")
                {
                    ViewState["SortDir"] = "ASC";
                }
                else
                {
                    ViewState["SortDir"] = "DESC";
                }
            }
            else
            {
                ViewState["SortExpression"] = e.SortExpression; //将触发到表达式赋值给ViewState["SortExpression"];
            }
            gvDataBind();
        }
    }
}
