using System;

namespace Charity.Dal.Common
{

    public static class SqlStringExtensions
    {
        /// <summary>
        /// 过滤Sql不安全 字符
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string FilteSqlStr(this string source)
        {
            string result = source;
            result = result.Replace("'", "");
            result = result.Replace("\"", "");
            result = result.Replace("&", "&amp");
            result = result.Replace("<", "&lt");
            result = result.Replace(">", "&gt");

            return result;
        }

        /// <summary>
        /// 格式 % %
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string LikeParamStr(this string source)
        {
            return "%" + source + "%";
        }

        /// <summary>
        /// 前匹配
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string PrefixLikeParamStr(this string source)
        {
            return source + "%";
        }

        /// <summary>
        /// 后匹配
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string SuffixLikeParamStr(this string source)
        {
            return "%" + source;
        }

        /// <summary>
        /// 返回 1,2,3
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InValueOfInt(this string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                return "0";
            }
            string[] array = source.Split(new char[] { ',', '|' }, StringSplitOptions.RemoveEmptyEntries);
            int number = 0;
            foreach (string str in array)
            {
                if (!int.TryParse(str, out number))
                {
                    return string.Empty;
                }
            }
            return string.Join(",", array);
        }

    }
}
