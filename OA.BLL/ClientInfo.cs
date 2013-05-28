using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
   public partial class ClientInfo
    {

       public static DataTable getClientTypeList()
       {
           Query q = ClientType.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable getSupplyList()
       {
           Query q = Supply.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable getClientList()
       {
           Query q = Vw_Client.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static DataTable getRelateList()
       {
           Query q = Relate.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static void ClientDel(int ClientId)
       {
           Client.Delete(ClientId);
       }

       public static void RelateDel(int RelateId)
       {
           Relate.Delete(RelateId);
       }

       public static void DelRelateOfClient(int ClientId)
       {
           Query q = Relate.Query();
           q.AddWhere(Relate.Columns.ClientId, ClientId);
           q.QueryType = QueryType.Delete;
           q.Execute();
       }

       public static DataTable getClientLevelList()
       {
           Query q = ClientLevel.Query();
           return q.ExecuteDataSet().Tables[0];
       }


       public static DataTable getRelateOfClient(int clientid)
       {
           return SPs.RelateOfClient_Sp(clientid).GetDataSet().Tables[0];
       }
     

       public static DataTable getNameOfClient(string clientname)
       {
           return SPs.NameOfClient_Sp(clientname).GetDataSet().Tables[0];

       }
       public static DataTable getLevelOfClient(int levelid)
       {
           return SPs.LevelOfClient_Sp(levelid).GetDataSet().Tables[0];

       }
       public static DataTable getBothOfClient(int levelid,string ClientName)
       {
           return SPs.BothOfClient_Sp(ClientName, levelid).GetDataSet().Tables[0];

       }
    }
}
