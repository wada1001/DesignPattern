using System;

namespace StarBuzzCoffee
{
    /// <summary>
    /// it can replace interface
    /// </summary>
    public abstract class Beverage
    {
        public enum Size {
            Tall,
            Grande,
            Venti
        }

        protected string description = "unknown";
        protected Size size = Size.Tall;

        public abstract int Cost();
        public abstract string GetDescription();
        public abstract Size GetSize();
        public void SetSize(Size size) { this.size = size; }
    }
}
