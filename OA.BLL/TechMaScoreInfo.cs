using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SubSonic;
using CanYou.OA.DAL;


namespace CanYou.OA.BLL
{
   public partial class TechMaScoreInfo
    {
       public static void DelTechMaScore(int scoreid)
       {
           TechMaScore.Delete(scoreid);
       }

       public static DataTable getTechMaGv(int emid)
       {
           return SPs.TechMaScoregv_Sp(emid).GetDataSet().Tables[0];
       }

       public static DataTable getTech()
       {
           Query q=Vw_TechScore.Query();
           return q.ExecuteDataSet().Tables[0];
          
       }

       public static DataTable getMarket()
       {
           Query q = Vw_MarketScore.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataSet getTechds()
       {
           Query q = Vw_TechScore.Query();
           return q.ExecuteDataSet();
       }

       public static DataSet getMarketds()
       {
           Query q = Vw_MarketScore.Query();
           return q.ExecuteDataSet();
       }

       public static DataSet getTechEmds()
       {
           Query q = Vw_TechEmScore.Query();
           return q.ExecuteDataSet();
       }
    }
}
