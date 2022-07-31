using System;

namespace StarBuzzCoffee
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage) { }

        public override int Cost()
        {
            switch(size)
            {
                case Size.Tall:
                return beverage.Cost() + 10;
                    case Size.Grande:
                return beverage.Cost() + 15;
                    case Size.Venti:
                return beverage.Cost() + 20;
                default:
                    return beverage.Cost() + 10;
            }
        }

        public override string GetDescription() => "Soy" + beverage.GetDescription();
        public override Size GetSize() => size;
    }
}
