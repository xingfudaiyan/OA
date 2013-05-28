using System;
using System.Collections.Generic;
using System.Text;
using CanYou.OA.DAL;
using SubSonic;
using System.Data;

namespace CanYou.OA.BLL
{
    public partial  class ContactInfo
    {
        //获取通讯录视图 绑定GVW
        public static DataTable getContactListVW()
        {
            Query q = Vw_ContactList.CreateQuery();
            return q.ExecuteDataSet().Tables[0];
        }

        //删除单条通讯录 
        public static void DelContact(int contactid)
        {
            Contact.Delete(contactid);
        }

        //查询姓名
        public static DataTable EmployeeIdOfName(string employeeName)
        {
            DataTable dt = SPs.EmployeeIdOfName_Sp(employeeName).GetDataSet().Tables[0];
            return dt;

        }

        //部门查询
        public static DataTable ContactOfDepart(int departid)
        {
            DataTable dt = SPs.ContactOfDepart_Sp(departid).GetDataSet().Tables[0];
            return dt;
        }

        //查询姓名部门
        public static DataTable ContactOfBoth(int departid, string employeename)
        {
            return SPs.ContactOfBoth_Sp(departid, employeename).GetDataSet().Tables[0];
        }
    }
}
