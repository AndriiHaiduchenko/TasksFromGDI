using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Matrix<int> mat = new Matrix<int>(random.Next(1,30),random.Next(1,30)); //random instance of Matrix class
            

            for (int i = 0; i <mat.rows; i++)
            
            {
                for (int j = 0; j <mat.cols; j++)
                {
                    mat[i, j] = random.Next(0, 10);
                }
            }

            for (int i = 0; i <mat.rows; i++)
            {
                for (int j = 0; j <mat.cols; j++)
                {
                    Console.Write("{0} ", mat[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine( mat.rows);
            Console.WriteLine( mat.cols );
            Console.WriteLine(mat.IsMatrixSquare());

          
            
        }
    }
}
