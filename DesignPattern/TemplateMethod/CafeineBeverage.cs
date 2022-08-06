using System;
namespace StarBuzzCoffee2
{
    public abstract class CafeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (WantsCondiment()) AddCondiments();
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();
        protected virtual bool WantsCondiment() => true;

        protected void BoilWater() => Console.WriteLine("boil water");
        protected void PourInCup() => Console.WriteLine("pour in cup");
    }

    public class Coffee : CafeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("add suger");
            Console.WriteLine("add milk");
        }

        protected override void Brew() => Console.WriteLine("brew coffee");
    }

    public class Tea : CafeineBeverage
    {
        bool needCondiment;

        public Tea(bool needCondiment = true) => this.needCondiment = needCondiment;

        protected override void AddCondiments()
        {
            Console.WriteLine("add remon");
        }

        protected override void Brew() => Console.WriteLine("brew tea");
        protected override bool WantsCondiment() { return needCondiment; }
    }
}
