using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model.ViewModel
{
    public class VBuyShop
    {
        public int shopID
        {
            get; set;
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

        public string ShopValue
        {
            get; set;
        }
        /// <summary>
        /// 商品名字
        /// </summary>
        public string ShopName
        {
            get; set;
        }
        /// <summary>
        /// 商品种类
        /// </summary>
        public string ShopSale
        {
            get; set;
        }
        /// <summary>
        /// 募捐地区
        /// </summary>
        public string ShopArea
        {
            get; set;
        }
        /// <summary>
        /// 捐助物品的人的姓名
        /// </summary>
        public string ShopCharityName
        {
            get; set;
        }
        /// <summary>
        /// 捐助物品的人的联系方式
        /// </summary>
        public string ShopCharityPhone
        {
            get; set;
        }
        /// <summary>
        /// 捐助物品方式
        /// </summary>
        public string ShopCharityWay
        {
            get; set;
        }
        /// <summary>
        /// 捐助物品的人的身份证号码
        /// </summary>
        public string ShopCharityIdcard
        {
            get; set;
        }
        /// <summary>
        /// 募捐物品备注
        /// </summary>
        public string ShopRemark
        {
            get; set;
        }
        /// <summary>
        /// 捐助物品的创建时间
        /// </summary>
        public DateTime ShopSetTime
        {
            get; set;
        }
    }
}
