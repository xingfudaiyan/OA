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
using System.IO;
using CanYouLib.ExcelLib;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace OA
{
    public partial class Asset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["SortExpression"] = "DepartName";
                ViewState["SortDir"] = "ASC";
                IsRole();
                gvDataBind();
            }
        }

        protected void gvDataBind()
        {
            DataTable dt = AssetInfo.getAssetListVW();
           
            DataView view = dt.DefaultView;
            string sort = (string)ViewState["SortExpression"] + " " + (string)ViewState["SortDir"];
            view.Sort = sort;
           
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(dt.NewRow());
                UI.BindCtrl(dt.DefaultView, gvAsset, AspNetPager1);
                gvAsset.Rows[0].Visible = false;
            }
            else
            {
                UI.BindCtrl(dt.DefaultView, gvAsset, AspNetPager1);
            }
           
        }


        protected void IsRole()
        {
            string strDepartName = Session["DepartName"].ToString();

            string strRoleName = Session["RoleName"].ToString();
            if ((strRoleName == "总经理") || (strRoleName == "部门经理" && strDepartName=="综合部"))
            {
                btnAdd.Visible = true;
            }
            else
            {
                btnAdd.Visible = false;
            }

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAsset.aspx");
        }

   
        protected void gvAsset_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int assetid=Convert.ToInt32(gvAsset.DataKeys[e.RowIndex].Value);
            AssetInfo.DelAsset(assetid);
            gvDataBind();
        }

        protected void gvAsset_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int Assetid = Convert.ToInt32(gvAsset.DataKeys[e.RowIndex].Value);
            TextBox txtAssetName = gvAsset.Rows[e.RowIndex].FindControl("txtAssetName") as TextBox;
            TextBox txtAmount = gvAsset.Rows[e.RowIndex].FindControl("txtAmount") as TextBox;
            TextBox txtPrice = gvAsset.Rows[e.RowIndex].FindControl("txtPrice") as TextBox;
            TextBox txtType = gvAsset.Rows[e.RowIndex].FindControl("txtType") as TextBox;
            TextBox txtMemo = gvAsset.Rows[e.RowIndex].FindControl("txtMemo") as TextBox;
            DropDownList ddlUnit = gvAsset.Rows[e.RowIndex].FindControl("ddlUnit") as DropDownList;
            DropDownList ddlDepart = gvAsset.Rows[e.RowIndex].FindControl("ddlDepart") as DropDownList;
            DropDownList ddlSite = gvAsset.Rows[e.RowIndex].FindControl("ddlSite") as DropDownList;
            try
            {
                AssetInfo asset = new AssetInfo(Assetid);
                asset.AssetName = txtAssetName.Text.ToString();
                asset.Amount = txtAmount.Text.ToString();
                asset.Price = txtPrice.Text.ToString();
                asset.Type = txtType.Text.ToString();
                asset.Memo = txtMemo.Text.ToString();
                asset.UnitName = ddlUnit.SelectedItem.Text.ToString();
                asset.DepartName = ddlDepart.SelectedItem.Text.ToString();
                asset.SiteName = ddlSite.SelectedItem.Text.ToString();
                asset.Save();

                gvAsset.EditIndex = -1;
                gvDataBind();
            }
            catch(Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('更新失败：" + Ex.Message + "');", true); 
            }
        }

        protected void gvAsset_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvAsset.EditIndex = -1;
            gvDataBind();
        }

        protected void gvAsset_RowDataBound(object sender, GridViewRowEventArgs e)
        {
           
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

                string strRoleName = Session["RoleName"].ToString();
                string strDepartName = Session["DepartName"].ToString();

                if ((strRoleName == "总经理") || (strRoleName == "部门经理" && strDepartName == "综合部"))
                {
                    e.Row.Cells[9].Visible = true;
                    e.Row.Cells[10].Visible = true;
                    gvAsset.Columns[9].Visible = true;
                    gvAsset.Columns[10].Visible = true;

                }
                else
                {
                    e.Row.Cells[9].Visible = false;
                    e.Row.Cells[10].Visible = false;
                    gvAsset.Columns[9].Visible = false;
                    gvAsset.Columns[10].Visible = false;

                }
            }


            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                //鼠标移动到每项时颜色交替效果   
                e.Row.Attributes.Add("onmouseover", "e=this.style.backgroundColor; this.style.backgroundColor='#c1ebff'");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor=e");

                //设置悬浮鼠标指针形状为"小手"   
                e.Row.Attributes["style"] = "Cursor:hand";
            }
        }

        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            gvDataBind();
        }

        protected void gvAsset_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvAsset.EditIndex = e.NewEditIndex;
            gvDataBind();
        }

        void Export(bool p_IsTemplate)
        {
            try
            {
                DataTable dt = AssetInfo.getExAssetList();
              
                DataTable dtTemp = dt.Copy();


                if (dt.Rows.Count > 0)
                {

                    //获取路径
                    string strPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 1);
                    strPath = strPath.Replace("/", "\\");
                    DateTime time1 = DateTime.Now;
                    string temlpate = strPath + "\\template\\机器性能数据.xls";
                    strPath = strPath + "\\excel";
                    List<ExcelColumInfo> ExcelColumns = new List<ExcelColumInfo>();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        ExcelColumInfo colinfo = new ExcelColumInfo();
                        colinfo.HeadName = dc.ColumnName;
                        colinfo.TableColumnName = dc.ColumnName;
                        colinfo.Width = 20;
                        colinfo.DataType = DataType.Text;
                        if (dc.ColumnName == "MCDate" || dc.ColumnName == "WriteDate")
                            colinfo.DataType = DataType.DateTime;//ShareddedRate
                        else if (dc.ColumnName == "Processes" || dc.ColumnName == "Reject" || dc.ColumnName == "RejectRate" || dc.ColumnName == "Sharedded" || dc.ColumnName == "ShareddedRate" || dc.ColumnName == "RejShareddedRateect" || dc.ColumnName == "RunHour")
                            colinfo.DataType = DataType.Number;
                        ExcelColumns.Add(colinfo);
                    }

                    ExcelHelp eh = new ExcelHelp();
                    byte[] byteResult;
                    //导出数据到byte字节数组
                    if (!p_IsTemplate)
                        byteResult = eh.ExportData(dt, ExcelColumns, "办公用品数据", strPath, 5000);
                    else
                        byteResult = eh.ExportData(dt, ExcelColumns, "办公用品数据", strPath, 5000, temlpate);


                    DateTime time2 = DateTime.Now;
                    TimeSpan ts1 = new TimeSpan(time1.Ticks);
                    TimeSpan ts2 = new TimeSpan(time2.Ticks);
                    TimeSpan ts = ts1.Subtract(ts2).Duration();
                    string dateDiff = "导出1个数据表，共" + dt.Rows.Count.ToString() + "条记录，耗时" + ts.Days.ToString() + "天"
                    + ts.Hours.ToString() + "小时"
                    + ts.Minutes.ToString() + "分钟"
                    + ts.Seconds.ToString() + "秒";
                    //lblOledb.Text = dateDiff;
                    //客户端下载文件
                    Response.Clear();
                    //Response.Buffer = true;
                    Response.Charset = "GB2312";
                    Response.ContentEncoding = System.Text.Encoding.UTF8;
                    //  添加头信息，为"文件下载/另存为"对话框指定默认文件名  
                    Response.AddHeader("Content-Disposition", "attachment; filename = " + Server.UrlEncode("办公用品数据.xls"));
                    //  添加头信息，指定文件大小，让浏览器能够显示下载进度  
                    Response.AddHeader("Content-Length", byteResult.Length.ToString());
                    //  指定返回的是一个不能被客户端读取的流，必须被下载  
                    Response.ContentType = "application/ms-excel";
                    //  把文件流发送到客户端  
                    //Response.WriteFile(file.FullName);
                    Response.BinaryWrite(byteResult);
                    Response.Flush();
                    //  停止页面的执行
                    //GC.Collect();
                    //Response.End();
                    HttpContext.Current.ApplicationInstance.CompleteRequest();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "", "<script language='javascript'>alert('数据为空导出失败！');</script>");
                }
            }
            catch (Exception Ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Save", "alert('导出数据失败：" + Ex.Message + "');", true); 
                
            }
        }


        protected void btnOutExecel_Click(object sender, EventArgs e)
        {
            Export(false);
        }

        protected void btnInExecel_Click(object sender, EventArgs e)
        {
            if (myFile.PostedFile.FileName != "")
            {
                //上传文件的绝对路径
                string sFile = myFile.PostedFile.FileName;
                //获取文件全名
                sFile = sFile.Substring(sFile.LastIndexOf("\\") + 1);
                //获取后缀名
                sFile = sFile.Substring(sFile.LastIndexOf("."));
                if (sFile.ToLower() != ".xls")
                {
                    Page.RegisterStartupScript("", "<script>alert('文件格式不正确')</script>");
                }
                //为了防止重名，获得日期为文件名年月日时分秒毫秒
                string datatime = System.DateTime.Now.ToString("yyyMMddHHmmssffff");
                //上传后文件的新名
                sFile = datatime + sFile;
                //AppDomain.CurrentDomain.BaseDirectory.ToString() 获取此项目的根目录
                //sPath 获取上传后的路径
                string sPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "ExcelFiles\\" + sFile;
                //上传文件
                myFile.PostedFile.SaveAs(sPath);

                string connStr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sPath + ";Extended Properties=Excel 8.0;";
                OleDbConnection conn = new OleDbConnection(connStr);
                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();
                }
                OleDbDataAdapter oda = new OleDbDataAdapter("select * from [Sheet1$]", conn);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                conn.Close();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string strAssetName = ds.Tables[0].Rows[i][0].ToString();
                    string strAmount = ds.Tables[0].Rows[i][1].ToString();
                    string strUnitName = ds.Tables[0].Rows[i][2].ToString();
                    string strDepartName = ds.Tables[0].Rows[i][3].ToString();
                    string strSiteName = ds.Tables[0].Rows[i][4].ToString();
                    string strPrice = ds.Tables[0].Rows[i][5].ToString();
                    string strType = ds.Tables[0].Rows[i][6].ToString();
                    string strMemo = ds.Tables[0].Rows[i][7].ToString();
                    try
                    {
                        AssetInfo asset = new AssetInfo();
                        asset.AssetName = strAssetName.ToString();
                        asset.Amount = strAmount.ToString();
                        asset.UnitName = strUnitName.ToString();
                        asset.DepartName = strDepartName.ToString();
                        asset.SiteName = strSiteName.ToString();
                        asset.Price = strPrice.ToString();
                        asset.Type = strType.ToString();
                        asset.Memo = strMemo.ToString();
                        asset.Save();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("插入失败!由于：" + ex.Message);
                    }
                }
                Response.Write("<SCRIPT>alert('数据已成功导入到数据库！');</SCRIPT>");
                gvDataBind();
                File.Delete(sPath);
            }
            else
            {
                Response.Write("<SCRIPT>alert('请选择Excel文件！');</SCRIPT>");
            }
           
        }

        protected void gvAsset_Sorting(object sender, GridViewSortEventArgs e)
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
