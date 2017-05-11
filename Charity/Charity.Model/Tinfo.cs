using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model - 资讯表
    /// </summary>
    public class Tinfo
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get;set;
        }
        /// <summary>
        /// 资讯标题
        /// </summary>
        public string InfoTital
        {
            get;set;
        }
        /// <summary>
        /// 资讯负责人姓名
        /// </summary>
        public string InfoName
        {
            get; set;
        }
        /// <summary>
        /// 资讯内容
        /// </summary>
        public string InfoBody
        {
            get; set;
        }
        /// <summary>
        /// 资讯创建时间
        /// </summary>
        public DateTime InfoSetTime
        {
            get;set;
        }
    }
}
