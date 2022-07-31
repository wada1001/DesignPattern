using System;

namespace PizzaStore
{
    public class SimplePizzaFactory
    {
        public Pizza Create(Pizza.PizzaType type)
        {
            return null;
            //switch (type)
            //{
            //    case Pizza.PizzaType.Cheese:
            //        return new CheesePiza();
            //    case Pizza.PizzaType.Pepperoni:
            //        return new PepperoniPiza();
            //    case Pizza.PizzaType.Clam:
            //        return new ClamPiza();
            //    case Pizza.PizzaType.Veggie:
            //        return new VeggiePiza();
            //    default:
            //        throw new Exception("pizza not exists");
            //}
        }
    }
}
