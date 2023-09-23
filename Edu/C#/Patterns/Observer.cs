using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Observers
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber s);
        void RemoveSubscriber(ISubscriber s);
        void NotifySubscribers();
    }
    public class Publisher : IPublisher
    {
        private List<ISubscriber> subscribers;
        public Publisher()
        {
            subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update(null);
            }
        }

        public void RemoveSubscriber(ISubscriber s)
        {
            subscribers.Remove(s);
        }
    }
    public interface ISubscriber
    {
        void Update(object ob);
    }
    public class Subscriber : ISubscriber
    {
        public void Update(object ob)
        {
        }
    }

    // Пример подписчика

    public class Stock : IPublisher
    {
        private StockInfo sInfo;
        private List<ISubscriber> subscribers;
        public Stock()
        {
            subscribers = new List<ISubscriber>();
            sInfo = new StockInfo();
        }

        public void AddSubscriber(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update(sInfo);
            }
        }

        public void RemoveSubscriber(ISubscriber s)
        {
            subscribers.Remove(s);
        }
        public void Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(20, 41);
            sInfo.Euro = rnd.Next(30, 51);
            NotifySubscribers();
        }
    }
    public class StockInfo
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
    public class Broker : ISubscriber
    {
        public string Name { get; set; }
        private IPublisher stock;

        public Broker(string name, IPublisher publisher)
        {
            stock = publisher;
            Name = name;
            stock.AddSubscriber(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 30)
            {
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            }
            else
            {
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            }
        }
        public void StopTrade()
        {
            stock.RemoveSubscriber(this);
            stock = null;
        }
    }
    public class Bank : ISubscriber
    {
        public string Name { get; set; }
        private IPublisher stock;
        public Bank(string name, IPublisher publisher)
        {
            Name = name;
            stock = publisher;
            stock.AddSubscriber(this);
        }
        public void Update(object ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.Euro > 0)
            {
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            }
            else
            {
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            }
        }
    }
}
