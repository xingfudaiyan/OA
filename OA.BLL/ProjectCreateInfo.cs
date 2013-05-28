using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial class ProjectCreateInfo
    {
        //获取员工或部门经理申请列表
        public static DataTable getProjectApply(String EmName)
        {
            return SPs.ProjectApplyOfEm(EmName).GetDataSet().Tables[0];
        }

        //查询客户对应的销售立项
        public static DataTable getProjectApplyOfClient(String clientName,String EmName)
        {
            return SPs.ProjectApplyOfClientEm_Sp(clientName,EmName).GetDataSet().Tables[0];
            
        }
        
        //删除销售立项
        public static void DelProjectApply(int pcId)
        {
            ProjectCreate.Delete(pcId);
        }

        //获取部门经理审批列表
        public static DataTable getProjectApproveOfDepart(String departName)
        {
            return SPs.ProjectApplyOfDepart(departName).GetDataSet().Tables[0];
        }
        
        //获取技术部经理审批列表
        public static DataTable getProjectApproveOfTech(String departName)
        {
            return SPs.ProjectApplyOfTech(departName).GetDataSet().Tables[0];
        }

        public static DataTable getProjectApproveOfManager()
        {
            Query q = Vw_ProjectApplyManager.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        //销售立项表单号
        public static bool IsSheetNumOfPC(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfPC_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //销售立项表单号
        public static string SheetNumOfPC(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfPC_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }


        public static DataTable getProjectLevel()
        {
            Query q = ProjectLevel.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getProjectType()
        {
            Query q = ProjectType.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getYewu()
        {
            Query q = YeWu.Query();
            return q.ExecuteDataSet().Tables[0];
        }
        
    }
}
