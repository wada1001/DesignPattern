using System;

namespace SimUDuck.Models
{
    public class NormalQuack : QuackBehaviour
    {
        int count;

        public NormalQuack(int count = 1)
        {
            this.count = count;
        }

        public void Quack()
        {
            for (int i = 0; i < count; i++) Console.WriteLine("quack !!");
        }
    }
}
