using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SubSonic;
using CanYou.OA.DAL;

namespace CanYou.OA.BLL
{
   public partial class EmployeeInfo
    {
       public static DataTable GetEmployeeList()
       {
           Query q = Employee.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //获取gridview员工及所在部门视图
       public static DataTable EmployeeList()
       {
           Query q = Vw_EmployeeInfo.CreateQuery();
           return q.ExecuteDataSet().Tables[0];
       }

       
      //获取员工信息
       public static DataTable getEmployeeList(int employeeid)
       {
           return SPs.EmployeeList_Sp(employeeid).GetDataSet().Tables[0];
           
       }



       //获取部门包含的员工信息
       public static DataTable getEmployeeOfDepart(int departid)
       {
           return SPs.EmployeeOfDepart_Sp(departid).GetDataSet().Tables[0];
       }

       //获取登陆用户包含员工Id
       public static string   getEmployeeOfMaster(string MasterName, string MasterPsd)
       {
           Query q = Master.Query();
           q.AddWhere(Master.Columns.MasterName, MasterName);
           q.AND(Master.Columns.MasterPsd, MasterPsd);
           DataTable dt = q.ExecuteDataSet().Tables[0];
           return dt.Rows[0]["EmployeeId"].ToString();

       }
       //删除员工信息
       public static void EmployeeDel(int EmployeeId)
       {
           Employee.Delete(EmployeeId);
       }

       //获取学历信息表
       public static DataTable getEducationList()
       {
           Query q = Education.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //获取外语信息表
       public static DataTable getLanguageList()
       {
           Query q = Language.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //获取政治面貌信息表
       public static DataTable getPoliticsList()
       {
           Query q = Politics.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //获取职位信息表
       public static DataTable getPositionList()
       {
           Query q = Position.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //获取部门信息表
       public static DataTable getDepartList()
       {
           Query q = Depart.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //获取文件类型信息表
       public static DataTable getFileType()
       {
           Query q = FileType.Query();
           return q.ExecuteDataSet().Tables[0];
           
       }

       //查询级别信息
       public static DataTable getEmDang()
       {
           Query q = EmDang.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //查询档次信息
       public static DataTable getEmLevel()
       {
           Query q = EmLevel.Query();
           return q.ExecuteDataSet().Tables[0];
       }

    }
}
