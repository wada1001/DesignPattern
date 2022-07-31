using System;

namespace StarBuzzCoffee
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }

        public override int Cost() => beverage.Cost() + 20;
        public override string GetDescription() => "Mocha" + beverage.GetDescription();
        public override Size GetSize() => size;
    }
}
