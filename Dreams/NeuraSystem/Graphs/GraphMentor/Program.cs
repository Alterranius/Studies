using GraphMentor.Models;
using System;

namespace GraphMentor
{
    class Program
    {
        static void Main(string[] args)
        {
            vec vec1 = new vec(2, 3, 1);
            vec vec2 = new vec(-1, 2, -2);
            vec vec3 = new vec(1, 1, 1);

            vec vec4 = new vec(-3, 1, -2, 3);

            matrix matrix1 = new matrix(vec1, vec2, vec3);
            matrix matrix2 = new matrix(vec3, vec4, vec1, vec2);
            Console.WriteLine(matrix1.Reverse());
            Console.ReadKey();
        }
    }
}
