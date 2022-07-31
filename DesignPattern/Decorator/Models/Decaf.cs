using System;

namespace StarBuzzCoffee
{
    public class Decaf : Beverage
    {
        public override int Cost() => 105;
        public override string GetDescription() => "Decaf";
        public override Size GetSize() => size;
    }
}
