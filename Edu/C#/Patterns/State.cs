using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.States
{
    public class Context
    {
        public Context(State state)
        {
            State = state;
        }
        public State State { get; set; }
        public void Request()
        {
            State.Handle(this);
        }
    }
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
    public class StateA : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateA();
        }
    }
    public class StateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new StateB();
        }
    }
    // Пример состояния

    public interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }
    public class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }
    }
    public class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед");
            water.State = new SolidWaterState();
        }
    }
    public class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в жидкость");
            water.State = new LiquidWaterState();
        }
    }
    public class Water
    {
        public Water(IWaterState ws)
        {
            State = ws;
        }
        public IWaterState State { get; set; }
        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }
}
