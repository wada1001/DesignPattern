using System;

namespace PizzaStore
{
    public class NyIngredientFactory : IngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new Cheese() { amount = 200 };
        }

        public Clam CreateClam()
        {
            return new Clam { amount = 200 };
        }

        public Dough CreateDough()
        {
            return new Dough() { amount = 200 };
        }

        public Pepperoni CreatePepperoni()
        {
            return new Pepperoni() { amount = 200 };
        }

        public Sauce CreateSauce()
        {
            return new Sauce() { amount = 200 };
        }

        public Veggie[] CreateVeggie()
        {
            return new Veggie[]
            {
                new Veggie(){ name = "Onion", amount = 200 },
                new Veggie(){ name = "Corn", amount = 200 },
            };
        }
    }
}
