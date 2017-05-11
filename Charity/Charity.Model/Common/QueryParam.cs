using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Model.Common
{
    /// <summary>
    /// 查询参数 主要用于传递 查询的条件参数 
    /// </summary>
    public sealed class QueryParam : PagerParam
    {
        public QueryParam() : base() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">每页显示数</param>
        public QueryParam(int pageIndex, int pageSize) : base(pageIndex, pageSize) { }

        public QueryParam(PagerParam param) : base(param.PageIndex, param.PageSize) { }

        IDictionary<string, string> _whereDic;

        /// <summary>
        /// where 参数字典，前台传递指定的Key-Value Dal层根据具体的Key去拼接相应的字段值
        /// </summary>
        public IDictionary<string, string> WhereDic
        {
            get
            {
                if (_whereDic == null)
                {
                    _whereDic = new Dictionary<string, string>();
                }
                return _whereDic;
            }
            set
            {
                _whereDic = value;
            }
        }

        /// <summary>
        /// where 字典赋值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string this[string key]
        {
            get
            {
                string value = "";
                return WhereDic.TryGetValue(key, out value) ? value : "";
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) && WhereDic.ContainsKey(key))
                {
                    WhereDic.Remove(key);
                }
                else if (!string.IsNullOrWhiteSpace(value))
                {
                    this.WhereDic[key] = value;
                }
            }
        }

        public void AppendDic(string key, string value, bool ignoreEmpty = true)
        {
            if (!string.IsNullOrWhiteSpace(value) || ignoreEmpty == false)
            {
                this.WhereDic[key] = value;
            }
        }

        public void AppendDic(string key, int value, bool ignoreZeroAndNegative = false)
        {
            if (!ignoreZeroAndNegative || value > 0)
            {
                this.WhereDic[key] = value.ToString();
            }
        }
    }
}
