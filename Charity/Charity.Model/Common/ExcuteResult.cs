using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Model.Common
{
    
    public class ExcuteResult
    {
        /// <summary>
        /// 大于0表示成功  小于0表示失败
        /// </summary>
        public int ResultFlag { get; set; }
        public string ResultInfo { get; set; }

        /// <summary>
        /// 行信息
        /// </summary>
        public List<RowMsg> RowMessages { get; set; }

        public ExcuteResult()
        {
            ResultFlag = 0;
            RowMessages = new List<RowMsg>();
        }
    }

    public class RowMsg
    {        
        public int RowNum { get; set; }

        public string Msg { get; set; }
    }
}
