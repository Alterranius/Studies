using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Chains
{
    public class Client
    {
        public void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.Successor = h2;
            h1.HandleRequest(2); // Простое делегирование
        }
    }
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // Предобработка
            if (condition == 1)
            {
                // Логика реакции
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // Предобработка
            if (condition == 2)
            {
                // Логика реакции
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
    // Пример цепочки
    public class Receiver
    {
        public bool BankTransfer { get; set; }
        public bool MoneyTransfer { get; set; }
        public bool PayPalTransfer { get; set; }
        public Receiver(bool bt, bool mt, bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
    public abstract class PaymentHandler
    {
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
    public class BankPaymentHandle : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
    public class MoneyPaymentHandle : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Перевод через денежные переводы");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
    public class PayPalPaymentHandle : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("Перевод через PayPal");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
}
