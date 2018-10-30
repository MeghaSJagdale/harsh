using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_matrix
{
    class Twodimensional
    {
        public int x;
        public int[,] c = new int[3, 3];
        public int sum = 0;

        public void print(int[,] a,string no)
        {
            Console.WriteLine("2D array: "+no);
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write(" " + a[i, j]);
                }
                Console.WriteLine(" ");
            }
        }

        public void add(int[,] a,int[,] b)
        {
            Console.WriteLine("addition of two arrays :");

            if(a.Length==b.Length)
            {
                for(int i=0;i<a.GetLength(0);i++)
                {
                    for(int j=0;j<a.GetLength(1);j++)
                    {
                        c[i,j] = a[i,j] + b[i,j];
                        Console.Write(" "+c[i, j]);
                    }
                    Console.WriteLine(" ");
                }
            }
        }

        public int[,] multiplication(int[,] a,int[,] b)
        {
            Console.WriteLine("multiplication of two arrays :");
            if(a.Length==b.Length)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            sum = sum + (a[row, j] * b[j, i]);      //+ (a[0, 1] * b[j, i]) + (a[0, 2] * b[j, i]));

                        }
                        c[row, i] = sum;
                        Console.Write(" " + c[row, i]);
                        sum = 0;
                    }
                    Console.WriteLine();
                }


                   //for (int i = 0; i < 3; i++)
                   //{
                   //    for (int j = 0; j < 3; j++)
                   //    {
                   //        sum = sum + (a[1, j] * b[j, i]); //+ (a[0, 1] * b[j, i]) + (a[0, 2] * b[j, i]));

                   //    }
                   //    c[1, i] = sum;
                   //    Console.Write(" " + c[1, i]);
                   //    sum = 0;
                   //}

                   //Console.WriteLine();
                   //for (int i = 0; i < 3; i++)
                   //{
                   //    for (int j = 0; j < 3; j++)
                   //    {
                   //        sum = sum + (a[2, j] * b[j, i]); //+ (a[0, 1] * b[j, i]) + (a[0, 2] * b[j, i]));

                   //    }
                   //    c[2, i] = sum;
                   //    Console.Write(" " + c[2, i]);
                   //    sum = 0;
                   //}
              
            }
            
            return c;
        }
    }
}
