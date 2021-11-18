using System;
using System.Collections.Generic;
using System.Text;

namespace FindElement
{
    class SmallestNumber
    {
        public static void SmallNumber()
        {
            int[] arry = { 5, 10, 2, 88, 7, 63 };

            int larg = arry[0];
            for (int i = 0; i < arry.Length; i++)
            {
                if (arry[i] < larg)
                {
                    larg = arry[i];
                }
            }

            Console.WriteLine(larg);
        }
    }
}
