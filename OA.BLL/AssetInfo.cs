using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CanYou.OA.DAL;
using SubSonic;
namespace CanYou.OA.BLL
{
    public partial  class AssetInfo
    {
        //获取固定资产信息表
        public static DataTable getAssetListVW()
        {
            Query q = Asset.Query();
            
            return q.ExecuteDataSet().Tables[0];
        }

        public static DataTable getExAssetList()
        {
            Query q = Vw_ExAsset.Query();
            return q.ExecuteDataSet().Tables[0];
        }
        //获取计量单位Unit信息表
        public static DataTable getUnitList()
        {
            Query q = Unit.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        //获取存放地点Site信息表
        public static DataTable getSiteList()
        {
            Query q = Site.Query();
            return q.ExecuteDataSet().Tables[0];
        }

        //删除Asset
        public static void DelAsset(int assetid)
        {
            Asset.Delete(assetid);
        }
    }
}
