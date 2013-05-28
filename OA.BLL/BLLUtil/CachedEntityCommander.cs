using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using CanYouLib.Exceptions;
using CanYouLib.Common;

namespace CanYou
{
    /*请万勿手工调用Subsonic底层方法，或者sql语句更新数据库，否则会导致内存和数据库数据的不一致存在*/
    public class CachedEntityCommander
    {

        public const string CacheKey = "CachedEntity_{0}";
        private static Hashtable ht = new Hashtable();

        public static void RegisterMemoryObject(Type type)
        {
            if (!(type.IsSubclassOf(typeof(EntityObject))))
            {
                throw new AppException("请注册EntityObject类型");
            }
            try
            {
                ht.Add(type, 1);
            }
            catch (ArgumentNullException )
            {
                throw new AppException("注册的类型为空");
            }
            catch (ArgumentException )
            {
                //重复添加，放行
            }
        }
        internal static bool IsTypeRegistered(Type type)
        {
            return ht.ContainsKey(type);
        }
        internal static object GetCache(string cacheKey)
        {
            return DataCache.GetCache(cacheKey);
        }
        internal static void RemoveCache(string cacheKey)
        {
            DataCache.RemoveCache(cacheKey);
        }
        internal static void  SetCache(string cacheKey, object objObject)
        {
            DataCache.SetCache(cacheKey, objObject);  //在实际项目中可以更改此方法的实现
        }
        
    }
}
