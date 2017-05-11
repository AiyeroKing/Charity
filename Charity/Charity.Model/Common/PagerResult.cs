using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Model.Common
{
    public class PagerResult<T>
    {
        public PagerResult()
        {
        }

        public PagerResult(IEnumerable<T> data, int total)
        {
            this.data = data;
            this.total = total;
        }

        public int total { get; set; }

        public IEnumerable<T> data { get; set; }

    }
}
