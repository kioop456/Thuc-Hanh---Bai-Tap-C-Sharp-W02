using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Bai_tapIn_so_thanh_chu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 10)
            {
                if (number == 0)
                    Console.Write("Zero");
                if (number == 1)
                    Console.Write("One");
                if (number == 2)
                    Console.Write("Two");
                if (number == 3)
                    Console.Write("Three");
                if (number == 4)
                    Console.Write("Four");
                if (number == 5)
                    Console.Write("Five");
                if (number == 6)
                    Console.Write("Six");
                if (number == 7)
                    Console.Write("Seven");
                if (number == 8)
                    Console.Write("Eight");
                if (number == 9)
                    Console.Write("Nine");


            }
            else if (number >= 10 && number < 20)
            {
                int testNum = number - 10;
                if (testNum == 0)
                    Console.Write("Ten");
                if (testNum == 1)
                    Console.Write("Eleven");
                if (testNum == 2)
                    Console.Write("Twelve");
                if (testNum == 3)
                    Console.Write("Thirteen");
                if (testNum == 4)
                    Console.Write("Fourteen");
                if (testNum == 5)
                    Console.Write("Fifteen");
                if (testNum == 6)
                    Console.Write("Sixteen");
                if (testNum == 7)
                    Console.Write("Seventeen");
                if (testNum == 8)
                    Console.Write("Eighteen");
                if (testNum == 9)
                    Console.Write("Nineteen");
            }
            else if (number >= 20 && number <= 99)
            {
                int test1 = number / 10;
                if (test1 == 2)
                    Console.Write("Twenty ");
                if (test1 == 3)
                    Console.Write("Thirty ");
                if (test1 == 4)
                    Console.Write("Fourty ");
                if (test1 == 5)
                    Console.Write("Fifty ");
                if (test1 == 6)
                    Console.Write("Sixty ");
                if (test1 == 7)
                    Console.Write("Seventy ");
                if (test1 == 8)
                    Console.Write("Eighty ");
                if (test1 == 9)
                    Console.Write("Ninety ");
                test1 = number % 10;
                if (test1 == 1)
                    Console.Write("One");
                if (test1 == 2)
                    Console.Write("Two");
                if (test1 == 3)
                    Console.Write("Three");
                if (test1 == 4)
                    Console.Write("Four");
                if (test1 == 5)
                    Console.Write("Five");
                if (test1 == 6)
                    Console.Write("Six");
                if (test1 == 7)
                    Console.Write("Seven");
                if (test1 == 8)
                    Console.Write("Eight");
                if (test1 == 9)
                    Console.Write("Nine");
            }
            else if (number >= 100 && number <= 999)
            {
                int test1 = number / 100;
                if (test1 == 1)
                    Console.Write("One Hundred ");
                if (test1 == 2)
                    Console.Write("Two Hundred ");
                if (test1 == 3)
                    Console.Write("Three Hundred ");
                if (test1 == 4)
                    Console.Write("Four Hundred ");
                if (test1 == 5)
                    Console.Write("Five Hundred ");
                if (test1 == 6)
                    Console.Write("Six Hundred ");
                if (test1 == 7)
                    Console.Write("Seven Hundred ");
                if (test1 == 8)
                    Console.Write("Eight Hundred ");
                if (test1 == 9)
                    Console.Write("Nine Hundred ");
                int sNum = number % 100;
                if (sNum != 0)
                {
                    Console.Write("And ");
                    if (sNum == 1)
                        Console.Write("One");
                    if (sNum == 2)
                        Console.Write("Two");
                    if (sNum == 3)
                        Console.Write("Three");
                    if (sNum == 4)
                        Console.Write("Four");
                    if (sNum == 5)
                        Console.Write("Five");
                    if (sNum == 6)
                        Console.Write("Six");
                    if (sNum == 7)
                        Console.Write("Seven");
                    if (sNum == 8)
                        Console.Write("Eight");
                    if (sNum == 9)
                        Console.Write("Nine");
                    if (sNum == 10)
                        Console.Write("Ten");
                    if (sNum > 10 && sNum <= 19)
                    {
                        int testNum = sNum - 10;
                        if (testNum == 1)
                            Console.Write("Eleven");
                        if (testNum == 2)
                            Console.Write("Twelve");
                        if (testNum == 3)
                            Console.Write("Thirteen");
                        if (testNum == 4)
                            Console.Write("Fourteen");
                        if (testNum == 5)
                            Console.Write("Fifteen");
                        if (testNum == 6)
                            Console.Write("Sixteen");
                        if (testNum == 7)
                            Console.Write("Seventeen");
                        if (testNum == 8)
                            Console.Write("Eighteen");
                        if (testNum == 9)
                            Console.Write("Nineteen");
                    }
                    else if (sNum >= 20 && sNum <= 99)
                    {
                        int test2 = sNum / 10;
                        if (test2 == 2)
                            Console.Write("Twenty ");
                        if (test2 == 3)
                            Console.Write("Thirty ");
                        if (test2 == 4)
                            Console.Write("Fourty ");
                        if (test2 == 5)
                            Console.Write("Fifty ");
                        if (test2 == 6)
                            Console.Write("Sixty ");
                        if (test2 == 7)
                            Console.Write("Seventy ");
                        if (test2 == 8)
                            Console.Write("Eighty ");
                        if (test2 == 9)
                            Console.Write("Ninety ");
                        test2 = sNum % 10;
                        if (test2 == 1)
                            Console.Write("One");
                        if (test2 == 2)
                            Console.Write("Two");
                        if (test2 == 3)
                            Console.Write("Three");
                        if (test2 == 4)
                            Console.Write("Four");
                        if (test2 == 5)
                            Console.Write("Five");
                        if (test2 == 6)
                            Console.Write("Six");
                        if (test2 == 7)
                            Console.Write("Seven");
                        if (test2 == 8)
                            Console.Write("Eight");
                        if (test2 == 9)
                            Console.Write("Nine");
                    }
                }
            }


            Console.ReadKey();
        }
    }
}
