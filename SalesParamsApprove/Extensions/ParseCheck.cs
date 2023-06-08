using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesParamsApprove.Extensions
{
    public static class ParseCheck
    {
        public static bool isDouble(this string val)
        {
            double Val;
            return double.TryParse(val, out Val);
        }

        public static bool isCelka(this string val)
        {
            int Val;
            return int.TryParse(val, out Val);
        }
    }
}
