using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQs
{
    public class Number
    {
        private int num;
        private int len;
        public Number(int num, int len)
        {
            this.num = num;
            this.len = len;
        }
        public override string ToString()
        {
            return $"[value: {num.ToString()}], [length: {len.ToString()}]";
        }
    }
}
