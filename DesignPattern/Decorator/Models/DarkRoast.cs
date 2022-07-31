using System;

namespace StarBuzzCoffee
{
    public class DarkRoast : Beverage
    {
        public override int Cost() => 99;
        public override string GetDescription() => "DarkRoast";
        public override Size GetSize() => size;
    }
}
