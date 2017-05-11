using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model - 募捐商品表
    /// </summary>
    public class Tshop
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID
        {
            get;set;
        }
        /// <summary>
        /// 商品价值
        /// </summary>
        public int ShopValue
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
            get;set;
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
