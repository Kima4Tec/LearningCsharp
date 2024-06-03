using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    internal class Tools
    {
        public static void VisXOgY()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(i);
            }
            Console.SetCursorPosition(0, 10);
            for (int j = 0; j < 10; j++)
            {

                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
