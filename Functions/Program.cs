using System;

namespace Functions
{

    class Program
    {

        static void Pause()
        {
            //return;
            Console.ReadKey();
        }

        static int Sum(int a,int b)
        {
            //тело метода

            return a + b;
            Console.WriteLine(a+b);//это строка выполняться не будет
        }



        static void Main(string[] args)
        {

            int s=Sum(3, 4);
            Console.WriteLine(Sum(4,6));
            Pause();
            //стандартные функции?
            //Самые часто используемые функции входят в библиотеку System
            Console.WriteLine("Вывод данных на экран");//
            Console.Write("Вывод данных на экран без перехода на новую строку");

            Console.ReadLine();//считать строку с консоли
            //все стандартные типы данных входят в библиотеку System(int, double, string,long ...)
        }

    }
}
