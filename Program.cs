using LanguageExt.TypeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             Napišite program koji će izračunati broj prim brojeva manjih od 100
            (prim broj je broj koji je djeljiv samo s 1 i sa samim sobom)*/
            
            for (int i = 1; i < 100; i++)
            {
                if (i % 1 == 0 && i % i == 0)
                {
                    int[] num = new int[100];
                    i = + num[i];
                }

            }
            int length = num.Length;
            Console.WriteLine(length);
            Console.ReadKey();  
        }
    }
}
