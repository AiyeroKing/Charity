using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity.Model
{
    /// <summary>
    /// Model-总资金表
    /// </summary>
    public class TAllmoney
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
        /// 总资金  --
        /// 
        /// ID为1的数据为收入商品总资金  
        /// ID为2的为收入善款总资金 
        /// ID为3的为卖出商品总资金 
        /// ID为4的为卖出和获得总资金
        /// ID位5的为贫困地区需求总资金
        /// </summary>
        public int AllMoney
        {
            get;
            set;
        }


    }
}
