using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErgometerSimulator
{
    class ValueSetting
    {
        public bool random { get; }
        public int value1 { get; set; }
        public int value2 { get; }
        public int currentvalue { get; set; }

        public ValueSetting(bool random, int value1, int value2)
        {
            this.random = random;
            this.value1 = value1;
            this.value2 = value2;
            this.currentvalue = 0;
        }

        public override string ToString()
        {
            string str = "";
            str += random + "|";
            str += value1 + "|";
            str += value2 + "|";
            str += currentvalue;
            return str;
        }

    }
}
