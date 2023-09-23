using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Models
{
    public struct vec
    {
        public int Length { get; private set; }
        public decimal[] Value { get; set; }

        public vec(params decimal[] value)
        {
            Length = value.Length;
            Value = value;
        }

        public vec(vec vector)
        {
            Length = vector.Length;
            Value = vector.Value;
        }

        public vec Sum(vec vector)
        { 
            decimal[] result = new decimal[Length];
            for (int i = 0; i < Length; i++)
            {
                if (i < vector.Length)
                {
                    result[i] = Value[i] + vector.Value[i];
                }
                else
                {
                    result[i] = Value[i];
                }
            }
            return new vec(result);
        }

        public vec Mult(matrix matrix)
        {
            decimal[] result = new decimal[matrix.Rows];
            for (int i = 0; i < matrix.Rows; i++)
            {
                decimal current = 0;
                for (int j = 0; j < Length; j++)
                {
                    if (j < matrix.Columns)
                    {
                        current += Value[j] * matrix.Value[j].Value[i];
                    }
                    else
                    {
                        current += 0;
                    }
                }
                result[i] = current;
            }
            return new vec(result);
        }

        public vec Scale(decimal scalar)
        {
            decimal[] result = new decimal[Length];
            for (int i = 0; i < Length; i++)
            {
                result[i] = scalar * Value[i]; 
            }
            return new vec(result);
        }

        public static vec VEC0(int length)
        {
            return new vec(new decimal[length]);
        }

        public static vec VEC1(int length)
        {
            decimal[] result = new decimal[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = 1;
            }
            return new vec(result);
        }

        public override string ToString()
        {
            string result = "{ ";
            for (int i = 0; i < Length; i++)
            {
                if (Length - i == 1)
                {
                    result += $"{Value[i]} ";
                    break;
                }
                result += $"{Value[i]}, ";
            }
            result += "}";
            return result;
        }
    }
}
