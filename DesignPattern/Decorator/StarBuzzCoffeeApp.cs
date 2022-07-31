using System;
namespace StarBuzzCoffee
{
    public static class StarBuzzCoffeeApp
    {
        public static void Perform()
        {
            Beverage blend = new HouseBlend();
            blend = new Milk(blend);
            blend = new Mocha(blend);
            blend = new Mocha(blend);

            Console.WriteLine(blend.Cost());
            Console.WriteLine(blend.GetDescription());
        }

    }
}
