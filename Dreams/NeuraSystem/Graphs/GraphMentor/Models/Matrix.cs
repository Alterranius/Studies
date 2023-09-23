using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Models
{
    public struct matrix
    {
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public vec[] Value { get; set; }

        public matrix(params vec[] vectors)
        {
            Columns = vectors.Length;
            Rows = vectors[0].Length;
            Value = new vec[Columns];
            for (int i = 0; i < Columns; i++)
            {
                if (vectors[i].Length > Rows)
                {
                    decimal[] values = new decimal[Rows];
                    for (int j = 0; j < Rows; j++)
                    {
                        values[j] = vectors[i].Value[j];
                    }
                    Value[i] = new vec(values);
                }
                else if (vectors[i].Length < Rows)
                {
                    decimal[] values = new decimal[Rows];
                    for (int j = 0; j < Rows; j++)
                    {
                        if (j < vectors[i].Length)
                        {
                            values[j] = vectors[i].Value[j];
                        }
                        else
                        {
                            values[j] = 0;
                        }
                    }
                }
                else
                {
                    Value[i] = vectors[i];
                }
            }
        }

        public matrix(matrix matrix)
        {
            Rows = matrix.Rows;
            Columns = matrix.Columns;
            Value = matrix.Value;
        }

        public matrix(int columns, vec vector)
        {
            Columns = columns;
            Rows = vector.Length;
            Value = new vec[columns];
            for (int i = 0; i < columns; i++)
            {
                Value[i] = vector;
            }
        }

        public matrix Mult(matrix matrix)
        {
            vec[] result = new vec[Columns];
            for (int j = 0; j < Columns; j++)
            {
                result[j] = Value[j].Mult(matrix);
            }
            return new matrix(result);
        }

        public matrix Mult(vec vector)
        {
            return Mult(new matrix(vector));
        }

        public matrix Transp()
        {
            vec[] result = new vec[Rows];
            decimal[,] transp = new decimal[Columns, Rows];
            for (int j = 0; j < Columns; j++)
            {
                for (int i = 0; i < Rows; i++)
                {
                    transp[j, i] = Value[j].Value[i];      
                }
            }
            for (int i = 0; i < Rows; i++)
            {
                decimal[] vecResult = new decimal[Columns];
                for (int j = 0; j < Columns; j++)
                {
                    vecResult[j] = transp[j, i];
                }
                result[i] = new vec(vecResult);
            }
            return new matrix(result);
        }

        public matrix Sum(matrix matrix)
        {
            vec[] result = new vec[Columns];
            for (int j = 0; j < Columns; j++)
            {
                if (j < matrix.Columns)
                {
                    decimal[] vecResult = new decimal[Rows];
                    for (int i = 0; i < Rows; i++)
                    {
                        if (i < matrix.Columns)
                        {
                            vecResult[i] = matrix.Value[j].Value[i] + Value[j].Value[i];
                        }
                        else
                        {
                            vecResult[i] = Value[j].Value[i];
                        }
                    }
                    result[j] = new vec(vecResult);
                }
                else
                {
                    decimal[] vecResult = new decimal[Rows];
                    for (int i = 0; i < Rows; i++)
                    {
                        vecResult[i] = Value[j].Value[i];
                    }
                    result[j] = new vec(vecResult);
                }
            }
            return new matrix(result);
        }

        public matrix Scale(decimal scalar)
        {
            vec[] result = new vec[Columns];
            for (int j = 0; j < Columns; j++)
            {
                decimal[] vecResult = new decimal[Rows];
                for (int i = 0; i < Rows; i++)
                {
                    vecResult[i] = scalar * Value[j].Value[i];
                }
                result[j] = new vec(vecResult);
            }
            return new matrix(result);
        }

        public decimal Determinant()
        {
            if (Rows != Columns)
            {
                throw new Exception();
            }
            return Determinant(this);
        }

        private decimal Determinant(matrix matrix)
        {
            decimal result = 0;
            if (matrix.Columns == 2)
            {
                return
                    matrix.Value[0].Value[0] * matrix.Value[1].Value[1] - matrix.Value[0].Value[1] * matrix.Value[1].Value[0];
            }
            if (matrix.Columns == 1)
            {
                return matrix.Value[0].Value[0];
            }
            for (int j = 0; j < matrix.Columns; j++)
            {
                result += Convert.ToDecimal(Math.Pow((-1), 2 + j)) * Value[j].Value[0] * Determinant(Minor(0, j, matrix));
            }
            return result;
        }

        private matrix Minor(int x, int y, matrix matrix)
        {
            List<vec> result = new List<vec>();
            for (int j = 0; j < matrix.Columns; j++)
            {
                if (j == y)
                    continue;
                List<decimal> vecResult = new List<decimal>();
                for (int i = 0; i < matrix.Rows; i++)
                {
                    if (i == x)
                        continue;
                    vecResult.Add(matrix.Value[j].Value[i]);
                }
                result.Add(new vec(vecResult.ToArray()));
            }
            return new matrix(result.ToArray());
        }

        private decimal Algebraic(int x, int y, matrix matrix)
        {
            return Convert.ToDecimal(Math.Pow((-1), x + y)) * Determinant(Minor(x, y, matrix));
        }

        public matrix Reverse()
        {
            if (Rows != Columns)
                throw new InvalidOperationException("Неверная матрица для обращения");
            vec[] result = new vec[Rows];
            for (int i = 0; i < Rows; i++)
            {
                decimal[] vecResult = new decimal[Columns];
                for (int j = 0; j < Columns; j++)
                {
                    vecResult[j] = Algebraic(i, j, this);
                }
                result[i] = new vec(vecResult);
            }
            matrix resultMatrix = new matrix(result);
            return resultMatrix.Scale((decimal) 1 / this.Determinant());
        }

        public override string ToString()
        {
            string result = String.Empty;
            for (int i = 0; i < Rows; i++)
            {
                result += "- ";
                for (int j = 0; j < Columns; j++)
                {
                    result += $"{Value[j].Value[i]}  ";
                }
                result += "-\n";
            }
            return result;
        }
    }
}
