using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Iterators
{
    public abstract class Agregate // Интерфейс для объекта с итерацией
    {
        public abstract int Count { get; }
        public abstract object this[int index] { get; set; }
        public abstract Iterator CreateIterator();
    }
    public class ConcreteAgregate : Agregate // Сам объект с перебором
    {
        private readonly ArrayList _items = new ArrayList();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public override int Count { get => _items.Count; }
        public override object this[int index] { get => _items[index]; set => _items.Insert(index, value); }

    }
    public abstract class Iterator // Интерфейс перебора
    {
        public abstract object First();
        public abstract object Next();
        public abstract object CurrentItem();
        public abstract bool IsDone();
    }
    public class ConcreteIterator : Iterator // Реализация перебора для конкретного агрегата
    {
        private readonly Agregate _agregate;
        private int _current;

        public ConcreteIterator(Agregate agregate)
        {
            _agregate = agregate;
        }

        public override object CurrentItem()
        {
            return _agregate[_current];
        }

        public override object First()
        {
            return _agregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _agregate.Count; // Все элементы перечислены
        }

        public override object Next()
        {
            object result = null;
            _current++;
            /*if (_current < _agregate.Count) // Условие невыхода за границу
            {
                result = _agregate[_current];
            }*/
            if (!IsDone()) // Альтернативный вариант
            {
                result = _agregate[_current];
            }
            return result;
        }
    }

    // Пример использования Итератора

    public class Book
    {
        public string Name { get; set; }
    }
    public class Library : IBookNum
    {
        private Book[] books;

        public Book this[int index] => throw new NotImplementedException();

        public int Count => books.Length;

        public IBookIterator CreateIterator()
        {
            return new LibraryNumerator(this);
        }
    }
    public class LibraryNumerator : IBookIterator
    {
        IBookNum agregate;
        int index = 0;

        public LibraryNumerator(IBookNum booknum)
        {
            agregate = booknum;
        }

        public bool HasNext()
        {
            return index < agregate.Count;
        }

        public Book Next()
        {
            return agregate[index++];
        }
    }
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
    public interface IBookNum
    {
        IBookIterator CreateIterator();
        int Count { get; }
        Book this[int index] { get; }
    }
    public class Client
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateIterator();
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
