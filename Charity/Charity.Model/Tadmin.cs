using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model - 管理员表数据
    /// </summary>
    public class Tadmin
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get;
            set;
        }
        /// <summary>
        /// 管理员账号
        /// </summary>
        public string AdAccount
        {
            get;
            set;
        }

        /// <summary>
        /// 管理员密码
        /// </summary>
        public string AdPassWord
        {
            get;
            set;
        }
        /// <summary>
        /// 用户姓名
        /// </summary>
        public string AdName
        {
            get;
            set;
        }
        /// <summary>
        /// 联系手机
        /// </summary>
        public string AdPhone
        {
            get;
            set;
        }
        /// <summary>
        /// 所属部门
        /// </summary>
        public string AdSection
        {
            get;
            set;
        }
        /// <summary>
        /// 身份证证件
        /// </summary>
        public string AdIdCard
        {
            get;
            set;
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string AdRemark
        {
            get;
            set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime AdSetTime
        {
            get;
            set;
        }

    }
}
