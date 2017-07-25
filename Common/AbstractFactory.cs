#region Version Info
/*******************************************************
 * 作者 : yyj
 *
 * 时间 : 2017/7/7 11:02:13
 *
 * 版本 : V1.0.0
 *******************************************************
 * 修改者:
 * 说明 :
 *******************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 抽象工厂：实例化程序集对象
    /// </summary>
    public class AbstractFactory
    {
        private static readonly string dalPath = ConfigurationManager.AppSettings["DAL"];
        private static readonly string BllPath = ConfigurationManager.AppSettings["BLL"];
        /// <summary>
        /// 创建对象或从缓存获取
        /// </summary>
        public static object CreateObject(string assemblyPath, string cacheKey)
        {
            object objType = null;//DataCache.GetCache(CacheKey);//从缓存读取
            if (objType == null)
            {
                try
                {
                    objType = Assembly.Load(assemblyPath).CreateInstance(cacheKey);//反射创建
                    //DataCache.SetCache(CacheKey, objType);// 写入缓存
                }
                catch
                {
                    throw;
                }
            }
            return objType;
        }
        /// <summary>
        /// 创建DAL层对象实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="daoName"></param>
        /// <returns></returns>
        public static T CreateDaoInstance<T>(string daoName)
        {
            string cacheKey = dalPath + "." + daoName;
            object objType = CreateObject(dalPath, cacheKey);
            return (T)objType;
        }

        /// <summary>
        /// 创建BLL层对象实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="funName"></param>
        /// <returns></returns>
        public static T CreateFunInstance<T>(string funName)
        {
            string cacheKey = BllPath + "." + funName;
            object objType = CreateObject(BllPath, cacheKey);
            return (T)objType;
        }
    }
}
