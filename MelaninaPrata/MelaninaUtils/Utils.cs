using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelaninaUtils
{
    public static class Utils
    {
        public static Boolean IsNumeric(Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal || Expression is Single || Expression is Double)
                return true;
            else
                try
                {
                    if (Expression is string)
                        Double.Parse(Expression as string);
                    else
                        Double.Parse(Expression.ToString());
                    return true;
                }
                catch { }
            return false;
        }
    }
}
