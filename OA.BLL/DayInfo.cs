using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;

namespace CanYou.OA.BLL
{
    public partial  class DayInfo
    {
        

        public static void DelDay(int dayid)
        {
            Day.Delete(dayid);
        }

        public static DataTable getWeekList()
        {
            Query q = Week.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        //绑定批准列表
        public static DataTable getWeekSumOfApprove(int RecvEmployeeId)
        {
            return SPs.WeekSumListOfApprove_Sp(RecvEmployeeId).GetDataSet().Tables[0];
        }

        //获取登陆用户的RoleName 
        public static string getRoleNameOfMaster(string masterName)
        {
            return SPs.RoleNameOfMaster_Sp(masterName).ExecuteScalar().ToString();
        }

        public static bool IsRole(string mastername)
        {
            DataTable dt = SPs.RoleNameOfMaster_Sp(mastername).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //通过EmployeeId获取DepartId
        public static string GetDepartIdOfEmployee(int employeeid)
        {
            return SPs.DepartIdOfEmployee_Sp(employeeid).ExecuteScalar().ToString();
        }

        //通过DepatId获取周总结审批接收者的EmployeeId
        public static string getRecvEmployeeId(int DepartId)
        {
            return SPs.EmployeeOfWeekSum_Sp(DepartId).ExecuteScalar().ToString();
        }

       
        //获取绑定周总结gw的视图
        public static DataTable getWeekSumListOfEmployee(int emid)
        {
            return SPs.WeekSumListOfEmployee_Sp(emid).GetDataSet().Tables[0];
        }


        //删除周总结
        public static void DelWeekSum(int weeksumid)
        {
            WeekSum.Delete(weeksumid);
        }

        //删除周内日志
        public static void DelDaysOfWeekSum(int weeksumId)
        {
            Query q = Day.Query();
            q.AddWhere(Day.Columns.WeekSumId, weeksumId);
            q.QueryType = QueryType.Delete;
            q.Execute();
           
        }

        //获取绑定Day的视图
        public static DataTable getDayList(int wksumId)
        {
            return SPs.DayListOfWK_Sp(wksumId).GetDataSet().Tables[0];
        }


        //绑定周DLL
        public static DataTable getWeek()
        {
            Query q = Week.Query();
            return q.ExecuteDataSet().Tables[0];
        }
    }
}
