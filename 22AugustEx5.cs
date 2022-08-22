using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22August
{
    internal class ex5
    {
        static void Main(string[] args)
        {
            int [][] classsection = new int[4][];
            classsection[0] = new int[] {1,45 };
            classsection[1] = new int[] { 2, 65 }
            classsection[2] = new int[] { 3, 78 }
            classsection[3] = new int[] { 4,85 }

            for (int i = 0; i < classsection.Length; i++)
            {
                Console.WriteLine("Row [{0}]:",i);
                for(int j = 0; j < classsection[i].Length; j++)
                {
                    Console.Write(classsection[i][j]+" ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }

}
