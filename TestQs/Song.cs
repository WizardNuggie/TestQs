using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQs
{
    public class Song
    {
        string name;
        string performer;
        int length;
        public int GetLength()
        {
            return this.length;
        }
        public Song(string name, string performer, int length)
        {
            this.name = name;
            this.performer = performer;
            this.length = length;
        }
        public string LengthCatagory()
        {
            if (this.length <= 120)
                return "short";
            if (this.length > 240)
                return "long";
            return "avarage";
        }
    }
}
