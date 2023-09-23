using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Proxies
{
    public class Proxy : Subject // Заменяет собой настощий объект
    {
        RealSubject realSubject;
        public override void Request() // Контроль доступа к настоящему объекту
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
    public abstract class Subject // Абстрактный объект или интерфейс
    {
        public abstract void Request();
    }
    public class Client
    {
        public void Main()
        {
            Subject subject = new Proxy();
        }
    }
    public class RealSubject : Subject // Настоящий объект
    {
        public override void Request()
        {
            
        }
    }

    // Пример ПРОКСИ

    public class Page
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Text { get; set; }
    }
    public interface IBook
    {
        Page GetPage(int number);
    }
    public class BookStore : IBook
    {
        private List<Page> pages;
        public BookStore()
        {
            pages.Add(new Page() 
            {
                Id = 0,
                Number = 1,
                Text = "Война и мир"
            });
        }

        public Page GetPage(int number)
        {
            return pages.FirstOrDefault(p => p.Number == number);
        }
        public void Dispose()
        {
            pages.Clear();
        }
    }

    public class BookStoreProxy : IBook
    {
        private List<Page> pages;
        private BookStore bookStore;

        public BookStoreProxy()
        {
            pages = new List<Page>();
        }

        public Page GetPage(int number)
        {
            Page page = pages.FirstOrDefault(p => p.Number == number);
            if (page == null)
            {
                if (bookStore == null)
                {
                    bookStore = new BookStore();
                }
                page = bookStore.GetPage(number);
                pages.Add(page);
            }
            return page;
        }
        public void Dispose()
        {
            if (bookStore != null)
            {
                bookStore.Dispose();
            }
        }
    }
}
