using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Model.Common
{
    /// <summary>
    /// 分页接收参数model，用于接收miniui或者api post方式传递的页码、每页条数 
    /// </summary>
    public class PagerParam
    {
        public PagerParam()
        {
            _pageIndex = 0;
            _pageSize = 30;
        }

        public PagerParam(int pageIndex, int pageSize)
        {
            _pageIndex = pageIndex;
            _pageSize = pageSize;
        }

        int _pageIndex;

        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex
        {
            get { return _pageIndex; }
            set { _pageIndex = value >= 0 ? value : 0; }
        }

        int _pageSize;

        /// <summary>
        /// 每页条数
        /// </summary>
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value > 0 ? value : 30; }
        }

        /// <summary>
        /// 排序条件字符串 直接编写如 Id desc,Name desc 即可，此时忽略 sortField 和 SortOrder
        /// </summary>
        public string OrderBy
        {
            get;
            set;
        }

        /// <summary>
        /// 排序条件字符串 直接编写如 Id ,Name 即可
        /// </summary>
        public string SortField
        {
            get;
            set;
        }

        /// <summary>
        /// 排序方式 asc desc
        /// </summary>
        public string SortOrder
        {
            get;
            set;
        }

        /// <summary>
        /// 数据库查询的起始行
        /// </summary>
        public int StartRowIndex
        {
            get
            {
                return _pageIndex * _pageSize + 1;
            }
        }

        /// <summary>
        /// 数据库查询的结束行
        /// </summary>
        public int EndRowIndex
        {
            get
            {
                return (_pageIndex + 1) * _pageSize;
            }
        }
    }
}
