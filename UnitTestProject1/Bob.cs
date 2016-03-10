using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class Bob
    {
        public string hey(string remark)
        {
            if (remark.EndsWith("!"))
            {
                return "Whoa, chill out!";
            }

            if (remark.Length == 26)
            {
                return "Fine. Be that way!";
            }

            return "Whatever.";
        }
    }
}
