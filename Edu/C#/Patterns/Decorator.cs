using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Decorators
{
    public abstract class Component // Интерфейс, который нобходимо декорировать (интейрфейс сервера)
    {
        public abstract void Operation();
    }
    public class ConcreteComponent : Component // Реализация, в которую добавляется новый функционал
    {
        public override void Operation()
        {
            
        }
    }
    public abstract class Decorator : Component // Простой декоратор
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
    public class ConcreteDecoratorA : Decorator // Дополнительные функциональности А
    {
        public override void Operation()
        {
            base.Operation();
        }
    }
    public class ConcreteDecoratorB : Decorator // Дополнительные функциональности В
    {
        public override void Operation()
        {
            base.Operation();
        }
    }

    // Пример декоратора

    public abstract class Pizza
    {
        public Pizza(string name)
        {
            Name = name;
        }

        public string Name { get; protected set; }
        public abstract int GetCost();
    }

    public class ItalianPizza : Pizza // Вид питцы
    {
        public ItalianPizza() : base("Итальянская питца")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }

    public class BulgerianPizza : Pizza // Вид питцы
    {
        public BulgerianPizza() : base("Болгарская питса")
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }

    public abstract class PizzaDecorator : Pizza // Декоратор для наращивания функционала
    {
        protected Pizza pizza;
        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }
    public class TomatoPizza : PizzaDecorator // Декорирование нового типа пиццы
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + " с томатом", pizza)
        {

        }
        public override int GetCost()
        {
            return base.pizza.GetCost() + 3;
        }
    }

    public class CheesePizza : PizzaDecorator // Декорирование нового типа пиццы
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + " с сыром", pizza )
        {

        }
        public override int GetCost()
        {
            return base.pizza.GetCost() + 5;
        }
    }
}
