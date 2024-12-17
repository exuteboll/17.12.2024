using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //вариант 8 
        static void Output(List<string> line)
        {
            foreach (var e in line)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine();
        }
        static void Caps(List<string> line)
        {
            foreach (var i in line)
            {
                Console.WriteLine(i.ToUpper());
            }
            Console.WriteLine();
        }

        static void Output1 (int a)
            {
            Console.WriteLine(a);
            Console.WriteLine();
            }
        static void Main(string[] args)
        {
            //List<string> line = new List<string>() {"Адвокат","Актер","Ботаник","Ветеринар","Диспетчер","Журналист" };
            //Output(line);

            //Caps(line);
            ////int kolvo = line.Count();
            ////Console.WriteLine(kolvo);
            //Output1(line.Count);
            //line.Add("Дробильщик");
            //Output(line);
            //line.Insert(0, "Доменщик");
            //Output(line);
            //line.RemoveAt(3);
            //Output(line);
            //line.Reverse();
            //Output(line);

            //Задача2

            //Задача 3.
            //List<int> line1 = new List<int> { 7, 10, 20, 30, 345, 567, 8 };
            //foreach(var s in line1)
            //{
            //    if (s % 5 == 0)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //Задача 4.
            //List<int> line2 = new List<int>() { 2145, 25, -23, 2, -5 };
            //for(int i = 0;i<line2.Count;i++)
            //{
            //    if(line2[i] < 0)
            //    {
            //        line2.Insert(i + 1, 10);
            //        i++;
            //    }
            //}    
            Console.ReadKey();
        }
    }
}
