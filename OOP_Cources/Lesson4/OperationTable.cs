using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cources.Lesson4
{
    class OperationTable<T>
    {
        // the followng line defines a _type_ op_func 
        public delegate T OpFunc(T x, T y);

        // the following line defines a variable of type op_func 
        public OpFunc op;
        private List<List<T>> matrix = new List<List<T>>();

        public OperationTable(List<T> _row_values, List<T> _col_values, OpFunc _op)
        {
            for (int i = 0; i < _row_values.Count; i++)
            {
                matrix.Add(new List<T>());
                for (int j = 0; j < _col_values.Count; j++)
                {
                    matrix[i].Add(_op(_row_values[i], _col_values[j]));
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    }
