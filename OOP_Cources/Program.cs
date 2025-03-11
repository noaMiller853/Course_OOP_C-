// See https://aka.ms/new-console-template for more information
using OOP_Cources.Lesson3;
using OOP_Cources.Lesson4;


//Lessom3
//MainDelegate.PrintMaxItem();

//Lesson4

//ex1
//Generic generic = new Generic();
//generic.Print();
//ex2
List<double> row_values = new List<double> { 1.1, 2.9, 3.9, 4.9, 5.8 };
List<double> col_values = new List<double> { 1.8, 2.7, 3.9, 4.7, 5.8 };
OperationTable<double> table = new OperationTable<double>(row_values, col_values, (x, y) => x * y);
table.Print();
