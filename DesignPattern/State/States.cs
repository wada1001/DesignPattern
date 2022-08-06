using System;
namespace MightyGumball
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }

    public class SoldState : IState
    {
        GumballMachine machine;

        public SoldState(GumballMachine machine) => this.machine = machine;

        public void Dispense()
        {
            Console.WriteLine("dispense gumball");
            machine.ReleaseBall();

            Console.WriteLine("gumball remain = " + machine.Count.ToString());
            if (machine.Count > 0)
            {
                machine.SetState(machine.NoQuarter);
            }
            else
            {
                machine.SetState(machine.Soldout);
            }
        }

        public void EjectQuarter() => Console.WriteLine("Invalid Action");
        public void InsertQuarter() => Console.WriteLine("Invalid Action");
        public void TurnCrank() => Console.WriteLine("Invalid Action");
    }

    public class SoldOutState : IState
    {
        GumballMachine machine;

        public SoldOutState(GumballMachine machine) => this.machine = machine;

        public void Dispense() => Console.WriteLine("Invalid Action");
        public void EjectQuarter() => Console.WriteLine("Invalid Action");
        public void InsertQuarter() => Console.WriteLine("Invalid Action");
        public void TurnCrank() => Console.WriteLine("Invalid Action");
    }

    public class NoQuarterState : IState
    {
        GumballMachine machine;

        public NoQuarterState(GumballMachine machine) => this.machine = machine;

        public void Dispense() => Console.WriteLine("Invalid Action");
        public void EjectQuarter() => Console.WriteLine("Invalid Action");

        public void InsertQuarter()
        {
            Console.WriteLine("insert 25cent");
            machine.SetState(machine.HasQuarter);
        }

        public void TurnCrank() => Console.WriteLine("Invalid Action");
    }

    public class HasQuarterState : IState
    {
        GumballMachine machine;

        public HasQuarterState(GumballMachine machine) => this.machine = machine;

        public void Dispense() => Console.WriteLine("Invalid Action");

        public void EjectQuarter()
        {
            Console.WriteLine("eject 25cent");
            machine.SetState(machine.NoQuarter);
        }

        public void InsertQuarter() => Console.WriteLine("Invalid Action");

        public void TurnCrank()
        {
            Console.WriteLine("turn crank");

            DateTimeOffset dto = DateTimeOffset.Now;
            var rand = new Random((int)dto.ToUnixTimeSeconds());
            if (rand.Next(100) <= 10 && machine.Count > 1)
            {
                machine.SetState(machine.Winner);
            } else
            {
                machine.SetState(machine.Sold);
            }
        }
    }

    public class WinnerState : IState
    {
        GumballMachine machine;

        public WinnerState(GumballMachine machine) => this.machine = machine;

        public void Dispense()
        {
            Console.WriteLine("double gumball");
            machine.ReleaseBall();
            machine.ReleaseBall();

            Console.WriteLine("gumball remain = " + machine.Count.ToString());
            if (machine.Count > 0)
            {
                machine.SetState(machine.NoQuarter);
            }
            else
            {
                machine.SetState(machine.Soldout);
            }
        }

        public void EjectQuarter() => Console.WriteLine("Invalid Action");
        public void InsertQuarter() => Console.WriteLine("Invalid Action");
        public void TurnCrank() => Console.WriteLine("Invalid Action");
    }
}
