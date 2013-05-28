using System;
using System.Collections.Generic;
using System.Text;
using SubSonic;
using System.Collections;
using System.Web;

namespace CanYouLib
{
    internal class SubsonicHelper
    {

        internal static string GetUserName()
        {
            if (HttpContext.Current.User != null)
            {
                return HttpContext.Current.User.Identity.Name;
            }
            else
            {
                return "Î´µÇÂ½ÓÃ»§";
            }
        }

    

        internal static void QueryIn(string columnName, ArrayList listItems, Query qry)
        {
            if (listItems.Count > 0)
            {
                qry.IN(columnName, listItems);
            }
            else
            {
                qry.AddWhere(columnName, "00000000-0000-0000-0000-000000000000");
            }
        }
        
        internal static void QueryIn(string columnName, List<int> listItems, Query qry)
        {
            ArrayList array = new ArrayList();
            foreach (int pSiteId in listItems)
            {
                array.Add(pSiteId);
            }
            QueryIn(columnName, array, qry);
        }

        internal static void QueryIn(string columnName, List<Guid> listItems, Query qry)
        {
            ArrayList array = new ArrayList();
            foreach (Guid pSiteId in listItems)
            {
                array.Add(pSiteId);
            }
            QueryIn(columnName, array, qry);
        }
  
 
        internal static string AddTime(DateTime beginDate, DateTime endDate, string Field)
        {

            string sqlDate = "";
            if (beginDate != DateTime.MinValue && endDate == DateTime.MinValue)
            {
                //do nothing
            }

            if (beginDate == DateTime.MinValue && endDate == DateTime.MinValue)
            {
                //do nothing
            }

            if (beginDate == DateTime.MinValue && endDate != DateTime.MinValue)
            {
                sqlDate = Field + " <= '" + endDate.ToString() + "'";
            }

            if (beginDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                sqlDate = Field + " between '" + beginDate.ToString() + "' and '" + endDate.ToString() + "'";
            }
            return sqlDate;
        }


        internal static Query AddTime(DateTime beginDate, DateTime endDate, string Field, Query query)
        {
            if (beginDate != DateTime.MinValue && endDate == DateTime.MinValue)
            {
                //do nothing
            }

            if (beginDate == DateTime.MinValue && endDate == DateTime.MinValue)
            {
                //do nothing
            }

            if (beginDate == DateTime.MinValue && endDate != DateTime.MinValue)
            {
                query.AddWhere(Field, Comparison.LessThan, endDate);
            }

            if (beginDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                query.AddBetweenAnd(Field, beginDate, endDate);
            }
            return query;
        }

    }
}
