using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigBucksBank
{
    public static class Validator
    {

        private static string title = "Entry Error";

        public static string Title
        {
            get { return title; }
            set { title = value; }
        }

        public static bool IsPresent(string text)
        {
            if (text.Equals(""))
            {
                return false;
            }
            return true;
        }

        public static bool IsDecimal(string text)
        {
            decimal number = 0m;
            if(Decimal.TryParse(text, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInt32(string text)
        {
            int number = 0;
            if(Int32.TryParse(text, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsInRange(decimal amount, decimal min, decimal max)
        {
            
            if(amount < min || amount > max)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool IsAboveMin(decimal amount, decimal min)
        {
            if(amount < min)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
