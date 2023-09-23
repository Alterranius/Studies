using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.FactoryModified
{
    public static class CreatorModified
    {
        public static Product PlantProduct(string prodName)
        {
            if (prodName == "ProductA")
            {
                return new ProductA();
            }
            if (prodName == "ProductB")
            {
                return new ProductB();
            }
            else
            {
                return null;
            }
        }
    }
    public abstract class Product // Продукт
    {
        private List<Product> products;
        public Product()
        {
        }
        public Product(string prodName)
        {
            products.Add(CreatorModified.PlantProduct(prodName));
        }
       
    }
    public class ProductA : Product
    {
        public ProductA()
        {
        }
    }
    public class ProductB : Product
    {
        public ProductB()
        {
        }
    }
}
