using System;
using System.Runtime.CompilerServices;

namespace ChocolateFactory
{
    public class ChocolateBoiler
    {
        private static ChocolateBoiler instance = new ChocolateBoiler();

        private ChocolateBoiler() { }

        public ChocolateBoiler GetInstance() => instance;
    }

    public class ChocolateBoiler2
    {
        // thread safe
        private static ChocolateBoiler2 instance = new ChocolateBoiler2();

        private ChocolateBoiler2() { }

        // lot of costs
        [MethodImpl(MethodImplOptions.Synchronized)]
        public ChocolateBoiler2 GetInstance()
        {
            if (instance != null) return instance;

            // not safe
            instance = new ChocolateBoiler2();
            return instance;
        }
    }
}
