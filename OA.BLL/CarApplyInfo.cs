using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial class CarApplyInfo
    {
        public static DataTable getCarApplyList(int ApplyEmployeeId)
        {
            return SPs.CarApply_Sp(ApplyEmployeeId).GetDataSet().Tables[0];
        }

        public static void DelCarApply(int CarApplyId)
        {
            CarApply.Delete(CarApplyId);
        }

        ////员工
        //public static DataTable getCarApplyLists(int Emid, int MainId)
        //{
        //    return SPs.CarApplys_Sp(Emid, MainId).GetDataSet().Tables[0];
        //}

        //部门经理
        public static DataTable getCarApprove1List(int Emid)
        {
            return SPs.CarApprove1_Sp(Emid).GetDataSet().Tables[0];
        }

        public static DataTable getCarApprove1Lists(int Emid, int MainId)
        {
            return SPs.CarApproves1_Sp(Emid, MainId).GetDataSet().Tables[0];
        }

        //总助
        public static DataTable getCarApprove2List(int Emid)
        {
            return SPs.CarApprove2_Sp(Emid).GetDataSet().Tables[0];
        }

        public static DataTable getCarApprove2Lists(int Emid, int MainId)
        {
            return SPs.CarApproves2_Sp(Emid, MainId).GetDataSet().Tables[0];
        }
        
    
        //司机
        public static DataTable getCarApprove3List(int Emid)
        {
            return SPs.CarApprove3_Sp(Emid).GetDataSet().Tables[0];
        }

        public static bool IsSheetNumOfCar(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfCC_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        public static string SheetNumOfCar(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfCar_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }

    }
}
