using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayes
{
    class Program
    {
        static void Main(string[] args)
        {
            //запомнить температуру на неделю
            int t1, t2, t3, t4;
            //7. Объявление массиво
            //массивы - объекты, к ссылочным типам данных
            int[] temp;//объявляем массив
            
            temp = new int[7];//выделяем место для массива
            
            int[] t = new int[7];

            int[] temp2 = { 4, 5, 6, 7, 8, 9 };
            int[] temp3 = new int[6] { 4, 5, 6, 7, 8, 9 };
            //8. Ввод-вывод одномерных массивов.
            //пример заполнения массива
            //for (int i = 0; i < temp.Length; i++)
            //    temp[i] =new Random().Next(0,100);//заполнение массива случайными числами от 0..99
            
            ////пример вывода массива через цикл for
            //for (int i = 0; i < temp.Length; i++)
            //    Console.WriteLine(temp[i]);

            ////пример вывода массива через цикл foreach
            //foreach(int element in temp)//не позволяет менять значение элементов массива
            //    Console.WriteLine(element);


            //9.Ввод-вывод двумерных массивов.
            //Используется два цикла for
            int[,] a;
            a = new int[6, 5];
            a[0, 0] = 3;
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    a[i, j] = random.Next(0,100);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write($"{a[i, j],4}");
                Console.WriteLine();
            }


                    Console.ReadKey();
        }
    }
}
