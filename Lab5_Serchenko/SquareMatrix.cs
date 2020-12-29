using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareMatrices
{
    using Matrices;

    class SquareMatrix : Matrix
    {
        static public SquareMatrix operator ~(SquareMatrix m)
        {
			double tmp;

            for (uint i = 0; i < m._rows; i++)
            {
                for (uint j = 0; j < m._cols; j++)
                {
					tmp = m._Matrix[j][i];   //swap
					m._Matrix[j][i] = m._Matrix[i][j];
					m._Matrix[i][j] = tmp;
				}
            }

			return m.Clone();
        }

        public SquareMatrix(uint rowcols)
            : base(rowcols, rowcols) { }

		public override double Det()
		{
			double D = 0;
			uint n = GetRows();

			if (n == 0)
			{
				return 0;
			}

			if (n == 1)
			{
				return this[0][0];
			}

			SquareMatrix tmp = new SquareMatrix(n - 1);
			int sign = 1;
			for (uint f = 0; f < n; f++)
			{
				GetCofactor(this, ref tmp, 0, f);
				D += sign * this[0][f] * tmp.Det();
				sign = -sign;
			}

			return D;
		}

		private void GetCofactor
			(SquareMatrix thisM, ref SquareMatrix tmp, uint excessRow, uint excessCol)
        {
			uint i = 0, j = 0, n = thisM.GetRows();
			for (uint row = 0; row < n; row++) 
            {
				for (uint col = 0; col < n; col++)
				{
					if (row != excessRow && col != excessCol)
					{
						tmp[i][j++] = thisM[row][col];
						if (j == n - 1)
						{
							j = 0;
							i++;
						}
					}
				}
            }
        }

        public virtual SquareMatrix Clone()
		{
			SquareMatrix result = new SquareMatrix(_rows);

			for (uint i = 0; i < _rows; i++)
			{
				for (uint j = 0; j < _rows; j++)
				{
					result._Matrix[i][j] = _Matrix[i][j];
				}
			}

			return result;
		}
    }
}
