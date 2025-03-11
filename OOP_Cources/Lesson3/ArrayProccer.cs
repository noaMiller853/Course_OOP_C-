using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cources.Lesson3
{
    class ArrayProccer
    {
        public static void MaxArray(int[]array,Action<int> process)
        {
            foreach (int item in array)
            {
               process(item);
            }
        }
    }
    class MaxNumber
    {
        private int Max { get; set; }
        public void FindMax(int number)
        {
            if (Max < number)
                Max = number;
        }
        public int GetMax()
        {
            return Max;
        }
    }
}
