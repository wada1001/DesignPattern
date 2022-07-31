using System;

namespace StarBuzzCoffee
{
    public class Milk : CondimentDecorator
    {
        public Milk(Beverage beverage) : base(beverage) {}

        public override int Cost() => beverage.Cost() + 10;
        public override string GetDescription() => "Milk" + beverage.GetDescription();
        public override Size GetSize() => size;
    }
}
