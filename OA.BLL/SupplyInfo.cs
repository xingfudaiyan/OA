using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial class SupplyInfo
    {
        public static DataTable getSupply()
        {
            Query q = Supply.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static bool IsSheetNum(string sheetnum)
        {
            Query q = Supply.Query();
            q.AddWhere(Supply.Columns.SheetNum, sheetnum);
            DataTable dt = q.ExecuteDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DelSp(int spid)
        {
            Query q = Supply.Query();
            q.AddWhere(Supply.Columns.SupplyId, spid);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }
    }
}
