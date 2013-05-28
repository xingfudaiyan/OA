using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;

namespace CanYou.OA.BLL
{
    public class SheetNums
    {
        //合同编号是否存在
        public static bool IsNumOfContract(string SignName)
        {
            DataTable dt = SPs.IsNumOfContract_Sp(SignName).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //合同编号
        public static string NumOfContract(string PreIndex,string MidNum,string Today, string SignName)
        {
            DataTable dt = SPs.NumOfContract_Sp(PreIndex, MidNum, Today, SignName).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();

        }



        public static bool IsSheetNumOfClient(int ClientTypeId)
        {
            DataTable dt = SPs.IsClientOfSheetNum_Sp(ClientTypeId).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SheetNumOfClient(string PreIndex,int ClientTypeId)
        {
            DataTable dt = SPs.SheetNumOfClient_Sp(PreIndex,ClientTypeId).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();

        }


        public static bool IsSheetNumOfProject()
        {
            Query q = ProjectCreate.Query();
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

        public static string SheetNumOfProject(string PreIndex,string MidNum,string Today)
        {
            DataTable dt = SPs.SheetNumOfProject_Sp(PreIndex, MidNum, Today).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }



        public static bool IsSheetNumOfWS(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfWS_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SheetNumOfWS(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfWS_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }

        public static bool IsSheetNumOfBE(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfBE_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SheetNumOfBE(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfBE_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }

        public static bool IsSheetNumOfSE(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfSE_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SheetNumOfSE(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfSE_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }

        public static bool IsSheetNumOfCA(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfCA_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SheetNumOfCA(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfCA_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }

        public static bool IsSheetNumOfOP(string strToday)
        {
            DataTable dt = SPs.IsSheetNumOfOP_Sp(strToday).GetDataSet().Tables[0];
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string SheetNumOfOP(string PreIndex, string MidToday)
        {
            DataTable dt = SPs.SheetNumOfOP_Sp(PreIndex, MidToday).GetDataSet().Tables[0];
            return dt.Rows[0]["NewSheetNum"].ToString();
        }

    }
}
