using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;


namespace CanYou.OA.BLL
{
    public partial class OfferPriceInfo
    {

        public static DataTable getOfferPriceType()
        {
            Query q = OfferPriceType.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getProductTypeList(int OfferPriceId)
        {
            Query q = ProductType.Query();
            q.AddWhere(ProductType.Columns.OfferPriceId, OfferPriceId);
            return q.ExecuteDataSet().Tables[0];
        }

        

        public static void DelProductTypeList(int OfferPriceId)
        {
            Query q = ProductType.Query();
            q.AddWhere(ProductType.Columns.OfferPriceId, OfferPriceId);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }

        public static void DelOfferPrice(int OfferPriceId)
        {
            Query q = OfferPrice.Query();
            q.AddWhere(OfferPrice.Columns.OfferPriceId, OfferPriceId);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }

        public static void DelProductType(int productTypeId)
        {
            ProductType.Delete(productTypeId);

        }

        public static bool IsOfferFileSame(string FileName)
        {
            DataTable dt = SPs.OfferFileSame_Sp(FileName).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //产品总报价
        public static string GetProductMoneySum(int OfferPriceId)
        {
            DataTable dt = SPs.OfferPriceMoneySun_Sp(OfferPriceId).GetDataSet().Tables[0];
            return dt.Rows[0]["MoneySum"].ToString();
        }

        //市场部员工绑定 主gvSale
        public static DataTable getPreOfferPriceListOfEmployee(int emid)
        {
            return SPs.OfferPriceListOfPreEmployee_Sp(emid).GetDataSet().Tables[0];
        }

        //市场部员工绑定 子GridView2
        public static DataTable getPreOfferPriceListOfEmployee2(int emid, int MainOfferPriceId)
        {
            return SPs.OfferPriceListOfPreEmployee2_Sp(emid, MainOfferPriceId).GetDataSet().Tables[0];
        }

        //市场部经理绑定 主gvSale
        public static DataTable getOfferPriceListOfEmployee(int emid)
        {
            return SPs.OfferPriceListOfEmployee_Sp(emid).GetDataSet().Tables[0];
        }

        //市场部经理绑定 子gvSale
        public static DataTable getOfferPriceListOfEmployee2(int emid, int mainid)
        {
            return SPs.OfferPriceListOfEmployee2_Sp(emid, mainid).GetDataSet().Tables[0];
        }

        //审批 市场部经理绑定 主gvSale
        public static DataTable getOfferPriceListOfApprove(int RecvEmployeeId)
        {
            return SPs.OfferPriceListOfApprove_Sp(RecvEmployeeId).GetDataSet().Tables[0];
        }

        //审批 市场部经理绑定 子gvSale
        public static DataTable getOfferPriceListOfApproves(int RecvEmployeeId, int mainid)
        {
            return SPs.OfferPriceListOfApproves_Sp(RecvEmployeeId, mainid).GetDataSet().Tables[0];
        }

        //财务部经理绑定 主gvSale
        public static DataTable getOfferPriceListOfApprove1(int Recv1EmployeeId)
        {
            return SPs.OfferPriceListOfApprove1_Sp(Recv1EmployeeId).GetDataSet().Tables[0];
        }

        //财务部经理绑定 子gvSale
        public static DataTable getOfferPriceListOfApproves1(int Recv1EmployeeId, int mainid)
        {
            return SPs.OfferPriceListOfApproves1_Sp(Recv1EmployeeId, mainid).GetDataSet().Tables[0];
        }

        //总经理绑定 主gvSale
        public static DataTable getOfferPriceListOfApprove2(int Recv2EmployeeId)
        {
            return SPs.OfferPriceListOfApprove2_Sp(Recv2EmployeeId).GetDataSet().Tables[0];
        }

        //总经理绑定 子gvSale
        public static DataTable getOfferPriceListOfApproves2(int Recv2EmployeeId, int mainid)
        {
            return SPs.OfferPriceListOfApproves2_Sp(Recv2EmployeeId, mainid).GetDataSet().Tables[0];
        }

        //市场部员工查询项目全称
        public static DataTable getProjectOfPrice(string projectname, string preEmName)
        {
            return SPs.ProjectOfPrice_Sp(projectname, preEmName).GetDataSet().Tables[0];
        }

        //市场部员工查询客户名称
        public static DataTable getSheetNumOfPrice(string SheetNum, string preEmName)
        {
            return SPs.SheetNumOfPrice_Sp(SheetNum, preEmName).GetDataSet().Tables[0];
        }
        //市场部员工查询项目、客户名称
        public static DataTable getBothNameOfPrice(string SheetNum, string ProjectName, string preEmName)
        {
            return SPs.BothNameOfPrice_Sp(SheetNum, ProjectName, preEmName).GetDataSet().Tables[0];
        }

        //市场部经理查询
        public static DataTable getProjectOfPrice1(string projectname, string preEmName)
        {
            return SPs.ProjectOfPrice1_Sp(projectname, preEmName).GetDataSet().Tables[0];
        }

        public static DataTable getSheetNumOfPrice1(string SheetNum, string preEmName)
        {
            return SPs.SheetNumOfPrice1_Sp(SheetNum, preEmName).GetDataSet().Tables[0];
        }

        public static DataTable getBothNameOfPrice1(string SheetNum, string ProjectName, string preEmName)
        {
            return SPs.BothNameOfPrice1_Sp(SheetNum, ProjectName, preEmName).GetDataSet().Tables[0];
        }

       


        //审批 市场部经理查询
        public static DataTable getProjectOfPrice2(string projectname, int EmId)
        {
            return SPs.ProjectOfPrice2_Sp(projectname, EmId).GetDataSet().Tables[0];
        }

        public static DataTable getSheetNumOfPrice2(string SheetNum, int EmId)
        {
            return SPs.SheetNumOfPrice2_Sp(SheetNum, EmId).GetDataSet().Tables[0];
        }

        public static DataTable getBothNameOfPrice2(string SheetNum, string ProjectName, int EmId)
        {
            return SPs.BothNameOfPrice2_Sp(SheetNum, ProjectName, EmId).GetDataSet().Tables[0];
        }

        //财务部经理查询
        public static DataTable getProjectOfPrice3(string projectname, int EmId)
        {
            return SPs.ProjectOfPrice3_Sp(projectname, EmId).GetDataSet().Tables[0];
        }

        public static DataTable getSheetNumOfPrice3(string SheetNum, int EmId)
        {
            return SPs.SheetNumOfPrice3_Sp(SheetNum, EmId).GetDataSet().Tables[0];
        }

        public static DataTable getBothNameOfPrice3(string SheetNum, string ProjectName, int EmId)
        {
            return SPs.BothNameOfPrice3_Sp(SheetNum, ProjectName, EmId).GetDataSet().Tables[0];
        }

        //总经办查询
        public static DataTable getProjectOfPrice4(string projectname, int EmId)
        {
            return SPs.ProjectOfPrice4_Sp(projectname, EmId).GetDataSet().Tables[0];
        }

        public static DataTable getSheetNumOfPrice4(string SheetNum, int EmId)
        {
            return SPs.SheetNumOfPrice4_Sp(SheetNum, EmId).GetDataSet().Tables[0];
        }

        public static DataTable getBothNameOfPrice4(string SheetNum, string ProjectName, int EmId)
        {
            return SPs.BothNameOfPrice4_Sp(SheetNum, ProjectName, EmId).GetDataSet().Tables[0];
        }
    }
}
