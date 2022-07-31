using System;

namespace PizzaStore
{
    public abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggie[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clam clam;

        public enum PizzaType
        {
            Cheese,
            Pepperoni,
            Clam,
            Veggie
        }

        public virtual void Prepare() => Console.WriteLine("prepare " + name);
        public virtual void Bake() => Console.WriteLine("bake " + name);
        public virtual void Cut() => Console.WriteLine("cut " + name);
        public virtual void Box() => Console.WriteLine("boxing " + name);
    }

    public class CheesePiza : Pizza
    {
        public int cheezeValue;
        protected IngredientFactory factory;

        public CheesePiza(IngredientFactory factory)
        {
            this.factory = factory;
            name = "cheese";
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("add cheeze = " + cheezeValue.ToString());

            this.cheese = factory.CreateCheese();
            this.veggies = factory.CreateVeggie();
            this.sauce = factory.CreateSauce();
            this.clam = factory.CreateClam();
            this.dough = factory.CreateDough();
        }
    }

    public class PepperoniPiza : Pizza
    {
        public int pepperroniValue;
        protected IngredientFactory factory;

        public PepperoniPiza(IngredientFactory factory)
        {
            this.factory = factory;
            name = "pepperroni";
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("add pepperroni = " + pepperroniValue.ToString());

            this.cheese = factory.CreateCheese();
            this.veggies = factory.CreateVeggie();
            this.sauce = factory.CreateSauce();
            this.clam = factory.CreateClam();
            this.dough = factory.CreateDough();
        }
    }

    public class ClamPiza : Pizza
    {
        public int clamValue;
        protected IngredientFactory factory;

        public ClamPiza(IngredientFactory factory)
        {
            this.factory = factory;
            name = "clam";
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("add clam = " + clamValue.ToString());

            this.cheese = factory.CreateCheese();
            this.veggies = factory.CreateVeggie();
            this.sauce = factory.CreateSauce();
            this.clam = factory.CreateClam();
            this.dough = factory.CreateDough();
        }
    }

    public class VeggiePiza : Pizza
    {
        public int veggieValue;
        protected IngredientFactory factory;

        public VeggiePiza(IngredientFactory factory)
        {
            this.factory = factory;
            name = "veggie";
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine("add veggie = " + veggieValue.ToString());

            this.cheese = factory.CreateCheese();
            this.veggies = factory.CreateVeggie();
            this.sauce = factory.CreateSauce();
            this.clam = factory.CreateClam();
            this.dough = factory.CreateDough();
        }
    }

    public class Dough { public int amount; }
    public class Sauce { public int amount; }
    public class Cheese { public int amount; }
    public class Veggie { public string name; public int amount; }
    public class Pepperoni { public int amount; }
    public class Clam { public int amount; }
}
