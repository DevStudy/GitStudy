using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{

    /// <summary>
    /// 方法测试
    /// </summary>
    public class FunHelper
    {
        /// <summary>
        /// 获调用方取版本号
        /// </summary>
        /// <returns></returns>
        public static string GetCallingVersion()
        {
            return Assembly.GetCallingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// 获取库的版本号
        /// </summary>
        /// <returns></returns>
        public static string GetVersion()
        {
            return Assembly.GetAssembly(typeof(FunHelper)).GetName().Version.ToString();
        }
    }
}
