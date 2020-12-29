using System;

namespace Matrices
{
    class Matrix
    {
        public uint GetRows()
        {
            return _rows;
        }

        public uint GetCols()
        {
            return _cols;
        }

        public void Randomize()
        {
            Random random = new Random();
            for (uint i = 0; i < _rows; i++)
            {
                for (uint j = 0; j < _cols; j++)
                {
                    _Matrix[i][j] = random.NextDouble();
                }
            }
        }

        public virtual double Det()
        {
            throw new NotSupportedException();
        }

        public double[] this[uint i]
        {
            get { return _Matrix[i]; }
        }

        static public Matrix operator ~(Matrix m)
        {
            double[][] _NewMatrix = new double[m._cols][];

            for (uint i = 0; i < m._cols; i++)
            {
                _NewMatrix[i] = new double[m._rows];

                for (uint j = 0; j < m._rows; j++)
                {
                    _NewMatrix[i][j] = m._Matrix[j][i];
                }
            }
            m._Matrix = _NewMatrix;

            uint tmp = m._rows;   //swap
            m._rows = m._cols;
            m._cols = tmp;

            return m;
        }

        static public Matrix operator +(Matrix m1, Matrix m2)
        {
            if(m1._rows != m2._rows || m1._cols != m2._cols)
            {
                throw new ArgumentException();
            }

            Matrix tmp = new Matrix(m1._rows,  m1._cols);

            for (uint i = 0; i < m1._rows; i++)
            {
                for (uint j = 0; j < m1._cols; j++)
                {
                    tmp._Matrix[i][j] = m1._Matrix[i][j] + m2._Matrix[i][j];
                }
            }

            return tmp;
        }

        static public Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1._rows != m2._rows || m1._cols != m2._cols)
            {
                throw new ArgumentException();
            }

            Matrix tmp = new Matrix(m1._rows, m1._cols);

            for (uint i = 0; i < m1._rows; i++)
            {
                for (uint j = 0; j < m1._cols; j++)
                {
                    tmp._Matrix[i][j] = m1._Matrix[i][j] - m2._Matrix[i][j];
                }
            }

            return tmp;
        }

        static public Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1._cols != m2._rows)
            {
                throw new ArgumentException();
            }

            uint i, j, k;
            Matrix tmp = new Matrix(m1._rows, m2._cols);

            for (i = 0; i < m1._rows; i++)
            {
                for (j = 0; j < m2._cols; j++)
                {
                    tmp._Matrix[i][j] = 0;
                    for (k = 0; k < m1._cols; k++)
                    {
                        tmp._Matrix[i][j] += m1._Matrix[i][k] * m2._Matrix[k][j];
                    }
                }
            }

            return tmp;
        }

        public override string ToString() 
        {
            string s = "";
            uint i = 0, j;
            for (; i < _rows; i++) 
            {
                j = 0;
                for (; j < _cols; j++) 
                {
                    s += _Matrix[i][j];
                    s += ' ';
                }
                s += Environment.NewLine;
            }
            return s;
        }

        public Matrix(uint rows, uint cols)
        {
            _rows = rows;
            _cols = cols;
            _Matrix = new double[_rows][];
            for (uint i = 0; i < _rows; i++)
            {
                _Matrix[i] = new double[_cols];
            }
        }

        protected uint _rows;
        protected uint _cols;
        protected double[][] _Matrix = null;
    }

}

