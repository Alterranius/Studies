using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Composites
{
    public abstract class Component // Является интерфейсом в древовидной структуре
    {
        protected string name;
        public Component(string _name)
        {
            name = _name;
        }
        public abstract void Display();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
    }
    public class Composite : Component // Является носителем других компонентов и может добавлять их и удалять
    {
        private List<Component> children = new List<Component>();
        public Composite(string _name) : base(_name)
        {

        }
        public override void Add(Component component)
        {
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display()
        {
            Console.WriteLine(name);
            foreach (Component component in children)
            {
                component.Display();
            }
        }
    }
    public class Leaf : Component // Отдельный атомарный компонент
    {
        public Leaf(string _name) : base(_name)
        {

        }
        public override void Display()
        {
            Console.WriteLine(name);
        }
        public override void Add(Component component)
        {
        }
        public override void Remove(Component component)
        {
        }
    }
    public class Client // Использует структуру
    {
        public void Main()
        {
            Component root = new Composite("Root");
            Component leaf = new Leaf("Leaf");
            Composite subtree = new Composite("Subtree");
            root.Add(leaf);
            root.Add(subtree);
            root.Display(); // Покажет текущий уровень дерева : лист и поддерево
        }
    }
}
