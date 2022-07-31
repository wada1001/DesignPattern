using System;

namespace PizzaStore
{
    public class ChicagoIngredientFactory : IngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Cheese() { amount = 100 };
        }

        public Clam CreateClam()
        {
            return new Clam { amount = 100 };
        }

        public Dough CreateDough()
        {
            return new Dough() { amount = 100 };
        }

        public Pepperoni CreatePepperoni()
        {
            return new Pepperoni() { amount = 100 };
        }

        public Sauce CreateSauce()
        {
            return new Sauce() { amount = 100 };
        }

        public Veggie[] CreateVeggie()
        {
            return new Veggie[]
            {
                new Veggie(){ name = "Onion", amount = 100 },
                new Veggie(){ name = "Corn", amount = 100 },
            };
        }
    }
}
