using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class UC1_MaxThreeIntNum
    {
        public static int MaximumIntegerNumber(int firstvalue, int secondvalue, int thirdvalue)
        {
            if(firstvalue.CompareTo(secondvalue)>0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }

            throw new Exception("firstvalue, secondvalue, thirdvalue are same");
        }

        public static double MaximumfloatNumber(double firstvalue, double secondvalue, double thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && firstvalue.CompareTo(thirdvalue) > 0)
            {
                return firstvalue;
            }
            if (secondvalue.CompareTo(firstvalue) > 0 && secondvalue.CompareTo(thirdvalue) > 0)
            {
                return secondvalue;
            }
            if (thirdvalue.CompareTo(firstvalue) > 0 && thirdvalue.CompareTo(secondvalue) > 0)
            {
                return thirdvalue;
            }

            throw new Exception("firstvalue, secondvalue, thirdvalue are same");
        }

        public static string MaximumstringNumber(string firststring, string secondstring, string thirdstring)
        {
            if (firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) >= 0 && firststring.CompareTo(thirdstring) > 0 ||
                firststring.CompareTo(secondstring) > 0 && firststring.CompareTo(thirdstring) >= 0)
            {
                return firststring;
            }
            if (secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) >= 0 && secondstring.CompareTo(thirdstring) > 0 ||
                secondstring.CompareTo(firststring) > 0 && secondstring.CompareTo(thirdstring) >= 0)
            {
                return secondstring;
            }
            if (thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) >= 0 && thirdstring.CompareTo(secondstring) > 0 ||
                thirdstring.CompareTo(firststring) > 0 && thirdstring.CompareTo(secondstring) >= 0)
            {
                return thirdstring;
            }

            throw new Exception("firstvalue, secondvalue, thirdvalue are same");
        }
    }
}
