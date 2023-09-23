using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Facades
{
    public class Client
    {
        public void Main()
        {
            // Допущена вольность в управлении скрываемой логикой
            Facade facade = new Facade(new SubsystemA(), new SubsystemB(), new SubsystemC());
            facade.Operation1();
            facade.Operation2();
        }
    }
    public class Facade
    {
        private SubsystemA subsystemA;
        private SubsystemB subsystemB;
        private SubsystemC subsystemC;
        // Вообще говоря, может потребовать строгой композиции
        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            subsystemA = sa;
            subsystemB = sb;
            subsystemC = sc;
        }
        public void Operation1()
        {
            subsystemA.A1();
            subsystemB.B1();
            subsystemC.C1();
        }
        public void Operation2()
        {
            subsystemB.B1();
            subsystemC.C1();
        }
    }
    public class SubsystemA
    {
        public void A1()
        {
        }
    }
    public class SubsystemB
    {
        public void B1()
        {
        }
    }
    public class SubsystemC
    {
        public void C1()
        {
        }
    }
}
