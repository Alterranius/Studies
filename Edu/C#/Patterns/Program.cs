using Patterns.AbstractFactory;
using Patterns.Adapters;
using Patterns.Composites;
using Patterns.Decorators;
using Patterns.FabricMethodology;
using Patterns.Proxies;
using System;
using static Patterns.Singleton.Singleton;
using Patterns.Bridges;
using Patterns.Iterators;
using Patterns.Commands;
using Patterns.States;
using Patterns.Strategies;
using Patterns.Visitors;
using Patterns.Chains;
using Patterns.Templates;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            Computer computer = new Computer();
            computer.Launch("Win 8");
            Console.WriteLine(computer.OS.Name); // Здесь будет Win 8

            computer.OS = Singleton.Singleton.OS.GetInstance("Win 10"); // Изменения не будет, так как объект создан

            // Abstract Factory
            AbstractFactory.Client client = new AbstractFactory.Client(new ConcreteFactory1());

            // Factory Method (Original)
            Developer panelDeveloper = new PanelDeveloper("СтройЮгИнвест");
            House panelHouse = panelDeveloper.DevelopeHouse();

            Developer woodDeveloper = new WoodDeveloper("СрубПРО");
            House woodHouse = woodDeveloper.DevelopeHouse();

            // Адаптер
            Driver driver = new Driver();
            Auto auto = new Auto();
            driver.Travel(auto);
            Camel camel = new Camel();

            IAuto camelAuto = new CamelToAutoAdapter(camel);
            driver.Travel(camelAuto);

            // Ещё один пример адаптера
            Musician musician = new Musician();
            Accordion accordion = new Accordion();
            Piano piano = new Piano();
            IInstrumet accordionInstrumet = new AccordionInstrumentAdapter(accordion);
            IInstrumet pianoInstrumet = new PianoInstrumentAdapter(piano);

            musician.Play(accordionInstrumet);
            musician.Play(pianoInstrumet);


            // Декоратор
            Pizza pizza = new ItalianPizza(); // Создание объекта
            pizza = new TomatoPizza(pizza); // Наращивание функционала

            Pizza pizza2 = new BulgerianPizza();
            pizza2 = new TomatoPizza(pizza2); // Первое наращиваение
            pizza2 = new CheesePizza(pizza2); // Болгарская питца с томатом и сыром

            Pizza masterPizza = new ItalianPizza();
            masterPizza = new TomatoPizza(new CheesePizza(masterPizza)); // Уменьшенный вызов

            Pizza fullPizza = new TomatoPizza(new CheesePizza(new ItalianPizza())); // Сжатый вызов

            // Прокси
            IBook book = new BookStoreProxy(); // Создание контекста ПРОКСИ
            Page page1 = book.GetPage(1); // Использование ПРОКСИ для извлечения значения
            Console.WriteLine(page1.Text);

            Page page2 = book.GetPage(2);
            Console.WriteLine(page2.Text);

            page1 = book.GetPage(1);

            // Компоновщик: Пример с файловой системой
            Composites.Component fileSystem = new Composite("Файловая система");
            Composites.Component diskC = new Composite("Диск С");
            Composites.Component pngFile = new Leaf("Картинка.png");
            Composites.Component docxFile = new Leaf("Документ.docx");

            diskC.Add(pngFile);
            diskC.Add(docxFile);

            fileSystem.Add(diskC);
            fileSystem.Display();

            // Мост: пример с отчётом
            Report dayReport = new DayReport(new XlsFormat(), "Отчёт 23.05");
            dayReport.PrintReport();
            dayReport.FileType = new DocxFormat();
            dayReport.PrintReport();

            // Фасад примера не требует

            // Итератор: пример с библиотекой
            Library library = new Library();
            Iterators.Client reader = new Iterators.Client();
            reader.SeeBooks(library);

            // Команда: телевизор и пульт
            Pult pult = new Pult();
            TV tv = new TV();
            pult.SetCommand(new TVOnCommand(tv));
            pult.PressOnButton();
            pult.PressOffButton();

            Microwave microwave = new Microwave();
            pult.SetCommand(new MicrowaveCommand(microwave, 5000));
            pult.PressOnButton();

            // Состояние: пример с физическими состояниями вещества
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Heat();

            // Стратегия: пример с машиной
            Car car = new Car(4, "Volvo", new PetrolMove());
            car.Move();
            car.Movable = new ElectroMove();
            car.Move();

            // Наблюдатель не нуждается в примере

            // Посетитель: пример с банками
            var structure = new Bank();
            structure.Add(new Person { Name = "Виктор", Number = "2281488" });
            structure.Add(new Company { Name = "Salamandra", RegNumber = "228", Number = "1488" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

            // Цепочка обязанностей: выбор способа перевода
            Chains.Receiver receiver = new Chains.Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandle();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandle();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandle();
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHandler;

            bankPaymentHandler.Handle(receiver);

            // Шаблонный метод пример
            School school = new School();
            University university = new University();
            school.Educate();
            university.Educate();
        }
    }
}
