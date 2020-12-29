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
