using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CanYou.OA.DAL;
using SubSonic;

namespace CanYou.OA.BLL
{
   public partial class BasEmScoreInfo
    {
       public static void DelBasEmSocre(int id)
       {
           BasEmScore.Delete(id);
       }

       public static DataTable getBasEmScore(int EmId)
       {
           return SPs.BasEmScoregv_Sp(EmId).GetDataSet().Tables[0];
       }

       public static DataTable getDriverScore(int EmId)
       {
           return SPs.DriverScoregv_Sp(EmId).GetDataSet().Tables[0];
       }


       public static void DelDsScore(int id)
       {
           DriverScore.Delete(id);
       }

       public static DataTable getNurseScore(int EmId)
       {
           return SPs.NurseScoregv_Sp(EmId).GetDataSet().Tables[0];
       }

       public static DataSet getNurseds()
       {
           Query q = Vw_Nureseds.Query();
           return q.ExecuteDataSet();
       }

       public static DataSet getDriveds()
       {
           Query q = Vw_Driveds.Query();
           return q.ExecuteDataSet();
       }

       public static DataSet getBasM()
       {
          Query q=Vw_BasM.Query();
          return q.ExecuteDataSet();
       }

       public static DataSet getFrontM()
       {
           Query q = Vw_FrontM.Query();
           return q.ExecuteDataSet();
       }

       public static DataSet getAssisM()
       {
           Query q = Vw_AssisM.Query();
           return q.ExecuteDataSet();
       }

       public static void DelNsScore(int id)
       {
           NurseScore.Delete(id);
       }

       public static DataTable getFrontScore(int EmId)
       {
           return SPs.FrontScoregv_Sp(EmId).GetDataSet().Tables[0];
       }

       public static void DelFsScore(int Id)
       {
           FrontScore.Delete(Id);
       }

       public static DataTable getAssistantScore(int EmId)
       {
           return SPs.AssistantScoregv_Sp(EmId).GetDataSet().Tables[0];
       }

       public static void DelAssistantScore(int Id)
       {
           AssistantScore.Delete(Id);
       }

       public static DataTable getMarketScore(int Emid)
       {
           return SPs.MarketScoregv_Sp(Emid).GetDataSet().Tables[0];
       }

       public static void DelMarketScore(int id)
       {
           MarketScore.Delete(id);
       }
  
    }
}
