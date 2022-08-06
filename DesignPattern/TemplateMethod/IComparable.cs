using System;
namespace StarBuzzCoffee2
{
    public interface IComparable<T> where T : new()
    {
        int CompareTo(T comparable);
    }
}
