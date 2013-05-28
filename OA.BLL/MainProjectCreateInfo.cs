using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial class MainProjectCreateInfo
    {
        public static DataTable getProjectList()
        {
            Query q = Vw_MainProjectCreate.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        public static void DelProject(int projectid)
        {
            MainProjectCreate.Delete(projectid);
        }

        public static DataTable getBothOfProject(string projectname, string projectlevel)
        {
            return SPs.BothOfProject_Sp(projectname, projectlevel).GetDataSet().Tables[0];
        }

        public static DataTable getNameOfProject(string projectname)
        {
            return SPs.NameOfProject_Sp(projectname).GetDataSet().Tables[0];
        }

        public static DataTable getLevelOfProject(string projectlevel)
        {
            return SPs.LevelOfProject_Sp(projectlevel).GetDataSet().Tables[0];
        }
    }
}
