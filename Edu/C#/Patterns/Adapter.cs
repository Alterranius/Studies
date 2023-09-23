using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Adapters
{
    public class Adapter : Target // Адаптер, позволяет работать с Adaptee как с Target
    {
        private Adaptee adaptee = new Adaptee();
        public Adapter()
        {
        }
        public override void Request()
        {
            adaptee.SpecificRequest(); // Уточнение запроса для Adaptee
        }
    }
    public class Adaptee // Адаптируемый класс, то что на самом деле хочет клиент
    {
        public void SpecificRequest()
        {

        }
    }
    public class Client // Использует объект Target для задач
    {
        public Client()
        {
        }
        public void Request(Target target)
        {
            target.Request();
        }
    }
    public class Target // Цель для адаптации (во что)
    {
        public Target()
        {
        }
        public virtual void Request() // Метод
        {

        }
    }

    // Пример адаптера

    public interface IAuto
    {
        void Drive();
    }
    public class Auto : IAuto
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
    public class Driver
    {
        public void Travel(IAuto auto)
        {
            auto.Drive();
        }
    }

    public interface IAnimal
    {
        void Move();
    }
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идёт в песках");
        }
    }
    public class CamelToAutoAdapter : IAuto
    {
        Camel camel;

        public CamelToAutoAdapter(Camel camel)
        {
            this.camel = camel;
        }

        public void Drive()
        {
            camel.Move();
        }
    }

    // Ещё пример адаптера

    public class Musician
    {
        public void Play(IInstrumet instrumet)
        {
            instrumet.Use();
        }
    }
    public interface IInstrumet // Реализация в терминах клиента
    {
        void Use();
    }
    public class AccordionInstrumentAdapter : IInstrumet
    {
        private Accordion accordion;

        public AccordionInstrumentAdapter(Accordion accordion)
        {
            this.accordion = accordion;
        }

        public void Use()
        {
            accordion.Use();
        }
    }

    public class PianoInstrumentAdapter : IInstrumet // Адаптер для муз инструмента
    {
        private Piano piano;

        public PianoInstrumentAdapter(Piano piano)
        {
            this.piano = piano;
        }

        public void Use()
        {
            piano.Use();
        }
    }
    public class Accordion : IInstrumet // Один применитель
    {
        public void Use()
        {
            Console.WriteLine("Мехаа");
        }
    }
    public class Piano : IInstrumet // Второй применитель
    {
        public void Use()
        {
            Console.WriteLine("Педалькии");
        }
    }
}
