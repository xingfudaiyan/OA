using System;
using System.Collections.Generic;
using System.Text;

namespace CanYouLib
{
    public class SortDic
    {
        public SortDirection sortDirection;
        public String sortExpression;
        public SortDic(SortDirection pSortDirection, String pSortExpression)
        {
            sortDirection = pSortDirection;
            sortExpression = pSortExpression;
        }
               
    }
}
