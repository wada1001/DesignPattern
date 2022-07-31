using System;

namespace PizzaStore
{
    public class NYStyleStore : Store
    {
        protected override Pizza CreatePizza(Pizza.PizzaType type)
        {
            var factory = new NyIngredientFactory();

            switch (type)
            {
                case Pizza.PizzaType.Cheese:
                    return new CheesePiza(factory) { cheezeValue = 100};
                case Pizza.PizzaType.Pepperoni:
                    return new PepperoniPiza(factory) { pepperroniValue = 100 };
                case Pizza.PizzaType.Clam:
                    return new ClamPiza(factory) { clamValue = 100 };
                case Pizza.PizzaType.Veggie:
                    return new VeggiePiza(factory) { veggieValue = 100 };
                default:
                    throw new Exception("pizza not exists");
            }
        }
    }
}
