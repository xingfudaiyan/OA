using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using SubSonic;
using CanYou.OA.DAL;

namespace CanYou.OA.BLL
{
    public partial  class ToolInfo
    {
        public static DataTable getToolApply(string strName)
        {
            return SPs.GetToolApply_Sp(strName).GetDataSet().Tables[0];
        }

        public static DataTable getDepartGv(string strDepart)
        {
            return SPs.DepartGvOfTool_Sp(strDepart).GetDataSet().Tables[0];
        }

        public static DataTable getMangerGv()
        {
            return Vw_ManagerOfTool.Query().ExecuteDataSet().Tables[0];
        }

        public static DataTable ToolList()
        {
            return Vw_ListTool.Query().ExecuteDataSet().Tables[0];
        }

        public static void ToolDel(int id)
        {
            Tool.Delete(id);
        }
       
    }
}
