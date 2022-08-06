using System;
namespace CorporateMerger
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
