using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;
namespace CanYou.OA.BLL
{
   public partial class RoleInfo
    {
       public static DataTable getRoleList()
       {
           Query q = Role.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable getRightList()
       {
           Query q = Action.Query();
           return q.ExecuteDataSet().Tables[0];
       }
       
       //角色是否存在
       public static bool isRoleMaster(int masterid)
       {
           Query q = RoleMaster.Query();
           q.AddWhere(RoleMaster.Columns.MasterId, masterid);
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

       //角色是否存在
       public static bool IsRoleMasters(int masterid, int roleid)
       {
           Query q = RoleMaster.Query();
           q.AddWhere(RoleMaster.Columns.RoleId, roleid);
           q.AddWhere(RoleMaster.Columns.MasterId, masterid);
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

       //操作权限是否存在
       public static bool IsOperationRole(int roleid, int processid, int operationid)
       {

           Query q = OpProRole.Query();
           q.AddWhere(OpProRole.Columns.RoleId, roleid);
           q.AddWhere(OpProRole.Columns.ProcessId, processid);
           q.AddWhere(OpProRole.Columns.OperationId, operationid);
           DataTable dt = q.ExecuteDataSet().Tables[0];

           if (dt.Rows.Count>0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }
       //ProcessRole数据是否存在
       public static bool IsProcessRole(int processid, int roleid)
       {
           Query q = OpProRole.Query();
           q.AddWhere(OpProRole.Columns.RoleId, roleid);
           q.AddWhere(OpProRole.Columns.ProcessId, processid);
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

       ////重新赋值
       //public static void UpdateOperation(int operationid,int roleid,int processid)
       //{
       //    Query q = OpProRole.Query();
       //    q.AddWhere(OpProRole.Columns.RoleId, roleid);
       //    q.AddWhere(OpProRole.Columns.ProcessId, processid);
       //    q.AddUpdateSetting(OpProRole.Columns.OperationId, operationid);
       //    q.QueryType = QueryType.Update;
       //    q.Execute();
       //}

       //清空
       //public static void UpdateOperation(int processid, int roleid)
       //{
       //    Query q = OpProRole.Query();
       //    q.AddWhere(OpProRole.Columns.RoleId, roleid);
       //    q.AddWhere(OpProRole.Columns.ProcessId, processid);
       //    q.AddUpdateSetting(OpProRole.Columns.OperationId, null);
       //    q.QueryType = QueryType.Update;
       //    q.Execute();

       //}

       //删除指定操作权限
       public static void DelOperation(int processid, int roleid, int operationid)
       {
           Query q = OpProRole.Query();
           q.AddWhere(OpProRole.Columns.OperationId, operationid);
           q.AddWhere(OpProRole.Columns.RoleId, roleid);
           q.AddWhere(OpProRole.Columns.ProcessId, processid);
           q.QueryType = QueryType.Delete;
           q.Execute();
       }

       //查询指定流程、角色的操作
       public static DataTable getOperation(int processid, int roleid)
       {
           Query q = OpProRole.Query();
           q.AddWhere(OpProRole.Columns.RoleId, roleid);
           q.AddWhere(OpProRole.Columns.ProcessId, processid);
           return q.ExecuteDataSet().Tables[0];
       }
       //权限是否存在
       public static bool isActionMaster(int masterid)
       {
           Query q = ActionMaster.Query();
           q.AddWhere(ActionMaster.Columns.MasterId, masterid);
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

       //更新角色
       public static void UpdateRoleMaster(int masterid,int roleid)
       {
           Query q = RoleMaster.Query();
           q.AddWhere(RoleMaster.Columns.MasterId, masterid);
           q.AddUpdateSetting(RoleMaster.Columns.RoleId, roleid);
           q.QueryType = QueryType.Update;
           q.Execute();
       }

    

       public static void UpdateRoleMasters(int masterid)
       {
           Query q = RoleMaster.Query();
           q.AddWhere(RoleMaster.Columns.MasterId, masterid);
           q.AddUpdateSetting(RoleMaster.Columns.IsPass, 1);
           q.QueryType = QueryType.Update;
           q.Execute();
       }

      //删除权限
       public static void DelActionMaster(int masterid)
       {
           SPs.DelActionMaster_Sp(masterid).Execute();
       
       }

       //删除角色
      public static void DelRoles(int masterid,int roleid)
      {
          Query q = RoleMaster.Query();
          q.AddWhere(RoleMaster.Columns.MasterId, masterid);
          q.AddWhere(RoleMaster.Columns.RoleId, roleid);
          q.QueryType = QueryType.Delete;
          q.Execute();
          
      }


       //获取角色
       public static DataTable GetRoleFromMaster(int masterid)
       {
           Query q = RoleMaster.Query();
           q.AddWhere(RoleMaster.Columns.MasterId, masterid);
           return q.ExecuteDataSet().Tables[0];
       }

       //获取权限
       public static DataTable getActionFromMaster(int masterid)
       {
           Query q = ActionMaster.Query();
           q.AddWhere(ActionMaster.Columns.MasterId, masterid);
           return q.ExecuteDataSet().Tables[0];
       }

       //查询角色列表
       public static DataTable getRole()
       {
           Query q = Role.Query();
           return q.ExecuteDataSet().Tables[0];
       }
       //删除角色及对应的操作、用户
       public static void DelRole(int id)
       {
           Query q = RoleMaster.Query();
           q.AddWhere(RoleMaster.Columns.RoleId, id);
           q.QueryType = QueryType.Delete;
           q.Execute();
           Query s = OpProRole.Query();
           s.AddWhere(OpProRole.Columns.RoleId, id);
           s.QueryType = QueryType.Delete;
           s.Execute();
           Role.Delete(id);
       }

       //查询角色、用户列表
       public static DataTable getUserRoleList()
       {
           Query q = Vw_UserRoleList.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //查询流程表、角色表信息
       public static DataTable getProcessRoleList()
       {
           Query q = Vw_ProcessRole.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       //查询操作
       public static DataTable getOperationList()
       {
           Query q = Operation.Query();
           return q.ExecuteDataSet().Tables[0];
       }

  
      
 
    }
}
