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
    public partial class ManagerHelp : System.Web.UI.Page
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
            DataSet ds = BasEmScoreInfo.getBasM();
            DataSet ds1 = BasEmScoreInfo.getFrontM();
            DataSet ds2 = BasEmScoreInfo.getAssisM();
            ds.Merge(ds1);
            ds.Merge(ds2);

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

        protected void btnApprove_Click(object sender, EventArgs e)
        {
            Response.Redirect("MarketScoregv.aspx");
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

              // if (!Convert.IsDBNull(gvScore.DataKeys[e.Row.RowIndex].Value))
                //{
                    LinkButton lbtName = e.Row.FindControl("lbtnEmployeeName") as LinkButton;
                    Button btnSubmit = e.Row.FindControl("btnSubmit") as Button;
                    if (lbtName.Text == "王娇")
                    {
                        int basid = Convert.ToInt32(gvScore.DataKeys[e.Row.RowIndex]["BasEmScoreId"].ToString());
                        BasEmScoreInfo bas = new BasEmScoreInfo(basid);
                        if (bas.IsSubmit == 2)
                        {
                            btnSubmit.Enabled = false;
                        }
                    }
                    else if (lbtName.Text == "马琪")
                    {
                        int fid = Convert.ToInt32(gvScore.DataKeys[e.Row.RowIndex]["FrontScoreId"].ToString());
                        FrontScoreInfo front = new FrontScoreInfo(fid);
                        if (front.IsSubmit == 2)
                        {
                            btnSubmit.Enabled = false;
                        }
                       
                    }

                    else if (lbtName.Text == "白杨")
                    {
                        int aid = Convert.ToInt32(gvScore.DataKeys[e.Row.RowIndex]["AssistantScoreId"].ToString());
                        AssistantScoreInfo ass = new AssistantScoreInfo(aid);
                        if (ass.IsSubmit == 2)
                        {
                            btnSubmit.Enabled = false;
                        }
                    }
               // }
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

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void lbtnEmployeeName_Click(object sender, EventArgs e)
        {
            //int sid = Convert.ToInt32(((LinkButton)sender).CommandArgument.ToString());
            string[] str = ((LinkButton)sender).CommandArgument.Split(',');
            if (str[0] != "")
            {
                Response.Redirect("BasEmScoreDetail.aspx?BasEmScoreId="+str[0]);
            }
            else if (str[1] != "")
            {
                Response.Redirect("FrontScoreDetail.aspx?FrontScoreId=" + str[1]);
            }
            else if (str[2] != "")
            {
                Response.Redirect("AsistantScoreDetail.aspx?AssistantScoreId=" + str[2]);
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string[] str = ((Button)sender).CommandArgument.Split(',');
            if (str[0] != "")
            {
                Response.Redirect("BasEmApprove.aspx?BasEmScoreId=" + str[0]);
            }
            else if (str[1] != "")
            {
                Response.Redirect("FrontScoreApprove.aspx?FrontScoreId=" + str[1]);
            }
            else if (str[2] != "")
            {
                Response.Redirect("AsistantScoreApprove.aspx?AssistantScoreId=" + str[2]);
            }
        }
    }
}
