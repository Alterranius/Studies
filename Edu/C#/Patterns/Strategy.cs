using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Strategies
{
    public abstract class Strategy
    {
        public abstract void Algorithm();
    }
    public class ConcreteStrategy1 : Strategy
    {
        public override void Algorithm()
        {
            
        }
    }
    public class ConcreteStrategy2 : Strategy
    {
        public override void Algorithm()
        {
            
        }
    }
    public class Context
    {
        public Strategy Strategy { get; set; }
        public Context(Strategy strategy)
        {
            Strategy = strategy;
        }
        public void ExecuteAlgorithm()
        {
            Strategy.Algorithm();
        }
    }

    // Пример стратегии

    public interface IMovable
    {
        void Move();
    }
    public class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }
    public class ElectroMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на электричестве");
        }
    }
    public class Car
    {
        protected int passengersAmount;
        protected string model;
        public IMovable Movable { private get; set; }

        public Car(int _num, string _model, IMovable _move)
        {
            passengersAmount = _num;
            model = _model;
            Movable = _move;
        }
        public void Move()
        {
            Movable.Move();
        }
    }
    public class Client
    {
        public void Main()
        {
            Car car = new Car(4, "Volvo", new PetrolMove());
            car.Move();
            car.Movable = new ElectroMove();
            car.Move();
        }
    }
}
