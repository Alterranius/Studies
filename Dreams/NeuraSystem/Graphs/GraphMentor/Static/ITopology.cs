using System;
using System.Collections.Generic;
using System.Text;

namespace GraphMentor.Static
{
    public interface ITopology<T>
    {
        decimal Range(T t1, T t2);
        Top<T> GetNeighbours(T t);
        Top<T> GetNeighboursIncluded(T t);
    }
}
