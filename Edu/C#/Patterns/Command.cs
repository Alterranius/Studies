using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Commands
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
    public class ConcreteCommand : Command // Сама команда
    {
        private Receiver receiver;
        public ConcreteCommand(Receiver _receiver)
        {
            receiver = _receiver; // Делегирование команды
        }
        public override void Execute()
        {
            receiver.Operation();
        }
        public override void Undo()
        {
        }
    }
    public class Receiver // Получатель команды
    {
        public void Operation() // Действие при команде
        {
        }
    }
    public class Invoker // Инициатор команды
    {
        private List<Command> commands;
        public void AddCommand(Command command)
        {
            commands.Add(command);
        }
        public void Run() // Управление очередями
        {
            foreach (Command command in commands)
            {
                command.Execute();
            }
        }
        public void Undo(int index)
        {
            commands[index].Undo();
        }
    }
    public class Client
    {
        public void Main()
        {
            Invoker invoker = new Invoker(); // Инициализатор
            Receiver receiver = new Receiver(); // Получатель
            ConcreteCommand command = new ConcreteCommand(receiver); // Делегирование
            invoker.AddCommand(command);
            invoker.Run(); // Вызов исполнения
        }
    }

    // Пример Command

    public interface ICommand
    {
        void Execute();
        void Undo();
    }
    public class TV // Получатель
    {
        public void On()
        {
            Console.WriteLine("Телевизор включён");
        }
        public void Off()
        {
            Console.WriteLine("Телевизор выключен");
        }
    }
    public class TVOnCommand : ICommand
    {
        private TV tv;

        public TVOnCommand(TV _tv)
        {
            tv = _tv;
        }

        public void Execute()
        {
            tv.On();
        }

        public void Undo()
        {
            tv.Off();
        }
    }
    public class Pult // Инициализатор
    {
        private ICommand command;
        public void SetCommand(ICommand _command)
        {
            command = _command;
        }
        public void PressOnButton()
        {
            if (command != null)
                command.Execute();
        }
        public void PressOffButton()
        {
            if (command != null)
                command.Undo();
        }
    }

    // Ещё один пример команды
    public class Microwave
    {
        public void StartCooking(int time)
        {
            Console.WriteLine("Подогреваем еду");
            // имитация работы с помощью асинхронного метода Task.Delay
            Task.Delay(time).GetAwaiter().GetResult();
        }

        public void StopCooking()
        {
            Console.WriteLine("Еда подогрета!");
        }
    }
    public class MicrowaveCommand : ICommand
    {
        private Microwave microwave;
        private int time;
        public MicrowaveCommand(Microwave m, int t)
        {
            microwave = m;
            time = t; // Передача времени в качестве параметра команды
        }
        public void Execute()
        {
            microwave.StartCooking(time);
            microwave.StopCooking();
        }

        public void Undo()
        {
            microwave.StopCooking();
        }
    }
}
