using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FabricMethodology
{
    public abstract class Creator // Мини-фабрика
    {
        public abstract Product CreateProduct();
    }
    public class CreatorA : Creator // Частная фабрика A
    {
        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
    public class CreatorB : Creator // Частная фабрика B
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }
    public abstract class Product // Продукт
    {
        private List<Product> products;
        public Product()
        {
        }
        public Product(Creator creator)
        {
            products.Add(creator.CreateProduct());
        }
    }
    public class ProductA : Product
    {

    }
    public class ProductB : Product
    {

    }


    // Пример реальизации фабричного метода

    
    public abstract class Developer
    {
        private string name;

        public Developer(string name)
        {
            this.name = name;
        }
        public abstract House DevelopeHouse();
    }

    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {
        }

        public override House DevelopeHouse()
        {
            return new PanelHouse();
        }
    }
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House DevelopeHouse()
        {
            return new WoodHouse();
        }
    }
    public abstract class House
    {

    }
    public class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом");
        }
    }
    public class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом");
        }
    }

}
