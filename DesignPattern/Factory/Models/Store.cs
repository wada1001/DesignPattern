using System;
namespace PizzaStore
{
    public abstract class Store
    {
        public Pizza OrderPizza(Pizza.PizzaType type)
        {
            var pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(Pizza.PizzaType type);
    }
}
