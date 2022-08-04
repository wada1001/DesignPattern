using System;
namespace TurkeyAdapter
{
    public static class TurkeyAdapterApp
    {
        public static void Perform()
        {
            Turkey turkey = new WildTurkey();
            Duck adapter = new TurkeyAdapter(turkey);

            adapter.Quack();
            adapter.Fly();
        }

    }
}
