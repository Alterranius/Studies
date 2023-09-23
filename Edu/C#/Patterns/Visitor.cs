using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Visitors
{
    public abstract class Visitor // Абстрактный посетитель
    {
        public abstract void VisitElementA(ElementA elementA);
        public abstract void VisitElementB(ElementB elementB);
    }
    public abstract class Element // Элемент, который посещают
    {
        public abstract void Accept(Visitor visitor);
        public string SomeState { get; set; }
    }
    public class ElementA : Element // Конкретный элемент 1
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA()
        {
        }
    }
    public class ElementB : Element // Конкретный элемент 2
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
        public void OperationB()
        {
        }
    }
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }
    public class ConcreteVisitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA(); // Двойная диспетчеризация
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }
    public class ObjectStructure // Структура, хранящая элементы и предоставляющая доступ
    {
        private List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Add(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }
        }
    }


    // Пример визитора

    public interface IVisitor // Можно использозвать не разные методы, а перегрузку одного
    {
        void VisitPersonAcc(Person acc); // Метод 1
        void VisitCompanyAcc(Company acc); // Метод 2
    }
    public class HtmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAcc(Company acc)
        {
            string result = "<table><tr><td>Свойство<td><td>Значение</td></tr>";
            result += "<tr><td>Name<td><td>" + acc.Name + "</td></tr>";
            result += "<tr><td>RegNumber<td><td>" + acc.RegNumber + "</td></tr>";
            result += "<tr><td>Number<td><td>" + acc.Number + "</td></tr></table>";
            Console.WriteLine(result);
        }
    }
    public class XmlVisitor : IVisitor
    {
        public void VisitPersonAcc(Person acc)
        {
            string result = "<Person><Name>" + acc.Name + "</Name>" +
                "<Number>" + acc.Number + "</Number><Person>";
            Console.WriteLine(result);
        }

        public void VisitCompanyAcc(Company acc)
        {
            string result = "<Company><Name>" + acc.Name + "</Name>" +
                "<RegNumber>" + acc.RegNumber + "</RegNumber>" +
                "<Number>" + acc.Number + "</Number><Company>";
            Console.WriteLine(result);
        }
    }
    public interface IAccount
    {
        void Accept(IVisitor visitor); 
    }
    public class Person : IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitPersonAcc(this);
        }
    }
    public class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAcc(this);
        }
    }
    public class Bank
    {
        private List<IAccount> accounts = new List<IAccount>();
        public void Add(IAccount acc)
        {
            accounts.Add(acc);
        }
        public void Remove(IAccount acc)
        {
            accounts.Remove(acc);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (IAccount acc in accounts)
                acc.Accept(visitor);
        }
    }
}
