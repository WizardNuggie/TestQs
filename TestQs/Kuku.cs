using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQs
{
    public class Kuku
    {
        protected int num1;
        protected int num2;
        private static int dif = 0;
        public Kuku(int num):this(num, num+1)
        {
            Console.WriteLine("Kuku One");
        }
        public Kuku(int num, int num2)
        {
            Console.WriteLine("Kuku Two");
            this.num1 = num;
            this.num2 = num2;
            dif = num1 - num2;
        }
        public virtual int Sum()
        {
            return num1 + num2;
        }
        public static int GetDif()
        {
            return dif;
        }
    }
    public class Kiki : Kuku
    {
        private int num3;
        public Kiki() : base(1, 1)
        {
            num3 = 1;
        }
        public Kiki(int n1, int n2, int n3) : base(n1, n2)
        {
            this.num3 = n3;
        }
        public override int Sum()
        {
            return base.Sum() + num3;
        }
    }
}
