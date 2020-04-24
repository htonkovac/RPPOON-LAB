using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{

   /**
     * Odgovornosti ove klase:
     * Stvarnje Matrice
     * Popunjavanje Matrice
     * Vracanje same sebe
     */
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private double[][] matrix;
        private Random generator;

        private MatrixGenerator()
        {
            this.generator = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }
        public double[][] GenerateMatrix(int row, int column)
        {
            this.matrix = new double[row][];
            for (int i = 0; i < row; i++)
            {
                matrix[i] = new double[column];
            }
                     
            for(int i=0; i<row; i++)
            {
                for(int j=0; j< column; j++)
                {
                    this.matrix[i][j] = generator.NextDouble();
                }
            }
            return this.matrix;
        }


    }
}
