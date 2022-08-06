using System;
namespace StarBuzzCoffee2
{
    public static class StarBuzzCoffeeApp
    {
        public static void Perform()
        {
            var coffee = new Coffee();
            var tea = new Tea(false);

            coffee.PrepareRecipe();
            tea.PrepareRecipe();


        }
    }
}
