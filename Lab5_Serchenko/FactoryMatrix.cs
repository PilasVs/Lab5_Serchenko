using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    using Matrices;
    using SquareMatrices;
    class FactoryMatrix
    {
        static public Matrix CreateMatrix(uint rows, uint cols)
        {
            if(rows==cols)
            {
                return new SquareMatrix(rows);
            }
            return new Matrix(rows, cols);
        }
    }
}
