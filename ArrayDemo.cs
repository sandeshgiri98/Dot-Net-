using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWSCBasic
{
     class ArrayDemo
    {
        public void accessArray()
        {
            //creating array;
            //direct method: if value has to be directly insert 
            int[] marks = { 34, 56, 78, 85 };
            //using string keyword
            string[] name = new string[4];
            name[0] = "ram";
            name[1] = "Sam";
            name[2] = "Hari";
            name[3] = "Madan";

            //finding out size of array: no. of element in array.
            Console.WriteLine("size of first array" + marks.Length);
            Console.WriteLine("size of second array" + name.Length);

            //printing array using loop

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine("-------------------------");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            Console.WriteLine("--Example on multidimensional Array--");
            //declaring 2D int array
            int[,] score =
            {
                {1,2,3 },
                {4,5,6},
                {7,8,9}
            };
            //dec;aromg stromg 2D array
            string[,] programs =
            {
                {"bca","bim","csit" },
                {"bbm","bba","bbs" },
                {"ba","bsw","B.Ed" }
            };
            //printing 2D array using for loop
            for (int i = 0; i < score.GetLength(0); i++)
            {
                for (int j = 0; j < score.GetLength(1); j++)
                {
                    Console.Write(score[i, j]);
                }
                Console.WriteLine();
            }
            //using for each loop to print 2D array
            foreach (string var in programs)
            {
                Console.WriteLine(var);
            }
            //jagged array
            //such array which donot have equal number of column
            //i.e. each row can have different number of column (data)
            //eg first row canhave 2 col, 2nd row can have 5 col so on
            //declaring jagged array

            int[][] data = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 8, 10 },
                new int[] { 11, 12, 13, 14 }
            };
            //printing jagged array
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].GetLength(0); j++)
                {
                    Console.Write(data[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
    