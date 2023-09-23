using GraphMentor.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static
{
    public abstract class AggFunc
    {
        public abstract vec Agg(matrix W, List<vec> vecs);
    }
}
