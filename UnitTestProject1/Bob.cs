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
            if (IsShouting(remark))
            {
                return "Whoa, chill out!";
            }

            if (remark.EndsWith("?"))
            {
                return "Sure.";
            }

            if (string.IsNullOrWhiteSpace(remark))
            {
                return "Fine. Be that way!";
            }
            return "Whatever.";
        }

        private bool IsShouting(string remark)
        {
            if (!remark.ToCharArray().Any(c => char.IsLetter(c)))
            {
                return false;
            }

            var result = remark.ToCharArray().All(c => char.IsUpper(c) 
                    || char.IsPunctuation(c)
                    || char.IsSeparator(c)
                    || char.IsNumber(c)
                    || char.IsSymbol(c));
            return result;
        }
    }
}
