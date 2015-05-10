using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix 
{
    class Matrix<T> // T - parameter
    {
        public int rows;
        public int cols;
        public T[,] matrix;  //this will be changed later
        Random random = new Random();


        public Matrix(int rows, int cols) // Matrix constructor
        {
            this.cols = cols;
            this.rows = rows;
            matrix = new T[rows,cols];
            
        }

        public T this[int iRows, int iCols] //indexers
        {
            get { return matrix[iRows, iCols]; }
            set { matrix[iRows, iCols] = value; }
        }

        public bool IsMatrixSquare() //Checking if matrix is square
        {
            return (rows == cols);
        }

        

       


        
    }
}
