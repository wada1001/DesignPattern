using System;

namespace DesignPattern.TemplateMethod
{
    // one of template method pattern
    public class Duck : IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(Duck other)
        {
            if (weight == other.weight) return 0;
            return weight > other.weight ? 1 : -1;
        }
    }
}
