using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Singleton
{
    public class Singleton
    {
        private static Singleton instance; // Экземпляр синглтона
        private Singleton() // Приватный конструктор
        {

        }
        public static Singleton GetInstance() // Получение экземпляра или его создание единым образом
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }

        // Пример на использовании

        public class Computer
        {
            private OS oS;

            public void Launch(string osName)
            {
                OS = OS.GetInstance(osName);
            }

            public OS OS { get => oS; set => oS = value; }
        }
        public class OS // Пример синглтона
        {
            private static OS instance;
            protected OS(string name)
            {
                Name = name;
            }

            public string Name { get; private set; }

            public static OS GetInstance(string name)
            {
                if (instance == null)
                {
                    instance = new OS(name);
                }
                return instance;
            }
        }

        // Пример с ленивой реализацией

        public class SingletonLazy
        {
            private class Nested
            {
                internal static readonly SingletonLazy lazy = new SingletonLazy();
            }
            public static string text = "hello";
            public string Date { get; private set; }

            private SingletonLazy()
            {
                Date = DateTime.Now.ToString();
            }
            public static SingletonLazy GetInstance()
            {
                Console.WriteLine($"Имя получено: {text}");
                return Nested.lazy;
            }
        }
    }
}
