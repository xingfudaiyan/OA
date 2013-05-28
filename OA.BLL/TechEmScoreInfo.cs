using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SubSonic;
using CanYou.OA.DAL;

namespace CanYou.OA.BLL
{
    public partial class TechEmScoreInfo
    {
        public static  DataTable getTechEmScoreGv(int EmId)
        {
            return SPs.TechEmScoregv_Sp(EmId).GetDataSet().Tables[0];
        }

        public static DataTable getTechgv(string departname)
        {
            return SPs.Techgv_Sp(departname).GetDataSet().Tables[0];
        }

        public static void DelTechEmScore(int ScoreId)
        {
            TechEmScore.Delete(ScoreId);
        }

        public static DataTable getYearddl()
        {
            Query q = Year.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getMonthddl()
        {
            Query q = Month.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getLevels()
        {
            Query q = EvaluateLevel.Query();
            return q.ExecuteDataSet().Tables[0];
        }
    }
}
