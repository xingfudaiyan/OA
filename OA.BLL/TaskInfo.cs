using System;
using System.Collections.Generic;
using System.Text;
using SubSonic;
using System.Data;
using CanYou.OA.DAL;

namespace CanYou.OA.BLL
{
    public partial  class TaskInfo
    {
        public static DataTable getTaskList(int emid)
        {
            return SPs.GetTaskList_Sp(emid).GetDataSet().Tables[0];
        }

        public static string getTaskIdFromWkId(int Wkid)
        {
            return SPs.GetTaskIdFromWkId_Sp(Wkid).ExecuteScalar().ToString();
        }
    }
}
