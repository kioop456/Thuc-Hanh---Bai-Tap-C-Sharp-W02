using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _Bai_tap__Ung_dung_chuyen_doi_tien_te
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rate = 23000;
            float dollar;
            

            Console.Write("Enter dollar: ");
            string dollarString = Console.ReadLine();
            dollar = float.Parse(dollarString);
            float vnd = dollar * rate;
            Console.WriteLine("Vnd: " + vnd);
            Console.ReadKey();

        }
    }
}
