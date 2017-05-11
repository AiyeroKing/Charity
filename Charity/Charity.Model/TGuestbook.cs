using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model - 留言板
    /// </summary>
    public class TGuestbook
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get; set;
        }
        /// <summary>
        /// 留言标题
        /// </summary>
        public string BoredTital
        {
            get; set;
        }
        /// <summary>
        /// 留言人姓名
        /// </summary>
        public string BoredName
        {
            get; set;
        }
        /// <summary>
        /// 留言内容
        /// </summary>
        public string BoredBody
        {
            get; set;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BoredSetTime
        {
            get; set;
        }
        /// <summary>
        /// 留言人电话号码
        /// </summary>
        public string BoredTelphone
        {
            get; set;
        }
        /// <summary>
        /// 留言人电子邮箱
        /// </summary>
        public string BoredEmail
        {
            get; set;
        }
        /// <summary>
        /// 留言人主页
        /// </summary>
        public string BoredIndex
        {
            get; set;
        }
    }
}
