using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    ///Model -  普通用户表
    /// </summary>
    public class Tuseraccount
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get;set;
        }
        /// <summary>
        /// 普通用户表 - 账号
        /// </summary>
        public string UsAccount
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 密码
        /// </summary>
        public string UsPassword
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 账户姓名
        /// </summary>
        public string UsName
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 账户昵称
        /// </summary>
        public string UsNiname
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 用户的联系方式
        /// </summary>
        public string UsPhone
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 用户的电子邮件
        /// </summary>
        public string Usmail
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 用户的身份证号码
        /// </summary>
        public string UsIdcard
        {
            get; set;
        }
        /// <summary>
        /// 普通用户表 - 用户账号创建时间
        /// </summary>
        public DateTime UsSettime
        {
            get; set;
        }

        /// <summary>
        /// 普通用户表 - 备注
        /// </summary>
        public string UsRemark
        {
            get; set;
        }
    }
}
