using System;
using System.Collections.Generic;
using System.Text;

namespace FindElement
{
    class StringPattern
    {
        public static void Pattern()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write((char)(i+64));
                }
                Console.WriteLine();
            }
        }

        public static void NumPattern()
        {
            for (int i = 6; i>1 ; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
