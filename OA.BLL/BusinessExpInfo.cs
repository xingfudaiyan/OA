using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;
namespace CanYou.OA.BLL
{
    public partial class BusinessExpInfo
    {
        public static DataTable getRelateBExp(int businessid)
        {
            return SPs.BExpRelate_Sp(businessid).GetDataSet().Tables[0];
        }

        public static DataTable getEmployeeBExp(int businessid)
        {
            return SPs.BExpEmployee_Sp(businessid).GetDataSet().Tables[0];
        }

        public static void DelRBExp(int businessid)
        {
            Query q = RelateBExp.Query();
            q.AddWhere(RelateBExp.Columns.BusinessExpId, businessid);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }

        public static void DelBExp(int businessid)
        {
            BusinessExp.Delete(businessid);
            
        }

        public static void DelEBExp(int businessid)
        {
            Query q = EmployeeBExp.Query();
            q.AddWhere(EmployeeBExp.Columns.BusinessExpId, businessid);
            q.QueryType = QueryType.Delete;
            q.Execute();
        }

        public static void DelRB(int RBid)
        {
            RelateBExp.Delete(RBid);
        }

        public static void DelEB(int EBid)
        {
            EmployeeBExp.Delete(EBid);
        }
        
        //市场部员工绑定 主gv
        public static DataTable getBusinessExpListOfPreEmployee(int emid)
        {
            return SPs.BsListOfPreEmployee_Sp(emid).GetDataSet().Tables[0];
        }

        //市场部员工绑定 子GridView2
        public static DataTable getBusinessExpListOfPreEmployee2(int emid, int MainBusinessExpId)
        {
            return SPs.BsListOfPreEmployee2_Sp(emid, MainBusinessExpId).GetDataSet().Tables[0];
        }

        //市场部经理绑定 主gv
        public static DataTable getBusinessExpListOfEmployee(int emid)
        {
            return SPs.BsListOfEmployee_Sp(emid).GetDataSet().Tables[0];
        }

        //市场部经理绑定 子gv
        public static DataTable getBusinessExpListOfEmployee2(int emid, int mainid)
        {
            return SPs.BsListOfEmployee2_Sp(emid, mainid).GetDataSet().Tables[0];
        }



        //审批 市场部经理绑定 主gv
        public static DataTable getBusinessExpListOfApprove(int RecvEmployeeId)
        {
            return SPs.BsListOfApprove_Sp(RecvEmployeeId).GetDataSet().Tables[0];
        }

        //审批 市场部经理绑定 子gv
        public static DataTable getBusinessExpListOfApproves(int RecvEmployeeId, int mainid)
        {
            return SPs.BsListOfApproves_Sp(RecvEmployeeId, mainid).GetDataSet().Tables[0];
        }

        //总经理绑定 主gv
        public static DataTable getBusinessExpListOfApprove1(int Recv1EmployeeId)
        {
            return SPs.BsListOfApprove1_Sp(Recv1EmployeeId).GetDataSet().Tables[0];
        }

        //总经理绑定 子gv
        public static DataTable getBusinessExpListOfApproves1(int Recv1EmployeeId, int mainid)
        {
            return SPs.BsListOfApproves1_Sp(Recv1EmployeeId, mainid).GetDataSet().Tables[0];
        }

        //财务部经理绑定 主gv
        public static DataTable getBusinessExpListOfApprove2(int Recv2EmployeeId)
        {
            return SPs.BsListOfApprove2_Sp(Recv2EmployeeId).GetDataSet().Tables[0];
        }

        //财务部经理绑定 子gv
        public static DataTable getBusinessExpListOfApproves2(int Recv2EmployeeId, int mainid)
        {
            return SPs.BsListOfApproves2_Sp(Recv2EmployeeId, mainid).GetDataSet().Tables[0];
        }

    }
}
