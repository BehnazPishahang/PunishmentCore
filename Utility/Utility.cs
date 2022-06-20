using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Utility
    {

        public static int toInt(this string text)
        {
            int result;

            if(text == null || text.Length == 0 || text.Equals(""))
                result = 0;
            else
                result = Convert.ToInt32(text);

            return result;
        }

    }
}
