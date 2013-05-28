using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
   public partial class StateInfo
    {
        //查询状态ID：一级待审
        public static int getStateId1()
        {
            Query q = State.Query();
            q.AddWhere(State.Columns.StateName, "一级待审");
            DataTable dt = q.ExecuteDataSet().Tables[0];
            return Convert.ToInt32(dt.Columns["StateId"].ToString());
        }
        //查询状态ID：一级未过
        public static int getStateId2()
        {
            Query q = State.Query();
            q.AddWhere(State.Columns.StateName, "一级未过");
            DataTable dt = q.ExecuteDataSet().Tables[0];
            return Convert.ToInt32(dt.Columns["StateId"].ToString());
        }
        //查询状态ID：二级待审
        public static int getStateId3()
        {
            Query q = State.Query();
            q.AddWhere(State.Columns.StateName, "二级待审");
            DataTable dt = q.ExecuteDataSet().Tables[0];
            return Convert.ToInt32(dt.Columns["StateId"].ToString());
        }
        //查询状态ID：审批完成
        public static int getStateId4()
        {
            Query q = State.Query();
            q.AddWhere(State.Columns.StateName, "审批完成");
            DataTable dt = q.ExecuteDataSet().Tables[0];
            return Convert.ToInt32(dt.Columns["StateId"].ToString());
        }
    }
}
