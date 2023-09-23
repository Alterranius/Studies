using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Templates
{
    public abstract class Education
    {
        public void Educate()
        {
            Enter();
            Learn();
            PassExam();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Learn();
        public virtual void PassExam()
        {
            Console.WriteLine("Пройти экзамены");
        }
        public abstract void GetDocument();
    }
    public class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }

        public override void Learn()
        {
            Console.WriteLine("Посещаем уроки, делаем домашние задания");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат о среднем образовании");
        }
    }
    public class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены и поступаем в ВУЗ");
        }

        public override void Learn()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }

        public override void PassExam()
        {
            Console.WriteLine("Сдаем экзамен по специальности");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом о высшем образовании");
        }
    }
}
