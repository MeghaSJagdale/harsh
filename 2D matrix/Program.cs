using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3] { { 7, 1, 8 }, { 1, 2, 6 }, { 4, 5, 2 } };
            int[,] b = new int[3, 3] { { 1, 2, 3 }, { 5, 3, 5 }, { 4, 5, 2 } };
            Twodimensional call = new Twodimensional();
            call.print(a,"a");
            Console.WriteLine(" ");
            call.print(b,"b");
            call.add(a, b);
            Console.WriteLine(" ");
            call.multiplication(a, b);

            Console.Read();
        }
    }
}
