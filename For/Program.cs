using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            //цикл for
            //for (int i = 0; i < 10; )
            //{
            //    Console.WriteLine(i);
            //    i += 1;
            //}
            //вложенные циклы
            for (int i = 0; i < 4;i++)//внешний цикл
                for(int j=0;j<4;j++)//внутренний цилк
            {
                Console.WriteLine($"{i} {j}");
                
            }

            Console.ReadKey();

        }
    }
}
