using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model - 资金捐助
    /// </summary>
    public class Tmoney
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get;set;
        }
        /// <summary>
        /// 捐助资金
        /// </summary>
        public int ChrityMoney
        {
            get; set;
        }
        /// <summary>
        /// 捐助人姓名
        /// </summary>
        public string ChrityName
        {
            get; set;
        }
        /// <summary>
        /// 捐助人电话
        /// </summary>
        public string ChrityPhone
        {
            get; set;
        }
        /// <summary>
        /// 捐助人证件
        /// </summary>
        public string ChrityIdcard
        {
            get; set;
        }
        /// <summary>
        /// 资金捐赠创建时间
        /// </summary>
        public DateTime ChritySetTime
        {
            get; set;
        }
        /// <summary>
        /// 资金捐赠备注
        /// </summary>
        public string ChrityRemark
        {
            get; set;
        }
    }
}
