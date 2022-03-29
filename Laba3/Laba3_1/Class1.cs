using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_1
{
    public class StrangeOperation
    {
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static int ChangeNum(int num)
        {
            if (IsEven(num))
                return num / 2;
            else
                return num + 3;
        }
    }
}
