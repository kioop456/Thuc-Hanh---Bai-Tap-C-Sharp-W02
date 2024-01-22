using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thuc_Hanh___Bai_Tap_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float height;
            float width;

            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());

            float area = height * width;
            Console.WriteLine("Area is: " + area);
            Console.ReadKey();

        }
    }
}
