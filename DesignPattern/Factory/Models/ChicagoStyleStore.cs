using System;

namespace PizzaStore
{
    public class ChicagoStyleStore : Store
    {
        protected override Pizza CreatePizza(Pizza.PizzaType type)
        {
            var factory = new ChicagoIngredientFactory();

            switch (type)
            {
                case Pizza.PizzaType.Cheese:
                    return new CheesePiza(factory) { cheezeValue = 200 };
                case Pizza.PizzaType.Pepperoni:
                    return new PepperoniPiza(factory) { pepperroniValue = 200 };
                case Pizza.PizzaType.Clam:
                    return new ClamPiza(factory) { clamValue = 200 };
                case Pizza.PizzaType.Veggie:
                    return new VeggiePiza(factory) { veggieValue = 200 };
                default:
                    throw new Exception("pizza not exists");
            }
        }
    }
}
