using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.AbstractFactory
{
    public abstract class AbstractFactory // Абстрактная фабрика
    {
        public abstract ProductA CreateProductA(); // Контракт создания продукта класса A
        public abstract ProductB CreateProductB(); // Контракт создания продукта класса B
    }

    public class ConcreteFactory1 : AbstractFactory // Реализация фабрики для вида 1
    {
        public override ProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
    public class ConcreteFactory2 : AbstractFactory // Реализация фабрики для вида 2
    {
        public override ProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override ProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
    public class Client
    {
        private ProductA productA;
        private ProductB productB;

        public Client(AbstractFactory factory) // Запрос на фабрику
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }
    }

    public abstract class ProductA
    {
        public ProductA()
        {
        }
    }
    public abstract class ProductB
    {
        public ProductB()
        {
        }
    }

    public class ProductA1 : ProductA
    {
        public ProductA1()
        {
        }
    }
    public class ProductA2 : ProductA
    {
        public ProductA2()
        {
        }
    }
    public class ProductB1 : ProductB
    {
        public ProductB1()
        {
        }
    }
    public class ProductB2 : ProductB
    {
        public ProductB2()
        {
        }
    }


    // Пример абстрактной фабрики для кнопки
    public class OS
    {
        private readonly Button button;
        public OS(AbsFactory factory)
        {
            button = factory.CreateButton();
        }

        public Button Button { get => button; }
    }

    public abstract class AbsFactory
    {
        public abstract Button CreateButton();
    }
    public class WinButtonFactory : AbsFactory
    {
        public override Button CreateButton()
        {
            return new WinButton();
        }
    }
    public class MacButtonFactory : AbsFactory
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }
    }

    public abstract class Button
    {
        public Button()
        {
        }
    }
    public class WinButton : Button
    {
        public WinButton()
        {
        }
    }
    public class MacButton : Button
    {
        public MacButton()
        {
        }
    }
}
