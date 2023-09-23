using GraphMentor.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GraphMentor.Static
{
    public class Top<T> /*: ICollection<T>, ITopology<T>*/
    {
        private HashSet<KeyValuePair<vec, T>> value = new HashSet<KeyValuePair<vec, T>>();
        public int Count { get; private set; }

        public bool IsReadOnly 
        {
            get
            {
                return false;
            }
            set 
            {
            } 
        }

        public void Add(vec vec, T item)
        {
            value.Add(new KeyValuePair<vec, T>(vec, item));
        }

        public void Clear()
        {
            value.Clear();
        }

        public bool Contains(T item)
        {
            return value.Contains(value.FirstOrDefault(x => x.Value.Equals(item)));
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            value.CopyTo(array as KeyValuePair<vec, T>[], arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            //IEnumerator<T> enumerator = value.GetEnumerator(); 
            //return value.GetEnumerator() as IEnumerator<T>;
            throw new NotImplementedException();
        }

        public Top<T> GetNeighbours(T t)
        {
            return new Top<T>(this, t);
        }

        public Top<T> GetNeighboursIncluded(T t)
        {
            return this;
        }

        public decimal Range(T t1, T t2)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            return value.Remove(value.FirstOrDefault(x => x.Value.Equals(item)));
        }

        public Top()
        {
        }

        public Top(Top<T> top, T t)
        {
            top.Remove(t);
            value = top.value;
        }
    }
}
