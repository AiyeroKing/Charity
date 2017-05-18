using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model - 贫困表
    /// </summary>
    public class Tpoverty
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get;set;
        }
        /// <summary>
        /// 申请贫困地方区域
        /// </summary>
        public string ApplyArea
        {
            get; set;
        }
        /// <summary>
        /// 申请负责人姓名
        /// </summary>
        public string ApplyName
        {
            get; set;
        }
        /// <summary>
        /// 申请负责人联系方式
        /// </summary>
        public string ApplyPhone
        {
            get; set;
        }
        /// <summary>
        /// 申请资金补助信息
        /// </summary>
        public string ApplyInfo
        {
            get; set;
        }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string Srcimg
        {
            get; set;
        }
        /// <summary>
        /// 申请金额
        /// </summary>
        public string ApplyValue
        {
            get; set;
        }
        /// <summary>
        /// 申请资金创建时间
        /// </summary>
        public DateTime ApplySetTime
        {
            get;set;
        }
    }
}
