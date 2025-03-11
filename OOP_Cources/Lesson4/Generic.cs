using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cources.Lesson4
{
    class Generic
    {
        public void SortTwo<T>(ref T item, ref T item2)
            where T : IComparable<T>
        {
            if (item.CompareTo(item2) > 0)
            {
                T temp = item;
                item = item2;
                item2 = temp;
            }
        }
        public void Print()
        {
            int num = 10;
            int num2 = 20;
            Console.WriteLine(num);
            SortTwo(ref num, ref num2);
            Console.WriteLine(num);
            SortTwo(ref num2, ref num);
            Console.WriteLine(num);
        }
    }
}
