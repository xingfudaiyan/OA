using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;

namespace CanYou.OA.BLL
{
    public partial class SpecialExpInfo
    {
        

        public static DataTable getProjectStepList()
        {
            Query q = ProjectStep.CreateQuery();
            return q.ExecuteDataSet().Tables[0];
        }


        //市场部员工绑定 主gv
        public static DataTable getSpecialExpListOfPreEmployee(int emid)
        {
            return SPs.SpecialExpOfPreEmployee_Sp(emid).GetDataSet().Tables[0];
        }

        //市场部员工绑定 子GridView2
        public static DataTable getSpecialExpListOfPreEmployee2(int emid, int MainSpecialExpId)
        {
            return SPs.SpecialExpOfPreEmployee2_Sp(emid, MainSpecialExpId).GetDataSet().Tables[0];
        }

        //市场部经理绑定 主gv
        public static DataTable getSpecialExpListOfEmployee(int emid)
        {
            return SPs.SpecialExpOfEmployee_Sp(emid).GetDataSet().Tables[0];
        }

        //市场部经理绑定 子gv
        public static DataTable getSpecialExpListOfEmployee2(int emid, int mainid)
        {
            return SPs.SpecialExpOfEmployee2_Sp(emid, mainid).GetDataSet().Tables[0];
        }



        //审批 市场部经理绑定 主gv
        public static DataTable getSpecialExpListOfApprove(int RecvEmployeeId)
        {
            return SPs.SpecialExpOfApprove_Sp(RecvEmployeeId).GetDataSet().Tables[0];
        }

        //审批 市场部经理绑定 子gv
        public static DataTable getSpecialExpListOfApproves(int RecvEmployeeId, int mainid)
        {
            return SPs.SpecialExpOfApproves_Sp(RecvEmployeeId, mainid).GetDataSet().Tables[0];
        }

        //总经理绑定 主gv
        public static DataTable getSpecialExpListOfApprove1(int Recv1EmployeeId)
        {
            return SPs.SpecialExpOfApprove1_Sp(Recv1EmployeeId).GetDataSet().Tables[0];
        }

        //总经理绑定 子gv
        public static DataTable getSpecialExpListOfApproves1(int Recv1EmployeeId, int mainid)
        {
            return SPs.SpecialExpOfApproves1_Sp(Recv1EmployeeId, mainid).GetDataSet().Tables[0];
        }

        //财务部经理绑定 主gv
        public static DataTable getSpecialExpListOfApprove2(int Recv2EmployeeId)
        {
            return SPs.SpecialExpOfApprove2_Sp(Recv2EmployeeId).GetDataSet().Tables[0];
        }

        //财务部经理绑定 子gv
        public static DataTable getSpecialExpListOfApproves2(int Recv2EmployeeId, int mainid)
        {
            return SPs.SpecialExpOfApproves2_Sp(Recv2EmployeeId, mainid).GetDataSet().Tables[0];
        }


    

        //市场部员工查询项目全称
        public static DataTable getSheetNumOfSpecial(string SheetNum, int preEmId)
        {
            return SPs.SheetNumOfSpecial_Sp(SheetNum, preEmId).GetDataSet().Tables[0];
        }

        //市场部员工查询客户名称
        public static DataTable getProjectOfSpecial(int ProjectId, int preEnId)
        {
            return SPs.ProjectIdOfSpecial_Sp(ProjectId, preEnId).GetDataSet().Tables[0];
        }
        //市场部员工查询项目、客户名称
        public static DataTable getBothNameOfSpecial(string SheetNum, int ProjectId, int preEnId)
        {
            return SPs.BothNameOfSpecial_Sp(SheetNum, ProjectId, preEnId).GetDataSet().Tables[0];
        }

        //市场部经理查询项目全称
        public static DataTable getSheetNumOfSpecial1(string SheetNum, int preEnId)
        {
            return SPs.SheetNumOfSpecial1_Sp(SheetNum, preEnId).GetDataSet().Tables[0];
        }

        //市场部经理查询客户名称
        public static DataTable getProjectOfSpecial1(int ProjectId, int preEnId)
        {
            return SPs.ProjectIdOfSpecial1_Sp(ProjectId, preEnId).GetDataSet().Tables[0];
        }
        //市场部经理查询项目、客户名称
        public static DataTable getBothNameOfSpecial1(string SheetNum, int ProjectId, int preEnId)
        {
            return SPs.BothNameOfSpecial1_Sp(SheetNum, ProjectId, preEnId).GetDataSet().Tables[0];
        }

        //审批 市场部经理查询项目全称
        public static DataTable getSheetNumOfSpecial2(string SheetNum, int RecvId)
        {
            return SPs.SheetNumOfSpecial2_Sp(SheetNum, RecvId).GetDataSet().Tables[0];
        }

        //审批 市场部经理查询客户名称
        public static DataTable getProjectOfSpecial2(int ProjectId, int RecvId)
        {
            return SPs.ProjectIdOfSpecial2_Sp(ProjectId, RecvId).GetDataSet().Tables[0];
        }
        //审批 市场部经理查询项目客户名称
        public static DataTable getBothNameOfSpecial2(string SheetNum, int ProjectId, int RecvId)
        {
            return SPs.BothNameOfSpecial2_Sp(SheetNum, ProjectId, RecvId).GetDataSet().Tables[0];
        }

        //技术部经理查询项目全称
        public static DataTable getSheetNumOfSpecial3(string SheetNum, int RecvId)
        {
            return SPs.SheetNumOfSpecial3_Sp(SheetNum, RecvId).GetDataSet().Tables[0];
        }

        //技术部经理查询客户名称
        public static DataTable getProjectOfSpecial3(int ProjectId, int RecvId)
        {
            return SPs.ProjectIdOfSpecial3_Sp(ProjectId, RecvId).GetDataSet().Tables[0];
        }
        //技术部经理查询项目客户名称
        public static DataTable getBothNameOfSpecial3(string SheetNum, int ProjectId, int RecvId)
        {
            return SPs.BothNameOfSpecial3_Sp(SheetNum, ProjectId, RecvId).GetDataSet().Tables[0];
        }
        //总经理查询项目全称
        public static DataTable getSheetNumOfSpecial4(string SheetNum, int RecvId)
        {
            return SPs.SheetNumOfSpecial4_Sp(SheetNum, RecvId).GetDataSet().Tables[0];
        }

        //总经理查询客户名称
        public static DataTable getProjectOfSpecial4(int ProjectId, int RecvId)
        {
            return SPs.ProjectIdOfSpecial4_Sp(ProjectId, RecvId).GetDataSet().Tables[0];
        }
        //总经理查询项目客户名称
        public static DataTable getBothNameOfSpecial4(string SheetNum, int ProjectId, int RecvId)
        {
            return SPs.BothNameOfSpecial4_Sp(SheetNum, ProjectId, RecvId).GetDataSet().Tables[0];
        }

        

    }
}
