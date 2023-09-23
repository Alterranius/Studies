using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Bridges
{
    public class Client
    {
        public void Main()
        {
            Abstraction abstraction = new RefAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
    public abstract class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor { get => implementor; set => implementor = value; }
        public Abstraction(Implementor imp)
        {
            implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
    public abstract class Implementor
    {
        public abstract void OperationImp();
    }
    public class RefAbstraction : Abstraction
    {
        public RefAbstraction(Implementor imp) : base(imp)
        {
        }
        public override void Operation()
        {
            // Действие для реализации поведения
        }
    }

    public class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
            // Реализация действия
        }
    }
    public class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
            // Реализация действия
        }
    }


    // Пример Моста

    public abstract class Report
    {
        protected FileType fileType;
        private readonly string name;
        public FileType FileType { get => fileType; set => fileType = value; }

        public Report(FileType _fileType, string _name)
        {
            fileType = _fileType;
            name = _name;
        }
        public virtual void PrintReport()
        {
            fileType.FilePrint();
        }
    }
    public abstract class FileType
    {
        public abstract void FilePrint();
    }
    public class YearReport : Report
    {
        public YearReport(FileType _fileType, string _name) : base(_fileType, _name)
        {
        }
        public override void PrintReport()
        {
            base.PrintReport();
            Console.WriteLine("Годовой отчёт сохранён");
        }
    }
    public class DayReport : Report
    {
        public DayReport(FileType _fileType, string _name) : base(_fileType, _name)
        {
        }
        public override void PrintReport()
        {
            base.PrintReport();
            Console.WriteLine("Годовой отчёт сохранён");
        }
    }
    public class DocxFormat : FileType
    {
        public override void FilePrint()
        {
            Console.WriteLine("Печать в docx");
        }
    }
    public class XlsFormat : FileType
    {
        public override void FilePrint()
        {
            Console.WriteLine("Печать в docx");
        }
    }
}
