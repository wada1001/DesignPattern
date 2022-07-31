using System;

namespace StarBuzzCoffee
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override int Cost() => beverage.Cost() + 10;
        public override string GetDescription() => "Whip" + beverage.GetDescription();
        public override Size GetSize() => size;
    }
}
