using System;
namespace PizzaStore
{
    public interface IngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public Veggie[] CreateVeggie();
        public Pepperoni CreatePepperoni();
        public Clam CreateClam();
    }
}
