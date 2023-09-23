using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.ComplexCommands
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }

    public class TVOnCommand : ICommand
    {
        private TV tv;
        public TVOnCommand(TV tvSet)
        {
            tv = tvSet;
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

    public class Volume // Receiver №2
    {
        public const int OFF = 0;
        public const int START = 8;
        public const int HIGH = 20;
        private int level;

        public Volume()
        {
            level = START;
        }

        public void RaiseLevel()
        {
            if (level < HIGH)
                level++;
            Console.WriteLine("Уровень звука {0}", level);
        }
        public void DropLevel()
        {
            if (level > OFF)
                level--;
            Console.WriteLine("Уровень звука {0}", level);
        }
    }
    public class VolumeCommand : ICommand // Команда
    {
        private Volume volume;
        public VolumeCommand(Volume v)
        {
            volume = v;
        }
        public void Execute()
        {
            volume.RaiseLevel();
        }

        public void Undo()
        {
            volume.DropLevel();
        }
    }
    public class MultiPult // Invoker Инициализатор команд
    {
        private ICommand[] buttons;
        private Stack<ICommand> commandsHistory; // Стек истории команд
        public MultiPult()
        {
            buttons = new ICommand[2];
            commandsHistory = new Stack<ICommand>(); // Создание пустого стека (инициализация лога)
        }
        public void SetCommand(int index, ICommand command)
        {
            buttons[index] = command;
        }
        public void PressButton(int number)
        {
            buttons[number].Execute();
            commandsHistory.Push(buttons[number]); // Логгирование
        }
        public void PressUndoButton()
        {
            if (commandsHistory.Count > 0)
            {
                ICommand undoCommand = commandsHistory.Pop();
                undoCommand.Undo();
            }
        }
    }
    public class Client
    {
        public void Main()
        {
            TV tv = new TV();
            Volume volume = new Volume();
            MultiPult pult = new MultiPult();

            pult.SetCommand(0, new TVOnCommand(tv));
            pult.SetCommand(1, new VolumeCommand(volume));

            pult.PressButton(0);
            pult.PressButton(1);
            pult.PressButton(1);
            pult.PressButton(1);

            pult.PressUndoButton();
            pult.PressUndoButton();
            pult.PressUndoButton();
            pult.PressUndoButton();
        }
    }
}
