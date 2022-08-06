using System;
namespace MightyGumball
{
    public class GumballMachine
    {
        public IState Soldout { get; private set; }
        public IState NoQuarter { get; private set; }
        public IState HasQuarter { get; private set; }
        public IState Sold { get; private set; }
        public IState Winner { get; private set; }

        public IState State { get; private set; }
        public int Count { get; private set; }
        public string Location { get; private set; }

        public GumballMachine(int count, string location = "")
        {
            Soldout = new SoldState(this);
            NoQuarter = new NoQuarterState(this);
            HasQuarter = new HasQuarterState(this);
            Sold = new SoldState(this);
            Winner = new WinnerState(this);

            this.Count = count;
            this.Location = location;

            if (this.Count > 0)
            {
                State = NoQuarter;
            }
            else
            {
                State = Soldout;
            }
        }

        public void InsertQuarter() => State.InsertQuarter();
        public void EjectQuarter() => State.EjectQuarter();
        public void TurnCrank() => State.TurnCrank();
        public void Dispense() => State.Dispense();

        public void Refill(int count)
        {
            this.Count += count;
            if (count > 0) State = HasQuarter;
        }

        public void SetState(IState state) => this.State = state;

        public void ReleaseBall()
        {
            Console.Write("release gum ball !");
            if (Count > 0) Count--;
        }
    }
}
