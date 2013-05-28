using System;
using System.Collections.Generic;
using System.Text;
using SubSonic;
using CanYou.OA.DAL;
using System.Data;

namespace CanYou.OA.BLL
{
   public partial class MasterInfo
    {
         //验证用户是否存在
        public static bool IsUserExit(string userName)
        {
            Console.WriteLine(userName);
            Query q = Master.Query();
            q.AddWhere(Master.Columns.MasterName, userName);
            DataTable dt = q.ExecuteDataSet().Tables[0];
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public static bool IsUser(string userName, string psd)
        {
            DataTable dt = SPs.UserLogin_Sp(userName, psd).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                string str1 = dt.Rows[0]["MasterName"].ToString();
                string str2 = dt.Rows[0]["MasterPsd"].ToString();
                Console.WriteLine(str1 + str2);
                if (str1 == userName && str2 == psd)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
     
        }

        //重置密码
        public static void ResetPsd(string mastername,string strOldUserPsd, string strNewPsd)
        {
            Query q = Master.Query();
            q.AddWhere(Master.Columns.MasterName,mastername);
            q.AddWhere(Master.Columns.MasterPsd, strOldUserPsd);
            q.AddUpdateSetting(Master.Columns.MasterPsd, strNewPsd);
            q.QueryType = QueryType.Update;
            q.Execute();

        }

        //获取用户列表
        public static DataTable  GetMasterList()
        {
            Query q = Vw_MasterList.CreateQuery();
            return q.ExecuteDataSet().Tables[0];
        }

       //获取用户列表
       public static DataTable getMasterLists()
       {
           Query q = Master.Query();
           return q.ExecuteDataSet().Tables[0];
       }

        public static DataTable getRecvMasterList()
        {
            Query q = Vw_RecvMaster.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        //删除用户id
        public static void DelMaster(int msid)
        {
            Master.Delete(msid);
        }


     
    }
}
