using System;

namespace StarBuzzCoffee
{
    public class HouseBlend : Beverage
    {
        public override int Cost() => 89;
        public override string GetDescription() => "HouseBlend";
        public override Size GetSize() => size;
    }
}
