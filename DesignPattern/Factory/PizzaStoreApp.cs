using System;

namespace PizzaStore
{
    public static class PizzaStoreApp
    {
        public static void Perform()
        {
            var ny = new NYStyleStore();
            var chicago = new ChicagoStyleStore();

            var nyCheese = ny.OrderPizza(Pizza.PizzaType.Cheese);
            var chicagoCheese = chicago.OrderPizza(Pizza.PizzaType.Cheese);
        }
    }
}
