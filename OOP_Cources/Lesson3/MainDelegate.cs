using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cources.Lesson3
{
    class MainDelegate
    {
       
       public static void PrintMaxItem()
        {
            int[]numbers = { 1, 2, 3, 4, 5 };
            MaxNumber maxNumber = new MaxNumber();
            ArrayProccer.MaxArray(numbers, maxNumber.FindMax);
            Console.WriteLine($"Max number: {maxNumber.GetMax()}");
        }
    }
}
