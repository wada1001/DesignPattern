using System;
using System.Collections.Generic;

namespace CorporateMerger
{
    public class MenuItem : MenuComponent
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Vegetarian { get; private set; }
        public double Price { get; private set; }

        public MenuItem(
            string name,
            string description,
            bool vegetarian,
            double price
        ) {
            this.Name = name;
            this.Description = description;
            this.Vegetarian = vegetarian;
            this.Price = price;
        }

        public override string GetName() => Name;
        public override string GetDescription() => Name;
        public override double GetPrice() => Price;
        public override bool IsVegeterian() => Vegetarian;

        public override void Print() => Console.WriteLine("name = " + Name + " desc = " + Description + " price = " + Price);
    }

    public class Menu : MenuComponent
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        List<MenuComponent> menuItems = new List<MenuComponent>();

        public Menu(
            string name,
            string description
        ) {
            this.Name = name;
            this.Description = description;
        }

        public override string GetName() => Name;
        public override string GetDescription() => Name;

        public override void Add(MenuComponent component) => menuItems.Add(component);
        public override void Remove(MenuComponent component) => menuItems.Remove(component);
        public override MenuComponent GetChild(int index) => menuItems[index];

        public override void Print()
        {
            Console.WriteLine("name = " + Name + " desc = " + Description);
            menuItems.ForEach(x => x.Print());
        }
    }

    public class PancakeHouseMenu
    {
        List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>() {};
            AddMenu("breakfast pancake", "egg, toast, pancake", true, 2.99);
            AddMenu("classic pancake", "egg, meat, pancake", false, 2.99);
            AddMenu("blueberry pancake", "blueberry, pancake", true, 3.49);
            AddMenu("waffle", "blueberry, pancake", true, 3.59);
        }

        public void AddMenu(string name, string desc, bool veggie, double price)
        {
            menuItems.Add(new MenuItem(name, desc, veggie, price));
        }

        public IIterator<MenuItem> GetIterator()
        {
            return new PancakeIterator(menuItems);
        }
    }

    public class DinerMenu
    {
        const int MENU_MAX = 6;

        public MenuItem[] menuItems { get; private set; }
        

        public DinerMenu()
        {
            menuItems = new MenuItem[MENU_MAX];
            AddMenu("vegetarian blt", "lettuce, tomato, sandwitch", true, 2.99);
            AddMenu("blt", "lettuce, tomato, bacon", false, 3.29);
            AddMenu("soup", "today soup, potaosalada", false, 3.29);
            AddMenu("hotdog", "sauekraut, onion, cheese, hotdog", false, 3.05);
        }

        public void AddMenu(string name, string desc, bool veggie, double price)
        {
            for (int i=0;i<MENU_MAX;i++)
            {
                if (menuItems[i] != null) continue;

                menuItems[i] = new MenuItem(name, desc, veggie, price);
                return;
            }

            Console.WriteLine("menu is full !!");
        }

        public IIterator<MenuItem> GetIterator()
        {
            return new DinerIterator(menuItems);
        }
    }

    public class PancakeIterator : IIterator<MenuItem>
    {
        List<MenuItem> menuItems;
        int position = 0;

        public PancakeIterator(List<MenuItem> menuItems) => this.menuItems = menuItems;

        public bool HasNext()
        {
            return position < menuItems.Count;
        }

        public MenuItem Next()
        {
            Console.WriteLine(position);
            var tmp = menuItems[position];
            position++;
            return tmp;
        }
    }

    public class DinerIterator : IIterator<MenuItem>
    {
        public MenuItem[] menuItems { get; private set; }
        int position = 0;

        public DinerIterator(MenuItem[] menuItems) => this.menuItems = menuItems;

        public bool HasNext()
        {
            //Console.WriteLine(position);
            return menuItems.Length > position && menuItems[position] != null;
        }

        public MenuItem Next()
        {
            Console.WriteLine(position); 
            var tmp = menuItems[position];
            position++;
            return tmp;
        }
    }

    // Composite
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent component) => throw new NotImplementedException("should implement");
        public virtual void Remove(MenuComponent component) => throw new NotImplementedException("should implement");
        public virtual MenuComponent GetChild(int index) => throw new NotImplementedException("should implement");

        public virtual string GetName() => throw new NotImplementedException("should implement");
        public virtual string GetDescription() => throw new NotImplementedException("should implement");
        public virtual double GetPrice() => throw new NotImplementedException("should implement");
        public virtual bool IsVegeterian() => throw new NotImplementedException("should implement");
        public virtual void Print() => throw new NotImplementedException("should implement");
    }


}
