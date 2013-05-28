using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using System.Data;
using SubSonic;

namespace CanYou.OA.BLL
{
   public partial class NoticeInfo
    {
       public static DataTable getNoticeList()
       {
           Query q = Notice.Query();
           return q.ExecuteDataSet().Tables[0];
       }

       public static void DelNotice(int NoticeId)
       {
           Query q = Notice.Query();
           q.AddWhere(Notice.Columns.NoticeId, NoticeId);
           q.QueryType = QueryType.Delete;
           q.Execute();

       }

       public static int getMaxNoticeId()
       {
           Query q = Vw_MaxNoticId.CreateQuery();
           DataTable dt = q.ExecuteDataSet().Tables[0];
           if (dt.Rows.Count==0)
           {
               return 0; 
           }
           else
           {
               return Convert.ToInt32(dt.Rows[0]["NoticeId"].ToString()); 
           }
           
       }

       public static DataTable getNoticeAsc()
       {
           Query q = Vw_Notice.Query();
           return q.ExecuteDataSet().Tables[0];
       }

     
    }
}
