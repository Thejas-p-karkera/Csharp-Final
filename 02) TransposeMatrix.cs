// To transpose a matrix of order N*M and check whether it is symmetric or not.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace C_programs
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter value for M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mat1 = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write("Enter value for "+j+" th element of "+i+" th row: ");
                    mat1[i, j] = int.Parse(Console.ReadLine()) ;
                }
            }

            Console.WriteLine("The matrix is: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat1[i, j]+" ");
                }
                Console.WriteLine();
            }

            int[,] mat2 = new int[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat2[j, i] = mat1[i, j];
                }
            }

            Console.WriteLine("The Transposed matrix is: ");

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat2[i, j] + " ");
                }
                Console.WriteLine();
            }

            if(isSymmetr(mat1, mat2, n, m))
            {
                Console.WriteLine("The matrix is symmetric");
            }
            else
            {
                Console.WriteLine("The matrix is not symmetric");
            }
        }

        static bool isSymmetr(int[,] mat1, int[,] mat2, int n, int m)
        {
            if (n != m)
            {
                return false;
            }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (mat1[i, j] != mat2[i, j])
                        {
                            return false;
                        }
                    }
                }
            
            return true;
        }
    }
}
