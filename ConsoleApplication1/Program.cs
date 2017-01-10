using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public const int N = 10;
        public static void Main(string[] args)
        {
            int[] array1 = new int[N];

            string Sarray1 = Console.ReadLine();

            for ( int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Convert.ToString(Sarray1[2 * i]));
                
            }

            Console.WriteLine();
            
            for (int i = 0; i < N/2; i++ )
            {
                int tmp = array1[i];
                array1[i] = array1[N - 1 - i];
                array1[N - 1 - i] = tmp;
            }

            for ( int i = 0; i < N; i++)
                Console.Write(array1[i] + " ");

            Console.ReadLine();
        }
    }
}
