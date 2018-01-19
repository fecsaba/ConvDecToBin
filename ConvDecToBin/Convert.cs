using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvDecToBin
{
    class Convert
    {
        string dec;

        public string Dec
        {
            get
            {
                return dec;
            }
            set
            {
                dec = DToB(value);
            }
        }
        public string DToB(string st)
        {
            
            bool ok = int.TryParse(st, out int num);
            //int num = int.Parse(st);
            string result = "";
            if (ok)
            {
                while (num > 0)
                {
                    int remainder = num % 2;
                    result = remainder.ToString() + result;

                    num /= 2;
                }
                int l = result.Length;
                for (int i = 0; i < 8 - l; i++)
                {
                    result = "0" + result;
                }
                return result;
            }
            return "el..tad";
        }
    }
}
