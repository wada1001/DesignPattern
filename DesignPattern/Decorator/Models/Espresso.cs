using System;

namespace StarBuzzCoffee
{
    public class Espresso : Beverage
    {
        public override int Cost() => 199;
        public override string GetDescription() => "Espresso";
        public override Size GetSize() => size;
    }
}
